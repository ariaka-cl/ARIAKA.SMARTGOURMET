Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("bdSmartGourmet.Categoria")>
Partial Public Class Categoria
    Public Sub New()
        Productoes = New HashSet(Of Producto)()
    End Sub

    Public Property ID As Integer

    <Required>
    <StringLength(45)>
    Public Property Nombre As String

    Public Overridable Property Productoes As ICollection(Of Producto)
End Class
