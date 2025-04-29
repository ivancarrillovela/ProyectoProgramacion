Imports Biblioteca_de_clases

Public Class FormGestionarActividad

    Private Sub FormGestionarActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvOdsGA.DataSource = gestion.OdsPorActividad(actividadSeleccionada)
        dgvVoluntariosGA.DataSource = gestion.VoluntariosPorActividad(actividadSeleccionada)
        cbxOrganizacion.Text = gestion.OrganizacionPorActividad(actividadSeleccionada)
        tbxCdActividad.Text = actividadSeleccionada.CodActividad
        tbxNombre.Text = actividadSeleccionada.Nombre
        cbxEstado.Text = actividadSeleccionada.Estado
        tbxDireccion.Text = actividadSeleccionada.Direccion
        tbxParticipantes.Text = actividadSeleccionada.Max_participantes
        tbxFechaInicio.Text = actividadSeleccionada.Fecha_incio
        tbxFechaFin.Text = actividadSeleccionada.Fecha_fin

        If cbxEstado.Text = "En Curso" Then
            Dim estados As New List(Of String) From {"Pendiente", "Archivado"}
            cbxEstado.Items.AddRange(estados.ToArray)
        ElseIf cbxEstado.Text = "Archivado" Then
            Dim estados As New List(Of String) From {"Pendiente", "En Curso"}
            cbxEstado.Items.AddRange(estados.ToArray)
        ElseIf cbxEstado.Text = "Pendiente" Then
            Dim estados As New List(Of String) From {"En Curso", "Archivado"}
            cbxEstado.Items.AddRange(estados.ToArray)
        End If

        cbxOrganizacion.Items.AddRange((gestion.OrganizacionesLista(cbxOrganizacion.Text)).ToArray)

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
                gestion.BorrarActividad(tbxCdActividad.Text)
                FormPrincipal.dvgMenuActividades.DataSource = gestion.ListaActividades
                FormPrincipal.Show()
                Me.Close()
            End If

        End If
    End Sub

    Private Sub btnGuardarCambiosGA_Click(sender As Object, e As EventArgs) Handles btnGuardarCambiosGA.Click
        If verificacionCampos() = True Then
            MessageBox.Show("Cambios guardados correctamente.")
            Dim actividadCambiada As New Actividad((Convert.ToInt32(tbxCdActividad.Text)), tbxNombre.Text, cbxEstado.Text, tbxDireccion.Text, Convert.ToInt32(tbxParticipantes.Text), Convert.ToDateTime(tbxFechaInicio.Text), Convert.ToDateTime(tbxFechaFin.Text), gestion.CifDeOrganizacionPorNombre(cbxOrganizacion.Text))

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
        Dim nombre As String = tbxNombre.Text.Trim()
        Dim regex As New System.Text.RegularExpressions.Regex("^[A-Za-zÁÉÍÓÚáéíóúÑñ\s]+$")

        If String.IsNullOrWhiteSpace(nombre) Then
            MessageBox.Show("No puedes dejar el nombre vacío, introduce un valor.")
            tbxNombre.Focus()
            Return False
        ElseIf Not regex.IsMatch(nombre) Then
            MessageBox.Show("El nombre solo puede contener letras y espacios.")
            tbxNombre.Focus()
            Return False
        End If

        Dim direccion As String = tbxDireccion.Text.Trim()
        If String.IsNullOrWhiteSpace(direccion) Then
            MessageBox.Show("No puedes dejar la dirección vacía, introduce un valor.")
            tbxDireccion.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(tbxParticipantes.Text) Then
            MessageBox.Show("No puedes dejar el campo vacío de máximo de participantes.")
            tbxParticipantes.Focus()
            Return False
        ElseIf Not IsNumeric(tbxParticipantes.Text) Then
            MessageBox.Show("Solo puedes introducir números en el campo de máximo de participantes.")
            tbxParticipantes.Focus()
            Return False
        ElseIf Convert.ToInt32(tbxParticipantes.Text) < 0 Then
            MessageBox.Show("No puede haber un valor negativo en el campo de máximo de participantes.")
            tbxParticipantes.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(tbxFechaInicio.Text) Then
            MessageBox.Show("No puedes dejar el campo de fecha de inicio vacío.")
            tbxFechaInicio.Focus()
            Return False
        ElseIf Not IsDate(tbxFechaInicio.Text) Then
            MessageBox.Show("Has ingresado un tipo de fecha no válido en la fecha de inicio.")
            tbxFechaInicio.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(tbxFechaFin.Text) Then
            MessageBox.Show("No puedes dejar el campo de fecha de fin vacío.")
            tbxFechaFin.Focus()
            Return False
        ElseIf Not IsDate(tbxFechaFin.Text) Then
            MessageBox.Show("Has ingresado un tipo de fecha no válido en la fecha de fin.")
            tbxFechaFin.Focus()
            Return False
        End If

        Dim fechaInicio As Date = Convert.ToDateTime(tbxFechaInicio.Text)
        Dim fechaFin As Date = Convert.ToDateTime(tbxFechaFin.Text)

        If fechaInicio > fechaFin Then
            MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.")
            tbxFechaInicio.Focus()
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

    Private Sub tbxDireccion_TextChanged(sender As Object, e As EventArgs) Handles tbxDireccion.TextChanged

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