Namespace Models
    Public Class MesaDetalleDTO
        Public Property ID As Integer
        Public Property MesaID As Integer
        Public Property FechaPedido As Date?
        Public Property ProductoID As Integer
        Public Property Producto As ProductosDTO
        Public Property EstadoImpreso As Short?
    End Class

    Public Class ResumenMesaDetalleDTO
        Public Property Cantidad As Integer
        Public Property Nombre As String
        Public Property Precio As Integer
    End Class

End Namespace
