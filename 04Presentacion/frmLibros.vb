﻿Imports _03Entidades
Imports _02LogicaNegocios
Imports System.Globalization
Public Class frmLibros

    Dim lstAutores As New List(Of AutorEN)
    Private Sub frmLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each objCultureInfo As CultureInfo In CultureInfo.GetCultures(System.Globalization.CultureTypes.SpecificCultures)
            Dim objRegionInfo As New RegionInfo(objCultureInfo.Name)
            If Not cboPais.Items.Contains(objRegionInfo.DisplayName) Then
                cboPais.Items.Add(objRegionInfo.DisplayName)
            End If
        Next
        cboPais.Sorted = True


        Dim valida As New AutorLN
        lstAutores = valida.obtenerTodosAutores

        cboAutor.DataSource = lstAutores
        cboAutor.DisplayMember = "NombreAutor" 'Propiedad EN (Visualiza)
        cboAutor.ValueMember = "CodAutor" 'Propiedad EN (Valor Interno)
        cboAutor.Text = ""



    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click

        Try
            Dim miLib As New LibroEN()
            miLib.ISBN = txtISBN.Text
            miLib.TituloCompleto = txtNombre.Text
            miLib.Editorial = txtEditorial.Text
            miLib.Categoria = txtCategoria.Text
            miLib.FecPublicacion = dtpFecPublicacion.Text
            miLib.Pais = cboPais.Text
            miLib.Descripcion = txtDescripcion.Text
            miLib.CodAutor = cboAutor.SelectedValue

            Dim valida As New LibroLN
            valida.InsertarLibro(miLib)
            MessageBox.Show("El Libro ha sido Creado con Exito!")

            txtISBN.Clear()
            txtEditorial.Clear()
            txtNombre.Clear()
            txtCategoria.Clear()
            dtpFecPublicacion.Value = Today
            txtDescripcion.Clear()
            cboPais.Text = ""
            cboAutor.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        txtISBN.Clear()
        txtEditorial.Clear()
        txtNombre.Clear()
        txtCategoria.Clear()
        dtpFecPublicacion.Value = Today
        txtDescripcion.Clear()
        cboPais.Text = ""
        cboAutor.Text = ""
        btnInsertar.Enabled = False

        Try
            Dim strISBN As String
            strISBN = InputBox("Digite el ISBN del Libro a buscar")

            Dim miLib As LibroEN = Nothing

            Dim valida As New LibroLN
            miLib = valida.ObtenerLibroPorISBN(strISBN)

            If Not IsNothing(miLib) Then
                txtISBN.Text = miLib.ISBN
                txtNombre.Text = miLib.TituloCompleto
                txtEditorial.Text = miLib.Editorial
                txtCategoria.Text = miLib.Categoria
                dtpFecPublicacion.Text = miLib.FecPublicacion
                cboPais.Text = miLib.Pais
                txtCategoria.Text = miLib.Categoria
                txtDescripcion.Text = miLib.Descripcion
                For Each item As AutorEN In lstAutores
                    If (miLib.CodAutor = item.CodAutor) Then
                        cboAutor.Text = item.NombreAutor
                        Exit For
                    End If
                Next

                btnModificar.Enabled = True
                btnBorrar.Enabled = True
            Else
                MessageBox.Show("No existe")
                btnInsertar.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim miLib As New LibroEN()
            miLib.ISBN = txtISBN.Text
            miLib.TituloCompleto = txtNombre.Text
            miLib.Editorial = txtEditorial.Text
            miLib.Categoria = txtCategoria.Text
            miLib.FecPublicacion = dtpFecPublicacion.Text
            miLib.Pais = cboPais.Text
            miLib.Descripcion = txtDescripcion.Text
            miLib.CodAutor = cboAutor.SelectedValue

            Dim valida As New LibroLN
            valida.ModificarLibro(miLib)
            MessageBox.Show("El Libro ha sido Modificado con Exito!")

            txtISBN.Clear()
            txtEditorial.Clear()
            txtNombre.Clear()
            txtCategoria.Clear()
            dtpFecPublicacion.Value = Today
            txtDescripcion.Clear()
            cboPais.Text = ""
            cboAutor.Text = ""


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnInsertar.Enabled = True
        btnModificar.Enabled = False
        btnBorrar.Enabled = False
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        Try
            Dim miLib As New LibroEN()
            miLib.ISBN = txtISBN.Text
            miLib.TituloCompleto = txtNombre.Text
            miLib.Editorial = txtEditorial.Text
            miLib.Categoria = txtCategoria.Text
            miLib.FecPublicacion = dtpFecPublicacion.Text
            miLib.Pais = cboPais.Text
            miLib.Descripcion = txtDescripcion.Text
            miLib.CodAutor = cboAutor.SelectedValue

            Dim valida As New LibroLN

            Dim intOption As Integer
            intOption = MessageBox.Show("Realmente Desea Eliminar el Libro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If intOption = 6 Then
                valida.BorrarLibro(miLib)
                txtISBN.Clear()
                txtEditorial.Clear()
                txtNombre.Clear()
                txtCategoria.Clear()
                dtpFecPublicacion.Value = Today
                txtDescripcion.Clear()
                cboPais.Text = ""
                cboAutor.Text = ""

                MessageBox.Show("El Libro ha sido Eliminado con Exito!")
                btnInsertar.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnModificar.Enabled = False
        btnBorrar.Enabled = False
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        txtISBN.Clear()
        txtEditorial.Clear()
        txtNombre.Clear()
        txtCategoria.Clear()
        dtpFecPublicacion.Value = Today
        txtDescripcion.Clear()
        cboPais.Text = ""
        cboAutor.Text = ""


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnModificar.Enabled = False
        btnBorrar.Enabled = False
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim Pantalla As New frmReportes
        Dim Reporte As New rptListaLibros
        Dim dstDatosReporte As New DataSet
        Dim strConsulta As String = "SELECT ISBN, TituloCompleto, Editorial, Categoria, FecPublicacion, Pais, Descripcion, CodAutor FROM Libros"
        Dim adpLista As New OleDb.OleDbDataAdapter(strConsulta, miConexion)
        adpLista.Fill(dstDatosReporte, "ListaLibros")
        Reporte.SetDataSource(dstDatosReporte)
        Reporte.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        Pantalla.crvVisorReportes.ReportSource = Reporte
        Pantalla.Text = “Listado de Libros”
        Pantalla.ShowDialog()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class