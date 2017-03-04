Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("bdSmartGourmet.Mesa")>
Partial Public Class Mesa

    Public Property ID As Integer

    <StringLength(20)>
    Public Property Numero As String

    <Column(TypeName:="timestamp")>
    Public Property FechaCreacion As Date?

    Public Property Estado As Integer?
    Public Property Notas As String
    Public Property UsuarioID As Integer?

End Class