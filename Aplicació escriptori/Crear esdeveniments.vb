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
        'Control d'error de que no hi hagui cap camp null
        If String.IsNullOrEmpty(nom.Text) = True Or String.IsNullOrEmpty(any.Text) = True Or String.IsNullOrEmpty(descripcio.Text) = True Then
            MessageBox.Show("No hi poden haver-hi camps buits")
        Else
            'Control d'error de que no es pugui introduïr lletres en els camps on hi han d'haver números
            If IsNumeric(any.Text) = False Then
                MessageBox.Show("El camp any ha de ser numèric")
            Else
                'Comprobar el camp actiu
                If actiu.Checked = True Then
                    active = 1
                Else
                    active = 0
                End If
                'Controll d'errors dels apostrofs
                If name.Contains("'") Then
                    name = nom.Text.Replace("'", "’")
                    'Insert de les dades
                    query = $"INSERT INTO `esdeveniment` (`any`,`nom`,`descripcio`,`actiu`)
        VALUES ('{any.Text}','{name}','{description}','{active}');"
                Else
                    query = $"INSERT INTO `esdeveniment` (`any`,`nom`,`descripcio`,`actiu`)
        VALUES ('{any.Text}','{name}','{description}','{active}');"
                End If
                'Controll d'errors dels apostrofs
                If description.Contains("'") Then
                    description = descripcio.Text.Replace("'", "’")
                    'Insert de les dades
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
