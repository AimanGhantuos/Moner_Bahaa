Imports System.Data.SqlClient
Module DbConnectionSQL


    Public smsQuery As String

    Dim conAn As New SqlConnection("Data Source=199.203.47.136;Initial Catalog=Moner_Bahaa;User ID=dd;Password=1234;Network Library=dbmssocn")
    Dim ds As New DataSet
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim sql As String

    Public Function ExecuteRetrieveSQL(ByVal sql As String, ByVal para As Dictionary(Of String, Object)) As Integer

        Dim query2 As String = "Select @@Identity"
        Dim ID As Integer
        Try
            If conAn.State = ConnectionState.Closed Then
                conAn.Open()
            End If

            cmd = New SqlCommand(sql, conAn)
            For x = 0 To para.Count - 1
                cmd.Parameters.AddWithValue(para.Keys(x), para.Values(x))
            Next
            cmd.ExecuteNonQuery()

            cmd.CommandText = query2
            ID = cmd.ExecuteScalar()

        Catch ex As Exception

        Finally
            conAn.Close()
        End Try

        Return ID


    End Function
    Public Sub ExecuteSQL(ByVal sql As String, ByVal para As Dictionary(Of String, Object), Optional status As Boolean = False)

        Try
            If conAn.State = ConnectionState.Closed Then
                conAn.Open()
            End If

            cmd = New SqlCommand(sql, conAn)
            For x = 0 To para.Count - 1
                cmd.Parameters.AddWithValue(para.Keys(x), para.Values(x))
            Next

            cmd.ExecuteNonQuery()

        Catch ex As Exception

        Finally
            If status = False Then
                conAn.Close()
            End If
        End Try

    End Sub
    Public Sub RunCMD(command As String, Optional ShowWindow As Boolean = False, Optional WaitForProcessComplete As Boolean = False, Optional permanent As Boolean = False)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(ShowWindow AndAlso permanent, "/K", "/C") + " " + command
        pi.FileName = "cmd.exe"
        pi.CreateNoWindow = Not ShowWindow
        If ShowWindow Then
            pi.WindowStyle = ProcessWindowStyle.Normal
        Else
            pi.WindowStyle = ProcessWindowStyle.Hidden
        End If
        p.StartInfo = pi
        p.Start()
        If WaitForProcessComplete Then Do Until p.HasExited : Loop
    End Sub
    Public Sub ExecuteScriptSQL(ByVal SQLScriptPath As String, Optional status As Boolean = False)

        Dim sqlBuilder As SqlConnectionStringBuilder = New SqlConnectionStringBuilder(conAn.ConnectionString)
        Dim serv As String = sqlBuilder.DataSource
        Dim database As String = sqlBuilder.InitialCatalog
        Dim username As String = "dd"
        Dim pass As String = "1234"
        Dim cmdCommand = $"sqlcmd -S {serv} -i {SQLScriptPath} -U {username} -P {pass} -d {database}"
        RunCMD(cmdCommand, True, True, False)
    End Sub
    Public Sub SearchExecuteSQL(ByVal sql As String, _dataset As DataSet, ByVal para As Dictionary(Of String, String), Optional status As Boolean = False)
        smsQuery = sql
        Try
            If conAn.State = ConnectionState.Closed Then
                conAn.Open()
            End If

            cmd = New SqlCommand(sql, conAn)
            da = New SqlDataAdapter(cmd)
            For x = 0 To para.Count - 1
                cmd.Parameters.AddWithValue(para.Keys(x), para.Values(x))
                smsQuery = Replace(smsQuery, para.Keys(x), " '" & para.Values(x) & "' ")
            Next
            da.Fill(_dataset)

            cmd.Dispose()
            If status = False Then
                conAn.Close()
            End If
        Catch ex As Exception

        Finally

        End Try

    End Sub

    Public Sub LoadDataSQL(ByVal sql As String, ByVal dataset As DataSet, Optional status As Boolean = False)
        smsQuery = sql
        If conAn.State = ConnectionState.Closed Then
            conAn.Open()
        End If

        Try

            da = New SqlDataAdapter(sql, conAn)
            da.Fill(dataset)
            If status = False Then
                conAn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub ExecuteSqlStmtSQL(ByVal sql As String, Optional status As Boolean = False)
        If conAn.State = ConnectionState.Closed Then
            conAn.Open()
        End If
        Try
            'conAn.Open()
            cmd = New SqlCommand(sql, conAn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            If status = False Then
                conAn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function LoadDataRetrievIdSQL(ByVal sql As String) As Integer
        Dim query2 As String = "Select @@Identity"
        Dim ID As Integer
        Using cmd As New SqlCommand(sql, conAn)
            conAn.Open()
            cmd.ExecuteNonQuery()
            cmd.CommandText = query2
            ID = cmd.ExecuteScalar()
            conAn.Close()
        End Using
        Return ID
    End Function

    Public Sub LoadDataTableSQL(ByVal sql As String, ByVal dataset As DataTable, Optional status As Boolean = False)

        If conAn.State = ConnectionState.Closed Then
            conAn.Open()
        End If
        Try
            'conAn.Open()
            da = New SqlDataAdapter(sql, conAn)
            da.Fill(dataset)
            If status = False Then
                conAn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Module
