Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq
Imports System.Data.Entity.ModelConfiguration.Conventions

Partial Public Class SGContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=SGContext")
    End Sub


    Public Overridable Property Boletas As DbSet(Of Boleta)
    Public Overridable Property Categorias As DbSet(Of Categoria)
    Public Overridable Property Mesas As DbSet(Of Mesa)
    Public Overridable Property MesaDetalles As DbSet(Of MesaDetalle)
    Public Overridable Property Productoes As DbSet(Of Producto)
    Public Overridable Property Rols As DbSet(Of Rol)
    Public Overridable Property Users As DbSet(Of User)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Conventions.Remove(Of OneToManyCascadeDeleteConvention)()
        MyBase.OnModelCreating(modelBuilder)

        'modelBuilder.Entity(Of Boleta)() _
        '    .Property(Function(e) e.MedioPago) _
        '    .IsUnicode(False)

        'modelBuilder.Entity(Of Boleta)() _
        '    .Property(Function(e) e.FechaCreacion) _
        '    .HasPrecision(6)

        'modelBuilder.Entity(Of Categoria)() _
        '    .Property(Function(e) e.Nombre) _
        '    .IsUnicode(False)

        'modelBuilder.Entity(Of Categoria)() _
        '    .HasMany(Function(e) e.Productoes) _
        '    .WithRequired(Function(e) e.Categoria) _
        '    .WillCascadeOnDelete(False)

        'modelBuilder.Entity(Of Mesa)() _
        '    .Property(Function(e) e.Numero) _
        '    .IsUnicode(False)

        'modelBuilder.Entity(Of Mesa)() _
        '    .Property(Function(e) e.FechaCreacion) _
        '    .HasPrecision(6)

        'modelBuilder.Entity(Of Mesa)() _
        '    .HasMany(Function(e) e.Boletas) _
        '    .WithRequired(Function(e) e.Mesa) _
        '    .WillCascadeOnDelete(False)

        'modelBuilder.Entity(Of Mesa)() _
        '    .HasMany(Function(e) e.MesaDetalles) _
        '    .WithRequired(Function(e) e.Mesa) _
        '    .WillCascadeOnDelete(False)

        'modelBuilder.Entity(Of MesaDetalle)() _
        '    .Property(Function(e) e.FechaPedido) _
        '    .HasPrecision(6)

        'modelBuilder.Entity(Of Producto)() _
        '    .Property(Function(e) e.ProductoCodigo) _
        '    .IsUnicode(False)

        'modelBuilder.Entity(Of Producto)() _
        '    .Property(Function(e) e.Nombre) _
        '    .IsUnicode(False)

        'modelBuilder.Entity(Of Producto)() _
        '    .HasMany(Function(e) e.MesaDetalles) _
        '    .WithRequired(Function(e) e.Producto) _
        '    .WillCascadeOnDelete(False)

        'modelBuilder.Entity(Of Rol)() _
        '    .Property(Function(e) e.NombreRol) _
        '    .IsUnicode(False)

        'modelBuilder.Entity(Of Rol)() _
        '    .HasMany(Function(e) e.Users) _
        '    .WithRequired(Function(e) e.Rol) _
        '    .WillCascadeOnDelete(False)

        'modelBuilder.Entity(Of User)() _
        '    .Property(Function(e) e.Run) _
        '    .IsUnicode(False)

        'modelBuilder.Entity(Of User)() _
        '    .Property(Function(e) e.Nombre) _
        '    .IsUnicode(False)

        'modelBuilder.Entity(Of User)() _
        '    .Property(Function(e) e.UserName) _
        '    .IsUnicode(False)

        'modelBuilder.Entity(Of User)() _
        '    .Property(Function(e) e.Password) _
        '    .IsUnicode(False)

        'modelBuilder.Entity(Of User)() _
        '    .Property(Function(e) e.FechaCreacion) _
        '    .HasPrecision(6)

        'modelBuilder.Entity(Of User)() _
        '    .HasOptional(Function(e) e.Mesa) _
        '    .WithRequired(Function(e) e.User)
    End Sub
End Class
