Option Explicit On
Option Strict On
Imports System.Data.SqlClient
Public Class Matricula
    Public _Mat_Cod As Integer
    Public _Fecha As DateTime
    Public _Per_Cod As Integer
    Public _TipMat_Cod As Integer
    Public _Especialidad_Cod As Integer
    Public _Ciclo_Cod As Integer
    Public _Turno_Cod As Integer
    Public _Semestre_Cod As Integer
    Public _Mat_Condicion As Integer
    Public _Mar_Estado As String


    'Listado de Matriculas
    Public Function ListarMatriculas() As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_Matricula_lst")
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#Region "Mantenimiento "
    'Modificar Matricula
    Public Sub Agregar()
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Matricula_Add")
            proc.AgregarParametro("Mat_Cod", _Mat_Cod)
            proc.AgregarParametro("Fecha", _Fecha)
            proc.AgregarParametro("Per_Cod", _Per_Cod)
            proc.AgregarParametro("TipMat_Cod", _TipMat_Cod)
            proc.AgregarParametro("Especialidad_Cod", _Especialidad_Cod)
            proc.AgregarParametro("Ciclo_Cod", _Ciclo_Cod)
            proc.AgregarParametro("Turno_Cod", _Turno_Cod)
            proc.AgregarParametro("Semestre_Cod", _Semestre_Cod)
            proc.AgregarParametro("Mat_Condicion", _Mat_Condicion)
            proc.AgregarParametro("Mar_Estado", _Mar_Estado)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Cancelar Matricula
    Public Sub Editar()
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Matricula_Edit")
            proc.AgregarParametro("Mat_Cod", _Mat_Cod)
            proc.AgregarParametro("Fecha", _Fecha)
            proc.AgregarParametro("Per_Cod", _Per_Cod)
            proc.AgregarParametro("TipMat_Cod", _TipMat_Cod)
            proc.AgregarParametro("Especialidad_Cod", _Especialidad_Cod)
            proc.AgregarParametro("Ciclo_Cod", _Ciclo_Cod)
            proc.AgregarParametro("Turno_Cod", _Turno_Cod)
            proc.AgregarParametro("Semestre_Cod", _Semestre_Cod)
            proc.AgregarParametro("Mat_Condicion", _Mat_Condicion)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Cancelar Matricula
    Public Sub Cancelar(ByVal _Codigo As Integer)
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Matricula_Can")
            proc.AgregarParametro("Codigo", _Codigo)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Reservar Matricula
    Public Sub Reservar(ByVal _Codigo As Integer)
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Matricula_Res")
            proc.AgregarParametro("Codigo", _Codigo)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Anular Matricula
    Public Sub Anular(ByVal _Codigo As Integer)
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Matricula_Anu")
            proc.AgregarParametro("Codigo", _Codigo)
            proc.EjecutarProcedimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region
    'Listado general de Estudiantes
    Public Function ListadoGeneral() As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_lst_Estudiantes")
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    'Buscar Estudiantes
    Public Function Buscar(ByVal Nombre As String, _
                      ByVal Semestre As Integer, _
                      ByVal Especialidad As Integer) As DataTable
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Busc_Estudiantes")
            proc.AgregarParametro("Nombre", Nombre)
            proc.AgregarParametro("Semestre ", Semestre)
            proc.AgregarParametro("Especialidad", Especialidad)
            Return proc.EjecutarProcedimiento().Tables(0)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

#Region "Procedimientos de ComboBox "
    'ComboBox ciclo
    Public Function cb_Ciclo() As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_cb_Ciclo")
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'ComboBox condicion
    Public Function cb_Condicion() As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_cb_Condicion")
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'ComboBox tipoMatricula
    Public Function cb_TipoMatricula() As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_cb_TipMatricula")
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'ComboBox Turno
    Public Function cb_Turno() As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_cb_Turno")
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'ComboBox Semeste
    Public Function Cb_Semestre() As DataTable

        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_cb_Semestre")
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'ComboBox Especialidad
    Public Function Cb_Especialidad() As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_cb_Especialidad")
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

    'Listar cursos de un ciclo por especialidad
    Public Function Listar_Cursos(ByVal Esp As Integer, _
                                  ByVal Ciclo As Integer) As DataTable
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_lst_CurxEspxCic")
            proc.AgregarParametro("Esp", Esp)
            proc.AgregarParametro("Ciclo ", Ciclo)
            Return proc.EjecutarProcedimiento().Tables(0)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Ficha de Matricula
    Public Function Cr_FichaMatricula(ByVal Codigo As Integer) As DataTable
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Cr_FichaMatricula")
            proc.AgregarParametro("Codigo", Codigo)
            Return proc.EjecutarProcedimiento().Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Codigo Generado
    Public Function Codigo() As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_Matricula_Codigo")
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class



