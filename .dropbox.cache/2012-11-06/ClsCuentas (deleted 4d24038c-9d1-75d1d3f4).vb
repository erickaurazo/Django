Public Class ClsCuentas
    Public App_Cod As Integer
    Public Per_Cod As Integer
    Public Permiso As Boolean

    Dim oObj As New AccesoDatos.ClsCuentas

    'listar todos los usuarios
    Public Function Listar_Todos() As DataTable
        Try
            Dim tabla As New DataTable
            tabla = oObj.Listar_Todos()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Listar usuarios por nombre y tipo
    Public Function Listar_NombreTipo(ByVal Apellido As String, _
                    ByVal Tipo As Integer) As DataTable
        Try
            Dim tabla As New DataTable
            tabla = oObj.Listar_NombreTipo(Apellido, Tipo)
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Listar todos las aplicaciones
    Public Function Listar_Aplicaciones() As DataTable
        Try
            Dim tabla As New DataTable
            tabla = oObj.Listar_Aplicaciones()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Grabar Permisos de usuarios
    Public Sub Grabar_PermisosUsuario(ByVal App_Cod As Integer, ByVal Per_Cod As Integer, ByVal Permiso As Boolean)
        Try
            With oObj
                .Grabar_PermisosUsuario(App_Cod, Per_Cod, Permiso)
            End With
        Catch ex As Exception
        End Try
    End Sub

    'eliminar Permisos de usuarios 
    Public Sub Eliminar_Permisos_Usuario(ByVal per_cod As Integer)
        Try
            With oObj
                .Eliminar_Permisos_Usuario(per_cod)
            End With
        Catch ex As Exception
        End Try
    End Sub



    'cargar permisos de usuario
    Public Function Listar_aplicaciones_por_Usuario(ByVal _per_cod As Integer) As DataTable
        Try
            Dim tabla As New DataTable
            tabla = oObj.Listar_aplicaciones_por_Usuario(_per_cod)
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    'Actualizar Permisos de usuarios
    Public Sub Actualizar_PermisosUsuario(ByVal App_Cod As Integer, ByVal Per_Cod As Integer, ByVal Permiso As Boolean)
        Try
            With oObj
                .Actualizar_PermisosUsuario(App_Cod, Per_Cod, Permiso)
            End With
        Catch ex As Exception
        End Try
    End Sub

End Class
