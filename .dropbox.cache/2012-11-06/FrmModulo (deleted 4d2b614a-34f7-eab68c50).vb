Option Explicit On
Option Strict On
Public Class FrmModulo
    Dim oMod As New LogicaNegocio.ClsModulo
    Dim oEditar As Boolean
    Dim oCod As Integer

    Private Sub FrmModulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicio()
        Ciclo()
        Especialidad()
        Mostrar()
    End Sub

    Public Sub Limpiar()
        Me.txtCodigo.Text = "Autogenerado"
        Me.txtTitulo.Clear()
        Me.txtTitulo.Focus()
        Me.txtNombre.Clear()
        Me.txtDuracion.Clear()
        Me.txtUnidades.Clear()
        Me.cbCiclo.SelectedValue = 1
        Me.cbEspecialidad.SelectedValue = 1
        Mostrar()
    End Sub

    Public Sub Mostrar()
        Me.dgRegistro.DataSource = oMod.Listar()
    End Sub

    'combobox ciclo
    Public Sub Ciclo()
        Try
            Dim oMat As New LogicaNegocio.Matricula
            Me.cbCiclo.DataSource = oMat.cb_Ciclo
            Me.cbCiclo.DisplayMember = "Ciclo_desc"
            Me.cbCiclo.ValueMember = "Ciclo_Cod"
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
        Me.txtNombre.Enabled = False
        Me.txtDuracion.Enabled = False
        Me.txtTitulo.Enabled = False
        Me.txtUnidades.Enabled = False
        Me.cbCiclo.Enabled = False
        Me.cbEspecialidad.Enabled = False

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

    Private Sub btnListar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
        Limpiar()
        Me.txtNombre.Enabled = False
        Me.txtDuracion.Enabled = False
        Me.txtTitulo.Enabled = False
        Me.txtUnidades.Enabled = False
        Me.cbCiclo.Enabled = False
        Me.cbEspecialidad.Enabled = False

        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = True
        Me.BtnInhabilitar.Enabled = True
        Me.btnHabilitar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnGrabar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnBuscar.Enabled = True
        Mostrar()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Limpiar()
        Me.txtTitulo.Enabled = True
        Me.txtTitulo.Focus()
        Me.txtNombre.Enabled = True
        Me.txtDuracion.Enabled = True
        Me.txtUnidades.Enabled = True
        Me.cbCiclo.Enabled = True
        Me.cbEspecialidad.Enabled = True

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
        Me.txtNombre.Enabled = True
        Me.txtDuracion.Enabled = True
        Me.txtTitulo.Enabled = True
        Me.txtUnidades.Enabled = True
        Me.cbCiclo.Enabled = True
        Me.cbEspecialidad.Enabled = True
        Me.dgRegistro.Enabled = True

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
        Me.txtNombre.Enabled = False
        Me.txtDuracion.Enabled = False
        Me.txtTitulo.Enabled = False
        Me.txtUnidades.Enabled = False
        Me.cbCiclo.Enabled = False
        Me.cbEspecialidad.Enabled = False

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
        Me.txtNombre.Enabled = False
        Me.txtDuracion.Enabled = False
        Me.txtTitulo.Enabled = False
        Me.txtUnidades.Enabled = False
        Me.cbCiclo.Enabled = False
        Me.cbEspecialidad.Enabled = False

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

    Private Sub BtnInhabilitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInhabilitar.Click
        Try
            oCod = CInt(Me.txtCodigo.Text)
            oMod.Inhabilitar(oCod)
            Mostrar()
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro")
        End Try
        Limpiar()
        Me.txtNombre.Enabled = False
        Me.txtDuracion.Enabled = False
        Me.txtTitulo.Enabled = False
        Me.txtUnidades.Enabled = False
        Me.cbCiclo.Enabled = False
        Me.cbEspecialidad.Enabled = False

        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = False
        Me.BtnInhabilitar.Enabled = True
        Me.btnHabilitar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.BtnGrabar.Enabled = False
        Me.btnCancelar.Enabled = False

        Mostrar()
    End Sub

    Private Sub btnGrabar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim _Nombre, _Titulo, _Unidad As String
        Dim _Ciclo, _Especialidad, _Duracion As Integer
        _Nombre = CStr(Me.txtNombre.Text)
        _Titulo = CStr(Me.txtTitulo.Text)
        _Unidad = CStr(Me.txtUnidades.Text)
        _Duracion = CInt(Me.txtDuracion.Text)
        _Ciclo = CInt(Me.cbCiclo.SelectedValue)
        _Especialidad = CInt(Me.cbEspecialidad.SelectedValue)

        '-- Editar
        If oEditar = True Then
            Try
                With oMod
                    ._Codigo = CInt(Me.txtCodigo.Text)
                    ._Ciclo = _Ciclo
                    ._Especialidad = _Especialidad
                    ._Titulo = _Titulo
                    ._Nombre = _Nombre
                    ._Unidad = _Unidad
                    ._Duracion = _Duracion
                    .Editar()
                End With
            Catch ex As Exception
                Throw ex
                'MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro")
            End Try
            Mostrar()
        Else
            Try
                With oMod
                    ._Ciclo = _Ciclo
                    ._Especialidad = _Especialidad
                    ._Titulo = _Titulo
                    ._Nombre = _Nombre
                    ._Unidad = _Unidad
                    ._Duracion = _Duracion
                    ._Estado = True
                    .Agregar()
                End With
            Catch ex As Exception
                MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro")
            End Try
            Mostrar()
        End If

        Me.txtNombre.Enabled = False
        Me.txtDuracion.Enabled = False
        Me.txtTitulo.Enabled = False
        Me.txtUnidades.Enabled = False
        Me.cbCiclo.Enabled = False
        Me.cbEspecialidad.Enabled = False

        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = True
        Me.BtnInhabilitar.Enabled = True
        Me.btnHabilitar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnGrabar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnBuscar.Enabled = False
    End Sub

    Private Sub btnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Limpiar()
        Me.txtNombre.Enabled = False
        Me.txtDuracion.Enabled = False
        Me.txtTitulo.Enabled = False
        Me.txtUnidades.Enabled = False
        Me.cbCiclo.Enabled = False
        Me.cbEspecialidad.Enabled = False

        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = False
        Me.BtnInhabilitar.Enabled = False
        Me.btnHabilitar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.btnGrabar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnBuscar.Enabled = True
    End Sub

    Private Sub btnBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim _Ciclo, _Especialidad As Integer
            _Ciclo = CInt(Me.cbCiclo.SelectedValue)
            _Especialidad = CInt(Me.cbEspecialidad.SelectedValue)
            Me.dgRegistro.DataSource = oMod.Devolver_CicloEspecialidad(_Ciclo, _Especialidad)
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro")
        End Try

        Me.txtNombre.Enabled = False
        Me.txtDuracion.Enabled = False
        Me.txtTitulo.Enabled = False
        Me.txtUnidades.Enabled = False
        Me.cbCiclo.Enabled = True
        Me.cbEspecialidad.Enabled = True

        Me.btnBuscar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = True
        Me.BtnInhabilitar.Enabled = True
        Me.btnHabilitar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnGrabar.Enabled = False
        Me.btnCancelar.Enabled = True
        Me.btnBuscar.Enabled = True
    End Sub

    Private Sub dgRegistro_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRegistro.CellClick
        Me.txtCodigo.Text = CStr(Me.dgRegistro.CurrentRow.Cells(0).Value)
        Me.txtTitulo.Text = CStr(Me.dgRegistro.CurrentRow.Cells(1).Value)
        Me.txtNombre.Text = CStr(Me.dgRegistro.CurrentRow.Cells(2).Value)
        Me.txtUnidades.Text = CStr(Me.dgRegistro.CurrentRow.Cells(5).Value)
        Me.txtDuracion.Text = CStr(Me.dgRegistro.CurrentRow.Cells(6).Value)
        Me.cbCiclo.SelectedValue = CInt(Me.dgRegistro.CurrentRow.Cells(8).Value)
        Me.cbEspecialidad.SelectedValue = CInt(Me.dgRegistro.CurrentRow.Cells(9).Value)
    End Sub

    Private Sub txtTitulo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTitulo.KeyPress
        Dim oValidar As New Validar
        oValidar.ValidarLetras(e)
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        Dim oValidar As New Validar
        oValidar.ValidarLetras(e)
    End Sub

    Private Sub txtUnidades_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnidades.KeyPress
        Dim oValidar As New Validar
        oValidar.ValidarLetras(e)
    End Sub

    Private Sub txtDuracion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDuracion.KeyPress
        Dim oValidar As New Validar
        oValidar.ValidarEnteros(e)
    End Sub

End Class