Public Class ClsCuentas
    Public App_Cod As Integer
    Public Per_Cod As Integer
    Public Permiso As Boolean

    'listar todos los usuarios
    Public Function Listar_Todos() As DataTable
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Permiso_ListarTodos")
            Return proc.EjecutarProcedimiento().Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Listar usuarios por nombre y tipo
    Public Function Listar_NombreTipo(ByVal Apellido As String, _
                    ByVal Tipo As Integer) As DataTable
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Permiso_ListarNombreTipo")
            proc.AgregarParametro("Apellido", Apellido)
            proc.AgregarParametro("Tipo ", Tipo)
            Return proc.EjecutarProcedimiento().Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Listar todos las aplicaciones
    Public Function Listar_Aplicaciones() As DataTable
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Permiso_ListarAplicaciones")
            Return proc.EjecutarProcedimiento().Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Grabar Permisos de usuarios
    Public Sub Grabar_PermisosUsuario(ByVal App_Cod As Integer, ByVal Per_Cod As Integer, ByVal Permiso As Boolean)
        Try
            Dim Proc As New ClsProcedimientoAlmacenado("sp_Permiso_Insertar_usuario")
            Proc.AgregarParametro("App_Cod", App_Cod)
            Proc.AgregarParametro("Per_Cod ", Per_Cod)
            Proc.AgregarParametro("Permiso ", Permiso)
            Proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'eliminar Permisos de usuarios 
    Public Sub Eliminar_Permisos_Usuario(ByVal per_cod As Integer)
        Try
            Dim Proc As New ClsProcedimientoAlmacenado("sp_Permiso_borrar_usuario")
            Proc.AgregarParametro("Per_Cod ", Per_Cod)
            Proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub



    'cargar permisos de usuario
    Public Function Listar_aplicaciones_por_Usuario(ByVal _per_cod As Integer) As DataTable
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Permiso_listar_Codigo")
            proc.AgregarParametro("per_cod", _per_cod)
            Return proc.EjecutarProcedimiento().Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Actualizar Permisos de usuarios
    Public Sub Actualizar_PermisosUsuario(ByVal App_Cod As Integer, ByVal Per_Cod As Integer, ByVal Permiso As Boolean)
        Try
            Dim Proc As New ClsProcedimientoAlmacenado("sp_Permiso_Actualizar_usuario")
            Proc.AgregarParametro("App_Cod", App_Cod)
            Proc.AgregarParametro("Per_Cod ", Per_Cod)
            Proc.AgregarParametro("Permiso ", Permiso)
            Proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
