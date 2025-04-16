<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.lblActividades = New System.Windows.Forms.Label()
        Me.btnNuevaActividad = New System.Windows.Forms.Button()
        Me.btnGestionarActividad = New System.Windows.Forms.Button()
        Me.btnArchivarActividad = New System.Windows.Forms.Button()
        Me.btnMasInformacion = New System.Windows.Forms.Button()
        Me.btnSalirMenuActividades = New System.Windows.Forms.Button()
        Me.dvgMenuActividades = New System.Windows.Forms.DataGridView()
        CType(Me.dvgMenuActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblActividades
        '
        Me.lblActividades.AutoSize = True
        Me.lblActividades.BackColor = System.Drawing.Color.Transparent
        Me.lblActividades.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActividades.ForeColor = System.Drawing.Color.Navy
        Me.lblActividades.Location = New System.Drawing.Point(414, 27)
        Me.lblActividades.Name = "lblActividades"
        Me.lblActividades.Size = New System.Drawing.Size(492, 36)
        Me.lblActividades.TabIndex = 0
        Me.lblActividades.Text = "ACTIVIDADES DEL VOLUNTARIADO"
        '
        'btnNuevaActividad
        '
        Me.btnNuevaActividad.BackColor = System.Drawing.Color.Navy
        Me.btnNuevaActividad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNuevaActividad.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaActividad.ForeColor = System.Drawing.Color.White
        Me.btnNuevaActividad.Location = New System.Drawing.Point(1248, 85)
        Me.btnNuevaActividad.Name = "btnNuevaActividad"
        Me.btnNuevaActividad.Size = New System.Drawing.Size(197, 62)
        Me.btnNuevaActividad.TabIndex = 1
        Me.btnNuevaActividad.Text = "NUEVA ACTIVIDAD"
        Me.btnNuevaActividad.UseVisualStyleBackColor = False
        '
        'btnGestionarActividad
        '
        Me.btnGestionarActividad.BackColor = System.Drawing.Color.Navy
        Me.btnGestionarActividad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGestionarActividad.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionarActividad.ForeColor = System.Drawing.Color.White
        Me.btnGestionarActividad.Location = New System.Drawing.Point(1248, 302)
        Me.btnGestionarActividad.Name = "btnGestionarActividad"
        Me.btnGestionarActividad.Size = New System.Drawing.Size(197, 62)
        Me.btnGestionarActividad.TabIndex = 3
        Me.btnGestionarActividad.Text = "GESTIONAR ACTIVIDAD"
        Me.btnGestionarActividad.UseVisualStyleBackColor = False
        '
        'btnArchivarActividad
        '
        Me.btnArchivarActividad.BackColor = System.Drawing.Color.Navy
        Me.btnArchivarActividad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnArchivarActividad.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchivarActividad.ForeColor = System.Drawing.Color.White
        Me.btnArchivarActividad.Location = New System.Drawing.Point(1248, 222)
        Me.btnArchivarActividad.Name = "btnArchivarActividad"
        Me.btnArchivarActividad.Size = New System.Drawing.Size(197, 62)
        Me.btnArchivarActividad.TabIndex = 2
        Me.btnArchivarActividad.Text = "ARCHIVAR ACTIVIDAD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnArchivarActividad.UseVisualStyleBackColor = False
        '
        'btnMasInformacion
        '
        Me.btnMasInformacion.BackColor = System.Drawing.Color.Navy
        Me.btnMasInformacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMasInformacion.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasInformacion.ForeColor = System.Drawing.Color.White
        Me.btnMasInformacion.Location = New System.Drawing.Point(1248, 432)
        Me.btnMasInformacion.Name = "btnMasInformacion"
        Me.btnMasInformacion.Size = New System.Drawing.Size(197, 50)
        Me.btnMasInformacion.TabIndex = 4
        Me.btnMasInformacion.Text = "MÁS INFORMACIÓN"
        Me.btnMasInformacion.UseVisualStyleBackColor = False
        '
        'btnSalirMenuActividades
        '
        Me.btnSalirMenuActividades.BackColor = System.Drawing.Color.Navy
        Me.btnSalirMenuActividades.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalirMenuActividades.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirMenuActividades.ForeColor = System.Drawing.Color.White
        Me.btnSalirMenuActividades.Location = New System.Drawing.Point(1248, 498)
        Me.btnSalirMenuActividades.Name = "btnSalirMenuActividades"
        Me.btnSalirMenuActividades.Size = New System.Drawing.Size(197, 39)
        Me.btnSalirMenuActividades.TabIndex = 5
        Me.btnSalirMenuActividades.Text = "SALIR"
        Me.btnSalirMenuActividades.UseVisualStyleBackColor = False
        '
        'dvgMenuActividades
        '
        Me.dvgMenuActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgMenuActividades.Location = New System.Drawing.Point(60, 87)
        Me.dvgMenuActividades.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dvgMenuActividades.Name = "dvgMenuActividades"
        Me.dvgMenuActividades.RowHeadersWidth = 62
        Me.dvgMenuActividades.RowTemplate.Height = 28
        Me.dvgMenuActividades.Size = New System.Drawing.Size(1154, 450)
        Me.dvgMenuActividades.TabIndex = 6
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1495, 585)
        Me.Controls.Add(Me.dvgMenuActividades)
        Me.Controls.Add(Me.btnSalirMenuActividades)
        Me.Controls.Add(Me.btnMasInformacion)
        Me.Controls.Add(Me.btnArchivarActividad)
        Me.Controls.Add(Me.btnGestionarActividad)
        Me.Controls.Add(Me.btnNuevaActividad)
        Me.Controls.Add(Me.lblActividades)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPrincipal"
        Me.Text = "Aplicacion Voluntariado"
        CType(Me.dvgMenuActividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblActividades As Label
    Friend WithEvents btnNuevaActividad As Button
    Friend WithEvents btnGestionarActividad As Button
    Friend WithEvents btnArchivarActividad As Button
    Friend WithEvents btnMasInformacion As Button
    Friend WithEvents btnSalirMenuActividades As Button
    Friend WithEvents dvgMenuActividades As DataGridView
End Class
