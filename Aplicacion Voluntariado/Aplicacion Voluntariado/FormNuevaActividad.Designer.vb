<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevaActividad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNuevaActividad))
        Me.txtNombreNA = New System.Windows.Forms.TextBox()
        Me.txtDireccionNA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numNPaticipantesNA = New System.Windows.Forms.NumericUpDown()
        Me.dtpFechaInicioNA = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinNA = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblActividades = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboOrganizacionNA = New System.Windows.Forms.ComboBox()
        Me.btnDarDeAltaNA = New System.Windows.Forms.Button()
        Me.txtEstadoNA = New System.Windows.Forms.TextBox()
        Me.btnVolverNA = New System.Windows.Forms.Button()
        CType(Me.numNPaticipantesNA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombreNA
        '
        Me.txtNombreNA.Location = New System.Drawing.Point(205, 146)
        Me.txtNombreNA.Name = "txtNombreNA"
        Me.txtNombreNA.Size = New System.Drawing.Size(212, 26)
        Me.txtNombreNA.TabIndex = 1
        '
        'txtDireccionNA
        '
        Me.txtDireccionNA.Location = New System.Drawing.Point(306, 344)
        Me.txtDireccionNA.Name = "txtDireccionNA"
        Me.txtDireccionNA.Size = New System.Drawing.Size(492, 26)
        Me.txtDireccionNA.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Dirección de la actividad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nº Participantes:"
        '
        'numNPaticipantesNA
        '
        Me.numNPaticipantesNA.Location = New System.Drawing.Point(275, 279)
        Me.numNPaticipantesNA.Name = "numNPaticipantesNA"
        Me.numNPaticipantesNA.Size = New System.Drawing.Size(142, 26)
        Me.numNPaticipantesNA.TabIndex = 3
        '
        'dtpFechaInicioNA
        '
        Me.dtpFechaInicioNA.Location = New System.Drawing.Point(598, 146)
        Me.dtpFechaInicioNA.Name = "dtpFechaInicioNA"
        Me.dtpFechaInicioNA.Size = New System.Drawing.Size(200, 26)
        Me.dtpFechaInicioNA.TabIndex = 5
        '
        'dtpFechaFinNA
        '
        Me.dtpFechaFinNA.Location = New System.Drawing.Point(598, 212)
        Me.dtpFechaFinNA.Name = "dtpFechaFinNA"
        Me.dtpFechaFinNA.Size = New System.Drawing.Size(200, 26)
        Me.dtpFechaFinNA.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(481, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha inicio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(481, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fecha fín:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(481, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Estado:"
        '
        'lblActividades
        '
        Me.lblActividades.AutoSize = True
        Me.lblActividades.BackColor = System.Drawing.Color.Transparent
        Me.lblActividades.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActividades.ForeColor = System.Drawing.Color.Navy
        Me.lblActividades.Location = New System.Drawing.Point(241, 38)
        Me.lblActividades.Name = "lblActividades"
        Me.lblActividades.Size = New System.Drawing.Size(420, 42)
        Me.lblActividades.TabIndex = 13
        Me.lblActividades.Text = "ALTA NUEVA ACTIVIDAD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(101, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Organización:"
        '
        'cboOrganizacionNA
        '
        Me.cboOrganizacionNA.FormattingEnabled = True
        Me.cboOrganizacionNA.Location = New System.Drawing.Point(223, 213)
        Me.cboOrganizacionNA.Name = "cboOrganizacionNA"
        Me.cboOrganizacionNA.Size = New System.Drawing.Size(194, 28)
        Me.cboOrganizacionNA.TabIndex = 2
        '
        'btnDarDeAltaNA
        '
        Me.btnDarDeAltaNA.BackColor = System.Drawing.Color.Navy
        Me.btnDarDeAltaNA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDarDeAltaNA.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarDeAltaNA.ForeColor = System.Drawing.Color.White
        Me.btnDarDeAltaNA.Location = New System.Drawing.Point(576, 423)
        Me.btnDarDeAltaNA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDarDeAltaNA.Name = "btnDarDeAltaNA"
        Me.btnDarDeAltaNA.Size = New System.Drawing.Size(222, 49)
        Me.btnDarDeAltaNA.TabIndex = 9
        Me.btnDarDeAltaNA.Text = "DAR DE ALTA"
        Me.btnDarDeAltaNA.UseVisualStyleBackColor = False
        '
        'txtEstadoNA
        '
        Me.txtEstadoNA.BackColor = System.Drawing.SystemColors.Info
        Me.txtEstadoNA.Enabled = False
        Me.txtEstadoNA.Location = New System.Drawing.Point(598, 274)
        Me.txtEstadoNA.Name = "txtEstadoNA"
        Me.txtEstadoNA.ReadOnly = True
        Me.txtEstadoNA.Size = New System.Drawing.Size(200, 26)
        Me.txtEstadoNA.TabIndex = 7
        Me.txtEstadoNA.TabStop = False
        '
        'btnVolverNA
        '
        Me.btnVolverNA.BackColor = System.Drawing.Color.Navy
        Me.btnVolverNA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVolverNA.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverNA.ForeColor = System.Drawing.Color.White
        Me.btnVolverNA.Location = New System.Drawing.Point(105, 423)
        Me.btnVolverNA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVolverNA.Name = "btnVolverNA"
        Me.btnVolverNA.Size = New System.Drawing.Size(222, 49)
        Me.btnVolverNA.TabIndex = 8
        Me.btnVolverNA.Text = "VOLVER"
        Me.btnVolverNA.UseVisualStyleBackColor = False
        '
        'FormNuevaActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 527)
        Me.Controls.Add(Me.btnVolverNA)
        Me.Controls.Add(Me.txtEstadoNA)
        Me.Controls.Add(Me.btnDarDeAltaNA)
        Me.Controls.Add(Me.cboOrganizacionNA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblActividades)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFechaFinNA)
        Me.Controls.Add(Me.dtpFechaInicioNA)
        Me.Controls.Add(Me.numNPaticipantesNA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDireccionNA)
        Me.Controls.Add(Me.txtNombreNA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormNuevaActividad"
        Me.Text = "Formulario para nueva actividad"
        CType(Me.numNPaticipantesNA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombreNA As TextBox
    Friend WithEvents txtDireccionNA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents numNPaticipantesNA As NumericUpDown
    Friend WithEvents dtpFechaInicioNA As DateTimePicker
    Friend WithEvents dtpFechaFinNA As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblActividades As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboOrganizacionNA As ComboBox
    Friend WithEvents btnDarDeAltaNA As Button
    Friend WithEvents txtEstadoNA As TextBox
    Friend WithEvents btnVolverNA As Button
End Class
