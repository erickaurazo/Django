Public Class ClsUsuario
    Private Uusuario As String
    Public Uclave As String
    Dim oObj As New AccesoDatos.ClsUsuario

    '---
    Public Function Listar() As DataTable
        Try
            Dim tabla As New DataTable
            tabla = oObj.Listar_TipoPersonas()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    'Identificar el logeo de una alumno
    Public Function Identificar_Alumno(ByVal Per_cod As Integer, _
                  ByVal Usuario As String) As DataTable
        Dim tabla As DataTable
        Try
            tabla = oObj.Comprobar_Usuario(Per_cod, Usuario)
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    '--- listar a un usuario y su contraseña por codigo
    Public Function Listar_por_Codigo(ByVal Per_cod As Integer) As DataTable
        Dim tabla As DataTable
        Try
            tabla = oObj.Listar_por_Codigo(Per_cod)
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    '-----------

    '---- comprobar que no exista un usuario repetido por nombre o código
    Public Function Comprobar_duplicidad_de_Usuario(ByVal Per_cod As Integer, _
              ByVal Usuario As String) As DataTable
        Dim tabla As DataTable
        Try
            tabla = oObj.Comprobar_duplicidad_de_Usuario(Per_cod, Usuario)
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function



    '---- actualizar la contraseña del usuario
    Public Sub Actualizar_Clave(ByVal per_cod As Integer, _
                ByVal clave As String)
        Try
            With oObj
                .uPer_Cod = per_cod
                .uClave = clave
                .Actualizar_Clave()
            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    '---- insertar nuevo usuario
    Public Sub Insertar_nuevo_Usuario(ByVal per_cod As Integer, ByVal usuario As String, _
                ByVal clave As String)
        Try
            With oObj
                .uPer_Cod = per_cod
                .uUsuario = usuario
                .uClave = clave
                .Insertar_nuevo_Usuario()
            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


End Class
