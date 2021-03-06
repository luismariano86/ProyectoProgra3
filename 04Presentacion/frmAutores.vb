﻿Imports _03Entidades
Imports _02LogicaNegocios
Imports System.Globalization
Public Class frmAutores
    Private Sub frmAutores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each objCultureInfo As CultureInfo In CultureInfo.GetCultures(System.Globalization.CultureTypes.SpecificCultures)
            Dim objRegionInfo As New RegionInfo(objCultureInfo.Name)
            If Not cbxNacionalidad.Items.Contains(objRegionInfo.DisplayName) Then
                cbxNacionalidad.Items.Add(objRegionInfo.DisplayName)
            End If
        Next

        cbxNacionalidad.Sorted = True

    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs)

        Try
            Dim miAut As New AutorEN()
            miAut.CodAutor = txtCodAutor.Text
            miAut.NombreAutor = txtNombre.Text
            miAut.Nacionalidad = cbxNacionalidad.Text

            Dim valida As New AutorLN
            valida.InsertarAutor(miAut)
            MessageBox.Show("El Autor ha sido Creado con Exito!")

            txtCodAutor.Clear()
            cbxNacionalidad.Text = ""
            txtNombre.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        txtCodAutor.Clear()
        cbxNacionalidad.Text = ""
        txtNombre.Clear()
        btnInsertar.Enabled = False

        Try
            Dim strCodAutor As String
            strCodAutor = InputBox("Digite el CodAutor del Autor a buscar")

            Dim miAut As AutorEN = Nothing

            Dim valida As New AutorLN
            miAut = valida.ObtenerAutorPorCodAutor(strCodAutor)

            If Not IsNothing(miAut) Then
                txtCodAutor.Text = miAut.CodAutor
                txtNombre.Text = miAut.NombreAutor
                cbxNacionalidad.Text = miAut.Nacionalidad

                btnModificar.Enabled = True
                btnBorrar.Enabled = True
            Else
                MessageBox.Show("No existe")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs)
        Try
            Dim miAut As New AutorEN()
            miAut.CodAutor = txtCodAutor.Text
            miAut.NombreAutor = txtNombre.Text
            miAut.Nacionalidad = cbxNacionalidad.Text

            Dim valida As New AutorLN
            valida.ModificarAutor(miAut)
            MessageBox.Show("El Autor ha sido Modificado con Exito!")

            txtCodAutor.Clear()
            cbxNacionalidad.Text = ""
            txtNombre.Clear()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnInsertar.Enabled = True
        btnModificar.Enabled = False
        btnBorrar.Enabled = False
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs)

        Try
            Dim miAut As New AutorEN()
            miAut.CodAutor = txtCodAutor.Text
            miAut.NombreAutor = txtNombre.Text
            miAut.Nacionalidad = cbxNacionalidad.Text

            Dim valida As New AutorLN

            Dim intOption As Integer
            intOption = MessageBox.Show("Realmente Desea Eliminar el Autor?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If intOption = 6 Then
                valida.BorrarAutor(miAut)
                txtCodAutor.Clear()
                cbxNacionalidad.Text = ""
                txtNombre.Clear()
                MessageBox.Show("El Autor ha sido Eliminado con Exito!")
                btnInsertar.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnModificar.Enabled = False
        btnBorrar.Enabled = False
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        txtCodAutor.Clear()
        cbxNacionalidad.Text = ""
        txtNombre.Clear()
        btnInsertar.Enabled = True

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmAutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnModificar.Enabled = False
        btnBorrar.Enabled = False
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        Dim Pantalla As New frmReportes
        Dim Reporte As New rptListaAutores
        Dim dstDatosReporte As New DataSet
        Dim strConsulta As String = "SELECT CodAutor, NombreAutor, Nacionalidad FROM Autores"
        Dim adpLista As New OleDb.OleDbDataAdapter(strConsulta, miConexion)
        adpLista.Fill(dstDatosReporte, "ListaAutores")
        Reporte.SetDataSource(dstDatosReporte)
        Pantalla.crvVisorReportes.ReportSource = Reporte
        Pantalla.Text = “Listado de Autores”
        Pantalla.ShowDialog()

    End Sub
End Class