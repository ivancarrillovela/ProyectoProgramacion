Imports System.Collections.Specialized.BitVector32
Imports Biblioteca_de_clases
Imports StringVerificaciones

Public Class FormNuevaActividad
    Private Sub FormNuevaActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim organizaciones As List(Of Organizacion) = gestion.ListaOrganizaciones
        cboOrganizacionNA.Items.AddRange(organizaciones.ToArray)
        cboOrganizacionNA.Sorted = True
        txtEstadoNA.Text = "En Curso"
    End Sub

    Private Sub btnDarDeAltaNA_Click(sender As Object, e As EventArgs) Handles btnDarDeAltaNA.Click

        If String.IsNullOrEmpty(txtNombreNA.Text) OrElse String.IsNullOrEmpty(txtDireccionNA.Text) OrElse String.IsNullOrEmpty(cboOrganizacionNA.Text) Then
            MessageBox.Show("Ninguno de los campos pueden estar vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not StringVerificaciones.EsAlfabetico(txtNombreNA.Text) Then
            MessageBox.Show("El campo nombre no es válido. Introduce uno con caracteres alfabéticos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(cboOrganizacionNA.Text) Then
            MessageBox.Show("Debes seleccionar una organización de la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If dtpFechaFinNA.Value.Date < dtpFechaInicioNA.Value.Date Then
            MessageBox.Show("La fecha fin tiene que ser mayor que la fecha de inicio, revisa los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If numNPaticipantesNA.Value < 1 Then
            MessageBox.Show("Debes introducir al menos 1 participante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim cifOrganizacionSeleccionada As String = TryCast(cboOrganizacionNA.SelectedItem, Organizacion).Cif
        Dim nuevaActividad As New Actividad(0, txtNombreNA.Text, txtEstadoNA.Text, txtDireccionNA.Text, numNPaticipantesNA.Value, dtpFechaInicioNA.Value, dtpFechaFinNA.Value, cifOrganizacionSeleccionada)

        If gestion.AnadirActividad(nuevaActividad) Then
            MessageBox.Show("Actividad registrada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FormPrincipal.dvgMenuActividades.DataSource = gestion.ListaActividades
            FormPrincipal.Show()
            Me.Close()
        Else
            MessageBox.Show("Error al registrar la actividad. Revisa los datos introducidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub dtpFechaInicioNA_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicioNA.ValueChanged
        If dtpFechaInicioNA.Text > Date.Today Then
            txtEstadoNA.Text = "Pendiente"
        Else
            txtEstadoNA.Text = "En Curso"
        End If
    End Sub

    Private Sub dtpFechaFinNA_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFinNA.ValueChanged
        If dtpFechaFinNA.Text < Date.Today Then
            txtEstadoNA.Text = "Archivado"
        Else
            If dtpFechaInicioNA.Text > Date.Today Then
                txtEstadoNA.Text = "Pendiente"
            Else
                txtEstadoNA.Text = "En Curso"
            End If
        End If
    End Sub

    Private Sub btnVolverNA_Click(sender As Object, e As EventArgs) Handles btnVolverNA.Click
        FormPrincipal.Show()
        Me.Close()
    End Sub

End Class