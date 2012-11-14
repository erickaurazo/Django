Option Explicit On
Option Strict On
Public Class FrmEspecialidad
    Dim oEsp As New LogicaNegocio.ClsEspecialidad
    Dim oCod As Integer
    Dim oEditar As Boolean

    Private Sub FrmEspecialidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicio()
    End Sub

    Public Sub Mostrar()
        Me.dgRegistro.DataSource = oEsp.Listar()
    End Sub

    Private Sub BtnInhabilitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInhabilitar.Click
        oCod = CInt(Me.txtCodigo.Text)
        oEsp.Inhabilitar(oCod)
        Mostrar()
    End Sub

    Private Sub btnHabilitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHabilitar.Click
        oCod = CInt(Me.txtCodigo.Text)
        oEsp.Habilitar(oCod)
        Mostrar()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        oCod = CInt(dgRegistro.CurrentRow.Cells(0).Value)
        oEsp.Eliminar(oCod)
        Mostrar()
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        Dim _Nom, _Sig, _Des, _Per As String
        _Nom = CStr(Me.txtNombre.Text)
        _Sig = CStr(Me.txtSiglas.Text.ToUpper)
        _Des = CStr(Me.txtDesc.Text)
        _Per = CStr(Me.txtPerfil.Text)
        '-- Grabar

        If oEditar = True Then
            Try
                With oEsp
                    ._Codigo = CInt(Me.txtCodigo.Text)
                    ._Nombre = _Nom
                    ._Siglas = _Sig
                    ._Desc = _Des
                    ._Perfil = _Des
                    ._Estado = True
                    .Editar()
                End With

            Catch ex As Exception
                Throw ex
            End Try
            Mostrar()
        Else
            Try
                With oEsp
                    '._Codigo = CInt((Me.dgRegistro.CurrentRow.Cells(0).Value))
                    ._Nombre = _Nom
                    ._Siglas = _Sig
                    ._Desc = _Des
                    ._Perfil = _Des
                    ._Estado = True
                    .Agregar()
                End With

            Catch ex As Exception
                Throw ex
            End Try
            Mostrar()
        End If

        Me.txtNombre.Enabled = False
        Me.txtSiglas.Enabled = False
        Me.txtDesc.Enabled = False
        Me.txtPerfil.Enabled = False

        Me.BtnListar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = True
        Me.BtnInhabilitar.Enabled = True
        Me.btnHabilitar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.BtnGrabar.Enabled = False
        Me.btnCancelar.Enabled = False

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        oEditar = True

        Me.txtNombre.Enabled = True
        Me.txtSiglas.Enabled = True
        Me.txtDesc.Enabled = True
        Me.txtPerfil.Enabled = True

        Me.BtnListar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = False
        Me.BtnInhabilitar.Enabled = False
        Me.btnHabilitar.Enabled = False
        Me.btnEliminar.Enabled = True
        Me.BtnGrabar.Enabled = True
        Me.btnCancelar.Enabled = True
    End Sub

    Private Sub dgRegistro_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRegistro.CellClick
        Me.txtCodigo.Text = CStr(dgRegistro.CurrentRow.Cells(0).Value)
        Me.txtNombre.Text = CStr(Me.dgRegistro.CurrentRow.Cells(1).Value)
        Me.txtSiglas.Text = CStr(Me.dgRegistro.CurrentRow.Cells(2).Value)
        Me.txtDesc.Text = CStr(Me.dgRegistro.CurrentRow.Cells(3).Value)
        Me.txtPerfil.Text = CStr(Me.dgRegistro.CurrentRow.Cells(4).Value)
    End Sub

    Public Sub Inicio()
        Me.txtNombre.Enabled = False
        Me.txtSiglas.Enabled = False
        Me.txtDesc.Enabled = False
        Me.txtPerfil.Enabled = False

        Me.BtnListar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = False
        Me.BtnInhabilitar.Enabled = False
        Me.btnHabilitar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.BtnGrabar.Enabled = False
        Me.btnCancelar.Enabled = False
    End Sub

    Private Sub BtnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnListar.Click
        Limpiar()
        Me.txtNombre.Enabled = True
        Me.txtSiglas.Enabled = True
        Me.txtDesc.Enabled = True
        Me.txtPerfil.Enabled = True

        Me.BtnListar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = True
        Me.BtnInhabilitar.Enabled = True
        Me.btnHabilitar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.BtnGrabar.Enabled = False
        Me.btnCancelar.Enabled = False

        Mostrar()
    End Sub

    Public Sub Limpiar()
        Me.txtNombre.Clear()
        Me.txtPerfil.Clear()
        Me.txtSiglas.Clear()
        Me.txtDesc.Clear()
        Me.txtCodigo.Clear()
        'Me.dgRegistro.DataSource = ""
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Limpiar()
        Me.txtNombre.Enabled = True
        Me.txtSiglas.Enabled = True
        Me.txtDesc.Enabled = True
        Me.txtPerfil.Enabled = True

        Me.BtnListar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = False
        Me.BtnInhabilitar.Enabled = False
        Me.btnHabilitar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.BtnGrabar.Enabled = True
        Me.btnCancelar.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Limpiar()
        Me.txtNombre.Enabled = False
        Me.txtSiglas.Enabled = False
        Me.txtDesc.Enabled = False
        Me.txtPerfil.Enabled = False

        Me.BtnListar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnEditar.Enabled = False
        Me.BtnInhabilitar.Enabled = False
        Me.btnHabilitar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.BtnGrabar.Enabled = False
        Me.btnCancelar.Enabled = True
    End Sub
End Class