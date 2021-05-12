Imports System.IO
Imports MySql.Data.MySqlClient
Public Class principal
    Dim query As String
    Private Sub administrar_activitats_Click(sender As Object, e As EventArgs) Handles activitats.Click
        Me.Hide()
        administrar_activitats.Show()
    End Sub
    Private Sub gestionar_activitats_Click(sender As Object, e As EventArgs) Handles gestionar_activitats.Click
        Me.Hide()
        gestio_activitats.Show()
        gestio_activitats.actualitzarTaula()
    End Sub
    Private Sub administrar_esdeveniments_Click(sender As Object, e As EventArgs) Handles administrar_esdeveniments.Click
        Me.Hide()
        gestio_esdeveniment.Show()
        gestio_esdeveniment.actualitzarTaula()
    End Sub
    Private Sub gestionar_reserves_Click(sender As Object, e As EventArgs) Handles gestionar_reserves.Click
        Me.Hide()
        gestio_reserves.Show()
        gestio_reserves.actualitzarTaula()
    End Sub

    Private Sub generar_fitxer_Click(sender As Object, e As EventArgs) Handles generar_fitxer.Click
        Try
            Dim carpeta As New FolderBrowserDialog
            Dim ruta As String = String.Empty

            'Creació del explorador d'archius
            If carpeta.ShowDialog = Windows.Forms.DialogResult.OK Then
                ruta = carpeta.SelectedPath + "\dades.txt"
            End If
            Dim escritor As StreamWriter
            'Comprovació de si el fitcher existeix, si existeix l'elimina per poder crear el nou
            If File.Exists(ruta) Then
                File.Delete(ruta)
            End If
            escritor = File.AppendText(ruta)
            Connexions.connectar()

            'Creació de les dades i el format de com crear el ficher 
            'CATEGORIES
            query = $"SELECT * FROM categoria"
            Dim comandaCategoria As New MySqlCommand(query, Connexions.connexio)
            Dim adaptadorCategoria As New MySqlDataAdapter(comandaCategoria)
            Dim conjunt_dadesCategoria As New DataTable()
            adaptadorCategoria.Fill(conjunt_dadesCategoria)

            For i As Integer = 0 To (conjunt_dadesCategoria.Rows.Count - 1)
                Dim id As Int32 = conjunt_dadesCategoria.Rows(i).Item(0)
                Dim nom As String = conjunt_dadesCategoria.Rows(i).Item(1)

                escritor.WriteLine("C#" & id & ";" & nom)
                escritor.Flush()
            Next

            'UBICACIONS
            query = $"SELECT * FROM ubicacio"
            Dim comandaUbicacio As New MySqlCommand(query, Connexions.connexio)
            Dim adaptadorUbicacio As New MySqlDataAdapter(comandaUbicacio)
            Dim conjunt_dadesUbicacio As New DataTable()
            adaptadorUbicacio.Fill(conjunt_dadesUbicacio)

            For i As Integer = 0 To (conjunt_dadesUbicacio.Rows.Count - 1)
                Dim id As Int32 = conjunt_dadesUbicacio.Rows(i).Item(0)
                Dim nom As String = conjunt_dadesUbicacio.Rows(i).Item(1)

                escritor.WriteLine("U#" & id & ";" & nom)
                escritor.Flush()
            Next

            'DEPARTAMENTS
            query = $"SELECT * FROM departament"
            Dim comandaDepartament As New MySqlCommand(query, Connexions.connexio)
            Dim adaptadorDepartament As New MySqlDataAdapter(comandaDepartament)
            Dim conjunt_dadesDepartament As New DataTable()
            adaptadorDepartament.Fill(conjunt_dadesDepartament)

            For i As Integer = 0 To (conjunt_dadesDepartament.Rows.Count - 1)
                Dim id As Int32 = conjunt_dadesDepartament.Rows(i).Item(0)
                Dim nom As String = conjunt_dadesDepartament.Rows(i).Item(1)

                escritor.WriteLine("D#" & id & ";" & nom)
                escritor.Flush()
            Next

            'ESDEVENIMENTS
            query = $"SELECT * FROM esdeveniment"
            Dim comandaEsdeveniment As New MySqlCommand(query, Connexions.connexio)
            Dim adaptadorEsdeveniment As New MySqlDataAdapter(comandaEsdeveniment)
            Dim conjunt_dadesEsdeveniment As New DataTable()
            adaptadorEsdeveniment.Fill(conjunt_dadesEsdeveniment)

            For i As Integer = 0 To (conjunt_dadesEsdeveniment.Rows.Count - 1)
                Dim id As Int32 = conjunt_dadesEsdeveniment.Rows(i).Item(0)
                Dim any As String = conjunt_dadesEsdeveniment.Rows(i).Item(1)
                Dim nom As String = conjunt_dadesEsdeveniment.Rows(i).Item(2)
                Dim descripcio As String = conjunt_dadesEsdeveniment.Rows(i).Item(3)
                Dim actiu As String = conjunt_dadesEsdeveniment.Rows(i).Item(4)

                escritor.WriteLine("E#" & id & ";" & any & ";" & nom & ";" & descripcio & ";" & actiu)
                escritor.Flush()
            Next

            'PONENTS
            query = $"SELECT * FROM ponent"
            Dim comandaPonent As New MySqlCommand(query, Connexions.connexio)
            Dim adaptadorPonent As New MySqlDataAdapter(comandaPonent)
            Dim conjunt_dadesPonent As New DataTable()
            adaptadorPonent.Fill(conjunt_dadesPonent)

            For i As Integer = 0 To (conjunt_dadesPonent.Rows.Count - 1)
                Dim id As Int32 = conjunt_dadesPonent.Rows(i).Item(0)
                Dim nom As String = conjunt_dadesPonent.Rows(i).Item(1)
                Dim cognoms As String = conjunt_dadesPonent.Rows(i).Item(2)
                Dim telefon As String = conjunt_dadesPonent.Rows(i).Item(3)
                Dim email As String = conjunt_dadesPonent.Rows(i).Item(4)

                escritor.WriteLine("P#" & id & ";" & nom & ";" & cognoms & ";" & telefon & ";" & email)
                escritor.Flush()
            Next

            'ACTIVITATS
            query = $"SELECT * FROM activitat"
            Dim comandaActivitat As New MySqlCommand(query, Connexions.connexio)
            Dim adaptadorActivitat As New MySqlDataAdapter(comandaActivitat)
            Dim conjunt_dadesActivitat As New DataTable()
            adaptadorActivitat.Fill(conjunt_dadesActivitat)

            For i As Integer = 0 To (conjunt_dadesActivitat.Rows.Count - 1)
                Dim id As Int32 = conjunt_dadesActivitat.Rows(i).Item(0)
                Dim titol As String = conjunt_dadesActivitat.Rows(i).Item(1)
                Dim data As Date = conjunt_dadesActivitat.Rows(i).Item(2)
                Dim descripcio As String = conjunt_dadesActivitat.Rows(i).Item(3)
                Dim preu As String = conjunt_dadesActivitat.Rows(i).Item(4)
                Dim placesTotals As String = conjunt_dadesActivitat.Rows(i).Item(5)
                Dim placesActuals As String = conjunt_dadesActivitat.Rows(i).Item(6)
                Dim idEsdeveniment As String = conjunt_dadesActivitat.Rows(i).Item(7)
                Dim dataIniciMostra As Date = conjunt_dadesActivitat.Rows(i).Item(8)
                Dim dataFiMostra As Date = conjunt_dadesActivitat.Rows(i).Item(9)
                Dim idUbicacio As String = conjunt_dadesActivitat.Rows(i).Item(10)
                Dim idDepartament As String = conjunt_dadesActivitat.Rows(i).Item(11)

                escritor.WriteLine("A#" & id & ";" & titol & ";" & data.ToString("yyyy-MM-dd") & ";" & descripcio & ";" &
                                   preu & ";" & placesTotals & ";" & placesActuals & ";" & idEsdeveniment & ";" &
                                   dataIniciMostra.ToString("yyyy-MM-dd") & ";" & dataFiMostra.ToString("yyyy-MM-dd") & ";" &
                                   idUbicacio & ";" & idDepartament)
                escritor.Flush()
            Next

            'ACTIVITAT-PONENT
            query = $"SELECT * FROM activitat_ponent"
            Dim comandaActivitatPonent As New MySqlCommand(query, Connexions.connexio)
            Dim adaptadorActivitatPonent As New MySqlDataAdapter(comandaActivitatPonent)
            Dim conjunt_dadesActivitatPonent As New DataTable()
            adaptadorActivitatPonent.Fill(conjunt_dadesActivitatPonent)

            For i As Integer = 0 To (conjunt_dadesActivitatPonent.Rows.Count - 1)

                Dim activitat As String = conjunt_dadesActivitatPonent.Rows(i).Item(1)
                Dim ponent As String = conjunt_dadesActivitatPonent.Rows(i).Item(2)
                escritor.WriteLine("AP#" & activitat & ";" & ponent)
                escritor.Flush()
            Next

            'ACTIVITAT-CATEGORIA
            query = $"SELECT * FROM activitat_categoria"
            Dim comandaActivitatCategoria As New MySqlCommand(query, Connexions.connexio)
            Dim adaptadorActivitatCategoria As New MySqlDataAdapter(comandaActivitatCategoria)
            Dim conjunt_dadesActivitatCategoria As New DataTable()
            adaptadorActivitatCategoria.Fill(conjunt_dadesActivitatCategoria)

            For i As Integer = 0 To (conjunt_dadesActivitatCategoria.Rows.Count - 1)
                Dim activitat As String = conjunt_dadesActivitatCategoria.Rows(i).Item(1)
                Dim categoria As String = conjunt_dadesActivitatCategoria.Rows(i).Item(2)

                escritor.WriteLine("AC#" & activitat & ";" & categoria)
                escritor.Flush()
            Next

            'RESERVES
            query = $"SELECT * FROM reserva"
            Dim comandaReseva As New MySqlCommand(query, Connexions.connexio)
            Dim adaptadorReseva As New MySqlDataAdapter(comandaReseva)
            Dim conjunt_dadesReseva As New DataTable()
            adaptadorReseva.Fill(conjunt_dadesReseva)

            For i As Integer = 0 To (conjunt_dadesReseva.Rows.Count - 1)
                Dim id As Int32 = conjunt_dadesReseva.Rows(i).Item(0)
                Dim email As String = conjunt_dadesReseva.Rows(i).Item(1)
                Dim idActivitat As String = conjunt_dadesReseva.Rows(i).Item(2)
                Dim data As Date = conjunt_dadesReseva.Rows(i).Item(3)
                Dim codiTransaccio As String = conjunt_dadesReseva.Rows(i).Item(4)
                Dim estat As String = conjunt_dadesReseva.Rows(i).Item(5)
                escritor.WriteLine("R#" & id & ";" & email & ";" & idActivitat & ";" & data.ToString("yyyy-MM-dd") & ";" & codiTransaccio & ";" & estat)
                escritor.Flush()
            Next
            escritor.Close()
            MessageBox.Show("Escritura realizada con éxito")
        Catch ex As Exception
            MessageBox.Show("Escritura realizada incorrectamente")
        End Try
    End Sub
End Class