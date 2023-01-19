Imports System.Data.SqlServerCe
Imports System.Configuration

Namespace Utils

    Public Class DatabaseHelper

        Private Shared _con As SqlCeConnection
        Private Shared _cmd As SqlCeCommand

        Private Shared _myDA As SqlCeDataAdapter
        Private Shared _myDataSet As DataSet
        Private Shared _myDataTable As DataTable

        Private Shared _currentSet = ""
        Private Shared _currentDatabase = ""
        Private Shared _lastQuery As String = ""

        Private Shared objDatabaseHelper As DatabaseHelper
        Private Sub New()

        End Sub

        Public Shared Function getInstance() As DatabaseHelper
            If objDatabaseHelper Is Nothing Then
                objDatabaseHelper = New DatabaseHelper
            End If
            Return objDatabaseHelper
        End Function


        Public Property currentDatabase As String
            Get
                Return _currentDatabase
            End Get
            Set(value As String)
                _currentDatabase = value
                updateConnectionString()
            End Set
        End Property
        Public Shared Property currentSet As String
            Get
                Return _currentSet
            End Get
            Set(value As String)
                _currentSet = value
            End Set
        End Property
        Public Shared Property cmd As String
            Get
                Return _cmd.CommandText
            End Get
            Set(value As String)
                _lastQuery = _cmd.CommandText
                _cmd.CommandText = value
            End Set
        End Property

        Shared Function checkDBConnection()
            Try
                If _con.State = ConnectionState.Closed Then
                    _con.Open()
                    _con.Close()
                End If
            Catch ex As Exception
                Return False
            End Try

            Return True
        End Function

        Shared Sub updateConnectionString()
            _con = New SqlCeConnection("Data Source=""" & Application.StartupPath & "\databases\" & _currentDatabase & """")
        End Sub

        Public Shared Function executeQuery() As SqlCeDataReader
            If _con.State = ConnectionState.Closed Then _con.Open()
            _cmd.CommandText = cmd
            _con.Close()
            cmd = ""
            Return _cmd.ExecuteReader()
        End Function
        Public Shared Function executeQuery(query As String) As SqlCeDataReader
            If _con.State = ConnectionState.Closed Then _con.Open()
            _cmd.CommandText = query
            _con.Close()
            cmd = ""
            Return _cmd.ExecuteReader()
        End Function

        Public Shared Function executeNonQuery()
            If _con.State = ConnectionState.Closed Then _con.Open()
            _cmd.CommandText = cmd
            _con.Close()
            cmd = ""
            Return _cmd.ExecuteNonQuery()
        End Function
        Public Shared Function executeNonQuery(query As String)
            If _con.State = ConnectionState.Closed Then _con.Open()
            _cmd.CommandText = query
            _con.Close()
            cmd = ""
            Return _cmd.ExecuteNonQuery()
        End Function

        Shared Sub createDatabase(fromConnectionString As Boolean, Optional connectionString As String = Nothing)
            Dim engine = Nothing
            If fromConnectionString Then
                engine = New SqlCeEngine(connectionString)
            Else
                engine = New SqlCeEngine(_con.ConnectionString)
            End If
            engine.CreateDatabase()
        End Sub

        'refactor this in proper way
        Public Shared Function getDataSet(tableName As String)
            executeQuery()
            _myDA = New SqlCeDataAdapter(_cmd)
            _myDataSet = New DataSet()

            _myDA.Fill(_myDataSet, tableName)
            Return _myDataSet.Tables(_currentSet).defaultView
        End Function

        Public Shared Function getDataSet()
            executeQuery()
            _myDA = New SqlCeDataAdapter(_cmd)
            _myDataSet = New DataSet()

            _myDA.Fill(_myDataSet, _currentSet)
            Return _myDataSet.Tables(_currentSet).defaultView
        End Function
        Public Shared Function getDataTable()
            executeQuery()
            _myDA = New SqlCeDataAdapter(_cmd)
            _myDataSet = New DataSet()

            _myDA.Fill(_myDataTable)
            Return _myDataTable
        End Function

        Public Shared Function getLastQuery() As String
            Return _lastQuery
        End Function
    End Class

End Namespace