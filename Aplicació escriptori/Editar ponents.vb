Imports MySql.Data.MySqlClient

Public Class editar_ponents
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_ponent.Show()
        gestio_ponent.actualitzarTaula()
    End Sub
    Private Sub actualitzar_Click(sender As Object, e As EventArgs) Handles actualitzar.Click
        Connexions.connectar()
        Dim name As String
        Dim lastname As String
        Dim id As String
        name = nom.Text
        lastname = cognom.Text
        id = identificador.Text

        Connexions.connectar()
        'Control d'error de que no hi hagui cap camp null
        If String.IsNullOrEmpty(name) = True Or String.IsNullOrEmpty(lastname) = True Or String.IsNullOrEmpty(email.Text) = True Or String.IsNullOrEmpty(telefon.Text) = True Then
            MessageBox.Show("No hi poden haver-hi camps buits")
        Else
            'Control d'error de que no es pugui introduïr lletres en els camps on hi han d'haver números
            If IsNumeric(telefon.Text) = False Then
                MessageBox.Show("El camp telèfon ha de ser numèric")
            Else
                'Controll d'errors dels apostrofs
                If name.Contains("'") Then
                    name = nom.Text.Replace("'", "’")
                    'Update de les dades
                    query = $"Update ponent SET nom=('{nom.Text}'), cognoms = ('{cognom.Text}'), telefon = ('{telefon.Text}'), 
        email =('{email.Text}') where id = ('{id}')"
                Else
                    'Update de les dades
                    query = $"Update ponent SET nom=('{nom.Text}'), cognoms = ('{cognom.Text}'), telefon = ('{telefon.Text}'), 
        email =('{email.Text}') where id = ('{id}')"
                End If
                'Controll d'errors dels apostrofs
                If lastname.Contains("'") Then
                    lastname = cognom.Text.Replace("'", "’")
                    'Update de les dades
                    query = $"Update ponent SET nom=('{nom.Text}'), cognoms = ('{cognom.Text}'), telefon = ('{telefon.Text}'), 
        email =('{email.Text}') where id = ('{id}')"
                Else
                    'Update de les dades
                    query = $"Update ponent SET nom=('{nom.Text}'), cognoms = ('{cognom.Text}'), telefon = ('{telefon.Text}'), 
        email =('{email.Text}') where id = ('{id}')"
                End If
                Dim comanda As New MySqlCommand(query, Connexions.connexio)
                comanda.ExecuteNonQuery()
                MessageBox.Show("Ponent actualitzat/da")
            End If
        End If
        Connexions.desconnectar()
    End Sub
End Class