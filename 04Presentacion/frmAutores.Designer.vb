<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutores
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiarCampos = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxNacionalidad = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodAutor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(336, 262)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(113, 23)
        Me.btnSalir.TabIndex = 36
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiarCampos
        '
        Me.btnLimpiarCampos.Location = New System.Drawing.Point(126, 262)
        Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
        Me.btnLimpiarCampos.Size = New System.Drawing.Size(112, 23)
        Me.btnLimpiarCampos.TabIndex = 35
        Me.btnLimpiarCampos.Text = "Limpiar Campos"
        Me.btnLimpiarCampos.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(451, 210)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 34
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(336, 210)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 33
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(212, 210)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 32
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(88, 210)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertar.TabIndex = 31
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxNacionalidad)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCodAutor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 43)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(9)
        Me.GroupBox1.Size = New System.Drawing.Size(504, 155)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'cbxNacionalidad
        '
        Me.cbxNacionalidad.FormattingEnabled = True
        Me.cbxNacionalidad.Location = New System.Drawing.Point(288, 102)
        Me.cbxNacionalidad.Name = "cbxNacionalidad"
        Me.cbxNacionalidad.Size = New System.Drawing.Size(121, 21)
        Me.cbxNacionalidad.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(32, 104)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(9)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(235, 20)
        Me.txtNombre.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nombre"
        '
        'txtCodAutor
        '
        Me.txtCodAutor.Location = New System.Drawing.Point(32, 53)
        Me.txtCodAutor.Margin = New System.Windows.Forms.Padding(9)
        Me.txtCodAutor.Name = "txtCodAutor"
        Me.txtCodAutor.Size = New System.Drawing.Size(103, 20)
        Me.txtCodAutor.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Codigo de Autor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nacionalidad"
        '
        'frmAutores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 322)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiarCampos)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAutores"
        Me.Text = "Autores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiarCampos As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodAutor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxNacionalidad As ComboBox
End Class
