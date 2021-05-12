Imports MySql.Data.MySqlClient
Public Class crear_departaments
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
        Insertar()
        gestio_departament.actualitzarTaula()
    End Sub
    Function Insertar()
        Connexions.connectar()
        'Control d'error de que no hi hagui cap camp null
        If String.IsNullOrEmpty(nom.Text) = True Then
            MessageBox.Show("No hi poden haver-hi camps buits")
        Else
            Dim name As String
            name = nom.Text
            'Controll d'errors dels apostrofs
            If name.Contains("'") Then
                name = nom.Text.Replace("'", "’")
                'Insert de les dades
                query = $"INSERT INTO `departament` (`nom`) VALUES ('{name}');"
            Else
                query = $"INSERT INTO `departament` (`nom`) VALUES ('{name}');"
            End If
            Dim comanda = New MySqlCommand(query, Connexions.connexio)
            comanda.ExecuteNonQuery()
            MessageBox.Show("Valor afegit")
        End If
        Connexions.desconnectar()
    End Function
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_departament.Show()
    End Sub
End Class