<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGestionarActividad
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGestionarActividad))
        Me.btnEliminarActividad = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gpxActividad = New System.Windows.Forms.GroupBox()
        Me.cbxOrganizacion = New System.Windows.Forms.ComboBox()
        Me.cbxEstado = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxFechaFin = New System.Windows.Forms.TextBox()
        Me.tbxFechaInicio = New System.Windows.Forms.TextBox()
        Me.tbxParticipantes = New System.Windows.Forms.TextBox()
        Me.tbxDireccion = New System.Windows.Forms.TextBox()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.tbxCdActividad = New System.Windows.Forms.TextBox()
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.dgvVoluntarios = New System.Windows.Forms.DataGridView()
        Me.dgvODS = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.gpxActividad.SuspendLayout()
        CType(Me.dgvVoluntarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvODS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminarActividad
        '
        Me.btnEliminarActividad.BackColor = System.Drawing.Color.Red
        Me.btnEliminarActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarActividad.ForeColor = System.Drawing.Color.White
        Me.btnEliminarActividad.Location = New System.Drawing.Point(626, 441)
        Me.btnEliminarActividad.Name = "btnEliminarActividad"
        Me.btnEliminarActividad.Size = New System.Drawing.Size(150, 56)
        Me.btnEliminarActividad.TabIndex = 6
        Me.btnEliminarActividad.Text = "Eliminar Actividad"
        Me.btnEliminarActividad.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Navy
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(200, 353)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(173, 53)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Añadir Voluntario"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(12, 353)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(182, 53)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Eliminar Voluntario"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Informacion de la Actividad"
        '
        'gpxActividad
        '
        Me.gpxActividad.Controls.Add(Me.cbxOrganizacion)
        Me.gpxActividad.Controls.Add(Me.cbxEstado)
        Me.gpxActividad.Controls.Add(Me.Label10)
        Me.gpxActividad.Controls.Add(Me.Label8)
        Me.gpxActividad.Controls.Add(Me.Label7)
        Me.gpxActividad.Controls.Add(Me.Label6)
        Me.gpxActividad.Controls.Add(Me.Label5)
        Me.gpxActividad.Controls.Add(Me.Label4)
        Me.gpxActividad.Controls.Add(Me.Label3)
        Me.gpxActividad.Controls.Add(Me.Label1)
        Me.gpxActividad.Controls.Add(Me.tbxFechaFin)
        Me.gpxActividad.Controls.Add(Me.tbxFechaInicio)
        Me.gpxActividad.Controls.Add(Me.tbxParticipantes)
        Me.gpxActividad.Controls.Add(Me.tbxDireccion)
        Me.gpxActividad.Controls.Add(Me.tbxNombre)
        Me.gpxActividad.Controls.Add(Me.tbxCdActividad)
        Me.gpxActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpxActividad.Location = New System.Drawing.Point(12, 50)
        Me.gpxActividad.Name = "gpxActividad"
        Me.gpxActividad.Size = New System.Drawing.Size(764, 150)
        Me.gpxActividad.TabIndex = 19
        Me.gpxActividad.TabStop = False
        '
        'cbxOrganizacion
        '
        Me.cbxOrganizacion.FormattingEnabled = True
        Me.cbxOrganizacion.Location = New System.Drawing.Point(381, 96)
        Me.cbxOrganizacion.Name = "cbxOrganizacion"
        Me.cbxOrganizacion.Size = New System.Drawing.Size(198, 24)
        Me.cbxOrganizacion.TabIndex = 27
        '
        'cbxEstado
        '
        Me.cbxEstado.FormattingEnabled = True
        Me.cbxEstado.Location = New System.Drawing.Point(277, 33)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.Size = New System.Drawing.Size(104, 24)
        Me.cbxEstado.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(378, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Organizacion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(176, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Fecha Fin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Fecha Inicio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(638, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "MaxParticipantes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(392, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Estado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "CodActividad"
        '
        'tbxFechaFin
        '
        Me.tbxFechaFin.Location = New System.Drawing.Point(179, 96)
        Me.tbxFechaFin.Name = "tbxFechaFin"
        Me.tbxFechaFin.Size = New System.Drawing.Size(169, 22)
        Me.tbxFechaFin.TabIndex = 20
        '
        'tbxFechaInicio
        '
        Me.tbxFechaInicio.Location = New System.Drawing.Point(6, 96)
        Me.tbxFechaInicio.Name = "tbxFechaInicio"
        Me.tbxFechaInicio.Size = New System.Drawing.Size(161, 22)
        Me.tbxFechaInicio.TabIndex = 20
        '
        'tbxParticipantes
        '
        Me.tbxParticipantes.Location = New System.Drawing.Point(641, 33)
        Me.tbxParticipantes.Name = "tbxParticipantes"
        Me.tbxParticipantes.Size = New System.Drawing.Size(107, 22)
        Me.tbxParticipantes.TabIndex = 20
        '
        'tbxDireccion
        '
        Me.tbxDireccion.Location = New System.Drawing.Point(395, 33)
        Me.tbxDireccion.Name = "tbxDireccion"
        Me.tbxDireccion.Size = New System.Drawing.Size(228, 22)
        Me.tbxDireccion.TabIndex = 20
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(115, 33)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(144, 22)
        Me.tbxNombre.TabIndex = 1
        '
        'tbxCdActividad
        '
        Me.tbxCdActividad.Enabled = False
        Me.tbxCdActividad.Location = New System.Drawing.Point(6, 33)
        Me.tbxCdActividad.Name = "tbxCdActividad"
        Me.tbxCdActividad.Size = New System.Drawing.Size(88, 22)
        Me.tbxCdActividad.TabIndex = 0
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.BackColor = System.Drawing.Color.Navy
        Me.btnGuardarCambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCambios.ForeColor = System.Drawing.Color.White
        Me.btnGuardarCambios.Location = New System.Drawing.Point(470, 441)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(150, 56)
        Me.btnGuardarCambios.TabIndex = 20
        Me.btnGuardarCambios.Text = "Guardar Cambios"
        Me.btnGuardarCambios.UseVisualStyleBackColor = False
        '
        'dgvVoluntarios
        '
        Me.dgvVoluntarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVoluntarios.Location = New System.Drawing.Point(12, 224)
        Me.dgvVoluntarios.Name = "dgvVoluntarios"
        Me.dgvVoluntarios.RowHeadersWidth = 51
        Me.dgvVoluntarios.RowTemplate.Height = 24
        Me.dgvVoluntarios.Size = New System.Drawing.Size(361, 123)
        Me.dgvVoluntarios.TabIndex = 21
        '
        'dgvODS
        '
        Me.dgvODS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvODS.Location = New System.Drawing.Point(410, 224)
        Me.dgvODS.Name = "dgvODS"
        Me.dgvODS.RowHeadersWidth = 51
        Me.dgvODS.RowTemplate.Height = 24
        Me.dgvODS.Size = New System.Drawing.Size(366, 123)
        Me.dgvODS.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(410, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 53)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Eliminar ODS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Navy
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(600, 353)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(177, 53)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Añadir ODS"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FormGestionarActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 509)
        Me.Controls.Add(Me.dgvODS)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgvVoluntarios)
        Me.Controls.Add(Me.btnGuardarCambios)
        Me.Controls.Add(Me.gpxActividad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnEliminarActividad)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormGestionarActividad"
        Me.Text = "Gestion Actividad"
        Me.gpxActividad.ResumeLayout(False)
        Me.gpxActividad.PerformLayout()
        CType(Me.dgvVoluntarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvODS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEliminarActividad As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents gpxActividad As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxFechaFin As TextBox
    Friend WithEvents tbxFechaInicio As TextBox
    Friend WithEvents tbxParticipantes As TextBox
    Friend WithEvents tbxDireccion As TextBox
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents tbxCdActividad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGuardarCambios As Button
    Friend WithEvents dgvVoluntarios As DataGridView
    Friend WithEvents dgvODS As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents cbxEstado As ComboBox
    Friend WithEvents cbxOrganizacion As ComboBox
End Class
