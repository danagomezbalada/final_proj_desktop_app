Imports MySql.Data.MySqlClient
Public Class crear_esdeveniments
    Public query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
        Insertar()
        MessageBox.Show("Valor afegit")
        gestio_esdeveniment.actualitzarTaula()
    End Sub

    Function Insertar()
        Connexions.connectar()
        Dim name As String
        Dim year As Int32
        Dim active As Int32
        Dim description As String

        name = nom.Text
        year = any.Text
        description = descripcio.Text

        If actiu.Checked = True Then
            active = 1
        Else
            active = 0
        End If
        If name.Contains("'") Then
            name = nom.Text.Replace("'", "’")
            query = $"INSERT INTO `esdeveniment` (`any`,`nom`,`descripcio`,`actiu`)
        VALUES ('{year}','{name}','{description}','{active}');"
        Else
            query = $"INSERT INTO `esdeveniment` (`any`,`nom`,`descripcio`,`actiu`)
        VALUES ('{year}','{name}','{description}','{active}');"
        End If

        If description.Contains("'") Then
            description = descripcio.Text.Replace("'", "’")
            query = $"INSERT INTO `esdeveniment` (`any`,`nom`,`descripcio`,`actiu`)
        VALUES ('{year}','{name}','{description}','{active}');"
        Else
            query = $"INSERT INTO `esdeveniment` (`any`,`nom`,`descripcio`,`actiu`)
        VALUES ('{year}','{name}','{description}','{active}');"
        End If



        Dim comanda = New MySqlCommand(query, Connexions.connexio)
        comanda.ExecuteNonQuery()
        Connexions.desconnectar()
    End Function

    Private Sub actiu_CheckedChanged(sender As Object, e As EventArgs) Handles actiu.CheckedChanged
        If actiu.Checked = True Then

        End If
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_esdeveniment.Show()
    End Sub
End Class
