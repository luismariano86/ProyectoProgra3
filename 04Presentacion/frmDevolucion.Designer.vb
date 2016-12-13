<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevolucion
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
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblUsuActivo = New System.Windows.Forms.Label()
        Me.cboLibros = New System.Windows.Forms.ComboBox()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtnNo = New System.Windows.Forms.RadioButton()
        Me.rbtnSi = New System.Windows.Forms.RadioButton()
        Me.dtpFecDevolucion = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboClientes = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFecPrestamo = New System.Windows.Forms.DateTimePicker()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(281, 426)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(113, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiarCampos
        '
        Me.btnLimpiarCampos.Location = New System.Drawing.Point(120, 426)
        Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
        Me.btnLimpiarCampos.Size = New System.Drawing.Size(112, 23)
        Me.btnLimpiarCampos.TabIndex = 2
        Me.btnLimpiarCampos.Text = "&Limpiar Campos"
        Me.btnLimpiarCampos.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(281, 374)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(157, 374)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.cboLibros)
        Me.GroupBox1.Controls.Add(Me.txtObservacion)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dtpFecDevolucion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboClientes)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpFecPrestamo)
        Me.GroupBox1.Controls.Add(Me.txtCodPrestamo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(9)
        Me.GroupBox1.Size = New System.Drawing.Size(465, 333)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblUsuActivo)
        Me.GroupBox3.Location = New System.Drawing.Point(278, 270)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(119, 51)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Usuario Activo"
        '
        'lblUsuActivo
        '
        Me.lblUsuActivo.AutoSize = True
        Me.lblUsuActivo.Location = New System.Drawing.Point(22, 23)
        Me.lblUsuActivo.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lblUsuActivo.Name = "lblUsuActivo"
        Me.lblUsuActivo.Size = New System.Drawing.Size(76, 13)
        Me.lblUsuActivo.TabIndex = 0
        Me.lblUsuActivo.Text = "Usuario Activo"
        '
        'cboLibros
        '
        Me.cboLibros.Enabled = False
        Me.cboLibros.FormattingEnabled = True
        Me.cboLibros.Location = New System.Drawing.Point(43, 116)
        Me.cboLibros.Name = "cboLibros"
        Me.cboLibros.Size = New System.Drawing.Size(171, 21)
        Me.cboLibros.TabIndex = 2
        '
        'txtObservacion
        '
        Me.txtObservacion.Enabled = False
        Me.txtObservacion.Location = New System.Drawing.Point(44, 228)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(217, 89)
        Me.txtObservacion.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtnNo)
        Me.GroupBox2.Controls.Add(Me.rbtnSi)
        Me.GroupBox2.Location = New System.Drawing.Point(278, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(119, 51)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Devuelto"
        '
        'rbtnNo
        '
        Me.rbtnNo.AutoSize = True
        Me.rbtnNo.Location = New System.Drawing.Point(67, 24)
        Me.rbtnNo.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.rbtnNo.Name = "rbtnNo"
        Me.rbtnNo.Size = New System.Drawing.Size(39, 17)
        Me.rbtnNo.TabIndex = 1
        Me.rbtnNo.TabStop = True
        Me.rbtnNo.Text = "No"
        Me.rbtnNo.UseVisualStyleBackColor = True
        '
        'rbtnSi
        '
        Me.rbtnSi.AutoSize = True
        Me.rbtnSi.Location = New System.Drawing.Point(21, 24)
        Me.rbtnSi.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.rbtnSi.Name = "rbtnSi"
        Me.rbtnSi.Size = New System.Drawing.Size(34, 17)
        Me.rbtnSi.TabIndex = 0
        Me.rbtnSi.TabStop = True
        Me.rbtnSi.Text = "Si"
        Me.rbtnSi.UseVisualStyleBackColor = True
        '
        'dtpFecDevolucion
        '
        Me.dtpFecDevolucion.Enabled = False
        Me.dtpFecDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDevolucion.Location = New System.Drawing.Point(278, 171)
        Me.dtpFecDevolucion.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.dtpFecDevolucion.Name = "dtpFecDevolucion"
        Me.dtpFecDevolucion.Size = New System.Drawing.Size(116, 20)
        Me.dtpFecDevolucion.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(275, 151)
        Me.Label4.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Fecha de Devolución"
        '
        'cboClientes
        '
        Me.cboClientes.Enabled = False
        Me.cboClientes.FormattingEnabled = True
        Me.cboClientes.Location = New System.Drawing.Point(278, 57)
        Me.cboClientes.Name = "cboClientes"
        Me.cboClientes.Size = New System.Drawing.Size(175, 21)
        Me.cboClientes.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(275, 38)
        Me.Label8.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 208)
        Me.Label3.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Observación"
        '
        'txtMonto
        '
        Me.txtMonto.Enabled = False
        Me.txtMonto.Location = New System.Drawing.Point(278, 116)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(9)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(119, 20)
        Me.txtMonto.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(275, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Monto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 93)
        Me.Label6.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Libro"
        '
        'dtpFecPrestamo
        '
        Me.dtpFecPrestamo.Enabled = False
        Me.dtpFecPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecPrestamo.Location = New System.Drawing.Point(43, 170)
        Me.dtpFecPrestamo.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.dtpFecPrestamo.Name = "dtpFecPrestamo"
        Me.dtpFecPrestamo.Size = New System.Drawing.Size(116, 20)
        Me.dtpFecPrestamo.TabIndex = 4
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.Enabled = False
        Me.txtCodPrestamo.Location = New System.Drawing.Point(43, 57)
        Me.txtCodPrestamo.Margin = New System.Windows.Forms.Padding(9)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(171, 20)
        Me.txtCodPrestamo.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 38)
        Me.Label5.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Codigo de Prestamo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 150)
        Me.Label2.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha de Prestamo"
        '
        'frmDevolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 472)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiarCampos)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDevolucion"
        Me.Text = "Devolucion de Libros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiarCampos As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblUsuActivo As Label
    Friend WithEvents cboLibros As ComboBox
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtnNo As RadioButton
    Friend WithEvents rbtnSi As RadioButton
    Friend WithEvents dtpFecDevolucion As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cboClientes As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpFecPrestamo As DateTimePicker
    Friend WithEvents txtCodPrestamo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
End Class
