<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionarActividad
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGestionarActividad))
        Me.dgvOdsGA = New System.Windows.Forms.DataGridView()
        Me.btnEliminarOdsGA = New System.Windows.Forms.Button()
        Me.btnAnadirOdsGA = New System.Windows.Forms.Button()
        Me.dgvVoluntariosGA = New System.Windows.Forms.DataGridView()
        Me.btnGuardarCambiosGA = New System.Windows.Forms.Button()
        Me.gpxActividad = New System.Windows.Forms.GroupBox()
        Me.cbxOrganizacionGA = New System.Windows.Forms.ComboBox()
        Me.cbxEstadoGA = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxDireccionGA = New System.Windows.Forms.TextBox()
        Me.tbxNombreGA = New System.Windows.Forms.TextBox()
        Me.tbxCdActividadGA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEliminarVoluntarioGA = New System.Windows.Forms.Button()
        Me.btnAnadirVoluntarioGA = New System.Windows.Forms.Button()
        Me.btnEliminarActividadGA = New System.Windows.Forms.Button()
        Me.btnVolverGA = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.dtpFechaInicioGA = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinGA = New System.Windows.Forms.DateTimePicker()
        Me.numParticipantesGA = New System.Windows.Forms.NumericUpDown()
        CType(Me.dgvOdsGA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVoluntariosGA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxActividad.SuspendLayout()
        CType(Me.numParticipantesGA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvOdsGA
        '
        Me.dgvOdsGA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOdsGA.Location = New System.Drawing.Point(461, 271)
        Me.dgvOdsGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvOdsGA.Name = "dgvOdsGA"
        Me.dgvOdsGA.RowHeadersWidth = 51
        Me.dgvOdsGA.RowTemplate.Height = 24
        Me.dgvOdsGA.Size = New System.Drawing.Size(412, 154)
        Me.dgvOdsGA.TabIndex = 34
        '
        'btnEliminarOdsGA
        '
        Me.btnEliminarOdsGA.BackColor = System.Drawing.Color.Red
        Me.btnEliminarOdsGA.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarOdsGA.ForeColor = System.Drawing.Color.White
        Me.btnEliminarOdsGA.Location = New System.Drawing.Point(461, 432)
        Me.btnEliminarOdsGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminarOdsGA.Name = "btnEliminarOdsGA"
        Me.btnEliminarOdsGA.Size = New System.Drawing.Size(207, 66)
        Me.btnEliminarOdsGA.TabIndex = 33
        Me.btnEliminarOdsGA.Text = "Eliminar ODS"
        Me.btnEliminarOdsGA.UseVisualStyleBackColor = False
        '
        'btnAnadirOdsGA
        '
        Me.btnAnadirOdsGA.BackColor = System.Drawing.Color.Navy
        Me.btnAnadirOdsGA.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadirOdsGA.ForeColor = System.Drawing.Color.White
        Me.btnAnadirOdsGA.Location = New System.Drawing.Point(675, 432)
        Me.btnAnadirOdsGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAnadirOdsGA.Name = "btnAnadirOdsGA"
        Me.btnAnadirOdsGA.Size = New System.Drawing.Size(199, 66)
        Me.btnAnadirOdsGA.TabIndex = 32
        Me.btnAnadirOdsGA.Text = "Añadir ODS"
        Me.btnAnadirOdsGA.UseVisualStyleBackColor = False
        '
        'dgvVoluntariosGA
        '
        Me.dgvVoluntariosGA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVoluntariosGA.Location = New System.Drawing.Point(14, 271)
        Me.dgvVoluntariosGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvVoluntariosGA.Name = "dgvVoluntariosGA"
        Me.dgvVoluntariosGA.RowHeadersWidth = 51
        Me.dgvVoluntariosGA.RowTemplate.Height = 24
        Me.dgvVoluntariosGA.Size = New System.Drawing.Size(406, 154)
        Me.dgvVoluntariosGA.TabIndex = 31
        '
        'btnGuardarCambiosGA
        '
        Me.btnGuardarCambiosGA.BackColor = System.Drawing.Color.Navy
        Me.btnGuardarCambiosGA.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCambiosGA.ForeColor = System.Drawing.Color.White
        Me.btnGuardarCambiosGA.Location = New System.Drawing.Point(529, 542)
        Me.btnGuardarCambiosGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGuardarCambiosGA.Name = "btnGuardarCambiosGA"
        Me.btnGuardarCambiosGA.Size = New System.Drawing.Size(169, 70)
        Me.btnGuardarCambiosGA.TabIndex = 30
        Me.btnGuardarCambiosGA.Text = "Guardar Cambios"
        Me.btnGuardarCambiosGA.UseVisualStyleBackColor = False
        '
        'gpxActividad
        '
        Me.gpxActividad.Controls.Add(Me.numParticipantesGA)
        Me.gpxActividad.Controls.Add(Me.dtpFechaFinGA)
        Me.gpxActividad.Controls.Add(Me.dtpFechaInicioGA)
        Me.gpxActividad.Controls.Add(Me.cbxOrganizacionGA)
        Me.gpxActividad.Controls.Add(Me.cbxEstadoGA)
        Me.gpxActividad.Controls.Add(Me.Label10)
        Me.gpxActividad.Controls.Add(Me.Label8)
        Me.gpxActividad.Controls.Add(Me.Label7)
        Me.gpxActividad.Controls.Add(Me.Label6)
        Me.gpxActividad.Controls.Add(Me.Label5)
        Me.gpxActividad.Controls.Add(Me.Label4)
        Me.gpxActividad.Controls.Add(Me.Label3)
        Me.gpxActividad.Controls.Add(Me.Label1)
        Me.gpxActividad.Controls.Add(Me.tbxDireccionGA)
        Me.gpxActividad.Controls.Add(Me.tbxNombreGA)
        Me.gpxActividad.Controls.Add(Me.tbxCdActividadGA)
        Me.gpxActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpxActividad.Location = New System.Drawing.Point(14, 54)
        Me.gpxActividad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxActividad.Name = "gpxActividad"
        Me.gpxActividad.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxActividad.Size = New System.Drawing.Size(860, 188)
        Me.gpxActividad.TabIndex = 29
        Me.gpxActividad.TabStop = False
        '
        'cbxOrganizacionGA
        '
        Me.cbxOrganizacionGA.FormattingEnabled = True
        Me.cbxOrganizacionGA.Location = New System.Drawing.Point(448, 117)
        Me.cbxOrganizacionGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxOrganizacionGA.Name = "cbxOrganizacionGA"
        Me.cbxOrganizacionGA.Size = New System.Drawing.Size(222, 28)
        Me.cbxOrganizacionGA.TabIndex = 27
        '
        'cbxEstadoGA
        '
        Me.cbxEstadoGA.FormattingEnabled = True
        Me.cbxEstadoGA.Location = New System.Drawing.Point(312, 40)
        Me.cbxEstadoGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxEstadoGA.Name = "cbxEstadoGA"
        Me.cbxEstadoGA.Size = New System.Drawing.Size(116, 28)
        Me.cbxEstadoGA.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(444, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 20)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Organizacion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(226, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Fecha Fin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Fecha Inicio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(718, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "MaxParticipantes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(441, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(308, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Estado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "CodActividad"
        '
        'tbxDireccionGA
        '
        Me.tbxDireccionGA.Location = New System.Drawing.Point(444, 41)
        Me.tbxDireccionGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbxDireccionGA.Name = "tbxDireccionGA"
        Me.tbxDireccionGA.Size = New System.Drawing.Size(256, 25)
        Me.tbxDireccionGA.TabIndex = 20
        '
        'tbxNombreGA
        '
        Me.tbxNombreGA.Location = New System.Drawing.Point(129, 42)
        Me.tbxNombreGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbxNombreGA.Name = "tbxNombreGA"
        Me.tbxNombreGA.Size = New System.Drawing.Size(162, 25)
        Me.tbxNombreGA.TabIndex = 1
        '
        'tbxCdActividadGA
        '
        Me.tbxCdActividadGA.Enabled = False
        Me.tbxCdActividadGA.Location = New System.Drawing.Point(7, 42)
        Me.tbxCdActividadGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbxCdActividadGA.Name = "tbxCdActividadGA"
        Me.tbxCdActividadGA.Size = New System.Drawing.Size(98, 25)
        Me.tbxCdActividadGA.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Informacion de la Actividad"
        '
        'btnEliminarVoluntarioGA
        '
        Me.btnEliminarVoluntarioGA.BackColor = System.Drawing.Color.Red
        Me.btnEliminarVoluntarioGA.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarVoluntarioGA.ForeColor = System.Drawing.Color.White
        Me.btnEliminarVoluntarioGA.Location = New System.Drawing.Point(14, 432)
        Me.btnEliminarVoluntarioGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminarVoluntarioGA.Name = "btnEliminarVoluntarioGA"
        Me.btnEliminarVoluntarioGA.Size = New System.Drawing.Size(205, 66)
        Me.btnEliminarVoluntarioGA.TabIndex = 27
        Me.btnEliminarVoluntarioGA.Text = "Eliminar Voluntario"
        Me.btnEliminarVoluntarioGA.UseVisualStyleBackColor = False
        '
        'btnAnadirVoluntarioGA
        '
        Me.btnAnadirVoluntarioGA.BackColor = System.Drawing.Color.Navy
        Me.btnAnadirVoluntarioGA.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadirVoluntarioGA.ForeColor = System.Drawing.Color.White
        Me.btnAnadirVoluntarioGA.Location = New System.Drawing.Point(225, 432)
        Me.btnAnadirVoluntarioGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAnadirVoluntarioGA.Name = "btnAnadirVoluntarioGA"
        Me.btnAnadirVoluntarioGA.Size = New System.Drawing.Size(195, 66)
        Me.btnAnadirVoluntarioGA.TabIndex = 26
        Me.btnAnadirVoluntarioGA.Text = "Añadir Voluntario"
        Me.btnAnadirVoluntarioGA.UseVisualStyleBackColor = False
        '
        'btnEliminarActividadGA
        '
        Me.btnEliminarActividadGA.BackColor = System.Drawing.Color.Red
        Me.btnEliminarActividadGA.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarActividadGA.ForeColor = System.Drawing.Color.White
        Me.btnEliminarActividadGA.Location = New System.Drawing.Point(704, 542)
        Me.btnEliminarActividadGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminarActividadGA.Name = "btnEliminarActividadGA"
        Me.btnEliminarActividadGA.Size = New System.Drawing.Size(169, 70)
        Me.btnEliminarActividadGA.TabIndex = 25
        Me.btnEliminarActividadGA.Text = "Eliminar Actividad"
        Me.btnEliminarActividadGA.UseVisualStyleBackColor = False
        '
        'btnVolverGA
        '
        Me.btnVolverGA.BackColor = System.Drawing.Color.Navy
        Me.btnVolverGA.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverGA.ForeColor = System.Drawing.Color.White
        Me.btnVolverGA.Location = New System.Drawing.Point(14, 542)
        Me.btnVolverGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVolverGA.Name = "btnVolverGA"
        Me.btnVolverGA.Size = New System.Drawing.Size(205, 70)
        Me.btnVolverGA.TabIndex = 35
        Me.btnVolverGA.Text = "Volver"
        Me.btnVolverGA.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(797, 241)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(8, 28)
        Me.ComboBox1.TabIndex = 36
        '
        'dtpFechaInicioGA
        '
        Me.dtpFechaInicioGA.Location = New System.Drawing.Point(7, 120)
        Me.dtpFechaInicioGA.Name = "dtpFechaInicioGA"
        Me.dtpFechaInicioGA.Size = New System.Drawing.Size(200, 25)
        Me.dtpFechaInicioGA.TabIndex = 28
        '
        'dtpFechaFinGA
        '
        Me.dtpFechaFinGA.Location = New System.Drawing.Point(227, 120)
        Me.dtpFechaFinGA.Name = "dtpFechaFinGA"
        Me.dtpFechaFinGA.Size = New System.Drawing.Size(200, 25)
        Me.dtpFechaFinGA.TabIndex = 29
        '
        'numParticipantesGA
        '
        Me.numParticipantesGA.Location = New System.Drawing.Point(722, 42)
        Me.numParticipantesGA.Name = "numParticipantesGA"
        Me.numParticipantesGA.Size = New System.Drawing.Size(119, 25)
        Me.numParticipantesGA.TabIndex = 30
        '
        'FormGestionarActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 626)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnVolverGA)
        Me.Controls.Add(Me.dgvOdsGA)
        Me.Controls.Add(Me.btnEliminarOdsGA)
        Me.Controls.Add(Me.btnAnadirOdsGA)
        Me.Controls.Add(Me.dgvVoluntariosGA)
        Me.Controls.Add(Me.btnGuardarCambiosGA)
        Me.Controls.Add(Me.gpxActividad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEliminarVoluntarioGA)
        Me.Controls.Add(Me.btnAnadirVoluntarioGA)
        Me.Controls.Add(Me.btnEliminarActividadGA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormGestionarActividad"
        Me.Text = "FormGestionarActividad"
        CType(Me.dgvOdsGA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVoluntariosGA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxActividad.ResumeLayout(False)
        Me.gpxActividad.PerformLayout()
        CType(Me.numParticipantesGA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvOdsGA As DataGridView
    Friend WithEvents btnEliminarOdsGA As Button
    Friend WithEvents btnAnadirOdsGA As Button
    Friend WithEvents dgvVoluntariosGA As DataGridView
    Friend WithEvents btnGuardarCambiosGA As Button
    Friend WithEvents gpxActividad As GroupBox
    Friend WithEvents cbxOrganizacionGA As ComboBox
    Friend WithEvents cbxEstadoGA As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxDireccionGA As TextBox
    Friend WithEvents tbxNombreGA As TextBox
    Friend WithEvents tbxCdActividadGA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEliminarVoluntarioGA As Button
    Friend WithEvents btnAnadirVoluntarioGA As Button
    Friend WithEvents btnEliminarActividadGA As Button
    Friend WithEvents btnVolverGA As Button
    Friend WithEvents dtpFechaFinGA As DateTimePicker
    Friend WithEvents dtpFechaInicioGA As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents numParticipantesGA As NumericUpDown
End Class
