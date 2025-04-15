Imports Biblioteca_de_clases

Public Class listaOds
    Private Sub listaODS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dvgODSNo.DataSource = GestionActividades.ODSNoActividad(actividadSeleccionada)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAnadirOds.Click
        If dvgODSNo.SelectedRows.Count = 0 Then
            MessageBox.Show("Para agregar un ODS primero tienes que seleccionar la ODS")
            Exit Sub
        Else
            For i As Integer = 0 To dvgODSNo.SelectedRows.Count - 1
                Dim fila As DataGridViewRow = dvgODSNo.SelectedRows(i)
                Dim ods As New Ods(
                    Convert.ToInt32(fila.Cells("NUMODS").Value))
                GestionActividades.AnadirOds(ods.NumOds, actividadSeleccionada.CodActividad)
                dvgODSNo.DataSource = GestionActividades.ODSNoActividad(actividadSeleccionada)
                FormGestionarActividad.dgvODS.DataSource = GestionActividades.ODSPorActividad(actividadSeleccionada)
            Next
        End If
    End Sub
End Class