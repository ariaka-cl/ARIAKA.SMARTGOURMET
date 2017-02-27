Imports System.Windows.Forms

Public Class MesaControl
    Private Sub Mesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateGarzon()
        PopulateProductos()
    End Sub

    Private Sub UserDTOBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles UserDTOBindingSource.CurrentChanged

    End Sub

    Private Sub PopulateProductos()
        Dim listProducts As New List(Of Models.ProductosDTO)
        listProducts.Add(New Models.ProductosDTO With {.Nombre = "Lomo Salteado", .Id = 1,
                         .Precio = 5000, .Stock = 3,
                         .Categoria = New Models.CategoriaDTO With {.ID = 1, .Nombre = "Plato de Fondo"}})
        listProducts.Add(New Models.ProductosDTO With {.Nombre = "Jugo Mango", .Id = 2,
                         .Precio = 1800, .Stock = 10,
                         .Categoria = New Models.CategoriaDTO With {.ID = 2, .Nombre = "Jugos"}})
        Me.ProductosDTOBindingSource.DataSource = listProducts
        Me.SearchLookUpEdit_Producto.Properties.DataSource = Me.ProductosDTOBindingSource.DataSource

    End Sub

    Private Sub PopulateGarzon()
        Dim listGarzones As New List(Of Models.UserDTO)
        listGarzones.Add(New Models.UserDTO With {.Nombre = "Juan Manuel", .Rol = "Garzón", .RolID = 1})
        listGarzones.Add(New Models.UserDTO With {.Nombre = "Pablo Marmol", .Rol = "Garzón", .RolID = 1})
        Me.UserDTOBindingSource.DataSource = listGarzones
        Me.ComboBox_Garzones.DataSource = UserDTOBindingSource.DataSource
    End Sub

    Private Sub SimpleButton_Plus_Click(sender As Object, e As EventArgs) Handles SimpleButton_Plus.Click

    End Sub
End Class
