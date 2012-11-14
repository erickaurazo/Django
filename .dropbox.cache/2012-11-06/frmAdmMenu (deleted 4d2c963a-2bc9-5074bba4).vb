Option Explicit On
Option Strict On
Public Class frmAdmMenu
    Dim oValidar As New Validar
    Dim oConst As New LogicaNegocio.ClsConstante
    Dim oApp As New LogicaNegocio.ClsAplicacion
    Dim Resp As Integer
    Dim contador As Integer
    Dim oEstado, aEstado2 As Boolean
    Dim aCodigo, aMenu As Integer
    Dim aNombre, aFormulario As String
    Dim aEstado As Boolean

    Private Sub frmAdmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Categoria_Menu()
        Me.gbDatosGenerales.Enabled = False
        Me.gbRegistros.Enabled = False
        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.btlEliminar.Enabled = False
        Me.BtnLimpiar.Enabled = False
        Me.BtnCancelar.Enabled = False
        Me.btnHabilitar.Enabled = False
        Listar()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Limpiar()
        Me.gbDatosGenerales.Enabled = True
        Me.gbRegistros.Enabled = True
        Me.btnBuscar.Enabled = False
        Me.BtnNuevo.Enabled = False
        Me.btnEditar.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btlEliminar.Enabled = True
        Me.BtnLimpiar.Enabled = True
        Me.BtnCancelar.Enabled = True
        Me.txtNombres.Enabled = True
        Me.cbTipoMenu.Focus()
        Listar()
    End Sub

    Public Sub Categoria_Menu()
        Try
            Dim oConst As New LogicaNegocio.ClsConstante
            cbTipoMenu.DataSource = oConst.Condicion_Persona(2)
            cbTipoMenu.DisplayMember = "Nombre"
            cbTipoMenu.ValueMember = "Valor"
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Error al cargar datos al combo")
            Exit Sub
        End Try
    End Sub

    Public Sub Listar()
        Me.dgRegistros.DataSource = oApp.Listar()
    End Sub

    Public Sub Limpiar()
        Me.txtFormulario.Clear()
        Me.txtNombres.Clear()
        Me.txtCodigo.Text = "Autogenerado"
        Me.cbTipoMenu.SelectedValue = 0
        Listar()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click


        If oValidar.oEditar = False Then
            If CStr(Me.txtFormulario.Text) = "" Then
                MessageBox.Show("Ingrese Nombre de Formulario")
                Exit Sub
            End If

            If CStr(txtNombres.Text) = "" Then
                MessageBox.Show("Ingrese Nombre de la aplicacion")
                Exit Sub
            End If

            If CInt(Me.cbTipoMenu.SelectedValue) = 0 Then
                MessageBox.Show("Seleccione Categoria del menú")
                Exit Sub
            End If

            aMenu = CInt(Me.cbTipoMenu.SelectedValue)
            aNombre = CStr(Me.txtNombres.Text)
            aFormulario = CStr(Me.txtFormulario.Text)
            aEstado = True


            Resp = MsgBox("" & vbCrLf & "¿Desea grabar los datos del registro?", CType(vbQuestion + vbYesNo + vbDefaultButton2, MsgBoxStyle), "Mantenimiento Persona")
            If Resp = 6 Then
                Try
                    oApp.Agregar(aNombre, aFormulario, aMenu, aEstado)
                Catch ex As Exception
                    MsgBox(ex.Source & "; " & ex.Message, Microsoft.VisualBasic.MsgBoxStyle.OkOnly, "Error al guardar Datos")
                    Exit Sub
                End Try
                MsgBox("Los datos han sido grabado correctamente")
                Listar()
            Else
            End If

        Else

            If CStr(Me.txtFormulario.Text) = "" Then
                MessageBox.Show("Ingrese Nombre de Formulario")
                Exit Sub
            End If

            If CStr(txtNombres.Text) = "" Then
                MessageBox.Show("Ingrese Nombre de la aplicacion")
                Exit Sub
            End If

            If CInt(Me.cbTipoMenu.SelectedValue) = 0 Then
                MessageBox.Show("Seleccione Categoria del menu")
                Exit Sub
            End If


            Try
                aCodigo = CInt(Me.txtCodigo.Text)
                aMenu = CInt(Me.cbTipoMenu.SelectedValue)
                aNombre = CStr(Me.txtNombres.Text)
                aFormulario = CStr(Me.txtFormulario.Text)
                aEstado = True
            Catch ex As Exception
                MsgBox(ex.Source & "; " & ex.Message, Microsoft.VisualBasic.MsgBoxStyle.OkOnly, "Error al guardar Datos")
                Exit Sub
            End Try

            Resp = MsgBox("" & vbCrLf & "¿Desea Modificar los cambios efectuados en el Registro?", CType(vbQuestion + vbYesNo + vbDefaultButton2, MsgBoxStyle), "Mantenimiento Persona")
            If Resp = 6 Then
                Try
                    oApp.Editar(aCodigo, aNombre, aFormulario, aMenu)
                Catch ex As Exception
                    MsgBox(ex.Source & "; " & ex.Message, Microsoft.VisualBasic.MsgBoxStyle.OkOnly, "Error al guardar Datos")
                    Exit Sub
                End Try
                MsgBox("Los datos han sido grabado correctamente")
                Listar()
            Else
            End If
        End If

        Me.gbDatosGenerales.Enabled = False
        Me.gbRegistros.Enabled = False
        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        oValidar.oEditar = True
        Me.gbDatosGenerales.Enabled = True
        Me.gbRegistros.Enabled = False
        Me.btnBuscar.Enabled = False
        Me.BtnNuevo.Enabled = False
        Me.btnEditar.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btlEliminar.Enabled = False
        Me.BtnLimpiar.Enabled = False
        Me.BtnCancelar.Enabled = True
        Me.txtNombres.Enabled = True
        Me.txtNombres.Focus()
    End Sub

    Private Sub btlEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btlEliminar.Click

        Resp = MsgBox("" & vbCrLf & "¿Desea Eliminar el Registro?", CType(vbQuestion + vbYesNo + vbDefaultButton2, MsgBoxStyle), "Mantenimiento Persona")
        If Resp = 6 Then
            Try
                oApp.Eliminar(CInt(Me.txtCodigo.Text))
            Catch ex As Exception
                MsgBox(ex.Source & "; " & ex.Message, Microsoft.VisualBasic.MsgBoxStyle.OkOnly, "Error al guardar Datos")
                Exit Sub
            End Try
            MsgBox("sen ha eliminado correctamente el Registro")
            Listar()
        Else
        End If

        Me.gbDatosGenerales.Enabled = False
        Me.gbRegistros.Enabled = False
        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.btlEliminar.Enabled = False
        Me.BtnLimpiar.Enabled = False
        Me.BtnCancelar.Enabled = True
        Limpiar()
        Listar()
    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        contador += 1
        If contador = 1 Then
            Limpiar()
            Me.gbDatosGenerales.Enabled = True
            Me.gbRegistros.Enabled = False
            Me.btnBuscar.Enabled = True
            Me.BtnNuevo.Enabled = False
            Me.btnEditar.Enabled = False
            Me.btnGuardar.Enabled = False
            Me.btlEliminar.Enabled = False
            Me.BtnLimpiar.Enabled = False
            Me.BtnCancelar.Enabled = True
            Me.btnHabilitar.Enabled = False
            Me.txtNombres.Enabled = False
            Me.txtFormulario.Focus()
        Else
            Me.dgRegistros.DataSource = oApp.Buscar(CStr(Me.txtFormulario.Text))
            Me.gbDatosGenerales.Enabled = False
            Me.gbRegistros.Enabled = True
            Me.btnBuscar.Enabled = False
            Me.BtnNuevo.Enabled = False
            Me.btnEditar.Enabled = True
            Me.btnGuardar.Enabled = False
            Me.btlEliminar.Enabled = True
            Me.BtnLimpiar.Enabled = False
            Me.BtnCancelar.Enabled = True
            Me.btnHabilitar.Enabled = True
            contador = 0
        End If


    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.gbDatosGenerales.Enabled = False
        Me.gbRegistros.Enabled = True
        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btlEliminar.Enabled = False
        Me.BtnLimpiar.Enabled = False
        Me.BtnCancelar.Enabled = False
        Limpiar()
    End Sub

    Private Sub dgRegistros_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRegistros.CellClick
        Me.txtCodigo.Text = CStr(Me.dgRegistros.CurrentRow.Cells(0).Value)
        Me.txtNombres.Text = CStr(Me.dgRegistros.CurrentRow.Cells(1).Value)
        Me.txtFormulario.Text = CStr(Me.dgRegistros.CurrentRow.Cells(2).Value)
        Me.cbTipoMenu.SelectedValue = CInt(Me.dgRegistros.CurrentRow.Cells(3).Value)
        oEstado = CBool(Me.dgRegistros.CurrentRow.Cells(5).Value)
        If oEstado = True Then
            aEstado2 = False
        Else
            aEstado2 = True
        End If

    End Sub

    Private Sub btnHabilitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHabilitar.Click

        Resp = MsgBox("" & vbCrLf & "¿Desea Cambiar el Estado del Registro?", CType(vbQuestion + vbYesNo + vbDefaultButton2, MsgBoxStyle), "Mantenimiento Persona")
        If Resp = 6 Then
            Try
                oApp.Habilitar(CInt(Me.txtCodigo.Text), aEstado2)
            Catch ex As Exception
                MsgBox(ex.Source & "; " & ex.Message, Microsoft.VisualBasic.MsgBoxStyle.OkOnly, "Error al guardar Datos")
                Exit Sub
            End Try
            MsgBox("sen ha eliminado correctamente el Registro")
            Listar()
        Else
        End If

        Me.gbDatosGenerales.Enabled = False
        Me.gbRegistros.Enabled = False
        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.btlEliminar.Enabled = False
        Me.BtnLimpiar.Enabled = False
        Me.BtnCancelar.Enabled = True
        Me.btnHabilitar.Enabled = False
        Limpiar()
        Listar()
    End Sub
End Class