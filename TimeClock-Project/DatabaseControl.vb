Imports System.Data.OleDb

Public Class DatabaseControl
    ' Create Database Connection
    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" &
                                               "Data Source=TimeClockProject.accdb;")
    ' Prepare Database Command
    Private DBCmd As OleDbCommand

    ' Database Data
    Public DBAdapter As OleDbDataAdapter
    Public DbDataTable As DataTable

    ' Query Parameters
    Public Params As New List(Of OleDbParameter)

    ' Query Statistics
    Public RecordCount As Integer
    Public Exception As String



    Public Sub ExecuteQuery(Query As String)
        ' Reset Query Stats
        RecordCount = 0
        Exception = ""

        Try
            ' Open Connection
            DBCon.Open()

            ' Create DB Command
            DBCmd = New OleDbCommand(Query, DBCon)

            ' Load params into DB Command
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' Clear Params List
            Params.Clear()

            ' Execute Command & Fill Datatable
            DbDataTable = New DataTable
            DBAdapter = New OleDbDataAdapter(DBCmd)
            RecordCount = DBAdapter.Fill(DbDataTable)
        Catch ex As Exception
            Exception = ex.Message
        End Try

        ' Close Connection
        If DBCon.State = ConnectionState.Open Then
            DBCon.Close()
        End If

    End Sub

    ' Include Query and Command Parameters
    Public Sub AddParam(Name As String, Value As Object)

        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

End Class
