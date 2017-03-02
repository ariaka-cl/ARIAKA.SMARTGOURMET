Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("bdSmartGourmet.User")>
Partial Public Class User
    'Public Sub New()
    '    Mesa = New HashSet(Of Mesa)()
    'End Sub

    <Key>
    Public Property ID As Integer

    <Required>
    <StringLength(20)>
    Public Property Run As String

    <Required>
    <StringLength(45)>
    Public Property Nombre As String

    <Required>
    <StringLength(45)>
    Public Property UserName As String

    <StringLength(1073741823)>
    Public Property Password As String

    <Column(TypeName:="timestamp")>
    Public Property FechaCreacion As Date?

    Public Property RolID As Integer

    Public Overridable Property Rol As Rol
    'Public Overridable Property Mesa As ICollection(Of Mesa)

End Class
