Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("bdSmartGourmet.Boleta")>
Partial Public Class Boleta
    'Public Sub New()
    '    Mesa = New HashSet(Of Mesa)()
    'End Sub

    <Key>
    Public Property ID As Integer

    Public Property MesaID As Integer

    Public Property Total As Integer?

    Public Property Propina As Integer?

    <StringLength(45)>
    Public Property MedioPago As String

    <Column(TypeName:="usmallint")>
    Public Property EstadoImpresa As Integer?

    <Column(TypeName:="timestamp")>
    Public Property FechaCreacion As Date?

    'Public Overridable Property Mesa As ICollection(Of Mesa)
End Class
