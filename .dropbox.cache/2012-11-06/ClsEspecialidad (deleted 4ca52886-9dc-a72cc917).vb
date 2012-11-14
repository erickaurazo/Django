Public Class ClsEspecialidad
    Public _Codigo As Integer
    Public _Nombre As String
    Public _Siglas As String
    Public _Desc As String
    Public _Perfil As String
    Public _Estado As Boolean

    Public Function Listar() As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_Especialidad_lst")
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Agregar()
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Especialidad_add")
            proc.AgregarParametro("Nombre", _Nombre)
            proc.AgregarParametro("Siglas ", _Siglas)
            proc.AgregarParametro("Desc ", _Desc)
            proc.AgregarParametro("Perfil ", _Perfil)
            proc.AgregarParametro("Estado ", _Estado)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Editar()
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Especialidad_Edit")
            proc.AgregarParametro("Nombre", _Nombre)
            proc.AgregarParametro("Siglas ", _Siglas)
            proc.AgregarParametro("Desc ", _Desc)
            proc.AgregarParametro("Perfil ", _Perfil)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Inhabilitar(ByVal _Codigo As Integer)
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Especialidad_Inh")
            proc.AgregarParametro("Codigo", _Codigo)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Habilitar(ByVal _Codigo As Integer)
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Especialidad_Hab")
            proc.AgregarParametro("Codigo", _Codigo)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(ByVal _Codigo As Integer)
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Especialidad_dlt")
            proc.AgregarParametro("Codigo", _Codigo)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
