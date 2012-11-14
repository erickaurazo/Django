Imports System.Data.SqlClient
Public Class ClsProcedimientoAlmacenado

#Region " Variables "
    Private mNombreProcedimiento As String
    Private mParametros As Collection
#End Region

#Region " Propiedades "
    Public Property Nombre() As String
        Get
            Return mNombreProcedimiento
        End Get
        Set(ByVal Value As String)
            mNombreProcedimiento = Value
        End Set
    End Property

    Public Property Parametros() As Collection
        Get
            Return mParametros
        End Get
        Set(ByVal Value As Collection)
            mParametros = Value
        End Set
    End Property
#End Region

#Region " Constructor "

    Public Sub New(ByVal nNombre As String)
        Try
            Nombre = nNombre
            Parametros = New Collection
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region " Propiedades y Funciones "

    'Agrega los parametros del procedimiento y su respectivo valor.
    Public Sub AgregarParametro(ByVal pVariable As String, ByVal pValor As Object)
        Try
            Dim iParametro As New ClsParametroProcAlamcenado("@" & pVariable, pValor)
            Me.Parametros.Add(iParametro)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function EjecutarProcedimiento() As DataSet
        Try
            Dim Conn As New ClsConexion
            Dim sqlCmd As New SqlCommand(Me.Nombre, Conn.SQLConn)
            sqlCmd.CommandType = CommandType.StoredProcedure

            Dim mParametro As ClsParametroProcAlamcenado

            For Each mParametro In Me.Parametros
                Dim pParam As New SqlParameter(mParametro.Variable, mParametro.GetTypeProperty)
                pParam.Direction = ParameterDirection.Input
                pParam.Value = mParametro.Valor
                sqlCmd.Parameters.Add(pParam)
            Next
            Dim sda As New SqlDataAdapter(sqlCmd)
            Dim ds As New DataSet
            sda.Fill(ds)

            Conn.SQLConn.Close()
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

End Class

