<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibrosAutor
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboAutor = New System.Windows.Forms.ComboBox()
        Me.btnVerLibros = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboAutor)
        Me.GroupBox1.Controls.Add(Me.btnVerLibros)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 162)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione el Autor"
        '
        'cboAutor
        '
        Me.cboAutor.FormattingEnabled = True
        Me.cboAutor.Location = New System.Drawing.Point(22, 48)
        Me.cboAutor.Name = "cboAutor"
        Me.cboAutor.Size = New System.Drawing.Size(228, 21)
        Me.cboAutor.TabIndex = 16
        '
        'btnVerLibros
        '
        Me.btnVerLibros.Location = New System.Drawing.Point(78, 95)
        Me.btnVerLibros.Name = "btnVerLibros"
        Me.btnVerLibros.Size = New System.Drawing.Size(116, 33)
        Me.btnVerLibros.TabIndex = 15
        Me.btnVerLibros.Text = "&VerLibros"
        Me.btnVerLibros.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(167, 204)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(113, 30)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmLibrosAutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 246)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLibrosAutor"
        Me.Text = "Libros por Autor"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboAutor As ComboBox
    Friend WithEvents btnVerLibros As Button
    Friend WithEvents btnSalir As Button
End Class
