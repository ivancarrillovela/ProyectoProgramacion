Imports Biblioteca_de_clases

Public Class FormGestionarActividad

    Private Sub FormGestionarActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvOdsGA.DataSource = gestion.OdsPorActividad(actividadSeleccionada)
        dgvVoluntariosGA.DataSource = gestion.VoluntariosPorActividad(actividadSeleccionada)
        cbxOrganizacionGA.Text = gestion.OrganizacionPorActividad(actividadSeleccionada)
        tbxCdActividadGA.Text = actividadSeleccionada.CodActividad
        tbxNombreGA.Text = actividadSeleccionada.Nombre
        cbxEstadoGA.Text = actividadSeleccionada.Estado
        tbxDireccionGA.Text = actividadSeleccionada.Direccion
        numParticipantesGA.Text = actividadSeleccionada.Max_participantes
        dtpFechaInicioGA.Text = actividadSeleccionada.Fecha_incio
        dtpFechaFinGA.Text = actividadSeleccionada.Fecha_fin

        If cbxEstadoGA.Text = "En Curso" Then
            Dim estados As New List(Of String) From {"Pendiente", "Archivado"}
            cbxEstadoGA.Items.AddRange(estados.ToArray)
        ElseIf cbxEstadoGA.Text = "Archivado" Then
            Dim estados As New List(Of String) From {"Pendiente", "En Curso"}
            cbxEstadoGA.Items.AddRange(estados.ToArray)
        ElseIf cbxEstadoGA.Text = "Pendiente" Then
            Dim estados As New List(Of String) From {"En Curso", "Archivado"}
            cbxEstadoGA.Items.AddRange(estados.ToArray)
        End If

        cbxOrganizacionGA.Items.AddRange((gestion.OrganizacionesLista(cbxOrganizacionGA.Text)).ToArray)

    End Sub

    Private Sub dgvVoluntarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVoluntariosGA.CellContentClick
        If dgvVoluntariosGA.SelectedRows.Count > 0 Then
            For i As Integer = 0 To dgvVoluntariosGA.SelectedRows.Count
                Dim voluDatos As DataGridViewRow = dgvVoluntariosGA.SelectedRows(i)
                gestion.QuitarVoluntario((Convert.ToInt32(voluDatos.Cells("dni").Value)), actividadSeleccionada.CodActividad)
            Next
        End If
    End Sub

    Private Sub btnEliminarOdsGA_Click(sender As Object, e As EventArgs) Handles btnEliminarOdsGA.Click
        If dgvOdsGA.SelectedRows.Count > 0 Then
            For i As Integer = 0 To dgvOdsGA.SelectedRows.Count - 1
                Dim ODS As DataGridViewRow = dgvOdsGA.SelectedRows(i)
                gestion.QuitarOds(actividadSeleccionada.CodActividad, (Convert.ToInt32(ODS.Cells("NumODS").Value)))
            Next
        Else
            MessageBox.Show("No has seleccionado ninguna ODS.")
        End If
        dgvOdsGA.DataSource = gestion.OdsPorActividad(actividadSeleccionada)

    End Sub

    Private Sub btnEliminarActividadGA_Click(sender As Object, e As EventArgs) Handles btnEliminarActividadGA.Click
        If verificacionCampos() = True Then
            Dim respuesta As DialogResult = MessageBox.Show(
            "¿Estás seguro de que deseas eliminar esta actividad y todas sus relaciones?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If respuesta = DialogResult.No Then
                Exit Sub
            Else
                gestion.BorrarActividad(tbxCdActividadGA.Text)
                FormPrincipal.dvgMenuActividades.DataSource = gestion.ListaActividades
                FormPrincipal.Show()
                Me.Close()
            End If

        End If
    End Sub

    Private Sub btnGuardarCambiosGA_Click(sender As Object, e As EventArgs) Handles btnGuardarCambiosGA.Click
        If verificacionCampos() = True Then
            MessageBox.Show("Cambios guardados correctamente.")
            Dim actividadCambiada As New Actividad((Convert.ToInt32(tbxCdActividadGA.Text)), tbxNombreGA.Text, cbxEstadoGA.Text, tbxDireccionGA.Text, Convert.ToInt32(numParticipantesGA.Text), Convert.ToDateTime(dtpFechaInicioGA.Text), Convert.ToDateTime(dtpFechaFinGA.Text), gestion.CifDeOrganizacionPorNombre(cbxOrganizacionGA.Text))

            gestion.ActualizarActividad(actividadCambiada)
            FormPrincipal.dvgMenuActividades.DataSource = gestion.ListaActividades
            FormPrincipal.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnAnadirVoluntarioGA_Click(sender As Object, e As EventArgs) Handles btnAnadirVoluntarioGA.Click
        Dim listaVoluntarios As New listaVoluntarios
        listaVoluntarios.Show()
        Me.Hide()
    End Sub

    Private Sub btnAnadirOdsGA_Click(sender As Object, e As EventArgs) Handles btnAnadirOdsGA.Click
        Dim listaOds As New listaOds
        listaOds.Show()
        Me.Hide()
    End Sub


    Public Sub actualizarODS()
        dgvOdsGA.DataSource = gestion.OdsPorActividad(actividadSeleccionada)
    End Sub

    Public Sub actualizarVoluntarios()
        dgvOdsGA.DataSource = gestion.VoluntariosPorActividad(actividadSeleccionada)

    End Sub

    Public Function verificacionCampos() As Boolean
        Dim nombre As String = tbxNombreGA.Text.Trim()
        Dim regex As New System.Text.RegularExpressions.Regex("^[A-Za-zÁÉÍÓÚáéíóúÑñ\s]+$")

        If String.IsNullOrWhiteSpace(nombre) Then
            MessageBox.Show("No puedes dejar el nombre vacío, introduce un valor.")
            tbxNombreGA.Focus()
            Return False
        ElseIf Not regex.IsMatch(nombre) Then
            MessageBox.Show("El nombre solo puede contener letras y espacios.")
            tbxNombreGA.Focus()
            Return False
        End If

        Dim direccion As String = tbxDireccionGA.Text.Trim()
        If String.IsNullOrWhiteSpace(direccion) Then
            MessageBox.Show("No puedes dejar la dirección vacía, introduce un valor.")
            tbxDireccionGA.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(numParticipantesGA.Text) Then
            MessageBox.Show("No puedes dejar el campo vacío de máximo de participantes.")
            numParticipantesGA.Focus()
            Return False
        ElseIf Not IsNumeric(numParticipantesGA.Text) Then
            MessageBox.Show("Solo puedes introducir números en el campo de máximo de participantes.")
            numParticipantesGA.Focus()
            Return False
        ElseIf Convert.ToInt32(numParticipantesGA.Text) < 0 Then
            MessageBox.Show("No puede haber un valor negativo en el campo de máximo de participantes.")
            numParticipantesGA.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(dtpFechaInicioGA.Text) Then
            MessageBox.Show("No puedes dejar el campo de fecha de inicio vacío.")
            dtpFechaInicioGA.Focus()
            Return False
        ElseIf Not IsDate(dtpFechaInicioGA.Text) Then
            MessageBox.Show("Has ingresado un tipo de fecha no válido en la fecha de inicio.")
            dtpFechaInicioGA.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(dtpFechaFinGA.Text) Then
            MessageBox.Show("No puedes dejar el campo de fecha de fin vacío.")
            dtpFechaFinGA.Focus()
            Return False
        ElseIf Not IsDate(dtpFechaFinGA.Text) Then
            MessageBox.Show("Has ingresado un tipo de fecha no válido en la fecha de fin.")
            dtpFechaFinGA.Focus()
            Return False
        End If

        Dim fechaInicio As Date = Convert.ToDateTime(dtpFechaInicioGA.Text)
        Dim fechaFin As Date = Convert.ToDateTime(dtpFechaFinGA.Text)

        If fechaInicio > fechaFin Then
            MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.")
            dtpFechaInicioGA.Focus()
            Return False
        End If
        Return True
    End Function


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnEliminarVoluntarioGA.Click
        If dgvVoluntariosGA.SelectedRows.Count > 0 Then
            For i As Integer = 0 To dgvVoluntariosGA.SelectedRows.Count - 1
                Dim Vol As DataGridViewRow = dgvVoluntariosGA.SelectedRows(i)
                gestion.QuitarVoluntario(Vol.Cells("DNI").Value.ToString, actividadSeleccionada.CodActividad)
            Next
        Else
            MessageBox.Show("No has seleccionado ningún voluntario.")
        End If
        dgvVoluntariosGA.DataSource = gestion.VoluntariosPorActividad(actividadSeleccionada)
    End Sub

    Private Sub tbxDireccion_TextChanged(sender As Object, e As EventArgs) Handles tbxDireccionGA.TextChanged

    End Sub



    Private Sub dgvODS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOdsGA.CellContentClick

    End Sub

    Private Sub gpxActividad_Enter(sender As Object, e As EventArgs) Handles gpxActividad.Enter

    End Sub

    Public Sub CargarVoluntarios()
        dgvVoluntariosGA.DataSource = gestion.OdsPorActividad(actividadSeleccionada)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolverGA.Click
        FormPrincipal.Show()
        Me.Hide()
    End Sub
End Class