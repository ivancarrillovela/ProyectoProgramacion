Imports Biblioteca_de_clases
Imports System.Configuration

Public Class FormMasInformacion
    Private Sub FormMasInformacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ciclos As List(Of Ciclo) = GestionActividades.ListaCiclos
        Dim ods As List(Of Ods) = GestionActividades.ListaOds
        cboNombeCicloMI.Items.AddRange(ciclos.ToArray)
        cboOdsMI.Items.AddRange(ods.ToArray)
        cboNombeCicloMI.Sorted = True
        cboOdsMI.Sorted = True
    End Sub

    Private Sub btnMasInformacion_Click(sender As Object, e As EventArgs) Handles btnMasInformacion.Click
        dvgMasInformacion.DataSource = GestionActividades.ActividadesPorCiclo(cboNombeCicloMI.Text)
    End Sub

    Private Sub btnVolverNA_Click(sender As Object, e As EventArgs) Handles btnVolverNA.Click
        FormPrincipal.Show()
        Me.Hide()
    End Sub
End Class