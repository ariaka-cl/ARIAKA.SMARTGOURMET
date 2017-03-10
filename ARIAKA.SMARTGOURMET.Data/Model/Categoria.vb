Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("bdSmartGourmet.Categoria")>
Partial Public Class Categoria
    Public Property ID As Integer
    <Required>
    <StringLength(45)>
    Public Property Nombre As String
End Class
