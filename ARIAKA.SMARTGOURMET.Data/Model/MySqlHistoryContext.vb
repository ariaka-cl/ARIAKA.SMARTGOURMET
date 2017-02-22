Imports System.Data.Common
Imports System.Data.Entity
Imports System.Data.Entity.Migrations.History

Namespace Model
    Public Class MySqlHistoryContext
        Inherits HistoryContext

        Public Sub New(existingConnection As DbConnection, defaultSchema As String)
            MyBase.New(existingConnection, defaultSchema)
        End Sub

        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            MyBase.OnModelCreating(modelBuilder)
            modelBuilder.Entity(Of HistoryRow).Property(Function(h) h.MigrationId).HasMaxLength(100).IsRequired()
            modelBuilder.Entity(Of HistoryRow).Property(Function(h) h.ContextKey).HasMaxLength(200).IsRequired()
        End Sub

    End Class
End Namespace
