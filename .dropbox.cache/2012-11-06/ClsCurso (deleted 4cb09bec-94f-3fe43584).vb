Option Strict On
Option Explicit On
Public Class ClsCurso
    Public _Codigo, esp, cic As Integer
    Public _Modulo As Integer
    Public _Nombre As String
    Public _Desc As String
    Public _Semanales As Integer
    Public _Unidades, _Creditos As Integer
    Public _Estado As Boolean

    Dim oCur As New AccesoDatos.ClsCurso

    Public Function Listar() As DataTable
        Try
            Dim tabla As New DataTable
            tabla = oCur.Listar
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Agregar()
        Try
            With oCur
                ._Modulo = _Modulo
                ._Nombre = _Nombre
                ._Desc = _Desc
                ._Semanales = _Semanales
                ._Unidades = _Unidades
                ._Creditos = _Creditos
                ._Estado = True
                .Agregar()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Editar()
        Try
            With oCur
                ._Codigo = _Codigo
                ._Modulo = _Modulo
                ._Nombre = _Nombre
                ._Desc = _Desc
                ._Semanales = _Semanales
                ._Unidades = _Unidades
                ._Creditos = _Creditos
                .Editar()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Inhabilitar(ByVal _Codigo As Integer)
        Try
            oCur.Inhabilitar(_Codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Habilitar(ByVal _Codigo As Integer)
        Try
            oCur.Habilitar(_Codigo)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Eliminar(ByVal _Codigo As Integer)
        Try
            oCur.Eliminar(_Codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function cb_Modulo(ByVal esp As Integer, ByVal cic As Integer) As DataTable
        Try
            Dim tabla As New DataTable
            tabla = oCur.cb_Modulo(esp, cic)
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
