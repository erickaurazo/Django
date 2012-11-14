Imports System.Data.SqlClient

Public Class ClsConexion

#Region " Variables "

    Private mUsuario As String
    Private mPassword As String
    Private mConSSPI As Boolean = True
    Private mServidor As String
    Private mBaseDatos As String
    Private mSqlConn As SqlConnection

#End Region

#Region " Propiedades "

    Public Property Usuario() As String
        Get
            Return mUsuario
        End Get
        Set(ByVal Value As String)
            mUsuario = Value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return mPassword
        End Get
        Set(ByVal Value As String)
            mPassword = Value
        End Set
    End Property

    Public Property ConSSPI() As Boolean
        Get
            Return mConSSPI
        End Get
        Set(ByVal Value As Boolean)
            mConSSPI = Value
        End Set
    End Property

    Public Property Servidor() As String
        Get
            Return mServidor
        End Get
        Set(ByVal Value As String)
            mServidor = Value
        End Set
    End Property

    Public Property BaseDatos() As String
        Get
            Return mBaseDatos
        End Get
        Set(ByVal Value As String)
            mBaseDatos = Value
        End Set
    End Property

    Public Property SQLConn() As SqlConnection
        Get
            Return mSqlConn
        End Get
        Set(ByVal Value As SqlConnection)
            mSqlConn = Value
        End Set
    End Property

#End Region

    Private Function StrConexion() As String
        Try
            Dim strConn As String
            strConn = "Server=" & Servidor & "; " & _
                        "DataBase=" & BaseDatos & "; "
            If Not ConSSPI Then
                strConn &= "user id=" & Usuario & ";password=" & Password
            Else
                strConn &= "Integrated Security=SSPI"
            End If

            Return strConn
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ConsultaBD(ByVal pQuery As String) As DataSet
        Try
            Return CreateDataSet(pQuery)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CreateDataSet(ByVal strSQL As String) As DataSet
        Try
            Dim sqlConn As New SqlConnection(Me.StrConexion)
            Dim sqlCmd As New SqlCommand(strSQL, sqlConn)
            sqlCmd.CommandTimeout = 3600
            Dim sda As New SqlDataAdapter(sqlCmd)
            Dim ds As New DataSet
            sda.Fill(ds)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub New()
        Try
            'Me.Servidor = "LOCAL\SQLEXPRESS"
            'Me.Servidor = "LI108\SQLEXPRESS"
            Me.Servidor = "GIERIKO\SQLEXPRESS"
            Me.BaseDatos = "db_Matricula"
            Me.Usuario = "sa"
            Me.Password = ""
            SQLConn = New SqlConnection(Me.StrConexion)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class