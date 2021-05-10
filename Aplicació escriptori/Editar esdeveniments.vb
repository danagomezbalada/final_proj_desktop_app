Imports MySql.Data.MySqlClient
Public Class editar_esdeveniments
    Dim query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_esdeveniment.Show()
        gestio_esdeveniment.actualitzarTaula()
    End Sub

    Private Sub actualitzar_Click(sender As Object, e As EventArgs) Handles actualitzar.Click
        Connexions.connectar()
        Dim id As String
        id = identificador.Text
        Dim active As Int32
        Dim name = nom.Text
        Dim description = descripcio.Text

        If IsNumeric(any.Text) = False Then
            MessageBox.Show("El camp any ha de ser numèric")
        Else
            If String.IsNullOrEmpty(nom.Text) = True Or String.IsNullOrEmpty(any.Text) = True Or String.IsNullOrEmpty(descripcio.Text) = True Then
                MessageBox.Show("No hi poden haver-hi camps buits")
            Else
                If actiu.Checked = True Then
                    active = 1
                Else
                    active = 0
                End If
                If nom.Text.Contains("'") Then
                    nom.Text = nom.Text.Replace("'", "’")
                    query = $"Update esdeveniment SET any = ('{any.Text}'),nom=('{nom.Text}'),  descripcio = ('{descripcio.Text}'),actiu = ('{active}') 
        where id = ('{id}')"
                Else
                    query = $"Update esdeveniment SET any = ('{any.Text}'),nom=('{nom.Text}'),  descripcio = ('{descripcio.Text}'),actiu = ('{active}') 
        where id = ('{id}')"
                End If

                If descripcio.Text.Contains("'") Then
                    descripcio.Text = descripcio.Text.Replace("'", "’")
                    query = $"Update esdeveniment SET any = ('{any.Text}'),nom=('{nom.Text}'),  descripcio = ('{descripcio.Text}'),actiu = ('{active}') 
        where id = ('{id}')"
                Else
                    query = $"Update esdeveniment SET any = ('{any.Text}'),nom=('{nom.Text}'),  descripcio = ('{descripcio.Text}'),actiu = ('{active}') 
        where id = ('{id}')"
                End If
                Dim comanda As New MySqlCommand(query, Connexions.connexio)
                comanda.ExecuteNonQuery()
                Connexions.desconnectar()
                MessageBox.Show("Esdeveniment actualitzat")
            End If
        End If


    End Sub
End Class