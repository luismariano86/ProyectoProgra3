Public Class PrestamoEN
#Region "Atributos"
    Dim _CodPrestamo As String
    Dim _Cedula As String
    Dim _ISBN As String
    Dim _Monto As Double
    Dim _FecPrestamo As Date
    Dim _FecDevolucion As Date
    Dim _IndDevuelto As Boolean
    Dim _Observaciones As String
    Dim _LoginUsuario As String

#End Region

#Region "Constructores"
    ''' <summary>
    ''' Constructor vacio del objeto
    ''' </summary>
    Public Sub New()
        _CodPrestamo = String.Empty
        _Cedula = String.Empty
        _ISBN = String.Empty
        _Monto = 0
        _FecPrestamo = CType("01/01/1900", Date)
        _FecDevolucion = CType("01/01/1900", Date)
        _IndDevuelto = False
        _Observaciones = String.Empty
        _LoginUsuario = String.Empty

    End Sub

    ''' <summary>
    ''' Recibe todos los datos
    ''' </summary>
    ''' <param name="pCodPrestamo">Nombre de Usuario</param>
    ''' <param name="pCedula">Nombre de Usuario</param>
    ''' <param name="pISBN">Nombre Completo</param>
    ''' <param name="pMonto">Fecha de ingreso a la empresa</param>
    ''' <param name="pFecPrestamo">Horas trabajadas en la semana</param>
    ''' <param name="pFecDevolucion">Precio de cada hora</param>
    ''' <param name="pIndDevuelto">Precio de cada hora</param>
    ''' <param name="pObservaciones">Fecha de ingreso a la empresa</param>
    ''' <param name="pLoginUsuario">Fecha de ingreso a la empresa</param>

    Public Sub New(ByVal pCodPrestamo As String,
                   ByVal pCedula As String,
                   ByVal pISBN As String,
                   ByVal pMonto As Double,
                   ByVal pFecPrestamo As Date,
                   ByVal pFecDevolucion As Date,
                   ByVal pIndDevuelto As Boolean,
                   ByVal pObservaciones As Date,
                   ByVal pLoginUsuario As Date)

        _CodPrestamo = pCodPrestamo
        _Cedula = pCedula
        _ISBN = pISBN
        _Monto = pMonto
        _FecPrestamo = pFecPrestamo
        _FecDevolucion = pFecDevolucion
        _IndDevuelto = pIndDevuelto
        _Observaciones = pObservaciones
        _LoginUsuario = pLoginUsuario

    End Sub

#End Region

#Region "Propiedades"
    Public Property CodPrestamo As String
        Set(value As String)
            _CodPrestamo = value
        End Set
        Get
            Return _CodPrestamo
        End Get
    End Property
    Public Property Cedula As String
        Set(value As String)
            _Cedula = value
        End Set
        Get
            Return _Cedula
        End Get
    End Property
    Public Property ISBN As String
        Set(value As String)
            _ISBN = value
        End Set
        Get
            Return _ISBN
        End Get
    End Property
    Public Property Monto As Double
        Set(value As Double)
            _Monto = value
        End Set
        Get
            Return _Monto
        End Get
    End Property
    Public Property FecPrestamo As Date
        Set(value As Date)
            _FecPrestamo = value
        End Set
        Get
            Return _FecPrestamo
        End Get
    End Property
    Public Property FecDevolucion As Date
        Set(value As Date)
            _FecDevolucion = value
        End Set
        Get
            Return _FecDevolucion
        End Get
    End Property
    Public Property IndDevuelto As Boolean
        Set(value As Boolean)
            _IndDevuelto = value
        End Set
        Get
            Return _IndDevuelto
        End Get
    End Property

    Public Property LoginUsuario As String
        Set(value As String)
            _LoginUsuario = value
        End Set
        Get
            Return _LoginUsuario
        End Get
    End Property

    Public Property Observaciones As String
        Set(value As String)
            _Observaciones = value
        End Set
        Get
            Return _Observaciones
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
            "CodPrestamo: " & _CodPrestamo & vbCrLf &
            "Cedula: " & _Cedula & vbCrLf &
            "ISBN: " & _ISBN & vbCrLf &
            "Observaciones: " & _Observaciones & vbCrLf &
            "Fecha de Prestamo: " & _FecPrestamo.ToShortDateString &
            "Fecha de Devolucion: " & FecDevolucion.ToShortDateString &
            "Monto:" & _Monto

        Return strDatos

    End Function


#End Region
End Class
