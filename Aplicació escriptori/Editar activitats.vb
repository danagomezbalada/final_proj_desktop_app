Public Class editar_activitats
    Private Sub actualitzar_Click(sender As Object, e As EventArgs) Handles actualitzar.Click

    End Sub

    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        gestio_activitats.Show()
    End Sub
End Class