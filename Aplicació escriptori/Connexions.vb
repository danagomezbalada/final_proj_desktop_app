Imports MySql.Data.MySqlClient
Public Class Connexions
    Public query As String
    Public Shared connexio As MySqlConnection

    Public Shared Sub connectar()
        Try
            connexio = New MySqlConnection()
            connexio.ConnectionString = "server=localhost;user id=root;password=alumne;database=projecte_escriptori"
            connexio.Open()
        Catch
            MessageBox.Show("Error de connexió a la BD")
        End Try
    End Sub

    Public Shared Sub desconnectar()
        connexio.Close()
    End Sub
End Class
