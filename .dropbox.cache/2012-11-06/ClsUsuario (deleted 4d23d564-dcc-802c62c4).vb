Public Class ClsUsuario
    Public uUsuario As String
    Public uClave As String
    Public uPer_Cod As Integer

    '-----------------------
    Public Property Per_cod() As Integer
        Get
            Return uPer_Cod
        End Get
        Set(ByVal Value As Integer)
            uPer_Cod = Value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return uUsuario
        End Get
        Set(ByVal Value As String)
            uUsuario = Value
        End Set
    End Property

    Public Property Clave() As String
        Get
            Return Uclave
        End Get
        Set(ByVal Value As String)
            Uclave = Value
        End Set
    End Property


    Public Function Listar_TipoPersonas() As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_UsuarioListarTodos")
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Identificar el logeo de una alumno
    Public Function Comprobar_Usuario(ByVal per_cod As Integer, _
                    ByVal usuario As String) As DataTable
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Login_Estudiante")
            proc.AgregarParametro("Per_cod", per_cod)
            proc.AgregarParametro("Usuario", usuario)
            Return proc.EjecutarProcedimiento().Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    '--- listar a un usuario y su contraseña por codigo
    Public Function Listar_por_Codigo(ByVal per_cod As Integer) As DataTable
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_UsuarioListarPorCodigo")
            proc.AgregarParametro("Per_cod", per_cod)
            Return proc.EjecutarProcedimiento().Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    '---- comprobar que no exista un usuario repetido por nombre o código
    Public Function Comprobar_duplicidad_de_Usuario(ByVal per_cod As Integer, _
                ByVal usuario As String) As DataTable
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_UsuarioComprobar")
            proc.AgregarParametro("Per_cod", per_cod)
            proc.AgregarParametro("Usuario", usuario)
            Return proc.EjecutarProcedimiento().Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function



    '---- actualizar la contraseña del usuario
    Public Sub Actualizar_Clave()
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Usuario_Actualizar")
            proc.AgregarParametro("Per_cod", per_cod)
            proc.AgregarParametro("clave", clave)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    '---- insertar nuevo usuario
    Public Sub Insertar_nuevo_Usuario()
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Usuario_Insertar")
            proc.AgregarParametro("Per_cod", Per_cod)
            proc.AgregarParametro("usuario", Usuario)
            proc.AgregarParametro("clave", Clave)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub




End Class
