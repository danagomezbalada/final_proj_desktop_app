﻿Imports MySql.Data.MySqlClient
Public Class crear_ponents
    Public query As String
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
        Insertar()
        MessageBox.Show("Valor afegit")
        gestio_ponent.actualitzarTaula()
    End Sub
    Function Insertar()
        Connexions.connectar()
        Dim name As String
        Dim lastname As String
        Dim phone As Int32
        Dim mail As String
        name = nom.Text
        lastname = cognom.Text
        phone = telefon.Text
        mail = email.Text

        If name.Contains("'") Then
            name = nom.Text.Replace("'", "’")
            query = $"INSERT INTO `ponent` (`nom`,`cognoms`,`telefon`,`email`)
        VALUES ('{name}','{lastname}','{phone}','{mail}');"
        Else
            query = $"INSERT INTO `ponent` (`nom`,`cognoms`,`telefon`,`email`)
        VALUES ('{name}','{lastname}','{phone}','{mail}');"
        End If
        If lastname.Contains("'") Then
            lastname = cognom.Text.Replace("'", "’")
            query = $"INSERT INTO `ponent` (`nom`,`cognoms`,`telefon`,`email`)
        VALUES ('{name}','{lastname}','{phone}','{mail}');"
        Else
            query = $"INSERT INTO `ponent` (`nom`,`cognoms`,`telefon`,`email`)
        VALUES ('{name}','{lastname}','{phone}','{mail}');"
        End If
        Dim comanda = New MySqlCommand(query, Connexions.connexio)
        comanda.ExecuteNonQuery()
        Connexions.desconnectar()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_ponent.Show()
    End Sub
End Class