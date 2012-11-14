Public Class Matricula_Detalle
    Public _Matricula, _Curso As Integer

    Dim oCur As New AccesoDatos.Matricula_Detalle

    Public Function Listar() As DataTable
        Try
            Dim tabla As New DataTable
            tabla = oCur.Listar
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Agregar(ByVal _Matricula As Integer, ByVal _Curso As Integer)
        Try
            oCur.Agregar(_Matricula, _Curso)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Editar()
        Try
            With oCur
                ._Matricula = _Matricula
                ._Curso = _Curso
                .Editar()
            End With
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

    'Ficha de Matricula
    Public Function Cr_DetalleMatricula(ByVal Codigo As Integer) As DataTable
        Try
            Dim oMat As New AccesoDatos.Matricula_Detalle
            Dim tabla As New DataTable
            tabla = oMat.Cr_DetalleMatricula(Codigo)
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
