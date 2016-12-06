Public Class EmpleadoEN

#Region "Atributos"
    Dim _Cedula As String
    Dim _Nombre As String
    Dim _FechaIngreso As Date
    Dim _Horas As Integer
    Dim _PrecioHora As Double
    Dim _Activo As Boolean
#End Region

#Region "Constructores"
    ''' <summary>
    ''' Constructor vacio del objeto
    ''' </summary>
    Public Sub New()
        _Cedula = String.Empty
        _Nombre = String.Empty
        _FechaIngreso = CType("01/01/1900", Date)
        _Horas = 0
        _PrecioHora = 0
        _Activo = False
    End Sub

    ''' <summary>
    ''' Recibe todos los datos
    ''' </summary>
    ''' <param name="pCedula">Id del Cliente</param>
    ''' <param name="pNombre">Nombre Completo</param>
    ''' <param name="pFecha">Fecha de ingreso a la empresa</param>
    ''' <param name="pHoras">Horas trabajadas en la semana</param>
    ''' <param name="pPrecio">Precio de cada hora</param>
    ''' <param name="pActivo">Indica si esta activo el empleado</param>
    Public Sub New(ByVal pCedula As String,
                   ByVal pNombre As String,
                   ByVal pFecha As Date,
                   ByVal pHoras As Integer,
                   ByVal pPrecio As Double,
                   ByVal pActivo As Boolean)

        _Cedula = pCedula
        _Nombre = pNombre
        _FechaIngreso = pFecha
        _Horas = pHoras
        _PrecioHora = pPrecio
        _Activo = pActivo
    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Id del Cliente
    ''' </summary>
    ''' <returns>Id del Cliente</returns>
    Public Property Cedula As String
        Set(value As String)
            _Cedula = value
        End Set
        Get
            Return _Cedula
        End Get
    End Property

    ''' <summary>
    ''' Nombre Completo
    ''' </summary>
    ''' <returns>Nombre Completo</returns>
    Public Property NombreCompleto As String
        Set(value As String)
            _Nombre = value
        End Set
        Get
            Return _Nombre
        End Get
    End Property

    ''' <summary>
    ''' Fecha de ingreso a la empresa
    ''' </summary>
    ''' <returns>Fecha de ingreso a la empresa</returns>
    Public Property FechaIngreso As Date
        Set(value As Date)
            _FechaIngreso = value
        End Set
        Get
            Return _FechaIngreso
        End Get
    End Property

    ''' <summary>
    ''' Horas trabajadas en la semana
    ''' </summary>
    ''' <returns>Horas trabajadas en la semana</returns>
    Public Property HorasTrabajadas As Integer
        Set(value As Integer)

            _Horas = value
        End Set
        Get
            Return _Horas
        End Get
    End Property

    ''' <summary>
    ''' Precio de cada hora
    ''' </summary>
    ''' <returns>Precio de cada hora</returns>
    Public Property PrecioPorHora As Double
        Set(value As Double)
            _PrecioHora = value
        End Set
        Get
            Return _PrecioHora
        End Get
    End Property

    ''' <summary>
    ''' Indica si esta activo el cliente
    ''' </summary>
    ''' <returns>Indica si esta activo el cliente</returns>
    Public Property IndicadorActivo As Boolean
        Set(value As Boolean)
            _Activo = value
        End Set
        Get
            Return _Activo
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

        strDatos = "Cedula: " & _Cedula & vbCrLf &
            "Nombre: " & _Nombre & vbCrLf &
            "Fecha Ingreso: " & _FechaIngreso.ToShortDateString & vbCrLf &
            "Horas Trabajadas: " & _Horas & vbCrLf &
            "Precio por Hora: " & _PrecioHora & vbCrLf &
            "Estado del cliente: " & IIf(_Activo, "Activo", "Renuncio")

        Return strDatos

    End Function

    ''' <summary>
    ''' Salario sin deducciones del elemento
    ''' </summary>
    ''' <returns>Salario sin deducciones del elemento</returns>
    Public Function SalarioBruto() As Double

        Dim dblSalario As Double
        dblSalario = _PrecioHora * _Horas
        Return dblSalario

    End Function

    Public Function DeduccionSeguroSocial() As Double
        Dim dblCCSS As Double
        dblCCSS = SalarioBruto() * 0.09
        Return dblCCSS
    End Function

    ''' <summary>
    ''' Monto de ahorro a la asociacion 2%
    ''' </summary>
    ''' <returns>Monto de ahorro a la asociacion 2%</returns>
    Public Function AhorroAsociacion() As Double
        Dim dblAhorro As Double
        dblAhorro = SalarioBruto() * 0.02
        Return dblAhorro
    End Function

    ''' <summary>
    ''' Salario liquido, restando las deducciones
    ''' </summary>
    ''' <returns>Salario liquido, restando las deducciones</returns>
    Public Function SalarioNeto() As Double
        Dim dblEfectivo As Double
        dblEfectivo = SalarioBruto() - AhorroAsociacion() - DeduccionSeguroSocial()
        Return dblEfectivo
    End Function
#End Region



End Class
