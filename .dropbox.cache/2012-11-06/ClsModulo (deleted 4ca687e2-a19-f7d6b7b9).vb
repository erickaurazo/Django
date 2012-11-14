Option Strict On
Option Explicit On
Public Class ClsModulo
    Public _Ciclo, _Especialidad, _Duracion, _Codigo As Integer
    Public _Nombre, _Titulo, _Unidad As String
    Public _Estado As Boolean

    Public Function Listar() As DataTable
        Dim oEsp As New AccesoDatos.ClsModulo
        Try
            Dim tabla As New DataTable
            tabla = oEsp.Listar
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Agregar()
        Try
            Dim oMod As New AccesoDatos.ClsModulo
            With oMod
                ._Ciclo = _Ciclo
                ._Especialidad = _Especialidad
                ._Titulo = _Titulo
                ._Nombre = _Nombre
                ._Unidad = _Unidad
                ._Duracion = _Duracion
                ._Estado = True
                .Agregar()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Editar()
        Try
            Dim oEsp As New AccesoDatos.ClsModulo
            With oEsp
                ._codigo = _Codigo
                ._Ciclo = _Ciclo
                ._Especialidad = _Especialidad
                ._Titulo = _Titulo
                ._Nombre = _Nombre
                ._Unidad = _Unidad
                ._Duracion = _Duracion
                .Editar()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Inhabilitar(ByVal _Codigo As Integer)
        Try
            Dim oMod As New AccesoDatos.ClsModulo
            oMod.Inhabilitar(_Codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Habilitar(ByVal _Codigo As Integer)
        Try
            Dim oMod As New AccesoDatos.ClsModulo
            oMod.Habilitar(_Codigo)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Eliminar(ByVal _Codigo As Integer)
        Try
            Dim oMod As New AccesoDatos.ClsModulo
            oMod.Eliminar(_Codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Devolver_CicloEspecialidad(ByVal _ciclo As Integer, ByVal _esp As Integer) As DataTable

        Try
            Dim oMod As New AccesoDatos.ClsModulo
            Return oMod.Devolver_CicloEspecialidad(_ciclo, _esp)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
