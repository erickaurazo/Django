Public Class ClsPersona
    Dim oObj As New AccesoDatos.ClsPersona

    Public Function Listar_Todos() As DataTable

        Try
            Dim tabla As New DataTable
            tabla = oObj.Listar_Todos
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Agregar(ByVal Nombres As String, ByVal Apellidos As String, _
                        ByVal Nacimiento As Date, ByVal Foto As String, _
                        ByVal Tipo As Integer, ByVal Estado As Boolean)
        Try

            With oObj
                .Nombres = Nombres
                .Apellidos = Apellidos
                .Nacimiento = Nacimiento
                .Foto = Foto
                .Tipo = Tipo
                .Estado = Estado
                .Agregar(Nombres, Apellidos, Nacimiento, Foto, Tipo, Estado)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub Editar(ByVal Per_Cod As Integer, _
                          ByVal Nombres As String, ByVal Apellidos As String, _
                          ByVal Nacimiento As Date, ByVal Foto As String, _
                          ByVal Tipo As Integer, ByVal Estado As Boolean)
        Try

            With oObj
                .Per_Cod = Per_Cod
                .Nombres = Nombres
                .Apellidos = Apellidos
                .Nacimiento = Nacimiento
                .Foto = Foto
                .Tipo = Tipo
                .Estado = Estado
                .Editar(Per_Cod, Nombres, Apellidos, Nacimiento, Foto, Tipo, Estado)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub Cambiar_Estado(ByVal Per_Cod As Integer, ByVal Estado As Boolean)
        Try

            With oObj
                .Per_Cod = Per_Cod
                .Estado = Estado
                .Cambiar_Estado(Per_Cod, Estado)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
