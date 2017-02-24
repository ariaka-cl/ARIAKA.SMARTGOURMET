Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("bdSmartGourmet.Mesa")>
Partial Public Class Mesa
    Public Sub New()
        Boletas = New HashSet(Of Boleta)()
        MesaDetalles = New HashSet(Of MesaDetalle)()
    End Sub

    Public Property ID As Integer

    <StringLength(20)>
    Public Property Numero As String

    <Column(TypeName:="timestamp")>
    Public Property FechaCreacion As Date?

    Public Property Estado As Boolean?

    Public Property UsuarioID As Integer?

    Public Overridable Property Boletas As ICollection(Of Boleta)

    Public Overridable Property MesaDetalles As ICollection(Of MesaDetalle)

    Public Overridable Property User As User
End Class
