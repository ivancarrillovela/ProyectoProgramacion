Imports Biblioteca_de_clases
Imports System.Configuration


Public Class listaOds
    Private Sub listaODS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dvgODSNo.DataSource = gestion.OdsNoActividad(actividadSeleccionada)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAnadirOds.Click
        If dvgODSNo.SelectedRows.Count = 0 Then
            MessageBox.Show("Para agregar un ODS primero tienes que seleccionar la ODS.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            For i As Integer = 0 To dvgODSNo.SelectedRows.Count - 1
                Dim fila As DataGridViewRow = dvgODSNo.SelectedRows(i)
                Dim ods As New Ods(
                    Convert.ToInt32(fila.Cells("NUMODS").Value))
                gestion.AnadirOds(actividadSeleccionada.CodActividad, ods.NumOds)
                dvgODSNo.DataSource = gestion.OdsNoActividad(actividadSeleccionada)
            Next
        End If
    End Sub
    Private Sub btnVolverOds_Click(sender As Object, e As EventArgs) Handles btnVolverOds.Click
        FormGestionarActividad.dgvOdsGA.DataSource = gestion.OdsPorActividad(actividadSeleccionada)
        FormGestionarActividad.Show()
        Close()
    End Sub
End Class