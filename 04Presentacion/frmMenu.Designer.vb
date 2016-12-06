<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuCatalogDatos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutores = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLibros = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcesos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPréstamo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDevolucion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrestamosFechas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLibrosXAutor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnPrestamo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnDevolucion = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnLibros = New System.Windows.Forms.ToolStripButton()
        Me.mnuUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnUsuarios = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCatalogDatos, Me.mnuProcesos, Me.mnuReportes, Me.mnuAcercaDe, Me.mnuSalir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(551, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuCatalogDatos
        '
        Me.mnuCatalogDatos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAutores, Me.mnuCientes, Me.mnuLibros, Me.mnuUsuarios})
        Me.mnuCatalogDatos.Name = "mnuCatalogDatos"
        Me.mnuCatalogDatos.Size = New System.Drawing.Size(100, 20)
        Me.mnuCatalogDatos.Text = "Catalogo Datos"
        '
        'mnuAutores
        '
        Me.mnuAutores.Name = "mnuAutores"
        Me.mnuAutores.Size = New System.Drawing.Size(152, 22)
        Me.mnuAutores.Text = "Autores"
        '
        'mnuCientes
        '
        Me.mnuCientes.Name = "mnuCientes"
        Me.mnuCientes.Size = New System.Drawing.Size(152, 22)
        Me.mnuCientes.Text = "Clientes"
        '
        'mnuLibros
        '
        Me.mnuLibros.Name = "mnuLibros"
        Me.mnuLibros.Size = New System.Drawing.Size(152, 22)
        Me.mnuLibros.Text = "Libros"
        '
        'mnuProcesos
        '
        Me.mnuProcesos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPréstamo, Me.mnuDevolucion})
        Me.mnuProcesos.Name = "mnuProcesos"
        Me.mnuProcesos.Size = New System.Drawing.Size(66, 20)
        Me.mnuProcesos.Text = "Procesos"
        '
        'mnuPréstamo
        '
        Me.mnuPréstamo.Name = "mnuPréstamo"
        Me.mnuPréstamo.Size = New System.Drawing.Size(152, 22)
        Me.mnuPréstamo.Text = "Préstamo"
        '
        'mnuDevolucion
        '
        Me.mnuDevolucion.Name = "mnuDevolucion"
        Me.mnuDevolucion.Size = New System.Drawing.Size(152, 22)
        Me.mnuDevolucion.Text = "Devolución"
        '
        'mnuReportes
        '
        Me.mnuReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrestamosFechas, Me.mnuLibrosXAutor})
        Me.mnuReportes.Name = "mnuReportes"
        Me.mnuReportes.Size = New System.Drawing.Size(65, 20)
        Me.mnuReportes.Text = "Reportes"
        '
        'mnuPrestamosFechas
        '
        Me.mnuPrestamosFechas.Name = "mnuPrestamosFechas"
        Me.mnuPrestamosFechas.Size = New System.Drawing.Size(198, 22)
        Me.mnuPrestamosFechas.Text = "Préstamos entre Fechas"
        '
        'mnuLibrosXAutor
        '
        Me.mnuLibrosXAutor.Name = "mnuLibrosXAutor"
        Me.mnuLibrosXAutor.Size = New System.Drawing.Size(198, 22)
        Me.mnuLibrosXAutor.Text = "Libros de un Autor"
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(41, 20)
        Me.mnuSalir.Text = "Salir"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.sslblFecha})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 380)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(551, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(178, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(178, 17)
        Me.ToolStripStatusLabel2.Spring = True
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'sslblFecha
        '
        Me.sslblFecha.Name = "sslblFecha"
        Me.sslblFecha.Size = New System.Drawing.Size(178, 17)
        Me.sslblFecha.Spring = True
        Me.sslblFecha.Text = "ToolStripStatusLabel3"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnLibros, Me.ToolStripSeparator3, Me.tsbtnDevolucion, Me.tsbtnPrestamo, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.tsbtnUsuarios, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(551, 38)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnPrestamo
        '
        Me.tsbtnPrestamo.Image = CType(resources.GetObject("tsbtnPrestamo.Image"), System.Drawing.Image)
        Me.tsbtnPrestamo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnPrestamo.Name = "tsbtnPrestamo"
        Me.tsbtnPrestamo.Size = New System.Drawing.Size(61, 35)
        Me.tsbtnPrestamo.Text = "Préstamo"
        Me.tsbtnPrestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'tsbtnDevolucion
        '
        Me.tsbtnDevolucion.Image = CType(resources.GetObject("tsbtnDevolucion.Image"), System.Drawing.Image)
        Me.tsbtnDevolucion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDevolucion.Name = "tsbtnDevolucion"
        Me.tsbtnDevolucion.Size = New System.Drawing.Size(71, 35)
        Me.tsbtnDevolucion.Text = "Devolución"
        Me.tsbtnDevolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'tsbtnLibros
        '
        Me.tsbtnLibros.Image = CType(resources.GetObject("tsbtnLibros.Image"), System.Drawing.Image)
        Me.tsbtnLibros.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnLibros.Name = "tsbtnLibros"
        Me.tsbtnLibros.Size = New System.Drawing.Size(43, 35)
        Me.tsbtnLibros.Text = "Libros"
        Me.tsbtnLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnuUsuarios
        '
        Me.mnuUsuarios.Name = "mnuUsuarios"
        Me.mnuUsuarios.Size = New System.Drawing.Size(152, 22)
        Me.mnuUsuarios.Text = "Usuarios"
        '
        'mnuAcercaDe
        '
        Me.mnuAcercaDe.Name = "mnuAcercaDe"
        Me.mnuAcercaDe.Size = New System.Drawing.Size(80, 20)
        Me.mnuAcercaDe.Text = "Acerca de..."
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(53, 35)
        Me.ToolStripButton1.Text = "Clientes"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 38)
        '
        'tsbtnUsuarios
        '
        Me.tsbtnUsuarios.Image = CType(resources.GetObject("tsbtnUsuarios.Image"), System.Drawing.Image)
        Me.tsbtnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUsuarios.Name = "tsbtnUsuarios"
        Me.tsbtnUsuarios.Size = New System.Drawing.Size(56, 35)
        Me.tsbtnUsuarios.Text = "Usuarios"
        Me.tsbtnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 402)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuCatalogDatos As ToolStripMenuItem
    Friend WithEvents mnuAutores As ToolStripMenuItem
    Friend WithEvents mnuCientes As ToolStripMenuItem
    Friend WithEvents mnuLibros As ToolStripMenuItem
    Friend WithEvents mnuProcesos As ToolStripMenuItem
    Friend WithEvents mnuPréstamo As ToolStripMenuItem
    Friend WithEvents mnuDevolucion As ToolStripMenuItem
    Friend WithEvents mnuSalir As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbtnPrestamo As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbtnDevolucion As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbtnLibros As ToolStripButton
    Friend WithEvents mnuReportes As ToolStripMenuItem
    Friend WithEvents mnuPrestamosFechas As ToolStripMenuItem
    Friend WithEvents mnuLibrosXAutor As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents sslblFecha As ToolStripStatusLabel
    Friend WithEvents mnuUsuarios As ToolStripMenuItem
    Friend WithEvents mnuAcercaDe As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbtnUsuarios As ToolStripButton
End Class
