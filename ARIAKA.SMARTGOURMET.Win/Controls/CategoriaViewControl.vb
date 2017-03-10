Namespace Controls
    Public Class CategoriaViewControl
        Private Property _cliente As New Logica.Cliente

        Public Sub CategoriaViewControl_Load() Handles MyBase.Load
            PopulateCateGrid()
        End Sub

        Public Sub PopulateCateGrid()
            Dim listCateDto As List(Of Models.CategoriaDTO) = _cliente.GetCategoria()
            If listCateDto IsNot Nothing Then
                Me.CategoriaControl.CategoriaDTOBindingSource.DataSource = listCateDto
                Me.CategoriaControl.GridView1.RefreshEditor(True)
            End If

        End Sub
        Private Sub SimpleButton_Guardar_Click(sender As Object, e As EventArgs) Handles SimpleButton_Guardar.Click
            Dim categoria As New Models.CategoriaDTO With {.Nombre = Me.TextEdit_Nombre.Text}
            categoria = _cliente.GuardarCategoria(categoria)
            Me.CategoriaControl.CategoriaDTOBindingSource.Add(categoria)
            Me.CategoriaControl.GridView1.RefreshEditor(True)
        End Sub

        Private Sub SimpleButton_Eliminar_Click(sender As Object, e As EventArgs) Handles SimpleButton_Eliminar.Click
            Dim categoriaDto As Models.CategoriaDTO = CType(CategoriaControl.CategoriaDTOBindingSource.Current, Models.CategoriaDTO)

            Dim id As Integer = categoriaDto.ID
            If id <> 0 Then _cliente.EliminarCategoria(id)
            CategoriaControl.GridView1.DeleteRow(CategoriaControl.GridView1.FocusedRowHandle)
            Me.CategoriaControl.GridView1.RefreshEditor(True)
        End Sub
    End Class
End Namespace
