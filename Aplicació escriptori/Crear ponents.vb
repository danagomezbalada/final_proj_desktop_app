Imports MySql.Data.MySqlClient
Public Class crear_ponents
    Public query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub
    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
        Insertar()
        gestio_ponent.actualitzarTaula()
    End Sub
    Function Insertar()
        Connexions.connectar()
        Dim name As String
        Dim lastname As String
        name = nom.Text
        lastname = cognom.Text
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
                    'Insert de les dades
                    query = $"INSERT INTO `ponent` (`nom`,`cognoms`,`telefon`,`email`)
        VALUES ('{name}','{lastname}','{telefon.Text}','{email.Text}');"
                Else
                    'Insert de les dades
                    query = $"INSERT INTO `ponent` (`nom`,`cognoms`,`telefon`,`email`)
        VALUES ('{name}','{lastname}','{telefon.Text}','{email.Text}');"
                End If
                'Controll d'errors dels apostrofs
                If lastname.Contains("'") Then
                    lastname = cognom.Text.Replace("'", "’")
                    'Insert de les dades
                    query = $"INSERT INTO `ponent` (`nom`,`cognoms`,`telefon`,`email`)
        VALUES ('{name}','{lastname}','{telefon.Text}','{email.Text}');"
                Else
                    'Insert de les dades
                    query = $"INSERT INTO `ponent` (`nom`,`cognoms`,`telefon`,`email`)
        VALUES ('{name}','{lastname}','{telefon.Text}','{email.Text}');"
                End If
                Dim comanda = New MySqlCommand(query, Connexions.connexio)
                comanda.ExecuteNonQuery()
                MessageBox.Show("Valor afegit")
            End If
        End If
        Connexions.desconnectar()
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_ponent.Show()
    End Sub
End Class