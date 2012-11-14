Public Class frmAdmCuenta
    Dim oConst As New LogicaNegocio.ClsConstante
    Dim oUsu As New LogicaNegocio.ClsUsuario
    Dim oCuentas As New LogicaNegocio.ClsCuentas

    Private _perCodigo As Integer
    Private _perUsuario As String
    Private _perTipo As Integer
    Private _perNombres As String
    Dim optGrabar As Boolean
    Dim Resp As Integer


    Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Sub New(ByVal perCodigo As Integer, ByVal perUsuario As String, ByVal perTipo As Integer, ByVal perNombres As String)
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        cb_CondicionPersona()

        ' TODO: Complete member initialization 
        _perCodigo = perCodigo
        _perUsuario = perUsuario
        _perTipo = perTipo
        _perNombres = perNombres


        '- asignar lso valores del constructor a las cajas y cb
        Me.txtCodigo.Text = _perCodigo
        Me.txtUsuario.Text = _perUsuario
        Me.cbCondicion.SelectedValue = _perTipo
        Me.txtNombreCompleto.Text = _perNombres


        'Si es nuevo activar el boton nuevo y desactivar editar
        If Me.txtUsuario.Text = "No Asignado" Then
            Me.btnEdicion.Enabled = False
            Me.btnNuevo.Enabled = True
        Else
            Me.btnEdicion.Enabled = True
            Me.btnNuevo.Enabled = False

        End If

    End Sub

    Private Sub frmAdmCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    'Cargar ComboBox TipoPersona
    Public Sub cb_CondicionPersona()
        Try
            Dim oUsuario As New LogicaNegocio.ClsUsuario
            cbCondicion.DataSource = oConst.Condicion_Persona(1)
            cbCondicion.DisplayMember = "Nombre"
            cbCondicion.ValueMember = "Valor"
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Error al cargar datos al combo")
            Exit Sub
        End Try
    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        optGrabar = True
        Me.txtNomClave.Enabled = True
        Me.txtNomUsuario.Enabled = True
        Me.btnGrabar.Enabled = True

        Me.txtNomUsuario.Focus()
    End Sub

    Private Sub btnEdicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdicion.Click
        optGrabar = False

        Me.txtNomClave.Enabled = True
        Me.btnGrabar.Enabled = True

        Dim tabla As New DataTable
        tabla = oUsu.Listar_por_Codigo(_perCodigo)

        Me.txtNomUsuario.Text = tabla.Rows(0).Item(0)
        Me.txtNomClave.Text = tabla.Rows(0).Item(1)

    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim svCodigo As Integer
        Dim svClave As String
        Dim svUsuario As String

        'Si es para editar
        If optGrabar = False Then

            If Me.txtNomClave.Text = "" Then
                MsgBox("Ingrese clave")
                Exit Sub
            End If

            svCodigo = _perCodigo
            svClave = CStr(Me.txtNomClave.Text)

            Resp = MsgBox("" & vbCrLf & "¿Desea grabar?", CType(vbQuestion + vbYesNo + vbDefaultButton2, MsgBoxStyle), "Administrar Cuenta")
            If Resp = 6 Then
                Try
                    oUsu.Actualizar_Clave(svCodigo, svClave)
                Catch ex As Exception
                    MsgBox(ex.Source & "; " & ex.Message, Microsoft.VisualBasic.MsgBoxStyle.OkOnly, "Error al guardar Datos")
                    Exit Sub
                End Try
                MsgBox("Se ha actualizado correctamente la contraseña")
            End If

            Me.btnGrabar.Enabled = False
            Me.txtNomClave.Enabled = False
        Else
            'si es para una nueva cuenta

            If Me.txtNomClave.Text = "" Then
                MsgBox("Ingrese clave")
                Exit Sub
            End If

            If Me.txtNomClave.Text = "" Then
                MsgBox("Ingrese Nombre de Usuario")
                Exit Sub
            End If


            svCodigo = _perCodigo
            svClave = CStr(Me.txtNomClave.Text)
            svUsuario = CStr(Me.txtNomUsuario.Text)

            Resp = MsgBox("" & vbCrLf & "¿Desea grabar?", CType(vbQuestion + vbYesNo + vbDefaultButton2, MsgBoxStyle), "Administrar Cuenta")
            If Resp = 6 Then
                'Comprobar la existencia de la nueva cuenta

                Dim tabla As DataTable
                tabla = oUsu.Comprobar_duplicidad_de_Usuario(_perCodigo, svUsuario)

                If tabla.Rows(0).Item(0) = 0 Then
                    oUsu.Insertar_nuevo_Usuario(svCodigo, svUsuario, svClave)
                    MessageBox.Show("Usuario registrado correctamente")


                    Dim tbPermiso As DataTable
                    tbPermiso = oCuentas.Listar_Aplicaciones()
                    Dim ncont, ncount2, nPermiso As Integer
                    ncount2 = tbPermiso.Rows.Count - 1

                    For ncont = 0 To ncount2
                        nPermiso = CInt((tbPermiso.Rows(ncont).Item(0)))
                        oCuentas.Grabar_PermisosUsuario(nPermiso, _perCodigo, False)
                        'nPermiso = 0
                    Next
                    MsgBox("Se Guardo Correctamente todos los permisos por defecto")


                    Me.txtUsuario.Text = svUsuario
                    Me.btnGrabar.Enabled = False
                    Me.txtNomClave.Enabled = False
                    Me.txtNomUsuario.Enabled = False
                    Me.btnNuevo.Enabled = False
                    Me.btnEdicion.Enabled = True

                Else
                    MessageBox.Show("Ya existe un usuario Registrado, Intente con otro nombre de Usuario")
                    Me.txtNomClave.Clear()
                    Me.txtNomUsuario.Focus()
                    Exit Sub
                End If

            Else
            End If

        End If
       
    End Sub





End Class