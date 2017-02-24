Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("bdSmartGourmet.MesaDetalle")>
Partial Public Class MesaDetalle
    Public Property ID As Integer

    Public Property MesaID As Integer

    <Column(TypeName:="timestamp")>
    Public Property FechaPedido As Date?

    Public Property ProductoID As Integer

    Public Property EstadoImpreso As Short?

    Public Overridable Property Mesa As Mesa

    Public Overridable Property Producto As Producto
End Class
