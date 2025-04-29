Imports Biblioteca_de_clases
Imports System.Configuration


Public Class listaVoluntarios

    Private Sub listaVoluntarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvVoluntariosNo.DataSource = gestion.VoluntariosNoActividad(actividadSeleccionada)
    End Sub

    Private Sub btnAgregarVoluntario_Click(sender As Object, e As EventArgs) Handles btnAnadirVoluntario.Click
        If dgvVoluntariosNo.SelectedRows.Count = 0 Then
            MessageBox.Show("Para agregar un voluntario primero tienes que seleccionar cualquiera")
            Exit Sub
        Else
            For i As Integer = 0 To dgvVoluntariosNo.SelectedRows.Count - 1
                Dim fila As DataGridViewRow = dgvVoluntariosNo.SelectedRows(i)

                Dim vol As New Voluntario(fila.Cells("DNI").Value.ToString)
                gestion.AnadirVoluntario(vol.Dni, actividadSeleccionada.CodActividad)
                dgvVoluntariosNo.DataSource = gestion.VoluntariosNoActividad(actividadSeleccionada)
            Next
        End If
    End Sub

    Private Sub btnVolverAnadirVoluntario_Click(sender As Object, e As EventArgs) Handles btnVolverAnadirVoluntario.Click
        FormGestionarActividad.dgvVoluntariosGA.DataSource = gestion.VoluntariosPorActividad(actividadSeleccionada)
        FormGestionarActividad.Show()
        Close()
    End Sub
End Class