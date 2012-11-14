Option Strict On
Option Explicit On
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
    Public _Mar_Estado As Integer
    
    'Listado de Matriculas
    Public Function ListarMatriculas() As DataTable

        Try
            Dim oMat As New AccesoDatos.Matricula
            Dim tabla As New DataTable
            tabla = oMat.ListarMatriculas
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#Region "Mantenimiento "
    'Modificar Matricula
    Public Sub Agregar()
        Try
            Dim oMat As New AccesoDatos.Matricula
            With oMat
                ._Mat_Cod = _Mat_Cod
                ._Fecha = _Fecha
                ._Per_Cod = _Per_Cod
                ._TipMat_Cod = _TipMat_Cod
                ._Especialidad_Cod = _Especialidad_Cod
                ._Ciclo_Cod = _Ciclo_Cod
                ._Turno_Cod = _Turno_Cod
                ._Semestre_Cod = _Semestre_Cod
                ._Mat_Condicion = _Mat_Condicion
                ._Mar_Estado = CStr(1)
                .Agregar()
            End With
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Agregar")
        End Try
    End Sub

    'Cancelar Matricula
    Public Sub Editar()
        Try
            Dim oMat As New AccesoDatos.Matricula
            With oMat
                ._Mat_Cod = _Mat_Cod
                ._Fecha = _Fecha
                ._Per_Cod = _Per_Cod
                ._TipMat_Cod = _TipMat_Cod
                ._Especialidad_Cod = _Especialidad_Cod
                ._Ciclo_Cod = _Ciclo_Cod
                ._Turno_Cod = _Turno_Cod
                ._Semestre_Cod = _Semestre_Cod
                ._Mat_Condicion = _Mat_Condicion
                .Editar()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Cancelar Matricula
    Public Sub Cancelar(ByVal _Codigo As Integer)
        Try
            Dim oMat As New AccesoDatos.Matricula
            oMat.Cancelar(_Codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Reservar Matricula
    Public Sub Reservar(ByVal _Codigo As Integer)
        Try
            Dim oMat As New AccesoDatos.Matricula
            oMat.Reservar(_Codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Anular Matricula
    Public Sub Anular(ByVal _Codigo As Integer)
        Try
            Dim oMat As New AccesoDatos.Matricula
            oMat.Anular(_Codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

    'Listado General de los Estudiantes 
    Public Function ListadoGeneral() As DataTable
        Dim oMatricula As New AccesoDatos.Matricula
        Try
            Dim tabla As New DataTable
            tabla = oMatricula.ListadoGeneral
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    'Buscar Estudiantes
    Public Function Buscar(ByVal Nombre As String, _
                      ByVal Semestre As Integer, _
                      ByVal Especialidad As Integer) As DataTable
        Try
            Dim oBuscar As New AccesoDatos.Matricula
            Dim tabla As New DataTable

            tabla = oBuscar.Buscar(Nombre, Semestre, Especialidad)
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#Region "Procedimientos de ComboBox "

    'ComboBox Ciclo 
    Public Function cb_Ciclo() As DataTable
        Dim oMatricula As New AccesoDatos.Matricula
        Try
            Dim tabla As New DataTable
            tabla = oMatricula.cb_Ciclo
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'ComboBox Condicion
    Public Function cb_Condicion() As DataTable
        Dim oMatricula As New AccesoDatos.Matricula
        Try
            Dim tabla As New DataTable
            tabla = oMatricula.cb_Condicion
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'ComboBox Tipo_Matricula 
    Public Function cb_TipoMatricula() As DataTable
        Dim oMatricula As New AccesoDatos.Matricula
        Try
            Dim tabla As New DataTable
            tabla = oMatricula.cb_TipoMatricula
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'ComboBox Turno
    Public Function cb_Turno() As DataTable
        Dim oMatricula As New AccesoDatos.Matricula
        Try
            Dim tabla As New DataTable
            tabla = oMatricula.cb_Turno
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'ComboBox Semestre
    Public Function Cb_Semestre() As DataTable
        Dim oSem As New AccesoDatos.Matricula
        Try
            Dim tabla As New DataTable
            tabla = oSem.Cb_Semestre
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ' 'ComboBox  Especialidades
    Public Function Cb_Especialidad() As DataTable
        Dim oEsp As New AccesoDatos.Matricula
        Try
            Dim tabla As New DataTable
            tabla = oEsp.Cb_Especialidad
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region


    'Listar cursos de un ciclo por especialidad
    Public Function Listar_Cursos(ByVal Esp As Integer, _
                                  ByVal Ciclo As Integer) As DataTable
        Try
            Dim oBuscar As New AccesoDatos.Matricula
            Dim tabla As New DataTable

            tabla = oBuscar.Listar_Cursos(Esp, Ciclo)
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Ficha de Matricula
    Public Function Cr_FichaMatricula(ByVal Codigo As Integer) As DataTable
        Try
            Dim oMat As New AccesoDatos.Matricula
            Dim tabla As New DataTable
            tabla = oMat.Cr_FichaMatricula(Codigo)
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Codigo generado
    Public Function Codigo() As DataTable

        Try
            Dim oMat As New AccesoDatos.Matricula
            Dim tabla As New DataTable
            tabla = oMat.Codigo()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
