Imports MySql.Data.MySqlClient

Public Class DatabaseConnection
    Private Shared connectionString As String = "Server=localhost;Database=docucare_db;Uid=root;Pwd=your_password;"
    Private Shared connection As MySqlConnection

    ' Get database connection
    Public Shared Function GetConnection() As MySqlConnection
        Try
            If connection Is Nothing OrElse connection.State = ConnectionState.Closed Then
                connection = New MySqlConnection(connectionString)
                connection.Open()
            End If
            Return connection
        Catch ex As MySqlException
            MessageBox.Show("Database Connection Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    ' Close database connection
    Public Shared Sub CloseConnection()
        Try
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error closing connection: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Test database connection
    Public Shared Function TestConnection() As Boolean
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Return True
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Connection Test Failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Execute a query that returns data (SELECT)
    Public Shared Function ExecuteQuery(query As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                If conn IsNot Nothing Then
                    Using cmd As New MySqlCommand(query, conn)
                        Using adapter As New MySqlDataAdapter(cmd)
                            adapter.Fill(dt)
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Query Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' Execute a command that doesn't return data (INSERT, UPDATE, DELETE)
    Public Shared Function ExecuteNonQuery(query As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                If conn IsNot Nothing Then
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.ExecuteNonQuery()
                        Return True
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Command Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Execute query with parameters (safer against SQL injection)
    Public Shared Function ExecuteQueryWithParams(query As String, parameters As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                If conn IsNot Nothing Then
                    Using cmd As New MySqlCommand(query, conn)
                        For Each param In parameters
                            cmd.Parameters.AddWithValue(param.Key, param.Value)
                        Next
                        Using adapter As New MySqlDataAdapter(cmd)
                            adapter.Fill(dt)
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Query Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' Execute non-query with parameters
    Public Shared Function ExecuteNonQueryWithParams(query As String, parameters As Dictionary(Of String, Object)) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                If conn IsNot Nothing Then
                    Using cmd As New MySqlCommand(query, conn)
                        For Each param In parameters
                            cmd.Parameters.AddWithValue(param.Key, param.Value)
                        Next
                        cmd.ExecuteNonQuery()
                        Return True
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Command Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class