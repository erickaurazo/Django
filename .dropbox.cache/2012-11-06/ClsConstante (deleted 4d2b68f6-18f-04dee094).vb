Public Class ClsConstante

    Dim oObj As New AccesoDatos.ClsConstante

    Public Function Condicion_Persona(ByVal cod_grupo As Integer) As DataTable

        Try
            Dim tabla As New DataTable
            tabla = oObj.Condicion_Persona(cod_grupo)
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
