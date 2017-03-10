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
    End Class
End Namespace