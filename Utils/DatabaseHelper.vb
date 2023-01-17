Imports System.Data.SqlServerCe
Imports System.Configuration

Namespace Utils

    Public Class DatabaseHelper

        Public Shared con As SqlCeConnection
        Public Shared cmd As SqlCeCommand
        Public Shared myDA As SqlCeDataAdapter
        Public Shared myDataSet As DataSet
        Public Shared cmd2 As SqlCeCommand
        Public Shared currentSet
        Public Shared currentDatabase = 0

        Public Shared Sub updateConnectionString(dbName As String)
            con = New SqlCeConnection("Data Source=""" & Application.StartupPath & "\databases\" & dbName & """")
        End Sub

        Public Shared Sub executeSQLNonQuery(query As String)
            cmd.CommandText = query
            If con.State = ConnectionState.Closed Then con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Sub
        Public Shared Function executeSQLQuery(query As String)
            cmd.CommandText = query
            If con.State = ConnectionState.Closed Then con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Return cmd.ExecuteReader()
        End Function

    End Class

End Namespace