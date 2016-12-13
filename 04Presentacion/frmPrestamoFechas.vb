Public Class frmPrestamoFechas
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Pantalla As New frmReportes
        Dim Reporte As New rptPrestamosFechas
        Dim dstDatosReporte As New DataSet
        Dim FecInicio As Date = dtpFecInicio.Text
        Dim FecFinal As Date = dtpFecFinal.Text

        Dim strConsulta As String = "SELECT CodPrestamo, Cedula, ISBN, Monto, FecPrestamo, FecDevolucion, IndDevuelto, Observaciones, LoginUsuario FROM Prestamos WHERE (((Prestamos.FecPrestamo)>=[FecInicio] And (Prestamos.FecPrestamo)<=[FecFinal]))"
        Dim adpLista As New OleDb.OleDbDataAdapter(strConsulta, miConexion)
        adpLista.Fill(dstDatosReporte, "PrestamosFechas")
        Reporte.SetDataSource(dstDatosReporte)
        Reporte.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        Pantalla.crvVisorReportes.ReportSource = Reporte
        Pantalla.Text = “Listado de Prestamos por Fecha”
        Pantalla.ShowDialog()
    End Sub
End Class