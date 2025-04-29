Imports Biblioteca_de_clases
Imports System.Configuration

Public Class FormMasInformacion
    Private Sub FormMasInformacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dvgMasInformacion.DataSource = gestion.ListaActividades
        Dim ciclos As List(Of Ciclo) = gestion.ListaCiclos
        Dim cursos As List(Of String) = ciclos.Select(Of String)(Function(c) c.curso.ToString).Distinct.ToList
        Dim ods As List(Of Ods) = gestion.ListaOds
        cboNombeCicloMI.Items.AddRange(ciclos.ToArray)
        cboCursoMI.Items.AddRange(cursos.ToArray)
        cboOdsMI.Items.AddRange(ods.ToArray)
        cboNombeCicloMI.Sorted = True
        cboCursoMI.Sorted = True
        cboOdsMI.Sorted = True
    End Sub

    Private Sub btnFiltrarActividadesMI_Click(sender As Object, e As EventArgs) Handles btnFiltrarActividadesMI.Click
        If cboNombeCicloMI.Text = "" Then
            MessageBox.Show("Debes seleccionar un ciclo como mínimo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            If cboCursoMI.Text = "" And cboOdsMI.Text = "" Then
                dvgMasInformacion.DataSource = gestion.ActividadesPorCiclo(cboNombeCicloMI.Text)

            ElseIf cboCursoMI.Text <> "" And cboOdsMI.Text = "" Then

                dvgMasInformacion.DataSource = gestion.ActividadesPorCicloYCurso(cboNombeCicloMI.Text, cboCursoMI.Text)

            ElseIf cboCursoMI.Text = "" And cboOdsMI.Text <> "" Then
                dvgMasInformacion.DataSource = gestion.ActividadesPorCicloYOds(cboNombeCicloMI.Text, CType(cboOdsMI.SelectedItem, Ods).NumOds)

            Else
                dvgMasInformacion.DataSource = gestion.ActividadesPorCicloCursoYOds(cboNombeCicloMI.Text, cboCursoMI.Text, CType(cboOdsMI.SelectedItem, Ods).NumOds)

            End If
        End If

    End Sub
    Private Sub btnVolverMI_Click(sender As Object, e As EventArgs) Handles btnVolverMI.Click
        FormPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub btnLimpiarControlesMi_Click(sender As Object, e As EventArgs) Handles btnLimpiarControlesMi.Click
        cboNombeCicloMI.Text = ""
        cboCursoMI.Text = ""
        cboOdsMI.Text = ""
        dvgMasInformacion.DataSource = gestion.ListaActividades

    End Sub

    Private Sub cboNombeCicloMI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombeCicloMI.SelectedIndexChanged

    End Sub
End Class