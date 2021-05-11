Imports MySql.Data.MySqlClient
Public Class crear_esdeveniments
    Public query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
        Insertar()

        gestio_esdeveniment.actualitzarTaula()
    End Sub

    Function Insertar()
        Connexions.connectar()
        Dim name As String
        Dim active As Int32
        Dim description As String


        name = nom.Text
        description = descripcio.Text

        If String.IsNullOrEmpty(nom.Text) = True Or String.IsNullOrEmpty(any.Text) = True Or String.IsNullOrEmpty(descripcio.Text) = True Then
            MessageBox.Show("No hi poden haver-hi camps buits")
        Else
            If IsNumeric(any.Text) = False Then
                MessageBox.Show("El camp any ha de ser numèric")
            Else
                If actiu.Checked = True Then
                    active = 1
                Else
                    active = 0
                End If

                If name.Contains("'") Then
                    name = nom.Text.Replace("'", "’")
                    query = $"INSERT INTO `esdeveniment` (`any`,`nom`,`descripcio`,`actiu`)
        VALUES ('{any.Text}','{name}','{description}','{active}');"
                Else
                    query = $"INSERT INTO `esdeveniment` (`any`,`nom`,`descripcio`,`actiu`)
        VALUES ('{any.Text}','{name}','{description}','{active}');"
                End If

                If description.Contains("'") Then
                    description = descripcio.Text.Replace("'", "’")
                    query = $"INSERT INTO `esdeveniment` (`any`,`nom`,`descripcio`,`actiu`)
        VALUES ('{any.Text}','{name}','{description}','{active}');"
                Else
                    query = $"INSERT INTO `esdeveniment` (`any`,`nom`,`descripcio`,`actiu`)
        VALUES ('{any.Text}','{name}','{description}','{active}');"
                End If
                Dim comanda = New MySqlCommand(query, Connexions.connexio)
                comanda.ExecuteNonQuery()
                MessageBox.Show("Valor afegit")
            End If
        End If

        Connexions.desconnectar()
    End Function



    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_esdeveniment.Show()
    End Sub
End Class
