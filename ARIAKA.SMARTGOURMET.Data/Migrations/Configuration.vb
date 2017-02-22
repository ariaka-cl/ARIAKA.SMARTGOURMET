Imports System.Data.Entity.Migrations

Namespace Migrations
    Public Class Configuration
        Inherits DbMigrationsConfiguration(Of Model.SmartGourmetContext)

        Public Sub Configuration()
            'SetSqlGenerator("MySql.Data.MySqlClient", New MySql.Data.Entity.MySqlMigrationSqlGenerator())
            ' SetHistoryContext("MySql.Data.MySqlClient", Function(con, schema) New Model.MySqlHistoryContext(con, schema))
        End Sub

        Protected Overrides Sub Seed(context As Model.SmartGourmetContext)

        End Sub

    End Class
End Namespace
