Public Class gestio_ponent
    Private Sub Nom_TextChanged(sender As Object, e As EventArgs) Handles Nom.TextChanged

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub inici_Click(sender As Object, e As EventArgs) Handles inici.Click
        Me.Hide()
        Principal.Show()
    End Sub

    Private Sub Afegir_Click(sender As Object, e As EventArgs) Handles Afegir.Click
        Me.Hide()
        crear_ponents.Show()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Me.Hide()
        editar_ponents.Show()
    End Sub
End Class