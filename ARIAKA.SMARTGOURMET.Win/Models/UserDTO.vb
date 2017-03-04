Namespace Models
    Public Class UserDTO
        Public Property ID As Integer
        Public Property Run As String
        Public Property Nombre As String
        Public Property UserName As String
        Public Property Password As String
        Public Property FechaCreacion As Date?
        Public Property RolID As Integer
        Public Overridable Property Rol As String
    End Class
End Namespace
