Public Class gestio_esdeveniment
    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        Principal.Show()
    End Sub

    Private Sub afegir_Click(sender As Object, e As EventArgs) Handles afegir.Click
        Me.Hide()
        crear_esdeveniments.Show()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Me.Hide()
        editar_esdeveniments.Show()
    End Sub
End Class