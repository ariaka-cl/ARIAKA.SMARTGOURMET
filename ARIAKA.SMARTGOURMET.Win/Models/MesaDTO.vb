Namespace Models
    Public Class MesaDTO
        Public Property ID As Integer
        Public Property Numero As String
        Public Property FechaCreacion As Date?
        Public Property Estado As Boolean?
        Public Property UsuarioID As Integer?
        Public Overridable Property Boletas As ICollection(Of BoletaDTO)
        Public Overridable Property MesaDetalles As ICollection(Of MesaDetalleDTO)
        Public Overridable Property User As UserDTO
    End Class
End Namespace
