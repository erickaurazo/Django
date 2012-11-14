Public Class ClsConstante

    'grupo 1 tipo de persona 
    'Cargar los valores al combobox, Si es postulante, alumno, docente , administrativo
    Public Function Condicion_Persona(ByVal cod_grupo As Integer) As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_Constante_Seleccionar")
            cb.AgregarParametro("cod_grupo", cod_grupo)
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function




End Class
