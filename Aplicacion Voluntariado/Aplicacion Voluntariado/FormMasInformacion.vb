Imports Biblioteca_de_clases
Imports System.Configuration

Public Class FormMasInformacion
    Private Sub FormMasInformacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ciclos As List(Of Ciclo) = gestion.ListaCiclos
        Dim ods As List(Of Ods) = gestion.ListaOds
        cboNombeCicloMI.Items.AddRange(ciclos.ToArray)
        cboOdsMI.Items.AddRange(ods.ToArray)
        cboNombeCicloMI.Sorted = True
        cboOdsMI.Sorted = True
    End Sub

    Private Sub btnMasInformacion_Click(sender As Object, e As EventArgs) Handles btnMasInformacion.Click
        If cboNombeCicloMI.Text = "" Then
            MessageBox.Show("Debes seleccionar un ciclo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            If cboCursoMI.Text = "" And cboOdsMI.Text = "" Then
                dvgMasInformacion.DataSource = gestion.ActividadesPorCiclo(cboNombeCicloMI.Text)

            ElseIf cboCursoMI.Text <> "" And cboOdsMI.Text = "" Then
                dvgMasInformacion.DataSource = gestion.ActividadesPorCicloYCurso(cboNombeCicloMI.Text, cboCursoMI.Text)

                'ElseIf cboCursoMI.Text = "" And cboOdsMI.Text <> "" Then
                '    dvgMasInformacion.DataSource = gestion.ActividadesPorCicloYOds(cboNombeCicloMI.Text, Convert.ToInt32(cboOdsMI.Text))

                'ElseIf cboCursoMI.Text <> "" And cboOdsMI.Text <> "" Then
                '    'dvgMasInformacion.DataSource = gestion.ActividadesPorCicloYCursoYOds(cboNombeCicloMI.Text, cboCursoMI.Text, cboOdsMI.Text)
            End If

        End If
        dvgMasInformacion.DataSource = gestion.ActividadesPorCicloYCurso(cboNombeCicloMI.Text, cboCursoMI.Text)
    End Sub

    Private Sub btnVolverNA_Click(sender As Object, e As EventArgs) Handles btnVolverNA.Click
        FormPrincipal.Show()
        Me.Hide()
    End Sub


End Class