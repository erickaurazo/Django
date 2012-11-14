Public Class ClsPersona

    Public Per_Cod As Integer
    Public Nombres As String
    Public Apellidos As String
    Public Nacimiento As Date
    Public Foto As String
    Public Tipo As Integer
    Public Estado As Boolean


    Public Function Listar_Todos() As DataTable
        Try
            Dim oTabla As New DataTable
            Dim cb As New ClsProcedimientoAlmacenado("sp_PersonaListarTodos")
            oTabla = cb.EjecutarProcedimiento().Tables(0)
            Return oTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Agregar(ByVal Nombres As String, ByVal Apellidos As String, _
                        ByVal Nacimiento As Date, ByVal Foto As String, _
                        ByVal Tipo As Integer, ByVal Estado As Boolean)
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_PersonaGrabar")

            With proc
                .AgregarParametro("Nombres", Nombres)
                .AgregarParametro("Apellidos", Apellidos)
                .AgregarParametro("Nacimiento", Nacimiento)
                .AgregarParametro("Foto", Foto)
                .AgregarParametro("Tipo", Tipo)
                .AgregarParametro("Estado", Estado)
                .EjecutarProcedimiento()
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
            Dim proc As New ClsProcedimientoAlmacenado("sp_PersonaEditar")

            With proc
                .AgregarParametro("Per_Cod", Per_Cod)
                .AgregarParametro("Nombres", Nombres)
                .AgregarParametro("Apellidos", Apellidos)
                .AgregarParametro("Nacimiento", Nacimiento)
                .AgregarParametro("Foto", Foto)
                .AgregarParametro("Tipo", Tipo)
                .AgregarParametro("Estado", Estado)
                .EjecutarProcedimiento()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Cambiar_Estado(ByVal Per_Cod As Integer,Estado As Boolean)
        Try
            Dim proc As New ClsProcedimientoAlmacenado("sp_PersonaCambiarEstado")
            With proc
                .AgregarParametro("Per_Cod", Per_Cod)
                .AgregarParametro("Estado", Estado)
                .EjecutarProcedimiento()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
