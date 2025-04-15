Imports Biblioteca_de_clases

Public Class FormGestionarActividadd
    Dim gestionActividad As New GestionActividades


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgv_Actividades_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub FormGestionarActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvODS.DataSource = GestionActividades.ODSPorActividad(actividadSeleccionada)
        dgvVoluntarios.DataSource = GestionActividades.voluntariosPorActividad(actividadSeleccionada)
        cbxOrganizacion.Text = GestionActividades.OrganizacionPorActividad(actividadSeleccionada)
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

        cbxOrganizacion.Items.AddRange((GestionActividades.organizacionesLista(cbxOrganizacion.Text)).ToArray)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)
    End Sub

    Private Sub cboVoluntarios_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvVoluntarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVoluntarios.CellContentClick
        If dgvVoluntarios.SelectedRows.Count > 0 Then
            For i As Integer = 0 To dgvVoluntarios.SelectedRows.Count
                Dim voluDatos As DataGridViewRow = dgvVoluntarios.SelectedRows(i)
                GestionActividades.QuitarVoluntario((Convert.ToInt32(voluDatos.Cells("dni").Value)), actividadSeleccionada.CodActividad)
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dgvODS.SelectedRows.Count > 0 Then
            For i As Integer = 0 To dgvODS.SelectedRows.Count - 1
                Dim ODS As DataGridViewRow = dgvODS.SelectedRows(i)
                GestionActividades.QuitarOds((Convert.ToInt32(ODS.Cells("NumODS").Value)), actividadSeleccionada.CodActividad)
            Next
        End If
        dgvODS.DataSource = GestionActividades.ODSPorActividad(actividadSeleccionada)

    End Sub

    Private Sub btnEliminarActividad_Click(sender As Object, e As EventArgs) Handles btnEliminarActividad.Click
        If verificacionCampos() = True Then
            Dim respuesta As DialogResult = MessageBox.Show(
            "¿Estás seguro de que deseas eliminar esta actividad y todas sus relaciones?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If respuesta = DialogResult.No Then
                Exit Sub
            Else
                GestionActividades.BorrarActividad(tbxCdActividad.Text)
                Me.Close()

            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        If verificacionCampos() = True Then
            MessageBox.Show("Cambios guardados correctamente.")
            Dim actividadCambiada As New Actividad((Convert.ToInt32(tbxCdActividad.Text)), tbxNombre.Text, cbxEstado.Text, tbxDireccion.Text, Convert.ToInt32(tbxParticipantes.Text), Convert.ToDateTime(tbxFechaInicio.Text), Convert.ToDateTime(tbxFechaFin.Text), GestionActividades.cifOrganizacionPorNombre(cbxOrganizacion.Text))

            GestionActividades.actualizarActividad(actividadCambiada)

            Me.Close()
        End If



    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim listaVoluntarios As New listaVoluntarios
        listaVoluntarios.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim listaOds As New listaOds
        listaOds.Show()
    End Sub


    Public Sub actualizarODS()
        dgvODS.DataSource = GestionActividades.ODSPorActividad(actividadSeleccionada)
    End Sub

    Public Sub actualizarVoluntarios()
        dgvODS.DataSource = GestionActividades.VoluntariosPorActividad(actividadSeleccionada)

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


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If dgvVoluntarios.SelectedRows.Count > 0 Then
            For i As Integer = 0 To dgvVoluntarios.SelectedRows.Count - 1
                Dim Vol As DataGridViewRow = dgvVoluntarios.SelectedRows(i)
                GestionActividades.QuitarVoluntario(Vol.Cells("DNI").Value.ToString, actividadSeleccionada.CodActividad)
            Next
        End If
        dgvVoluntarios.DataSource = GestionActividades.VoluntariosPorActividad(actividadSeleccionada)
    End Sub

    Private Sub tbxDireccion_TextChanged(sender As Object, e As EventArgs) Handles tbxDireccion.TextChanged

    End Sub



    Private Sub dgvODS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvODS.CellContentClick

    End Sub

    Private Sub gpxActividad_Enter(sender As Object, e As EventArgs) Handles gpxActividad.Enter

    End Sub
End Class