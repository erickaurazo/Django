Public Class ClsLogin
    Public Usuario As String
    Public Clave As String

    'Identificar Alumno
    Public Function Identificar_Alumno(ByVal Usuario As String, _
                    ByVal Clave As String) As DataTable
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_Login_Estudiante")
            proc.AgregarParametro("Usuario", Usuario)
            proc.AgregarParametro("Clave ", Clave)
            Return proc.EjecutarProcedimiento().Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function



End Class
