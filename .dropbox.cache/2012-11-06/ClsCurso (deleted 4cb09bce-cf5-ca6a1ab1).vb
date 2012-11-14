Public Class ClsCurso
    Public _Codigo As Integer
    Public _Modulo As Integer
    Public _Nombre As String
    Public _Desc As String
    Public _Semanales As Integer
    Public _Unidades, _Creditos As Integer
    Public _Estado As Boolean

    Public Function Listar() As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_Curso_LstGen")
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Agregar()
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Curso_add")
            proc.AgregarParametro("Modulo", _Modulo)
            proc.AgregarParametro("Nombre", _Nombre)
            proc.AgregarParametro("Desc", _Desc)
            proc.AgregarParametro("Semanales", _Semanales)
            proc.AgregarParametro("Unidades", _Unidades)
            proc.AgregarParametro("Creditos", _Creditos)
            proc.AgregarParametro("Estado", _Estado)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Editar()
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Curso_Edit")
            proc.AgregarParametro("Curso", _Codigo)
            proc.AgregarParametro("Modulo", _Modulo)
            proc.AgregarParametro("Nombre", _Nombre)
            proc.AgregarParametro("Desc", _Desc)
            proc.AgregarParametro("Semanales", _Semanales)
            proc.AgregarParametro("Unidades", _Unidades)
            proc.AgregarParametro("Creditos", _Creditos)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Inhabilitar(ByVal _Codigo As Integer)
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Curso_Inh")
            proc.AgregarParametro("Codigo", _Codigo)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Habilitar(ByVal _Codigo As Integer)
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Curso_Hab")
            proc.AgregarParametro("Codigo", _Codigo)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(ByVal _Codigo As Integer)
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Curso_dlt")
            proc.AgregarParametro("Codigo", _Codigo)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function cb_Modulo(ByVal esp As Integer, ByVal cic As Integer) As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_Curso_cb_Modulo")
            cb.AgregarParametro("Esp", esp)
            cb.AgregarParametro("Cic", cic)
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function









End Class
