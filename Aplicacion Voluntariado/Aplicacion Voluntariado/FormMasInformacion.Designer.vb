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
        Me.btnFiltrarActividadesMI = New System.Windows.Forms.Button()
        Me.cboOdsMI = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVolverMI = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCursoMI = New System.Windows.Forms.ComboBox()
        CType(Me.dvgMasInformacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgMasInformacion
        '
        Me.dvgMasInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgMasInformacion.Location = New System.Drawing.Point(44, 207)
        Me.dvgMasInformacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dvgMasInformacion.Name = "dvgMasInformacion"
        Me.dvgMasInformacion.RowHeadersWidth = 62
        Me.dvgMasInformacion.RowTemplate.Height = 28
        Me.dvgMasInformacion.Size = New System.Drawing.Size(1297, 481)
        Me.dvgMasInformacion.TabIndex = 7
        '
        'lblActividades
        '
        Me.lblActividades.AutoSize = True
        Me.lblActividades.BackColor = System.Drawing.Color.Transparent
        Me.lblActividades.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActividades.ForeColor = System.Drawing.Color.Navy
        Me.lblActividades.Location = New System.Drawing.Point(344, 43)
        Me.lblActividades.Name = "lblActividades"
        Me.lblActividades.Size = New System.Drawing.Size(702, 42)
        Me.lblActividades.TabIndex = 8
        Me.lblActividades.Text = "MÁS INFORMACIÓN SOBRE ACTIVIDADES"
        '
        'cboNombeCicloMI
        '
        Me.cboNombeCicloMI.FormattingEnabled = True
        Me.cboNombeCicloMI.Location = New System.Drawing.Point(153, 153)
        Me.cboNombeCicloMI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboNombeCicloMI.Name = "cboNombeCicloMI"
        Me.cboNombeCicloMI.Size = New System.Drawing.Size(323, 28)
        Me.cboNombeCicloMI.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nombre Ciclo:"
        '
        'btnFiltrarActividadesMI
        '
        Me.btnFiltrarActividadesMI.BackColor = System.Drawing.Color.Navy
        Me.btnFiltrarActividadesMI.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFiltrarActividadesMI.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrarActividadesMI.ForeColor = System.Drawing.Color.White
        Me.btnFiltrarActividadesMI.Location = New System.Drawing.Point(1121, 127)
        Me.btnFiltrarActividadesMI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFiltrarActividadesMI.Name = "btnFiltrarActividadesMI"
        Me.btnFiltrarActividadesMI.Size = New System.Drawing.Size(220, 54)
        Me.btnFiltrarActividadesMI.TabIndex = 11
        Me.btnFiltrarActividadesMI.Text = "FILTRAR ACTIVIDADES"
        Me.btnFiltrarActividadesMI.UseVisualStyleBackColor = False
        '
        'cboOdsMI
        '
        Me.cboOdsMI.FormattingEnabled = True
        Me.cboOdsMI.Location = New System.Drawing.Point(868, 153)
        Me.cboOdsMI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboOdsMI.Name = "cboOdsMI"
        Me.cboOdsMI.Size = New System.Drawing.Size(220, 28)
        Me.cboOdsMI.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(813, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ODS:"
        '
        'btnVolverMI
        '
        Me.btnVolverMI.BackColor = System.Drawing.Color.Navy
        Me.btnVolverMI.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVolverMI.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMI.ForeColor = System.Drawing.Color.White
        Me.btnVolverMI.Location = New System.Drawing.Point(44, 707)
        Me.btnVolverMI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVolverMI.Name = "btnVolverMI"
        Me.btnVolverMI.Size = New System.Drawing.Size(222, 51)
        Me.btnVolverMI.TabIndex = 14
        Me.btnVolverMI.Text = "VOLVER"
        Me.btnVolverMI.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(501, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Curso:"
        '
        'cboCursoMI
        '
        Me.cboCursoMI.FormattingEnabled = True
        Me.cboCursoMI.Location = New System.Drawing.Point(562, 153)
        Me.cboCursoMI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboCursoMI.Name = "cboCursoMI"
        Me.cboCursoMI.Size = New System.Drawing.Size(220, 28)
        Me.cboCursoMI.TabIndex = 16
        '
        'FormMasInformacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 783)
        Me.Controls.Add(Me.cboCursoMI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnVolverMI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboOdsMI)
        Me.Controls.Add(Me.btnFiltrarActividadesMI)
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
    Friend WithEvents btnFiltrarActividadesMI As Button
    Friend WithEvents cboOdsMI As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVolverMI As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cboCursoMI As ComboBox
End Class
