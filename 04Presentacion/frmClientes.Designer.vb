<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFecRegistro = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtDireccionExacta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(365, 378)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(113, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiarCampos
        '
        Me.btnLimpiarCampos.Location = New System.Drawing.Point(215, 378)
        Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
        Me.btnLimpiarCampos.Size = New System.Drawing.Size(112, 23)
        Me.btnLimpiarCampos.TabIndex = 4
        Me.btnLimpiarCampos.Text = "&Limpiar Campos"
        Me.btnLimpiarCampos.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(403, 326)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 3
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(288, 326)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(164, 326)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(40, 326)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertar.TabIndex = 0
        Me.btnInsertar.Text = "&Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpFecRegistro)
        Me.GroupBox1.Controls.Add(Me.dtpFecNacimiento)
        Me.GroupBox1.Controls.Add(Me.txtDireccionExacta)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(9)
        Me.GroupBox1.Size = New System.Drawing.Size(469, 278)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(24, 58)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(9)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(103, 20)
        Me.txtCedula.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 36)
        Me.Label6.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Cedula"
        '
        'dtpFecRegistro
        '
        Me.dtpFecRegistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecRegistro.Location = New System.Drawing.Point(26, 242)
        Me.dtpFecRegistro.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.dtpFecRegistro.Name = "dtpFecRegistro"
        Me.dtpFecRegistro.Size = New System.Drawing.Size(116, 20)
        Me.dtpFecRegistro.TabIndex = 5
        '
        'dtpFecNacimiento
        '
        Me.dtpFecNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecNacimiento.Location = New System.Drawing.Point(26, 114)
        Me.dtpFecNacimiento.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.dtpFecNacimiento.Name = "dtpFecNacimiento"
        Me.dtpFecNacimiento.Size = New System.Drawing.Size(116, 20)
        Me.dtpFecNacimiento.TabIndex = 2
        '
        'txtDireccionExacta
        '
        Me.txtDireccionExacta.Location = New System.Drawing.Point(26, 177)
        Me.txtDireccionExacta.Margin = New System.Windows.Forms.Padding(9)
        Me.txtDireccionExacta.Name = "txtDireccionExacta"
        Me.txtDireccionExacta.Size = New System.Drawing.Size(428, 20)
        Me.txtDireccionExacta.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 152)
        Me.Label5.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Dirección Exacta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 219)
        Me.Label3.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Fecha de Registro"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(175, 58)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(9)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(275, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(172, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre Completo"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(175, 114)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(9)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(103, 20)
        Me.txtTelefono.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha de Nacimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 381)
        Me.Label7.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Imprimir Registros"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global._04Presentacion.My.Resources.Resources.printer2
        Me.btnImprimir.Location = New System.Drawing.Point(127, 370)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(44, 39)
        Me.btnImprimir.TabIndex = 39
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmClientes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(509, 421)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiarCampos)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmClientes"
        Me.Text = "Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiarCampos As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpFecRegistro As DateTimePicker
    Friend WithEvents dtpFecNacimiento As DateTimePicker
    Friend WithEvents txtDireccionExacta As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnImprimir As Button
End Class
