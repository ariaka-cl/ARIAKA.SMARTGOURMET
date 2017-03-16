Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace Controls
    Public Class DeliveryControl

        Private Property _cliente As New Logica.Cliente
        Private Sub Delivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            PopulateProductos()
        End Sub
        Private Sub PopulateProductos()
            Me.ProductosDTOBindingSource.DataSource = _cliente.GetProductos() _
                .Where(Function(p) p.Categoria.Nombre = "Helados" OrElse p.Categoria.Nombre = "Tortas" OrElse p.Categoria.Nombre = "Bebidas").ToList()
            Me.SearchLookUpEdit_Productos.Properties.DataSource = Me.ProductosDTOBindingSource.DataSource
        End Sub

        Private Sub SimpleButton_Plus_Click(sender As Object, e As EventArgs) Handles SimpleButton_Plus.Click
            If Me.SearchLookUpEdit_Productos.EditValue Is Nothing OrElse Me.SearchLookUpEdit_Productos.EditValue.ToString.Contains("Buscar") Then
                MessageBox.Show("Debe seleccionar un producto")
                Return
            End If

            Dim idProduct As Integer = CInt(Me.SearchLookUpEdit_Productos.EditValue)
            Dim listProducts As List(Of Models.ProductosDTO) = _cliente.GetProductos()
            Dim producto As Models.ProductosDTO = listProducts.Where(Function(p) p.Id = idProduct).SingleOrDefault()
            SumarTotal(producto.Precio)
            Dim resumenMesa As New Models.ResumenMesaDetalleDTO With {.ID = producto.Id,
                                                                      .Nombre = producto.Nombre,
                                                                      .Cantidad = 1,
                                                                      .Precio = producto.Precio}

            Me.DeliveryProductosControl1.ResumenMesaDetalleDTOBindingSource.Add(resumenMesa)
            Me.DeliveryProductosControl1.GridView1.RefreshEditor(True)

        End Sub

        Private Sub SimpleButton_Minus_Click(sender As Object, e As EventArgs) Handles SimpleButton_Minus.Click
            Dim resumenDetalle As Models.ResumenMesaDetalleDTO = CType(DeliveryProductosControl1.ResumenMesaDetalleDTOBindingSource.Current _
                , Models.ResumenMesaDetalleDTO)
            If resumenDetalle Is Nothing Then Return
            DeliveryProductosControl1.GridView1.DeleteRow(DeliveryProductosControl1.GridView1.FocusedRowHandle)
            RestarTotal(resumenDetalle.Precio)
            Me.DeliveryProductosControl1.GridView1.RefreshEditor(True)
        End Sub

        Private Sub SumarTotal(precio As Integer)
            Dim total As String = LabelControl_Total_Value.Text
            Dim totalInt As Integer = CInt(total)
            totalInt = precio + totalInt
            LabelControl_Total_Value.Text = totalInt.ToString()
        End Sub

        Private Sub RestarTotal(precio As Integer)
            Dim total As String = LabelControl_Total_Value.Text
            Dim totalInt As Integer = CInt(total)
            totalInt = totalInt - precio
            LabelControl_Total_Value.Text = totalInt.ToString()
        End Sub

        Private Sub SimpleButton_Print_Click(sender As Object, e As EventArgs) Handles SimpleButton_Print.Click

            Dim report As New PDF.BoletaReport() With {.ShowPrintMarginsWarning = False, .ShowPrintStatusDialog = False}
            Dim resumenDetalle As List(Of Models.ResumenMesaDetalleDTO) = TryCast(DeliveryProductosControl1.GridView1.DataSource, BindingSource) _
                                                                .Cast(Of Models.ResumenMesaDetalleDTO).ToList()
            report.ObjectDataSourceMesaDetalle.DataSource = GroupData(resumenDetalle)
            report.XrTableCell_Total.Text = Me.LabelControl_Total_Value.Text
            report.XrTableCell_Garzon.Text = "Por Caja"
            report.XrTableCell_Hora_Value.Text = Date.Now.ToShortTimeString()
            report.XrTableCell_Fecha_Value.Text = Date.Now.Date
            report.XrTableCell_MesaNumero.Text = "Caja"
            report.XrTableCell_Propina.Text = ""
            report.XrTableCell_TotalAll_Value.Text = Me.LabelControl_Total_Value.Text

            Using printingTool As New ReportPrintTool(report)
                printingTool.Print(My.Settings.PrinterCaja)
            End Using

            MessageBox.Show("Se  Imprimio Cuenta con Éxito", "Imprimir Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Sub

        Public Function GroupData(listDetalles As List(Of Models.ResumenMesaDetalleDTO)) As List(Of Models.ResumenMesaDetalleDTO)
            Dim dict As New Dictionary(Of Integer, String)
            Dim listProduct As New List(Of Models.ResumenMesaDetalleDTO)
            For Each resumenMesa As Models.ResumenMesaDetalleDTO In listDetalles
                Dim acum As Integer = 0
                Dim precio As Integer = 0
                Dim nombre As String = resumenMesa.Nombre
                If Not dict.TryGetValue(resumenMesa.ID, nombre) Then
                    acum = acum + 1
                    precio = precio + resumenMesa.Precio
                    listProduct.Add(New Models.ResumenMesaDetalleDTO With {.ID = resumenMesa.ID,
                                                                           .Cantidad = acum,
                                                                           .Nombre = resumenMesa.Nombre,
                                                                           .Precio = precio})
                    dict.Add(resumenMesa.ID, nombre)
                Else
                    Dim rs As Models.ResumenMesaDetalleDTO = listProduct.Where(Function(pr) pr.ID = resumenMesa.ID).SingleOrDefault()
                    rs.Cantidad = rs.Cantidad + 1
                    rs.Precio = rs.Precio + resumenMesa.Precio
                    Dim reAux As New Models.ResumenMesaDetalleDTO With {.Cantidad = rs.Cantidad, .ID = rs.ID, .Nombre = rs.Nombre, .Precio = rs.Precio}
                    listProduct.Remove(rs)
                    listProduct.Add(reAux)
                End If
            Next

            Return listProduct
        End Function
    End Class
End Namespace
