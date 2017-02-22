Namespace Model
    Public Class Mesa
        Public Property Id As Integer
        Public Property MesaNumero As String
        Public Property FechaCreacion As DateTime
        Public Property Estado As Boolean
        Public Property Usuario As User
        Public Property Productos As List(Of Productos)
    End Class
End Namespace
