Option Explicit On
Option Strict On
Imports System.Data.SqlClient

Public Class FrmCurso
    Dim oMod As New LogicaNegocio.ClsCurso
    Dim oEditar As Boolean
    Dim oCod, i As Integer
    Dim oValidar As New Validar

    Public Sub Limpiar()
        Me.txtCodigo.Clear()
        Me.txtCreditos.Clear()
        Me.txtCurso.Clear()
        Me.txtdesc.Clear()
        Me.txtUnidades.Clear()
        Me.cbModulo.SelectedValue = 1
        Me.dgRegistro.DataSource = ""
    End Sub

    Public Sub Mostrar()
        Me.dgRegistro.DataSource = oMod.Listar()
    End Sub

    'combobox Ciclo
    Public Sub Ciclo()
        Try
            RemoveHandler cbCiclo.SelectedValueChanged, AddressOf cbCiclo_SelectedValueChanged
            Dim oMat As New LogicaNegocio.Matricula
            Me.cbCiclo.DataSource = oMat.cb_Ciclo
            Me.cbCiclo.DisplayMember = "Ciclo_desc"
            Me.cbCiclo.ValueMember = "Ciclo_Cod"
            AddHandler cbCiclo.SelectedValueChanged, AddressOf cbCiclo_SelectedValueChanged
        Catch ex As Exception
            Throw ex
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro")

        End Try
    End Sub

    'combobox modulo
    Public Sub cb_Modulo()
        Try
            Dim oCur As New LogicaNegocio.ClsCurso
            Me.cbModulo.DataSource = oCur.cb_Modulo(CInt(Me.cbEspecialidad.SelectedValue), CInt(Me.cbCiclo.SelectedValue))
            Me.cbModulo.DisplayMember = "Nombre"
            Me.cbModulo.ValueMember = "Modulo_Cod"
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro")
        End Try
    End Sub

    Private Sub cbCiclo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCiclo.SelectedValueChanged
        Try
            Dim oCur As New LogicaNegocio.ClsCurso
            Me.cbModulo.DataSource = oCur.cb_Modulo(CInt(Me.cbEspecialidad.SelectedValue), CInt(Me.cbCiclo.SelectedValue))
            Me.cbModulo.DisplayMember = "Nombre"
            Me.cbModulo.ValueMember = "Modulo_Cod"
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro")
        End Try

    End Sub

    'combobox Especialidad
    Public Sub Especialidad()
        Try
            Dim oEsp As New LogicaNegocio.Matricula
            Me.cbEspecialidad.DataSource = oEsp.Cb_Especialidad
            Me.cbEspecialidad.DisplayMember = "Esp_Nombre"
            Me.cbEspecialidad.ValueMember = "Especialidad_Cod"
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Especialidad")

        End Try

    End Sub

    Public Sub Inicio()
        Me.txtCodigo.Enabled = False
        Me.txtCreditos.Enabled = False
        Me.txtCurso.Enabled = False
        Me.txtdesc.Enabled = False
        Me.txtSemanal.Enabled = False
        Me.txtUnidades.Enabled = False
        Me.cbModulo.Enabled = False

        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = False
        Me.BtnInhabilitar.Enabled = False
        Me.btnHabilitar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.BtnGrabar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnBuscar.Enabled = True

    End Sub

    Private Sub BtnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnListar.Click
        Limpiar()
        Me.txtCodigo.Enabled = False
        Me.txtCreditos.Enabled = False
        Me.txtCurso.Enabled = False
        Me.txtdesc.Enabled = False
        Me.txtSemanal.Enabled = False
        Me.txtUnidades.Enabled = False
        Me.cbModulo.Enabled = False

        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = True
        Me.BtnInhabilitar.Enabled = True
        Me.btnHabilitar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.BtnGrabar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnBuscar.Enabled = True
        Mostrar()
    End Sub

    Private Sub FrmCurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cb_Modulo()
        Especialidad()
        Ciclo()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Limpiar()
        Me.txtCodigo.Enabled = True
        Me.txtCreditos.Enabled = True
        Me.txtCurso.Enabled = True
        Me.txtdesc.Enabled = True
        Me.txtSemanal.Enabled = True
        Me.txtUnidades.Enabled = True
        Me.cbModulo.Enabled = True

        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = False
        Me.BtnInhabilitar.Enabled = False
        Me.btnHabilitar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.BtnGrabar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnBuscar.Enabled = False


    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        oEditar = True
        Me.txtCodigo.Enabled = False
        Me.txtCreditos.Enabled = True
        Me.txtCurso.Enabled = True
        Me.txtdesc.Enabled = True
        Me.txtSemanal.Enabled = True
        Me.txtUnidades.Enabled = True
        Me.cbModulo.Enabled = True

        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = False
        Me.BtnInhabilitar.Enabled = False
        Me.btnHabilitar.Enabled = False
        Me.btnEliminar.Enabled = True
        Me.BtnGrabar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnBuscar.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            oCod = CInt(dgRegistro.CurrentRow.Cells(0).Value)
            oMod.Eliminar(oCod)
            Mostrar()
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro")
        End Try
        Limpiar()
        Me.txtCodigo.Enabled = False
        Me.txtCreditos.Enabled = False
        Me.txtCurso.Enabled = False
        Me.txtdesc.Enabled = False
        Me.txtSemanal.Enabled = False
        Me.txtUnidades.Enabled = False
        Me.cbModulo.Enabled = False

        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = False
        Me.BtnInhabilitar.Enabled = True
        Me.btnHabilitar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.BtnGrabar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnBuscar.Enabled = False
        Mostrar()
    End Sub

    Private Sub btnHabilitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHabilitar.Click
        Try
            oCod = CInt(Me.txtCodigo.Text)
            oMod.Habilitar(oCod)
            Mostrar()
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Error en Habilitar")
        End Try
        Limpiar()
        Me.txtCodigo.Enabled = False
        Me.txtCreditos.Enabled = False
        Me.txtCurso.Enabled = False
        Me.txtdesc.Enabled = False
        Me.txtSemanal.Enabled = False
        Me.txtUnidades.Enabled = False
        Me.cbModulo.Enabled = False

        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = True
        Me.BtnInhabilitar.Enabled = True
        Me.btnHabilitar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.BtnGrabar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnBuscar.Enabled = False
        Mostrar()
    End Sub

    Private Sub BtnInhabilitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInhabilitar.Click
        Try
            oCod = CInt(Me.txtCodigo.Text)
            oMod.Inhabilitar(oCod)
            Mostrar()
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro")
        End Try
        Limpiar()
        Me.txtCodigo.Enabled = False
        Me.txtCreditos.Enabled = False
        Me.txtCurso.Enabled = False
        Me.txtdesc.Enabled = False
        Me.txtSemanal.Enabled = False
        Me.txtUnidades.Enabled = False
        Me.cbModulo.Enabled = False

        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = True
        Me.BtnInhabilitar.Enabled = True
        Me.btnHabilitar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.BtnGrabar.Enabled = False
        Me.btnCancelar.Enabled = False

        Mostrar()
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        Dim _Nombre, _Desc As String
        Dim _Modulo, _Semanal, _Unidad, _Creditos, _Codigo As Integer

        _Modulo = CInt(Me.cbModulo.SelectedValue)
        _Nombre = CStr(Me.txtCurso.Text)
        _Desc = CStr(Me.txtdesc.Text)
        _Semanal = CInt(Me.txtSemanal.Text)
        _Unidad = CInt(Me.txtUnidades.Text)
        _Creditos = CInt(Me.txtCreditos.Text)

        '-- Editar
        If oEditar = True Then
            Try
                _Codigo = CInt(Me.txtCodigo.Text)
                With oMod
                    ._Codigo = _Codigo
                    ._Modulo = _Modulo
                    ._Nombre = _Nombre
                    ._Desc = _Desc
                    ._Semanales = _Semanal
                    ._Unidades = _Unidad
                    ._Creditos = _Creditos
                    .Editar()
                End With
            Catch ex As Exception
                Throw ex
                MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro")

            End Try
            Mostrar()
        Else
            Try
                With oMod
                    ._Modulo = _Modulo
                    ._Nombre = _Nombre
                    ._Desc = _Desc
                    ._Semanales = _Semanal
                    ._Unidades = _Unidad
                    ._Creditos = _Creditos
                    ._Estado = True
                    .Agregar()
                End With
            Catch ex As Exception
                MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro")
            End Try
            Mostrar()
        End If

        Me.txtCodigo.Enabled = False
        Me.txtCreditos.Enabled = False
        Me.txtCurso.Enabled = False
        Me.txtdesc.Enabled = False
        Me.txtSemanal.Enabled = False
        Me.txtUnidades.Enabled = False
        Me.cbModulo.Enabled = False

        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = True
        Me.BtnInhabilitar.Enabled = True
        Me.btnHabilitar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.BtnGrabar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnBuscar.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Limpiar()
        Me.txtCodigo.Enabled = False
        Me.txtCreditos.Enabled = False
        Me.txtCurso.Enabled = False
        Me.txtdesc.Enabled = False
        Me.txtSemanal.Enabled = False
        Me.txtUnidades.Enabled = False
        Me.cbModulo.Enabled = False

        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = False
        Me.BtnInhabilitar.Enabled = False
        Me.btnHabilitar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.BtnGrabar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnBuscar.Enabled = True
    End Sub

    Private Sub txtCreditos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCreditos.KeyPress
        oValidar.ValidarEnteros(e)
    End Sub

    Private Sub txtCurso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCurso.KeyPress
        oValidar.ValidarLetras(e)
    End Sub

    Private Sub txtSemanal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSemanal.KeyPress
        oValidar.ValidarEnteros(e)
    End Sub

    Private Sub txtUnidades_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnidades.KeyPress
        oValidar.ValidarEnteros(e)
    End Sub

    Private Sub dgRegistro_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRegistro.CellClick
        Me.txtCodigo.Text = CStr(Me.dgRegistro.CurrentRow.Cells(0).Value)
        Me.cbModulo.SelectedValue = CInt(Me.dgRegistro.CurrentRow.Cells(1).Value)
        Me.txtCurso.Text = CStr(Me.dgRegistro.CurrentRow.Cells(3).Value)
        Me.txtdesc.Text = CStr(Me.dgRegistro.CurrentRow.Cells(4).Value)
        Me.txtSemanal.Text = CStr(CInt(Me.dgRegistro.CurrentRow.Cells(5).Value))
        Me.txtUnidades.Text = CStr(Me.dgRegistro.CurrentRow.Cells(6).Value)
        Me.txtCreditos.Text = CStr(Me.dgRegistro.CurrentRow.Cells(7).Value)
        Me.cbEspecialidad.SelectedValue = CInt(Me.dgRegistro.CurrentRow.Cells(9).Value)
        Me.cbCiclo.SelectedValue = CInt(Me.dgRegistro.CurrentRow.Cells(10).Value)
    End Sub

End Class