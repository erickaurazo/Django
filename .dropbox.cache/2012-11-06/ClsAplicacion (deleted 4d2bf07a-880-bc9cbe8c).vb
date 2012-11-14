Option Strict On
Option Explicit On
Public Class ClsAplicacion
    Dim oApp As New AccesoDatos.ClsAplicacion


    Public Function Listar() As DataTable
        Try
            Dim tabla As New DataTable
            tabla = oApp.Listar()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Agregar(ByVal _Nombre As String, ByVal _Formulario As String, ByVal _aTip_AppCod As Integer, ByVal _Estado As Boolean)
        Try
            With oApp
                .Nombre = _Nombre
                .Formulario = _Formulario
                .aTip_AppCod = _aTip_AppCod
                .Estado = _Estado
                .Agregar()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Editar(ByVal _App_cod As Integer, ByVal _Nombre As String, ByVal _Formulario As String, ByVal _Tip_AppCod As Integer)
        Try
            With oApp
                .App_cod = _App_cod
                .Nombre = _Nombre
                .Formulario = _Formulario
                .Tip_AppCod = _Tip_AppCod
                .Editar()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Buscar(ByVal _Formulario As String) As DataTable
        Try
            Dim tabla As New DataTable
            tabla = oApp.Buscar(_Formulario)
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Sub Eliminar(ByVal _App_cod As Integer)
        Try
            With oApp
                .App_cod = _App_cod
                .Eliminar()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub Habilitar(ByVal _App_cod As Integer, ByVal _Estado As Boolean)
        Try
            With oApp
                .App_cod = _App_cod
                .Estado = _Estado
                .Habitar()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
