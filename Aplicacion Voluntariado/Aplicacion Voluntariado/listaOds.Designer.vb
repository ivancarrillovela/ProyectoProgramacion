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
        CType(Me.dvgODSNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgODSNo
        '
        Me.dvgODSNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgODSNo.Location = New System.Drawing.Point(18, 30)
        Me.dvgODSNo.Name = "dvgODSNo"
        Me.dvgODSNo.RowHeadersWidth = 51
        Me.dvgODSNo.Size = New System.Drawing.Size(563, 288)
        Me.dvgODSNo.TabIndex = 0
        '
        'btnAnadirOds
        '
        Me.btnAnadirOds.BackColor = System.Drawing.Color.Navy
        Me.btnAnadirOds.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadirOds.ForeColor = System.Drawing.Color.White
        Me.btnAnadirOds.Location = New System.Drawing.Point(201, 337)
        Me.btnAnadirOds.Name = "btnAnadirOds"
        Me.btnAnadirOds.Size = New System.Drawing.Size(185, 66)
        Me.btnAnadirOds.TabIndex = 1
        Me.btnAnadirOds.Text = "Añadir ODS"
        Me.btnAnadirOds.UseVisualStyleBackColor = False
        '
        'listaOds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 450)
        Me.Controls.Add(Me.btnAnadirOds)
        Me.Controls.Add(Me.dvgODSNo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "listaOds"
        Me.Text = "listaOds"
        CType(Me.dvgODSNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dvgODSNo As DataGridView
    Friend WithEvents btnAnadirOds As Button
End Class
