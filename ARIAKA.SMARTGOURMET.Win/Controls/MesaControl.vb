﻿Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Public Class MesaControl

    Private Property _cliente As New Logica.Cliente
    Private Property _mesaID As Integer
    Public Property MesaID As Integer
        Get
            Return _mesaID
        End Get
        Set(value As Integer)
            _mesaID = value
        End Set
    End Property

    Private Sub Mesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateGarzon()
        PopulateProductos()
        If _mesaID <> 0 Then
            PopulateMesa()
        End If
    End Sub

    Public Sub PopulateMesa()
        Dim mesa As Models.MesaDTO = _cliente.GetOneMesa(_mesaID)
        Me.TextBox_NumeroMesa.Text = mesa.Numero
        Me.DateTimePicker_Fecha.Value = mesa.FechaCreacion
        Me.RichTextBox_Comentarios.Text = mesa.Notas
        Me.ComboBox_Garzones.SelectedItem = mesa.Usuario.Nombre
        Dim total As Integer = 0
        If mesa.MesaDetalles IsNot Nothing Then
            Me.ProductosMesaControl1.MesaDetalleDTOBindingSource.Clear()
            For i As Integer = 0 To mesa.MesaDetalles.Count - 1
                Me.ProductosMesaControl1.MesaDetalleDTOBindingSource.Add(mesa.MesaDetalles.Item(i))
                total = mesa.MesaDetalles.Item(i).Producto.Precio + total
            Next
            Me.ProductosMesaControl1.GridView1.RefreshEditor(True)
        End If
        Me.LabelControl_Suma.Text = total.ToString()
    End Sub

    Private Sub PopulateProductos()
        Me.ProductosDTOBindingSource.DataSource = _cliente.GetProductos()
        Me.SearchLookUpEdit_Producto.Properties.DataSource = Me.ProductosDTOBindingSource.DataSource
    End Sub

    Private Sub PopulateGarzon()
        Me.UserDTOBindingSource.DataSource = _cliente.GetGarzones()
        Me.ComboBox_Garzones.DataSource = UserDTOBindingSource.DataSource
    End Sub

    Private Sub SimpleButton_Plus_Click(sender As Object, e As EventArgs) Handles SimpleButton_Plus.Click
        If Me.SearchLookUpEdit_Producto.EditValue Is Nothing OrElse Me.SearchLookUpEdit_Producto.EditValue.ToString.Contains("Buscar") Then
            MessageBox.Show("Debe seleccionar un producto")
            Return
        End If

        Dim idProduct As Integer = CInt(Me.SearchLookUpEdit_Producto.EditValue)
        Dim listProducts As List(Of Models.ProductosDTO) = _cliente.GetProductos()
        Dim producto As Models.ProductosDTO = listProducts.Where(Function(p) p.Id = idProduct).SingleOrDefault()
        SumarTotal(producto.Precio)
        Dim detalleMesa As New Models.MesaDetalleDTO With {.Producto = producto, .EstadoImpreso = 0,
                                                            .ProductoID = idProduct, .FechaPedido = Date.Now}

        Me.ProductosMesaControl1.MesaDetalleDTOBindingSource.Add(detalleMesa)
        Me.ProductosMesaControl1.GridView1.RefreshEditor(True)


    End Sub

    Private Sub SimpleButton_Guardar_Click(sender As Object, e As EventArgs) Handles SimpleButton_Guardar.Click
        If String.IsNullOrEmpty(Me.TextBox_NumeroMesa.Text) Then
            MessageBox.Show("Debe ingresar un numero para la mesa.")
            Return
        End If

        If _mesaID <> 0 Then

            Dim lisDetalle As List(Of Models.MesaDetalleDTO) = TryCast(ProductosMesaControl1.GridView1.DataSource, BindingSource) _
                                                                .Cast(Of Models.MesaDetalleDTO).ToList()
            Dim listDetalleNuevo As List(Of Models.MesaDetalleDTO) = lisDetalle.Where(Function(m) m.MesaID = 0).ToList()
            lisDetalle = Nothing
            If listDetalleNuevo Is Nothing OrElse listDetalleNuevo.Count = 0 Then
                MessageBox.Show("No hay datos para guardar", "Guardar Mesa")
                Return
            End If


            lisDetalle = _cliente.GuardarDetalleMesa(listDetalleNuevo, _mesaID)
            If lisDetalle IsNot Nothing Then
                Me.ProductosMesaControl1.MesaDetalleDTOBindingSource.Clear()
                For i As Integer = 0 To lisDetalle.Count - 1
                    Me.ProductosMesaControl1.MesaDetalleDTOBindingSource.Add(lisDetalle.Item(i))
                Next
                Me.ProductosMesaControl1.GridView1.RefreshEditor(True)
            End If

        Else
            Dim mesa As New Models.MesaDTO With {.Numero = Me.TextBox_NumeroMesa.Text,
                                             .Estado = Models.MesaEstado.Ocupada,
                                             .UsuarioID = CType(ComboBox_Garzones.SelectedItem, Models.UserDTO).ID,
                                             .FechaCreacion = Me.DateTimePicker_Fecha.Value,
                                             .Notas = Me.RichTextBox_Comentarios.Text}

            Dim lisDetalle As List(Of Models.MesaDetalleDTO) = TryCast(ProductosMesaControl1.GridView1.DataSource, BindingSource) _
                                                                .Cast(Of Models.MesaDetalleDTO).ToList()
            mesa.MesaDetalles = lisDetalle
            mesa = _cliente.GuardarMesa(mesa)
            _mesaID = mesa.ID

            Me.ProductosMesaControl1.MesaDetalleDTOBindingSource.Clear()
            For i As Integer = 0 To mesa.MesaDetalles.Count - 1
                Me.ProductosMesaControl1.MesaDetalleDTOBindingSource.Add(mesa.MesaDetalles.Item(i))
            Next
            Me.ProductosMesaControl1.GridView1.RefreshEditor(True)
        End If
        MessageBox.Show("Se guardaron con éxito los registros", "Guardar Mesa", MessageBoxButtons.OK)
    End Sub

    Private Sub TextBox_NumeroMesa_KeyUp(sender As Object, e As EventArgs) Handles TextBox_NumeroMesa.KeyUp
        Dim numero As String = TextBox_NumeroMesa.Text
        If String.IsNullOrWhiteSpace(numero) Then Return
        Dim estado As Models.MesaEstado = _cliente.SaberEstadoMesa(numero)
        Select Case estado
            Case Models.MesaEstado.Vacia
            Case Models.MesaEstado.Ocupada
                MessageBox.Show("La mesa se encuentra ocupada.")
                Return
            Case Models.MesaEstado.Pagada
            Case Models.MesaEstado.Impresa

        End Select
    End Sub

    Private Sub SumarTotal(precio As Integer)
        Dim total As String = LabelControl_Suma.Text
        Dim totalInt As Integer = CInt(total)
        totalInt = precio + totalInt
        LabelControl_Suma.Text = totalInt.ToString()
    End Sub

    Private Sub RestarTotal(precio As Integer)
        Dim total As String = LabelControl_Suma.Text
        Dim totalInt As Integer = CInt(total)
        totalInt = totalInt - precio
        LabelControl_Suma.Text = totalInt.ToString()
    End Sub

    Private Sub SimpleButton_Minus_Click(sender As Object, e As EventArgs) Handles SimpleButton_Minus.Click
        Dim detalleMesaDto As Models.MesaDetalleDTO = CType(ProductosMesaControl1.MesaDetalleDTOBindingSource.Current, Models.MesaDetalleDTO)
        If _mesaID <> 0 Then
            Dim id As Integer = detalleMesaDto.ID
            If id <> 0 Then _cliente.EliminarDetalleMesa(id)
        End If
        ProductosMesaControl1.GridView1.DeleteRow(ProductosMesaControl1.GridView1.FocusedRowHandle)
        RestarTotal(detalleMesaDto.Producto.Precio)
        Me.ProductosMesaControl1.GridView1.RefreshEditor(True)
    End Sub

    Private Sub SimpleButton_Print_Click(sender As Object, e As EventArgs) Handles SimpleButton_Print.Click
        If _mesaID = 0 Then
            MessageBox.Show("No existe mesa creada aún", "Imprimir Boleta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim report As New PDF.BoletaReport() With {.ShowPrintMarginsWarning = False, .ShowPrintStatusDialog = False}
        Dim listMesaDetail As List(Of Models.MesaDetalleDTO) = _cliente.GetMesaDetalles(_mesaID)
        report.ObjectDataSourceMesaDetalle.DataSource = GroupData(listMesaDetail)
        report.XrTableCell_Total.Text = Me.LabelControl_Suma.Text
        report.XrTableCell_Garzon.Text = CType(ComboBox_Garzones.SelectedItem, Models.UserDTO).Nombre
        report.XrTableCell_Hora_Value.Text = Me.DateTimePicker_Fecha.Value.ToShortTimeString()
        report.XrTableCell_Fecha_Value.Text = Me.DateTimePicker_Fecha.Value.ToShortDateString()
        report.XrTableCell_MesaNumero.Text = Me.TextBox_NumeroMesa.Text
        report.XrTableCell_Propina.Text = CalculaPropina()
        report.XrTableCell_TotalAll_Value.Text = SumaPropinaTotal(CalculaPropina())

        Using printingTool As New ReportPrintTool(report)
            printingTool.Print(My.Settings.PrinterCaja)
        End Using

        Dim boleta As New Models.BoletaDTO With {.MesaID = _mesaID,
                                                  .Total = CInt(SumaPropinaTotal(CalculaPropina())),
                                                  .Propina = CInt(CalculaPropina()),
                                                  .EstadoImpresa = Models.BoletaEstado.Impresa,
                                                  .FechaCreacion = Me.DateTimePicker_Fecha.Value}
        If _cliente.CreacionBoleta(boleta) Then
            MessageBox.Show("Se  Imprimio Cuenta con Éxito", "Imprimir Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

    End Sub

    Private Function CalculaPropina() As String
        Dim total As Integer = CInt(Me.LabelControl_Suma.Text)
        Dim propina As Double = total * (10 / 100)
        Dim propinaStr As String = propina.ToString()
        Return propinaStr
    End Function
    Private Function SumaPropinaTotal(propina As String) As String
        Dim total As Integer = CInt(Me.LabelControl_Suma.Text)
        total = total + CInt(propina)
        Return total.ToString()
    End Function

    Private Sub SimpleButton_Pagar_Click(sender As Object, e As EventArgs) Handles SimpleButton_Pagar.Click
        If _mesaID = 0 Then
            MessageBox.Show("No existe mesa para pagar", "Pagar Mesa", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Esta Seguro que desea Pagar", "Pagar Mesa", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim estadoMesa As Integer = _cliente.PagarMesa(_mesaID)

            Select Case estadoMesa
                Case Models.MesaEstado.Pagada
                    MessageBox.Show("La mesa se pago con éxito", "Pagar Mesa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                Case Models.MesaEstado.Impresa
                    MessageBox.Show("No se pudo pagar la mesa,", "Pagar Mesa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                Case Models.MesaEstado.Ocupada
                    MessageBox.Show("No se pudo pagar la mesa, aún no se imprime cuenta", "Pagar Mesa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                Case Else
                    MessageBox.Show("No se pudo pagar la mesa, verifique que este impresa la cuenta.", "Pagar Mesa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
            End Select
        End If
    End Sub

    Private Sub SimpleButton_Cocina_Click(sender As Object, e As EventArgs) Handles SimpleButton_Cocina.Click
        If _mesaID = 0 Then
            MessageBox.Show("No existe mesa creada aún", "Imprimir Cocina", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim report As New PDF.CocinaReport() With {.ShowPrintMarginsWarning = False, .ShowPrintStatusDialog = False}
        Dim listDateMesa As List(Of Models.MesaDetalleDTO) = _cliente.GetProductosImprimir(_mesaID)
        report.ObjectDataSourceMesaDetalle.DataSource = GroupData(listDateMesa)
        report.XrTableCell_Garzon.Text = CType(ComboBox_Garzones.SelectedItem, Models.UserDTO).Nombre
        report.XrTableCell_Hora_Value.Text = Me.DateTimePicker_Fecha.Value.ToShortTimeString()
        report.XrTableCell_MesaNumero.Text = Me.TextBox_NumeroMesa.Text
        report.XrTableCell_Fecha_Value.Text = Me.DateTimePicker_Fecha.Value.ToShortDateString()
        report.XrRichText_Observacion.Text = Me.RichTextBox_Comentarios.Text

        Using printingTool As New ReportPrintTool(report)
            printingTool.Print(My.Settings.PrinterCocina)
        End Using

        MessageBox.Show("Se  Imprimio en Cocina", "Imprimir Cocina", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Function GroupData(listDetalles As List(Of Models.MesaDetalleDTO)) As List(Of Models.ResumenMesaDetalleDTO)
        Dim dict As New Dictionary(Of Integer, String)
        Dim listProduct As New List(Of Models.ResumenMesaDetalleDTO)
        For Each mesaDetail As Models.MesaDetalleDTO In listDetalles
            Dim acum As Integer = 0
            Dim precio As Integer = 0
            Dim nombre As String = mesaDetail.Producto.Nombre
            If Not dict.TryGetValue(mesaDetail.ProductoID, nombre) Then
                acum = acum + 1
                precio = precio + mesaDetail.Producto.Precio
                listProduct.Add(New Models.ResumenMesaDetalleDTO With {.ID = mesaDetail.ProductoID,
                                                                       .Cantidad = acum,
                                                                       .Nombre = mesaDetail.Producto.Nombre,
                                                                       .Precio = precio})
                dict.Add(mesaDetail.ProductoID, nombre)
            Else
                Dim rs As Models.ResumenMesaDetalleDTO = listProduct.Where(Function(pr) pr.ID = mesaDetail.ProductoID).SingleOrDefault()
                rs.Cantidad = rs.Cantidad + 1
                rs.Precio = rs.Precio + mesaDetail.Producto.Precio
                Dim reAux As New Models.ResumenMesaDetalleDTO With {.Cantidad = rs.Cantidad, .ID = rs.ID, .Nombre = rs.Nombre, .Precio = rs.Precio}
                listProduct.Remove(rs)
                listProduct.Add(reAux)
            End If
        Next

        Return listProduct
    End Function
End Class
