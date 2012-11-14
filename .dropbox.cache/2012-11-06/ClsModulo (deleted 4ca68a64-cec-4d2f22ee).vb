Public Class ClsModulo

    Public _Ciclo, _Especialidad, _Duracion, _codigo As Integer
    Public _Nombre, _Titulo, _Unidad As String
    Public _Estado As Boolean

    Public Function Listar() As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_Modulo_LstGen")
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Agregar()
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Modulo_add")
            proc.AgregarParametro("ciclo", _Ciclo)
            proc.AgregarParametro("Especialidad", _Especialidad)
            proc.AgregarParametro("Titulo", _Titulo)
            proc.AgregarParametro("Nombre", _Nombre)
            proc.AgregarParametro("Unidad", _Unidad)
            proc.AgregarParametro("Duracion", _Duracion)
            proc.AgregarParametro("Estado ", _Estado)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Editar()
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Modulo_Edit")
            proc.AgregarParametro("Codigo", _codigo)
            proc.AgregarParametro("ciclo", _Ciclo)
            proc.AgregarParametro("Especialidad", _Especialidad)
            proc.AgregarParametro("Titulo", _Titulo)
            proc.AgregarParametro("Nombre", _Nombre)
            proc.AgregarParametro("Unidad", _Unidad)
            proc.AgregarParametro("Duracion", _Duracion)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Inhabilitar(ByVal _Codigo As Integer)
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Modulo_Inh")
            proc.AgregarParametro("Codigo", _Codigo)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Habilitar(ByVal _Codigo As Integer)
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Modulo_Hab")
            proc.AgregarParametro("Codigo", _Codigo)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(ByVal _Codigo As Integer)
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Modulo_dlt")
            proc.AgregarParametro("Codigo", _Codigo)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Devolver_CicloEspecialidad(ByVal _ciclo As Integer, ByVal _esp As Integer) As DataTable
        Try

            Dim cb As New ClsProcedimientoAlmacenado("sp_Modulo_Lst_Ciclo_Especialidad")
            cb.AgregarParametro("Ciclo", _ciclo)
            cb.AgregarParametro("esp", _esp)
            cb.EjecutarProcedimiento()
            Dim dt As New DataTable
            dt = cb.EjecutarProcedimiento().Tables(0)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
