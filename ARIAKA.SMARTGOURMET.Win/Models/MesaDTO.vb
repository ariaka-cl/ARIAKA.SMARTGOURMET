Namespace Models
    Public Class MesaDTO
        Public Property ID As Integer
        Public Property Numero As String
        Public Property FechaCreacion As Date?
        Public Property Estado As MesaEstado?
        Public Property Notas As String
        Public Property UsuarioID As Integer?
        Public Property Usuario As UserDTO
        Public Property MesaDetalles As List(Of MesaDetalleDTO)

    End Class
End Namespace
