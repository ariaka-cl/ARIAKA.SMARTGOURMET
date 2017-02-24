Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("bdSmartGourmet.User")>
Partial Public Class User
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

    Public Overridable Property Mesa As Mesa

    Public Overridable Property Rol As Rol
End Class
