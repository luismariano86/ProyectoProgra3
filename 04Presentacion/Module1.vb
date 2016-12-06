Imports _03Entidades
Imports System.Data.OleDb

Module Module1

    ' Objeto que permite conectarse a la BD Access
    Public miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Planilla.accdb")
    Public user As UsuarioEN = Nothing

End Module
