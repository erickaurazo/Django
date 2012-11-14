Public Class Matricula_Detalle
    Public _Matricula, _Curso As Integer

    Public Function Listar() As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_Dtll_Matricula_lst")
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Agregar(ByVal _Matricula As Integer, ByVal _Curso As Integer)
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Dtll_Matricula_Add")
            proc.AgregarParametro("Mat_Cod", _Matricula)
            proc.AgregarParametro("Curso_Cod", _Curso)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Editar()
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Dtll_Matricula_Edit")
            proc.AgregarParametro("Mat_Cod", _Matricula)
            proc.AgregarParametro("Curso_Cod", _Curso)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(ByVal _Codigo As Integer)
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Dtll_Matricula_Dlt")
            proc.AgregarParametro("Codigo", _Codigo)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Function Cr_DetalleMatricula(ByVal Codigo As Integer) As DataTable
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Cr_DetalleMatricula")
            proc.AgregarParametro("Codigo", Codigo)
            Return proc.EjecutarProcedimiento().Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
