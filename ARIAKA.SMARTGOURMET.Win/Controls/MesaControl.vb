Imports System.Windows.Forms

Public Class MesaControl

    Private Property _cliente As New Logica.Cliente
    Private Property _total As String

    Private Sub Mesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateGarzon()
        PopulateProductos()
    End Sub

    Private Sub PopulateProductos()
        Me.ProductosDTOBindingSource.DataSource = _cliente.GetProductos()
        Me.SearchLookUpEdit_Producto.Properties.DataSource = Me.ProductosDTOBindingSource.DataSource
    End Sub

    Private Sub PopulateGarzon()
        Dim listGarzones As New List(Of Models.UserDTO)
        listGarzones.Add(New Models.UserDTO With {.ID = 2, .Nombre = "Juan Manuel", .Rol = "Garzón", .RolID = 1})
        listGarzones.Add(New Models.UserDTO With {.ID = 1, .Nombre = "Pablo Marmol", .Rol = "Garzón", .RolID = 2})
        Me.UserDTOBindingSource.DataSource = listGarzones
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
        If String.IsNullOrEmpty(Me.TextBox_NumeroMesa.Text.ToString()) Then
            MessageBox.Show("Debe ingresar un numero para la mesa.")
            Return
        End If

        Dim mesa As New Models.MesaDTO With {.Numero = Me.TextBox_NumeroMesa.Text,
                                             .Estado = Models.MesaEstado.Ocupada,
                                             .UsuarioID = CType(ComboBox_Garzones.SelectedItem, Models.UserDTO).ID,
                                             .FechaCreacion = Date.Now}

        Dim lisDetalle As List(Of Models.MesaDetalleDTO) = TryCast(ProductosMesaControl1.GridView1.DataSource, BindingSource) _
                                                            .Cast(Of Models.MesaDetalleDTO).ToList()
        mesa.MesaDetalles = lisDetalle
        _cliente.GuardarMesa(mesa)

    End Sub

    Private Sub TextBox_NumeroMesa_TextChanged(sender As Object, e As EventArgs) Handles TextBox_NumeroMesa.TextChanged
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
End Class
