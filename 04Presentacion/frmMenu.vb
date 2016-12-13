Public Class frmMenu

    'este procedimiento es el inicial y la valida el acceso al sistema.
    Public Shared Sub Main()
        Application.EnableVisualStyles()

        Dim fAcceso As New frmLogin
        If fAcceso.ShowDialog() = System.Windows.Forms.DialogResult.Yes Then
            fAcceso.Close()
            Application.Run(New frmMenu)
        End If
    End Sub


    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sslblFecha.Text = Date.Today.ToLongDateString
        Dim NivelUsuario As String
        If user.IndAdministrador = True Then
            NivelUsuario = "Administrador"
            sslblTipoUsuario.Text = "Nivel de Usuario: " & NivelUsuario
        ElseIf user.IndBibliotecario = True
            NivelUsuario = "Bibliotecario"
            mnuAcercaDe.Visible = False
            mnuAutores.Visible = False
            mnuLibros.Visible = False
            mnuReportes.Visible = False
            mnuUsuarios.Visible = False
            tsbtnAutores.Visible = False
            tsbtnLibros.Visible = False
            tsbtnUsuarios.Visible = False
            sslblTipoUsuario.Text = "Nivel de Usuario: " & NivelUsuario
        End If
        sslblUsuario.Text = "Usuario: " & user.Login
    End Sub

    Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuLibrosXAutor.Click
        Dim Pantalla As New frmLibrosAutor
        Pantalla.Show()
    End Sub

    Private Sub mnuUsuarios_Click(sender As Object, e As EventArgs) Handles mnuUsuarios.Click
        Dim Pantalla As New frmUsuario
        Pantalla.Show()
    End Sub

    Private Sub tsbtnUsuarios_Click(sender As Object, e As EventArgs) Handles tsbtnUsuarios.Click
        Dim Pantalla As New frmUsuario
        Pantalla.Show()
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Dim intOption As Integer
        intOption = MessageBox.Show("Desea Salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If intOption = 6 Then
            Application.Exit()
        ElseIf intOption = 7 Then
            MessageBox.Show("Sigue en el Sistema")
        End If
    End Sub

    Private Sub mnuAutores_Click(sender As Object, e As EventArgs) Handles mnuAutores.Click
        Dim Pantalla As New frmAutores
        Pantalla.Show()
    End Sub

    Private Sub tsbtnAutores_Click(sender As Object, e As EventArgs) Handles tsbtnAutores.Click
        Dim Pantalla As New frmAutores
        Pantalla.Show()
    End Sub

    Private Sub mnuCientes_Click(sender As Object, e As EventArgs) Handles mnuClientes.Click
        Dim Pantalla As New frmClientes
        Pantalla.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim Pantalla As New frmClientes
        Pantalla.Show()
    End Sub

    Private Sub tsbtnLibros_Click(sender As Object, e As EventArgs) Handles tsbtnLibros.Click
        Dim Pantalla As New frmLibros
        Pantalla.Show()
    End Sub

    Private Sub mnuLibros_Click(sender As Object, e As EventArgs) Handles mnuLibros.Click
        Dim Pantalla As New frmLibros
        Pantalla.Show()
    End Sub

    Private Sub mnuPréstamo_Click(sender As Object, e As EventArgs) Handles mnuPréstamo.Click
        Dim Pantalla As New frmPrestamos
        Pantalla.Show()
    End Sub

    Private Sub tsbtnPrestamo_Click(sender As Object, e As EventArgs) Handles tsbtnPrestamo.Click
        Dim Pantalla As New frmPrestamos
        Pantalla.Show()
    End Sub

    Private Sub mnuAcercaDe_Click(sender As Object, e As EventArgs) Handles mnuAcercaDe.Click
        Dim Pantalla As New frmAcercaDe
        Pantalla.Show()
    End Sub

    Private Sub tsbtnDevolucion_Click(sender As Object, e As EventArgs) Handles tsbtnDevolucion.Click
        Dim Pantalla As New frmDevolucion
        Pantalla.Show()
    End Sub

    Private Sub mnuDevolucion_Click(sender As Object, e As EventArgs) Handles mnuDevolucion.Click
        Dim Pantalla As New frmDevolucion
        Pantalla.Show()
    End Sub

    Private Sub mnuPrestamosFechas_Click(sender As Object, e As EventArgs) Handles mnuPrestamosFechas.Click
        Dim Pantalla As New frmPrestamoFechas
        Pantalla.Show()
    End Sub
End Class