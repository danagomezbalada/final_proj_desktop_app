﻿Public Class gestio_ponents_activitat
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        crear_activitat.Show()

    End Sub

    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub
End Class