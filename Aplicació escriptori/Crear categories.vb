Imports MySql.Data.MySqlClient
Public Class crear_categories
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        Principal.Show()
    End Sub

    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
        Insertar()
        MessageBox.Show("Valor afegit")
    End Sub

    Function Insertar()
        Connexions.connectar()
        Dim name As String
        name = nom.Text
        query = $"INSERT INTO `categoria` (`nom`) VALUES ('{name}');"
        Dim comanda = New MySqlCommand(query, Connexions.connexio)
        comanda.ExecuteNonQuery()
        Connexions.desconnectar()
    End Function
End Class