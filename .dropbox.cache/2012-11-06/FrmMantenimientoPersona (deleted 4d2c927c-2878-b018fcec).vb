Option Explicit On
Option Strict On
Public Class FrmMantenimientoPersona
    Dim Oobj As New LogicaNegocio.ClsPersona
    Dim oConst As New LogicaNegocio.ClsConstante
    Dim oUsuario As New LogicaNegocio.ClsUsuario
    Dim oValidar As New Validar
    Dim Resp As Integer

    Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        cb_CondicionPersona()
        ListarRegistros()
        Me.gbDatosGenerales.Enabled = False
        Me.gbRegistros.Enabled = True
        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnSalir.Enabled = True
        Me.btnEditar.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btlEliminar.Enabled = False
        Me.BtnLimpiar.Enabled = False
        Me.BtnCancelar.Enabled = False
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    'Cargar ComboBox TipoPersona
    Public Sub cb_CondicionPersona()
        Try
            cbTipoPersona.DataSource = oConst.Condicion_Persona(1)
            cbTipoPersona.DisplayMember = "Nombre"
            cbTipoPersona.ValueMember = "Valor"
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Error al cargar datos al combo")
            Exit Sub
        End Try
    End Sub

    Private Sub FrmMantenimientoPersona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim aNombres, aApellidos, aFoto As String
        Dim aNacimiento As Date
        Dim aTipo As Integer
        Dim aCodigo As Integer

        If oValidar.oEditar = False Then
            If CStr(Me.txtApellidos.Text) = "" Then
                MessageBox.Show("Ingrese Apellidos")
                Exit Sub
            End If

            If CStr(txtNombres.Text) = "" Then
                MessageBox.Show("Ingrese Nombres")
                Exit Sub
            End If

            If CInt(Me.cbTipoPersona.SelectedValue) = 0 Then
                MessageBox.Show("Seleccione Condicion")
                Exit Sub
            End If

            If Me.cbTipoPersona.SelectedValue Is Nothing Then
                MessageBox.Show("Seleccione Condicion")
                Exit Sub
            End If
            aNombres = CStr(Me.txtApellidos.Text)
            aApellidos = CStr(txtNombres.Text)
            aNacimiento = Me.fecNacimiento.Value
            aFoto = "Hola"
            aTipo = CInt(Me.cbTipoPersona.SelectedValue)

            Resp = MsgBox("" & vbCrLf & "¿Desea grabar?", CType(vbQuestion + vbYesNo + vbDefaultButton2, MsgBoxStyle), "Mantenimiento Persona")
            If Resp = 6 Then
                Try
                    Me.Oobj.Agregar(aNombres, aApellidos, aNacimiento, aFoto, aTipo, True)
                Catch ex As Exception
                    MsgBox(ex.Source & "; " & ex.Message, Microsoft.VisualBasic.MsgBoxStyle.OkOnly, "Error al guardar Datos")
                    Exit Sub
                End Try
                MsgBox("Los datos han sido grabado correctamente")
                ListarRegistros()
            Else
            End If

        Else

            If CStr(Me.txtApellidos.Text) = "" Then
                MessageBox.Show("Ingrese Apellidos")
                Exit Sub
            End If

            If CStr(txtNombres.Text) = "" Then
                MessageBox.Show("Ingrese Nombres")
                Exit Sub
            End If

            If CInt(Me.cbTipoPersona.SelectedValue) = 0 Then
                MessageBox.Show("Seleccione Condicion")
                Exit Sub
            End If

            If Me.cbTipoPersona.SelectedValue Is Nothing Then
                MessageBox.Show("Seleccione Condicion")
                Exit Sub
            End If

            Try
                aCodigo = CInt(Me.txtCodigo.Text)
                aNombres = CStr(Me.txtApellidos.Text)
                aApellidos = CStr(txtNombres.Text)
                aNacimiento = Me.fecNacimiento.Value
                aFoto = "Hola"
                aTipo = CInt(Me.cbTipoPersona.SelectedValue)
            Catch ex As Exception
                MsgBox(ex.Source & "; " & ex.Message, Microsoft.VisualBasic.MsgBoxStyle.OkOnly, "Error al guardar Datos")
                Exit Sub
            End Try



            Resp = MsgBox("" & vbCrLf & "¿Desea guardar los cambios efecttuados?", CType(vbQuestion + vbYesNo + vbDefaultButton2, MsgBoxStyle), "Mantenimiento Persona")
            If Resp = 6 Then
                Try
                    Me.Oobj.Editar(aCodigo, aNombres, aApellidos, aNacimiento, aFoto, aTipo, True)
                Catch ex As Exception
                    MsgBox(ex.Source & "; " & ex.Message, Microsoft.VisualBasic.MsgBoxStyle.OkOnly, "Error al guardar Datos")
                    Exit Sub
                End Try
                MsgBox("Los datos han sido grabado correctamente")
                ListarRegistros()
            Else
            End If
        End If

            Me.gbDatosGenerales.Enabled = False
            Me.gbRegistros.Enabled = True
            Me.btnBuscar.Enabled = True
            Me.BtnNuevo.Enabled = True
            Me.btnSalir.Enabled = True
        Me.btnEditar.Enabled = True
            Me.btnGuardar.Enabled = False
            Me.btlEliminar.Enabled = False
            Me.BtnLimpiar.Enabled = False
        Me.BtnCancelar.Enabled = True

            LimpiarFormulario()

    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        ovalidar.ValidarLetras(e)

    End Sub

    Private Sub txtApellidos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidos.KeyPress
        ovalidar.ValidarLetras(e)
    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        LimpiarFormulario()
    End Sub

    Public Sub LimpiarFormulario()
        Me.txtNombres.Clear()
        Me.txtCodigo.Clear()
        Me.txtUsuario.Clear()
        Me.txtCodigo.Text = "Autogenerado"
        Me.txtUsuario.Text = "No asignado"
        Me.txtApellidos.Clear()
        Me.cbTipoPersona.SelectedValue = 0
        Me.picPersona.Image = Nothing
        Me.fecNacimiento.Value = Today
        Me.txtNombres.Focus()
    End Sub

    Public Sub ListarRegistros()
        Me.dgRegistros.DataSource = Me.Oobj.Listar_Todos()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        LimpiarFormulario()
        Me.gbDatosGenerales.Enabled = True
        Me.gbRegistros.Enabled = True
        Me.btnBuscar.Enabled = False
        Me.BtnNuevo.Enabled = False
        Me.btnSalir.Enabled = True
        Me.btnEditar.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btlEliminar.Enabled = False
        Me.BtnLimpiar.Enabled = True
        Me.BtnCancelar.Enabled = True
        Me.txtNombres.Focus()

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        oValidar.oEditar = True

        Me.gbDatosGenerales.Enabled = True
        Me.gbRegistros.Enabled = False
        Me.btnBuscar.Enabled = False
        Me.BtnNuevo.Enabled = False
        Me.btnSalir.Enabled = True
        Me.btnEditar.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btlEliminar.Enabled = True
        Me.BtnLimpiar.Enabled = False
        Me.BtnCancelar.Enabled = True
        Me.txtNombres.Focus()
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.gbDatosGenerales.Enabled = False
        Me.gbRegistros.Enabled = True
        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnSalir.Enabled = True
        Me.btnEditar.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btlEliminar.Enabled = False
        Me.BtnLimpiar.Enabled = False
        Me.BtnCancelar.Enabled = False
        LimpiarFormulario()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Resp = MsgBox("" & vbCrLf & "¿Desea salir?", CType(vbQuestion + vbYesNo + vbDefaultButton2, MsgBoxStyle), "Mantenimiento Persona")
        If Resp = 6 Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Me.gbDatosGenerales.Enabled = True
        Me.gbRegistros.Enabled = True
        Me.btnBuscar.Enabled = False
        Me.BtnNuevo.Enabled = False
        Me.btnSalir.Enabled = True
        Me.btnEditar.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btlEliminar.Enabled = False
        Me.BtnLimpiar.Enabled = False
        Me.BtnCancelar.Enabled = True
    End Sub

    Private Sub dgRegistros_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRegistros.CellClick

        Me.txtCodigo.Text = CStr(Me.dgRegistros.CurrentRow.Cells(0).Value)

        If dgRegistros.CurrentRow.Cells(1).Value Is DBNull.Value Then
            Me.txtUsuario.Text = "No asignado"
        Else
            Me.txtUsuario.Text = CStr(Me.dgRegistros.CurrentRow.Cells(1).Value)
        End If

        Me.txtNombres.Text = CStr(Me.dgRegistros.CurrentRow.Cells(2).Value)
        Me.txtApellidos.Text = CStr(Me.dgRegistros.CurrentRow.Cells(3).Value)
        Me.cbTipoPersona.SelectedValue = CInt(Me.dgRegistros.CurrentRow.Cells(4).Value)
        Me.fecNacimiento.Value = CDate(Me.dgRegistros.CurrentRow.Cells(7).Value)

    End Sub


    Private Sub btlEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btlEliminar.Click

    End Sub


End Class