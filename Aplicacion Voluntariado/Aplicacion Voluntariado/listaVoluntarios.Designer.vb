﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaVoluntarios
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
        Me.dgvVoluntariosNo = New System.Windows.Forms.DataGridView()
        Me.btnAnadirVoluntario = New System.Windows.Forms.Button()
        CType(Me.dgvVoluntariosNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvVoluntariosNo
        '
        Me.dgvVoluntariosNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVoluntariosNo.Location = New System.Drawing.Point(34, 48)
        Me.dgvVoluntariosNo.Name = "dgvVoluntariosNo"
        Me.dgvVoluntariosNo.RowHeadersWidth = 51
        Me.dgvVoluntariosNo.Size = New System.Drawing.Size(563, 288)
        Me.dgvVoluntariosNo.TabIndex = 1
        '
        'btnAnadirVoluntario
        '
        Me.btnAnadirVoluntario.BackColor = System.Drawing.Color.Navy
        Me.btnAnadirVoluntario.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadirVoluntario.ForeColor = System.Drawing.Color.White
        Me.btnAnadirVoluntario.Location = New System.Drawing.Point(224, 353)
        Me.btnAnadirVoluntario.Name = "btnAnadirVoluntario"
        Me.btnAnadirVoluntario.Size = New System.Drawing.Size(185, 66)
        Me.btnAnadirVoluntario.TabIndex = 2
        Me.btnAnadirVoluntario.Text = "Añadir voluntarios/a"
        Me.btnAnadirVoluntario.UseVisualStyleBackColor = False
        '
        'listaVoluntarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 450)
        Me.Controls.Add(Me.btnAnadirVoluntario)
        Me.Controls.Add(Me.dgvVoluntariosNo)
        Me.Name = "listaVoluntarios"
        Me.Text = "listaVoluntarios"
        CType(Me.dgvVoluntariosNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvVoluntariosNo As DataGridView
    Friend WithEvents btnAnadirVoluntario As Button
End Class
