Option Strict On
Option Explicit On
Public Class ClsEspecialidad
    Public _Codigo As Integer
    Public _Nombre As String
    Public _Siglas As String
    Public _Desc As String
    Public _Perfil As String
    Public _Estado As Boolean

    Public Function Listar() As DataTable
        Dim oEsp As New AccesoDatos.ClsEspecialidad
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
            Dim oEsp As New AccesoDatos.ClsEspecialidad
            With oEsp
                ._Nombre = _Nombre
                ._Siglas = _Siglas
                ._Desc = _Desc
                ._Perfil = _Perfil
                ._Estado = True
                .Agregar()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Editar()
        Try
            Dim oEsp As New AccesoDatos.ClsEspecialidad
            With oEsp
                ._Codigo = _Codigo
                ._Nombre = _Nombre
                ._Siglas = _Siglas
                ._Desc = _Desc
                ._Perfil = _Perfil
                .Agregar()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Inhabilitar(ByVal _Codigo As Integer)
        Try
            Dim oEsp As New AccesoDatos.ClsEspecialidad
            oEsp.Inhabilitar(_Codigo)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Habilitar(ByVal _Codigo As Integer)
        Try
            Dim oEsp As New AccesoDatos.ClsEspecialidad
            oEsp.Habilitar(_Codigo)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Eliminar(ByVal _Codigo As Integer)
        Try
            Dim oEsp As New AccesoDatos.ClsEspecialidad
            oEsp.Eliminar(_Codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
