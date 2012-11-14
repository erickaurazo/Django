Public Class ClsLogin
    Public Usuario As String
    Public Clave As String
    Dim oBuscar As New AccesoDatos.ClsLogin
'Identificar Alumno
     Public Function Identificar_Alumno(ByVal Usuario As String, _
                   ByVal Clave As String) As DataTable
        Try
            Dim tabla As New DataTable
            tabla = oBuscar.Identificar_Alumno(Usuario, Clave)
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
