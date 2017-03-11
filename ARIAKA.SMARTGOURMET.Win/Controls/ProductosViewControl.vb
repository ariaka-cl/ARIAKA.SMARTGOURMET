Namespace Controls
    Public Class ProductosViewControl

        Private Property _cliente As New Logica.Cliente

        Public Sub ProductosViewControl_Load() Handles MyBase.Load
            PopulateCategoria()
            PopulateProductosGrid()
        End Sub

        Public Sub PopulateProductosGrid()
            Dim listProductDto As List(Of Models.ProductosDTO) = _cliente.GetProduc()
            If listProductDto IsNot Nothing Then
                Me.ProductosControl1.ProductoDTOBindingSource.DataSource = listProductDto
                Me.ProductosControl1.GridView1.RefreshEditor(True)
            End If

        End Sub

        Private Sub PopulateCategoria()
            Me.CategoriaDTOBindingSource.DataSource = _cliente.GetCategoria()
            Me.ComboBox_Categoria.DataSource = CategoriaDTOBindingSource.DataSource
        End Sub

        Private Sub SimpleButton_Guardar_Click(sender As Object, e As EventArgs) Handles SimpleButton_Guardar.Click
            Dim codigo As String = TextBox_Codigo.Text
            Dim nombre As String = TextBox_Nombre.Text
            Dim precio As String = TextBox_Precio.Text
            Dim stock As String = TextBox_Stock.Text
            Dim cateId As Integer = CInt(ComboBox_Categoria.SelectedValue)
            Dim cateNombre As String = ComboBox_Categoria.Text

            Dim producto As New Models.ProductosDTO With {.ProducCodigo = codigo,
                                                          .Nombre = nombre,
                                                          .Precio = CInt(precio),
                                                          .Stock = CInt(stock),
                                                          .CategoriaID = cateId,
                                                          .Categoria = New Models.CategoriaDTO With {.ID = cateId, .Nombre = cateNombre}}
            producto = _cliente.GuardarProductos(producto)
            Me.ProductosControl1.ProductoDTOBindingSource.Add(producto)
            Me.ProductosControl1.GridView1.RefreshEditor(True)
        End Sub

        Private Sub SimpleButton_Eliminar_Click(sender As Object, e As EventArgs) Handles SimpleButton_Eliminar.Click
            Dim productoDto As Models.ProductosDTO = CType(ProductosControl1.ProductoDTOBindingSource.Current, Models.ProductosDTO)
            Dim id As Integer = productoDto.Id
            If id <> 0 Then _cliente.EliminarProducto(id)
            ProductosControl1.GridView1.DeleteRow(ProductosControl1.GridView1.FocusedRowHandle)
            Me.ProductosControl1.GridView1.RefreshEditor(True)
        End Sub
    End Class
End Namespace