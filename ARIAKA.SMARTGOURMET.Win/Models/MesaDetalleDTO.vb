Namespace Models
    Public Class MesaDetalleDTO
        Public Property ID As Integer
        Public Property MesaID As Integer
        Public Property FechaPedido As Date?
        Public Property ProductoID As Integer
        Public Property Producto As ProductosDTO
        Public Property EstadoImpreso As Short?
    End Class

End Namespace
