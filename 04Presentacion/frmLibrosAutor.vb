Imports _03Entidades
Imports _02LogicaNegocios
Public Class frmLibrosAutor
    Dim lstAutores As New List(Of AutorEN)
    Private Sub frmLibrosAutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim valida As New AutorLN
        lstAutores = valida.obtenerTodosAutores

        cboAutor.DataSource = lstAutores
        cboAutor.DisplayMember = "NombreAutor" 'Propiedad EN (Visualiza)
        cboAutor.ValueMember = "CodAutor" 'Propiedad EN (Valor Interno)
        cboAutor.Text = ""
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnVerLibros_Click(sender As Object, e As EventArgs) Handles btnVerLibros.Click
        Dim Pantalla As New frmReportes
        Dim Reporte As New rptLibrosAutor
        Dim dstDatosReporte As New DataSet
        Dim CodAutor As String = cboAutor.SelectedValue
        Dim strConsulta As String = "SELECT ISBN, TituloCompleto, Editorial, Categoria, CodAutor FROM Libros WHERE CodAutor = '" & CodAutor & "'"
        Dim adpLista As New OleDb.OleDbDataAdapter(strConsulta, miConexion)
        adpLista.Fill(dstDatosReporte, "LibrosAutor")
        Reporte.SetDataSource(dstDatosReporte)
        Pantalla.crvVisorReportes.ReportSource = Reporte
        Pantalla.Text = “Listado de Libros de un Autor”
        Pantalla.ShowDialog()
    End Sub
End Class