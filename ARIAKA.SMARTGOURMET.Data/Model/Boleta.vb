Namespace Model
    Public Class Boleta
        Public Property Id As Integer
        Public Property Mesa As Mesa
        Public Property Total As Integer
        Public Property Propina As Integer
        Public Property MedioPago As TipoPago
        Public Property Impresa As Boolean
        Public Property FechaImpresion As DateTime

    End Class

    Public Enum TipoPago
        Efectivo = 0
        Cheque = 1
        Tarjeta = 2
    End Enum
End Namespace
