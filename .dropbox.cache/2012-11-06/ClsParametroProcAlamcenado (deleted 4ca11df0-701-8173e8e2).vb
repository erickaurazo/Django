Public Class ClsParametroProcAlamcenado

    Private mVariable As String
    Private mValor As Object

    Public Property Variable() As String
        Get
            Return mVariable
        End Get
        Set(ByVal Value As String)
            mVariable = Value
        End Set
    End Property

    Public Property Valor()
        Get
            Return mValor
        End Get
        Set(ByVal Value)
            mValor = Value
        End Set
    End Property


    Public ReadOnly Property GetTypeProperty() As SqlDbType
        Get
            If mValor.GetType.FullName = "System.String" Then
                Return SqlDbType.VarChar
            ElseIf mValor.GetType.FullName = "System.Int16" Then
                Return SqlDbType.Int
            ElseIf mValor.GetType.FullName = "System.Int32" Then
                Return SqlDbType.Int
            ElseIf mValor.GetType.FullName = "System.Int64" Then
                Return SqlDbType.Int
            ElseIf mValor.GetType.FullName = "System.Decimal" Then
                Return SqlDbType.Decimal
            ElseIf mValor.GetType.FullName = "System.Double" Then
                Return SqlDbType.BigInt
            ElseIf mValor.GetType.FullName = "System.DateTime" Then
                Return SqlDbType.DateTime
            ElseIf mValor.GetType.FullName = "System.Byte" Then
                Return SqlDbType.Image
            End If
        End Get
    End Property

    Public Sub New(ByVal pVariable As String, ByVal pValor As Object)
        Try
            Me.Variable = pVariable
            Me.Valor = pValor
        Catch ex As Exception
            Throw New Exception("Error en la creacion del Parametro" & vbCrLf & ex.Message)
        End Try
    End Sub

End Class