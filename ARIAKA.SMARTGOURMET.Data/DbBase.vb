Imports System.Data.Common
Imports System.Data.Entity
Imports System.Data.Entity.Migrations

Public Class DbBase
        Inherits DbConfiguration

        Public Sub Configuration()
            SetHistoryContext("MySql.Data.MySqlClient", Function(con, schema) New Model.MySqlHistoryContext(con, schema))
            'SetSqlGenerator("MySql.Data.MySqlClient", New MySql.Data.Entity.MySqlMigrationSqlGenerator())
        End Sub
    End Class

