Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("bdSmartGourmet.Rol")>
Partial Public Class Rol
    Public Sub New()
        Users = New HashSet(Of User)()
    End Sub

    <Key>
    Public Property ID As Integer

    <Required>
    <StringLength(45)>
    Public Property NombreRol As String

    Public Overridable Property Users As ICollection(Of User)
End Class
