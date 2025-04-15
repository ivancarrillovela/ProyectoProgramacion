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
        Me.dvgMasInformacion = New System.Windows.Forms.DataGridView()
        Me.lblActividades = New System.Windows.Forms.Label()
        Me.cboNombeCicloMI = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMasInformacion = New System.Windows.Forms.Button()
        Me.cboOdsMI = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dvgMasInformacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgMasInformacion
        '
        Me.dvgMasInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgMasInformacion.Location = New System.Drawing.Point(44, 356)
        Me.dvgMasInformacion.Name = "dvgMasInformacion"
        Me.dvgMasInformacion.RowHeadersWidth = 62
        Me.dvgMasInformacion.RowTemplate.Height = 28
        Me.dvgMasInformacion.Size = New System.Drawing.Size(1297, 375)
        Me.dvgMasInformacion.TabIndex = 7
        '
        'lblActividades
        '
        Me.lblActividades.AutoSize = True
        Me.lblActividades.BackColor = System.Drawing.Color.Transparent
        Me.lblActividades.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActividades.ForeColor = System.Drawing.Color.Navy
        Me.lblActividades.Location = New System.Drawing.Point(344, 28)
        Me.lblActividades.Name = "lblActividades"
        Me.lblActividades.Size = New System.Drawing.Size(702, 42)
        Me.lblActividades.TabIndex = 8
        Me.lblActividades.Text = "MÁS INFORMACIÓN SOBRE ACTIVIDADES"
        '
        'cboNombeCicloMI
        '
        Me.cboNombeCicloMI.FormattingEnabled = True
        Me.cboNombeCicloMI.Location = New System.Drawing.Point(249, 141)
        Me.cboNombeCicloMI.Name = "cboNombeCicloMI"
        Me.cboNombeCicloMI.Size = New System.Drawing.Size(220, 28)
        Me.cboNombeCicloMI.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nombre Ciclo:"
        '
        'btnMasInformacion
        '
        Me.btnMasInformacion.BackColor = System.Drawing.Color.Navy
        Me.btnMasInformacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMasInformacion.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasInformacion.ForeColor = System.Drawing.Color.White
        Me.btnMasInformacion.Location = New System.Drawing.Point(1081, 246)
        Me.btnMasInformacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMasInformacion.Name = "btnMasInformacion"
        Me.btnMasInformacion.Size = New System.Drawing.Size(260, 82)
        Me.btnMasInformacion.TabIndex = 11
        Me.btnMasInformacion.Text = "BUSCAR ACTIVIDADES"
        Me.btnMasInformacion.UseVisualStyleBackColor = False
        '
        'cboOdsMI
        '
        Me.cboOdsMI.FormattingEnabled = True
        Me.cboOdsMI.Location = New System.Drawing.Point(249, 211)
        Me.cboOdsMI.Name = "cboOdsMI"
        Me.cboOdsMI.Size = New System.Drawing.Size(220, 28)
        Me.cboOdsMI.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ODS:"
        '
        'FormMasInformacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 772)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboOdsMI)
        Me.Controls.Add(Me.btnMasInformacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboNombeCicloMI)
        Me.Controls.Add(Me.lblActividades)
        Me.Controls.Add(Me.dvgMasInformacion)
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
End Class
