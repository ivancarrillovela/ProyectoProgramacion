<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaOds
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listaOds))
        Me.dvgODSNo = New System.Windows.Forms.DataGridView()
        Me.btnAnadirOds = New System.Windows.Forms.Button()
        Me.btnVolverOds = New System.Windows.Forms.Button()
        CType(Me.dvgODSNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgODSNo
        '
        Me.dvgODSNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgODSNo.Location = New System.Drawing.Point(20, 38)
        Me.dvgODSNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dvgODSNo.Name = "dvgODSNo"
        Me.dvgODSNo.RowHeadersWidth = 51
        Me.dvgODSNo.Size = New System.Drawing.Size(633, 360)
        Me.dvgODSNo.TabIndex = 0
        '
        'btnAnadirOds
        '
        Me.btnAnadirOds.BackColor = System.Drawing.Color.Navy
        Me.btnAnadirOds.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadirOds.ForeColor = System.Drawing.Color.White
        Me.btnAnadirOds.Location = New System.Drawing.Point(20, 425)
        Me.btnAnadirOds.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAnadirOds.Name = "btnAnadirOds"
        Me.btnAnadirOds.Size = New System.Drawing.Size(208, 82)
        Me.btnAnadirOds.TabIndex = 1
        Me.btnAnadirOds.Text = "Añadir ODS"
        Me.btnAnadirOds.UseVisualStyleBackColor = False
        '
        'btnVolverOds
        '
        Me.btnVolverOds.BackColor = System.Drawing.Color.Navy
        Me.btnVolverOds.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverOds.ForeColor = System.Drawing.Color.White
        Me.btnVolverOds.Location = New System.Drawing.Point(445, 425)
        Me.btnVolverOds.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVolverOds.Name = "btnVolverOds"
        Me.btnVolverOds.Size = New System.Drawing.Size(208, 82)
        Me.btnVolverOds.TabIndex = 2
        Me.btnVolverOds.Text = "Volver"
        Me.btnVolverOds.UseVisualStyleBackColor = False
        '
        'listaOds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 562)
        Me.Controls.Add(Me.btnVolverOds)
        Me.Controls.Add(Me.btnAnadirOds)
        Me.Controls.Add(Me.dvgODSNo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "listaOds"
        Me.Text = "listaOds"
        CType(Me.dvgODSNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dvgODSNo As DataGridView
    Friend WithEvents btnAnadirOds As Button
    Friend WithEvents btnVolverOds As Button
End Class
