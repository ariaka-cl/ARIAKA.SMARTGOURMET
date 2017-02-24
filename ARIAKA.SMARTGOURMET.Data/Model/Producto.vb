Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("bdSmartGourmet.Producto")>
Partial Public Class Producto
    Public Sub New()
        MesaDetalles = New HashSet(Of MesaDetalle)()
    End Sub

    Public Property ID As Integer

    <Required>
    <StringLength(45)>
    Public Property ProductoCodigo As String

    <Required>
    <StringLength(45)>
    Public Property Nombre As String

    Public Property CategoriaID As Integer

    Public Property Precio As Integer?

    Public Property Stock As Integer?

    Public Overridable Property Categoria As Categoria

    Public Overridable Property MesaDetalles As ICollection(Of MesaDetalle)
End Class
