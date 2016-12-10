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

        If user.IndBibliotecario Then
            mnuPrestamosFechas.Enabled = False
            mnuUsuarios.Enabled = False

        End If

    End Sub

    Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuLibrosXAutor.Click

        'Se crea una instancia de la pantalla que muestra reportes
        Dim Pantalla As New frmReportes

        'Se crea una instancia del reporte que deseamos mostrar
        Dim Reporte As New rptListaEmpleados

        'Se crea una instancia del dataset para contener los datos del reporte
        Dim dstDatosReporte As New DataSet

        'La consulta para obtener los datos: Cedula y Nombre_Completo que serían campos de una posible tabla llamada CLIENTE
        Dim strConsulta As String = "SELECT Login, Clave, NombreCompleto, indAdministrador, indBibliotecario, indActivo FROM USUARIOS"

        'Se prepara el adaptador para indicarle cual consulta tiene que realizar y la base de datos donde la va a realizar.
        Dim adpLista As New OleDb.OleDbDataAdapter(strConsulta, miConexion)

        adpLista.Fill(dstDatosReporte, "ListaEmpleados")  'ListaClientes corresponde al nombre de la tabla que se dibujó en el dataset con la cual se realizó el reporte. En caso de no ser nombrado igual, los datos NO SE DESPLEGARAN.

        'Se le asignan los datos a mostrar al reporte
        Reporte.SetDataSource(dstDatosReporte)

        'La pantalla que muestra reportes debe contener el control llamado crvReporte. Que es un control de tipo CrystalReportViewr el cual se encarga de mostrar o contener realmente que se desea visualizar
        Pantalla.crvVisorReporte.ReportSource = Reporte
        Pantalla.Text = “Listado de Empleados”
        Pantalla.ShowDialog()

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

    Private Sub mnuCientes_Click(sender As Object, e As EventArgs) Handles mnuCientes.Click
        Dim Pantalla As New frmClientes
        Pantalla.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim Pantalla As New frmClientes
        Pantalla.Show()
    End Sub
End Class