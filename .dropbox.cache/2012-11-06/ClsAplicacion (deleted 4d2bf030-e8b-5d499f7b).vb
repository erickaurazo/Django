Option Strict On
Option Explicit On
Public Class ClsAplicacion


    Public aApp_cod As Integer
    Public aNombre As String
    Public aFormulario As String
    Public aTip_AppCod As Integer
    Public aEstado As Boolean
    '-----------------------
    Public Property App_cod() As Integer
        Get
            Return aApp_cod
        End Get
        Set(ByVal Value As Integer)
            aApp_cod = Value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return aNombre
        End Get
        Set(ByVal Value As String)
            aNombre = Value
        End Set
    End Property

    Public Property Formulario() As String
        Get
            Return aFormulario
        End Get
        Set(ByVal Value As String)
            aFormulario = Value
        End Set
    End Property


    Public Property Tip_AppCod() As Integer
        Get
            Return aTip_AppCod
        End Get
        Set(ByVal Value As Integer)
            aTip_AppCod = Value
        End Set
    End Property

    Public Property Estado() As Boolean
        Get
            Return aEstado
        End Get
        Set(ByVal Value As Boolean)
            aEstado = Value
        End Set
    End Property

    Public Function Listar() As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_Aplicacion_Listar")
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function



    Public Sub Agregar()
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Aplicacion_Registrar")
            proc.AgregarParametro("Nombre", Nombre)
            proc.AgregarParametro("Formulario", Formulario)
            proc.AgregarParametro("Tip_AppCod", Tip_AppCod)
            proc.AgregarParametro("Estado", Estado)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Editar()
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Aplicacion_Actualizar")
            proc.AgregarParametro("App_cod", App_cod)
            proc.AgregarParametro("Nombre", Nombre)
            proc.AgregarParametro("Formulario", Formulario)
            proc.AgregarParametro("Tip_AppCod", Tip_AppCod)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Buscar(ByVal Formulario As String) As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_Aplicacion_Buscar")
            cb.AgregarParametro("Formulario", Formulario)
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Eliminar()
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Aplicacion_Eliminar")
            proc.AgregarParametro("App_cod", App_cod)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Habitar()
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Aplicacion_Habilitar")
            proc.AgregarParametro("App_cod", App_cod)
            proc.AgregarParametro("Estado", Estado)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub



End Class
