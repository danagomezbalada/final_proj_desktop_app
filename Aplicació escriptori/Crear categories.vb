Imports MySql.Data.MySqlClient
Public Class crear_categories
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
        Insertar()

    End Sub

    Function Insertar()
        Connexions.connectar()
        If String.IsNullOrEmpty(nom.Text) = True Then
            MessageBox.Show("No hi poden haver-hi camps buits")
        Else
            If name.Contains("'") Then
                name = nom.Text.Replace("'", "’")
                query = $"INSERT INTO `categoria` (`nom`) VALUES ('{name}');"
            Else
                query = $"INSERT INTO `categoria` (`nom`) VALUES ('{name}');"
            End If
            Dim comanda = New MySqlCommand(query, Connexions.connexio)
            comanda.ExecuteNonQuery()
            MessageBox.Show("Valor afegit")
        End If
        Connexions.desconnectar()
    End Function

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_categoria.Show()
        gestio_categoria.actualitzarTaula()
    End Sub
End Class