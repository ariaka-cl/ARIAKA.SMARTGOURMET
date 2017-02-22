Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports ARIAKA.SMARTGOURMET.Data.Model

Public Class MySqlInitializer
    Implements IDatabaseInitializer(Of SmartGourmetContext)
    Private Sub IDatabaseInitializer_InitializeDatabase(context As SmartGourmetContext) Implements IDatabaseInitializer(Of SmartGourmetContext).InitializeDatabase
        If Not context.Database.Exists() Then
            ' if database did not exist before - create it
            context.Database.Create()
        Else
            ' query to check if MigrationHistory table is present in the database 
            Dim migrationHistoryTableExists = DirectCast(context, IObjectContextAdapter).ObjectContext.ExecuteStoreQuery(Of Integer)(String.Format("SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = '{0}' AND table_name = '__MigrationHistory'", "[Insert your database schema here - such as 'users']"))

            ' if MigrationHistory table is not there (which is the case first time we run) - create it
            If migrationHistoryTableExists.FirstOrDefault() = 0 Then
                context.Database.Delete()
                context.Database.Create()
            End If
        End If
    End Sub
End Class
