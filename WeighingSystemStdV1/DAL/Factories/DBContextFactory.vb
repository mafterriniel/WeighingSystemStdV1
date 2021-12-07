Public Class DBContextGlobalVariable
    Public Shared SysSettings As New settings()

End Class


Public NotInheritable Class DBContextFactory
    Public Shared Function Query(qry As String) As Boolean
        Try

            Dim connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBContextGlobalVariable.SysSettings.access_file_path & ";" &
                            "Jet OLEDB:Database Password= " & DBContextGlobalVariable.SysSettings.access_pwd & ";"

            Using conn As OleDb.OleDbConnection = New OleDb.OleDbConnection(connectionString:=connString)
                conn.Open()
                Using command As OleDb.OleDbCommand = New OleDb.OleDbCommand(qry, conn)
                    command.CommandType = CommandType.Text
                    command.CommandText = qry
                    command.ExecuteNonQuery()
                    command.Dispose()
                    Return True
                End Using
            End Using

            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function Execute(query As String) As DataSet
        Try

            DBContextGlobalVariable.SysSettings = New settings()
            DBContextGlobalVariable.SysSettings.Load()
            Dim connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBContextGlobalVariable.SysSettings.access_file_path & ";" &
                            "Jet OLEDB:Database Password= " & DBContextGlobalVariable.SysSettings.access_pwd & ";"

            Using conn As OleDb.OleDbConnection = New OleDb.OleDbConnection(connectionString:=connString)
                conn.Open()
                Using command As OleDb.OleDbCommand = New OleDb.OleDbCommand(query, conn)
                    command.CommandType = CommandType.Text

                    Dim ds As DataSet = New DataSet()
                    Dim da As New OleDb.OleDbDataAdapter(command)
                    da.Fill(ds)
                    Return ds
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function GetConnectionString()
        Dim settings As settings = New settings()
        settings.Load()
        Dim connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & settings.access_file_path & ";" &
                        "Jet OLEDB:Database Password= " & settings.access_pwd & ";"
        Return connString
    End Function
End Class
