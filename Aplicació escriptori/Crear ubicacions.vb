Imports MySql.Data.MySqlClient
Public Class crear_ubicacio
    Dim query As String
    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub

    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
        Insertar()
        MessageBox.Show("Valor afegit")
        gestio_ubicacions.actualitzarTaula()
    End Sub
    Function Insertar()
        Connexions.connectar()
        Dim name As String
        name = Nom.Text
        If name.Contains("'") Then
            name = Nom.Text.Replace("'", "’")
            query = $"INSERT INTO `ubicacio` (`nom`) VALUES ('{name}');"
        Else
            query = $"INSERT INTO `ubicacio` (`nom`) VALUES ('{name}');"
        End If
        Dim comanda = New MySqlCommand(query, Connexions.connexio)
        comanda.ExecuteNonQuery()
        Connexions.desconnectar()
    End Function

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_ubicacions.Show()
    End Sub
End Class