Public Class UsuarioEN

#Region "Atributos"
    Dim _Login As String
    Dim _Clave As String
    Dim _NombreCompleto As String
    Dim _IndAdministrador As Boolean
    Dim _IndBibliotecario As Boolean
    Dim _IndActivo As Boolean
#End Region

#Region "Constructores"
    ''' <summary>
    ''' Constructor vacio del objeto
    ''' </summary>
    Public Sub New()
        _Login = String.Empty
        _Clave = String.Empty
        _NombreCompleto = String.Empty
        _IndAdministrador = False
        _IndBibliotecario = False
        _IndActivo = False
        _IndActivo = False

    End Sub

    ''' <summary>
    ''' Recibe todos los datos
    ''' </summary>
    ''' <param name="pLogin">Nombre de Usuario</param>
    ''' <param name="pClave">Nombre Completo</param>
    ''' <param name="pNombreCompleto">Fecha de ingreso a la empresa</param>
    ''' <param name="pIndAdministrador">Horas trabajadas en la semana</param>
    ''' <param name="pIndBibliotecario">Precio de cada hora</param>
    ''' <param name="pIndActivo">Indica si esta activo el empleado</param>
    Public Sub New(ByVal pLogin As String,
                   ByVal pClave As String,
                   ByVal pNombreCompleto As Date,
                   ByVal pIndAdministrador As Integer,
                   ByVal pIndBibliotecario As Double,
                   ByVal pIndActivo As Boolean)

        _Login = pLogin
        _Clave = pClave
        _NombreCompleto = pNombreCompleto
        _IndAdministrador = pIndAdministrador
        _IndBibliotecario = pIndBibliotecario
        _IndActivo = pIndActivo

    End Sub

#End Region

#Region "Propiedades"
    Public Property Login As String
        Set(value As String)
            _Login = value
        End Set
        Get
            Return _Login
        End Get
    End Property
    Public Property Clave As String
        Set(value As String)
            _Clave = value
        End Set
        Get
            Return _Clave
        End Get
    End Property
    Public Property NombreCompleto As String
        Set(value As String)
            _NombreCompleto = value
        End Set
        Get
            Return _NombreCompleto
        End Get
    End Property
    Public Property IndBibliotecario As Boolean
        Set(value As Boolean)
            _IndAdministrador = value
        End Set
        Get
            Return _IndAdministrador
        End Get
    End Property
    Public Property IndAdministrador As Boolean
        Set(value As Boolean)
            _IndBibliotecario = value
        End Set
        Get
            Return _IndBibliotecario
        End Get
    End Property
    Public Property IndActivo As Boolean
        Set(value As Boolean)
            _IndActivo = value
        End Set
        Get
            Return _IndActivo
        End Get
    End Property
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Cadena con los valores del objeto
    ''' </summary>
    ''' <returns>Cadena con los valores del objeto</returns>
    Public Overrides Function ToString() As String
        Dim strDatos As String

        strDatos =
            "Login: " & _Login & vbCrLf &
            "Clave: " & _Clave & vbCrLf &
            "Nombre completo: " & _NombreCompleto & vbCrLf &
            "Administrador del Sistema: " & IIf(_IndAdministrador, "Es Administrador", "No es Administrador") &
            "Nivel Bibliotecario: " & IIf(_IndBibliotecario, "Activo", "Renuncio") &
            "Estado del Usuario: " & IIf(_IndActivo, "Activo", "Renuncio")

        Return strDatos

    End Function


#End Region


End Class
