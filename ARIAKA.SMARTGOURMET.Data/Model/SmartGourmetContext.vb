Imports System.Data.Entity

Namespace Model
    Public Class SmartGourmetContext
        Inherits DbContext

        Public Property User As DbSet(Of User)
        Public Property Mesa As DbSet(Of Mesa)
        Public Property Boleta As DbSet(Of Boleta)
        Public Property Categoria As DbSet(Of Categoria)
        Public Property Productos As DbSet(Of Productos)

        Shared Sub New()
            Database.SetInitializer(New MySqlInitializer())
        End Sub

        Public Sub New()
            MyBase.New("name=SmartGourmet")
        End Sub

    End Class
End Namespace
