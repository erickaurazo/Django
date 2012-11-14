Public Class FrmLogin

    Dim oLog As New LogicaNegocio.ClsLogin
    Dim xU, xA As Integer
    Public Codigo, Tipo As Integer
    Public Usuario, Nombres As String


    Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        xU = 0
        xA = 0
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        'Validar que siempre se ingresen datos al logearse
        If Me.utxtUsuario.Text = "" Then
            MsgBox("Falta Ingresar Nombre de Usuario", MsgBoxStyle.Information, " Usuario")
            Exit Sub
        End If

        If Me.ptxtClave.Text = "" Then
            MsgBox("Falta Ingresar Clave de Usuario", MsgBoxStyle.Information, " Contraseña")
            Exit Sub
        End If

        'Asignamos para que todo ingreso lo convierta a cadena y en minusculas
        Dim tUsuario, tClave As String
        tUsuario = CStr(Me.utxtUsuario.Text).ToLower
        tClave = CStr(Me.ptxtClave.Text).ToLower

        'creamos un nuevo objeto de la clase datatable para obtener al usuario logeado
        Dim tbLog As New DataTable
        tbLog = oLog.Identificar_Alumno(tUsuario, tClave)

        'Cuando no hay ningun usuario registrado con el nombre y usuario
        If tbLog.Rows.Count = 0 Then
            MsgBox("Usuario o Clave incorrecta" & Chr(10) & "Le quedan " & 3 - xU & " intentos", MsgBoxStyle.Critical)
            xU = xU + 1
            If xU = 4 Then
                MsgBox("El sistema se cerrara por seguridad", MsgBoxStyle.Exclamation, " Inicio de Sesión")
                Me.Close()
            End If
            Exit Sub
        End If

        'Si el usuario se encuentre logeado correctamente se comprobará el tipo de persona que es,
        'si es estudiante o administrativo
        If tbLog.Rows.Count > 0 Then
            Select Case tbLog.Rows(0)(3)

                Case 1
                    Codigo = tbLog.Rows(0)(0)
                    Nombres = tbLog.Rows(0)(1) & " " & tbLog.Rows(0)(2)
                    Tipo = tbLog.Rows(0)(3)
                    Usuario = tbLog.Rows(0)(4)

                    Dim Sistema As New MDIMenu(Codigo, Nombres, Usuario, Tipo)
                    Sistema.ShowDialog()
                    Me.Close()
                    MsgBox("Bienvenido al Sistema", MsgBoxStyle.Information, "Mensaje")

                Case 2
                    Codigo = tbLog.Rows(0)(0)
                    Nombres = tbLog.Rows(0)(1) & " " & tbLog.Rows(0)(2)
                    Tipo = tbLog.Rows(0)(3)
                    Usuario = tbLog.Rows(0)(4)

                    Dim Sistema As New MDIMenu(Codigo, Nombres, Usuario, Tipo)
                    Sistema.ShowDialog()
                    Me.Close()
                    MsgBox("Bienvenido al Sistema", MsgBoxStyle.Information, "Mensaje")

                Case 3
                    Codigo = tbLog.Rows(0)(0)
                    Nombres = tbLog.Rows(0)(1) & " " & tbLog.Rows(0)(2)
                    Tipo = tbLog.Rows(0)(3)
                    Usuario = tbLog.Rows(0)(4)

                    Dim Sistema As New MDIMenu(Codigo, Nombres, Usuario, Tipo)
                    Sistema.ShowDialog()
                    Me.Close()
                    MsgBox("Bienvenido al Sistema", MsgBoxStyle.Information, "Mensaje")

                Case 4
                    Codigo = tbLog.Rows(0)(0)
                    Nombres = tbLog.Rows(0)(1) & " " & tbLog.Rows(0)(2)
                    Tipo = tbLog.Rows(0)(3)
                    Usuario = tbLog.Rows(0)(4)

                    Dim Sistema As New MDIMenu(Codigo, Nombres, Usuario, Tipo)
                    Sistema.ShowDialog()
                    Me.Close()
                    MsgBox("Bienvenido al Sistema", MsgBoxStyle.Information, "Mensaje")

                Case 5
                    Codigo = tbLog.Rows(0)(0)
                    Nombres = tbLog.Rows(0)(1) & " " & tbLog.Rows(0)(2)
                    Tipo = tbLog.Rows(0)(3)
                    Usuario = tbLog.Rows(0)(4)

                    Dim Sistema As New MDIMenu(Codigo, Nombres, Usuario, Tipo)
                    MsgBox("Bienvenido al Sistema", MsgBoxStyle.Information, "Mensaje")
                    Sistema.ShowDialog()
                    Me.Close()

            End Select
        Else
            MsgBox("Usuario o Clave incorrecta" & Chr(10) & "Le quedan " & 3 - xU & " intentos", MsgBoxStyle.Critical)
            xU = xU + 1
            If xU = 4 Then
                MsgBox("El sistema se cerrara por seguridad", MsgBoxStyle.Exclamation)
                Me.Close()
            End If
        End If
        'Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.utxtUsuario.Clear()
        Me.ptxtClave.Clear()
    End Sub

End Class
