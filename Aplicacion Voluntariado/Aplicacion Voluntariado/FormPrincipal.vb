﻿Imports System.Collections.Specialized.BitVector32
Imports Biblioteca_de_clases
Imports System.Configuration


Public Class FormPrincipal

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not gestion.CargarFichero Then
            MessageBox.Show("No existe el fichero para la conexión con la BBDD. Asegurate de que el fichero conexion.txt existe en la carpeta Debug.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End If
        If Not gestion.ComprobarConexion Then
            MessageBox.Show("No es posible establecer la conexión con la BBDD. Por favor verifica que el nombre está correctamente escrito en 'conexion.txt'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End If
        For Each actividad As Actividad In gestion.ListaActividades
            If actividad.Fecha_fin < Today.Date Then
                gestion.ModificarEstadoActividad(actividad.CodActividad, "Archivado")
            End If
        Next
        dvgMenuActividades.DataSource = gestion.ListaActividades
    End Sub

    Private Sub btnNuevaActividad_Click(sender As Object, e As EventArgs) Handles btnNuevaActividad.Click
        Dim subForm As New FormNuevaActividad
        subForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnGestionarActividad_Click(sender As Object, e As EventArgs) Handles btnGestionarActividad.Click
        If dvgMenuActividades.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar una actividad primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Exit Sub
        ElseIf dvgMenuActividades.SelectedRows.Count > 1 Then
            MessageBox.Show("Solo puedes gestionar una actividad al mismo tiempo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            Dim fila As DataGridViewRow = dvgMenuActividades.SelectedRows(0)
            actividadSeleccionada = New Actividad(Convert.ToInt32(fila.Cells("CODACTIVIDAD").Value))
            actividadSeleccionada.Cif = (fila.Cells("cif").Value.ToString)
            actividadSeleccionada.Nombre = (fila.Cells("NOMBRE").Value.ToString)
            actividadSeleccionada.Estado = (fila.Cells("ESTADO").Value.ToString)
            actividadSeleccionada.Direccion = (fila.Cells("DIRECCION").Value.ToString)
            actividadSeleccionada.Max_participantes = Convert.ToInt32(fila.Cells("MAX_PARTICIPANTES").Value)
            actividadSeleccionada.Fecha_incio = Convert.ToDateTime(fila.Cells("Fecha_Incio").Value)
            actividadSeleccionada.Fecha_fin = Convert.ToDateTime(fila.Cells("Fecha_Fin").Value)
            Dim subForm As New FormGestionarActividad
            subForm.Show()
        End If

        Me.Hide()
    End Sub
    Private Sub btnMasInformacion_Click(sender As Object, e As EventArgs) Handles btnMasInformacion.Click
        Dim subForm As New FormMasInformacion
        subForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnArchivarActividad_Click(sender As Object, e As EventArgs) Handles btnArchivarActividad.Click
        If dvgMenuActividades.SelectedRows.Count = 0 Then
            MessageBox.Show("Tienes que seleccionar una actividad.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            Dim codActividad As Integer = dvgMenuActividades.SelectedRows(0).Cells("CODACTIVIDAD").Value
            Dim estadoActual As String = dvgMenuActividades.SelectedRows(0).Cells("ESTADO").Value
            If Not estadoActual = "Archivado" Then
                gestion.ModificarEstadoActividad(codActividad, "Archivado")
                dvgMenuActividades.DataSource = gestion.ListaActividades
                MessageBox.Show("La actividad se ha archivado correctamente.", "Archivado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("La actividad seleccionada ya está archivada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnSalirMenuActividades_Click(sender As Object, e As EventArgs) Handles btnSalirMenuActividades.Click
        Me.Close()
    End Sub
End Class
