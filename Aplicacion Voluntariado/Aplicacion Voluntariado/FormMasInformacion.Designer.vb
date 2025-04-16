<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasInformacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasInformacion))
        Me.dvgMasInformacion = New System.Windows.Forms.DataGridView()
        Me.lblActividades = New System.Windows.Forms.Label()
        Me.cboNombeCicloMI = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMasInformacion = New System.Windows.Forms.Button()
        Me.cboOdsMI = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVolverNA = New System.Windows.Forms.Button()
        CType(Me.dvgMasInformacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgMasInformacion
        '
        Me.dvgMasInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgMasInformacion.Location = New System.Drawing.Point(39, 251)
        Me.dvgMasInformacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dvgMasInformacion.Name = "dvgMasInformacion"
        Me.dvgMasInformacion.RowHeadersWidth = 62
        Me.dvgMasInformacion.RowTemplate.Height = 28
        Me.dvgMasInformacion.Size = New System.Drawing.Size(1153, 300)
        Me.dvgMasInformacion.TabIndex = 7
        '
        'lblActividades
        '
        Me.lblActividades.AutoSize = True
        Me.lblActividades.BackColor = System.Drawing.Color.Transparent
        Me.lblActividades.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActividades.ForeColor = System.Drawing.Color.Navy
        Me.lblActividades.Location = New System.Drawing.Point(306, 22)
        Me.lblActividades.Name = "lblActividades"
        Me.lblActividades.Size = New System.Drawing.Size(584, 36)
        Me.lblActividades.TabIndex = 8
        Me.lblActividades.Text = "MÁS INFORMACIÓN SOBRE ACTIVIDADES"
        '
        'cboNombeCicloMI
        '
        Me.cboNombeCicloMI.FormattingEnabled = True
        Me.cboNombeCicloMI.Location = New System.Drawing.Point(221, 113)
        Me.cboNombeCicloMI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboNombeCicloMI.Name = "cboNombeCicloMI"
        Me.cboNombeCicloMI.Size = New System.Drawing.Size(196, 24)
        Me.cboNombeCicloMI.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nombre Ciclo:"
        '
        'btnMasInformacion
        '
        Me.btnMasInformacion.BackColor = System.Drawing.Color.Navy
        Me.btnMasInformacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMasInformacion.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasInformacion.ForeColor = System.Drawing.Color.White
        Me.btnMasInformacion.Location = New System.Drawing.Point(961, 180)
        Me.btnMasInformacion.Name = "btnMasInformacion"
        Me.btnMasInformacion.Size = New System.Drawing.Size(231, 66)
        Me.btnMasInformacion.TabIndex = 11
        Me.btnMasInformacion.Text = "BUSCAR ACTIVIDADES"
        Me.btnMasInformacion.UseVisualStyleBackColor = False
        '
        'cboOdsMI
        '
        Me.cboOdsMI.FormattingEnabled = True
        Me.cboOdsMI.Location = New System.Drawing.Point(221, 169)
        Me.cboOdsMI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboOdsMI.Name = "cboOdsMI"
        Me.cboOdsMI.Size = New System.Drawing.Size(196, 24)
        Me.cboOdsMI.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ODS:"
        '
        'btnVolverNA
        '
        Me.btnVolverNA.BackColor = System.Drawing.Color.Navy
        Me.btnVolverNA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVolverNA.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverNA.ForeColor = System.Drawing.Color.White
        Me.btnVolverNA.Location = New System.Drawing.Point(39, 567)
        Me.btnVolverNA.Name = "btnVolverNA"
        Me.btnVolverNA.Size = New System.Drawing.Size(197, 39)
        Me.btnVolverNA.TabIndex = 14
        Me.btnVolverNA.Text = "VOLVER"
        Me.btnVolverNA.UseVisualStyleBackColor = False
        '
        'FormMasInformacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 618)
        Me.Controls.Add(Me.btnVolverNA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboOdsMI)
        Me.Controls.Add(Me.btnMasInformacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboNombeCicloMI)
        Me.Controls.Add(Me.lblActividades)
        Me.Controls.Add(Me.dvgMasInformacion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormMasInformacion"
        Me.Text = "Form1"
        CType(Me.dvgMasInformacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dvgMasInformacion As DataGridView
    Friend WithEvents lblActividades As Label
    Friend WithEvents cboNombeCicloMI As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMasInformacion As Button
    Friend WithEvents cboOdsMI As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVolverNA As Button
End Class
