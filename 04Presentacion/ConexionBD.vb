Imports _03Entidades
Imports System.Data.OleDb

Module ConexionBD

    ' Objeto que permite conectarse a la BD Access
    Public miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Biblioteca.accdb")
    Public user As UsuarioEN = Nothing

End Module
