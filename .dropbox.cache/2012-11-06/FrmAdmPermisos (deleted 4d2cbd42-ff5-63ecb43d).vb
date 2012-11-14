Public Class FrmAdmPermisos

    Private _codigo As Integer
    Private _perCodigo As Integer
    Private _perUsuario As String
    Private _perTipo As Integer
    Private _perNombres As String

    Dim oCuentas As New LogicaNegocio.ClsCuentas
    Dim oConst As New LogicaNegocio.ClsConstante

    Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub


    Sub New(ByVal perCodigo As Integer, ByVal perUsuario As String, ByVal perTipo As Integer, ByVal perNombres As String)
        InitializeComponent()
        Combo_condicion_Persona()

        ' TODO: Complete member initialization 
        _perCodigo = perCodigo
        _perUsuario = perUsuario
        _perTipo = perTipo
        _perNombres = perNombres

        Me.txtNombres.Text = _perNombres
        Me.cbTipoPersona.SelectedValue = _perTipo
        Me.txtUsuario.Text = _perUsuario
        Listar_aplicaciones_de_usuario()
    End Sub

    Public Sub Listar_aplicaciones_de_usuario()
        dgAplicaciones.DataSource = oCuentas.Listar_aplicaciones_por_Usuario(_perCodigo)
    End Sub


    Public Sub Combo_condicion_Persona()
        Try
            Dim oUsuario As New LogicaNegocio.ClsUsuario
            cbTipoPersona.DataSource = oConst.Condicion_Persona(1)
            cbTipoPersona.DisplayMember = "Nombre"
            cbTipoPersona.ValueMember = "Valor"
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Error al cargar datos al combo")
            Exit Sub
        End Try
    End Sub

    Private Sub FrmAdmPermisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim Resp As Integer
        Dim nPermiso As Boolean
        Dim ncont, ncount2 As Integer
        Dim nApp_Cod As Integer
        ncount2 = dgAplicaciones.RowCount - 1

        'Validar Formulario
        If Me.txtNombres.Text = Nothing Then
            MessageBox.Show("Falta Nombres")
            Exit Sub
        End If

        If Me.txtUsuario.Text = Nothing Then
            MessageBox.Show("Falta usuario")
            Exit Sub
        End If

        If Me.cbTipoPersona.SelectedValue = Nothing Then
            MessageBox.Show("Falta Tipo")
            Exit Sub
        End If



        Resp = MsgBox("" & vbCrLf & "Desea grabar los permisos concididos.", vbQuestion + vbYesNo + vbDefaultButton2, "Administrar Permisos")
        If Resp = 6 Then
            Try
                For ncont = 0 To ncount2

                    If dgAplicaciones.Item("Permiso", ncont).Value = True Then
                        nApp_Cod = CInt(dgAplicaciones.Item("CodigoApp", ncont).Value)
                        nPermiso = CBool(dgAplicaciones.Item("Permiso", ncont).Value)
                        oCuentas.Actualizar_PermisosUsuario(nApp_Cod, _perCodigo, nPermiso)
                        nApp_Cod = 0
                    End If
                Next
                MsgBox("Se Guardo Correctamente")
                Listar_aplicaciones_de_usuario()
            Catch ex As Exception
                MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Administrar Permisos")
                Exit Sub
            End Try
        Else
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnDefecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefecto.Click


        Dim ncont, ncount2 As Integer
        ncount2 = dgAplicaciones.RowCount - 1
        For ncont = 0 To ncount2
            dgAplicaciones.Item("Permiso", ncont).Value = False
        Next

    End Sub
End Class