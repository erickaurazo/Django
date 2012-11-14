Option Explicit On
Option Strict On

Public Class FrmBuscarEstudiante
    Public oCod, oSem, oEsp, oCic As Integer
    Public oNom As String
    Dim oValidar As New Validar

    Private Sub btnMatricular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMatricular.Click

        Try
            oCod = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(0).Value)
            oNom = CStr(Me.dgRegistroEstudiantes.CurrentRow.Cells(1).Value)
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Matricula")
        End Try
        
        Try
            If Me.dgRegistroEstudiantes.CurrentRow.Cells(3).Value Is DBNull.Value Then
                oEsp = 1
            Else
                oEsp = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(3).Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Especialidad")
        End Try


        Try
            If Me.dgRegistroEstudiantes.CurrentRow.Cells(4).Value Is DBNull.Value Then
                oSem = 1
            Else
                oSem = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(4).Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Especialidad")
        End Try

        Try
            If Me.dgRegistroEstudiantes.CurrentRow.Cells(5).Value Is DBNull.Value Then
                oCic = 1
            Else
                oCic = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(5).Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Especialidad")
        End Try

        'oEsp = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(3).Value)
        'oSem = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(4).Value)
        'oCic = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(5).Value)
        Dim _Frm As New FrmMatricula(oCod, oNom, oEsp, oSem, oCic)
        _Frm.ShowDialog()
    End Sub

    Private Sub FrmBuscarEstudiante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Semestre()
        Especialidad()

    End Sub

    Public Sub Listar()
        Try
            Dim oListar As New LogicaNegocio.Matricula
            Me.dgRegistroEstudiantes.DataSource = oListar.ListadoGeneral
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'combobox Semestre
    Public Sub Semestre()
        Try
            Dim oSem As New LogicaNegocio.Matricula
            Me.cbSemestre.DataSource = oSem.Cb_Semestre
            Me.cbSemestre.DisplayMember = "Semestre_Nombre"
            Me.cbSemestre.ValueMember = "Semestre_Cod"
        Catch ex As Exception
            Throw ex
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
            Throw ex
        End Try

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnBuscarAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarAlumno.Click

        Dim oNom As String
        Dim oSem, oEsp As Integer

        If Trim(Me.txtNombre.Text) = "" Then
            MsgBox("Ingrese Nombre")
            Exit Sub
        End If

        If (Me.cbSemestre.SelectedValue).ToString = "" Then
            MsgBox("Seleccione Semestre")
            Exit Sub
        End If

        If (Me.cbEspecialidad.SelectedValue).ToString = "" Then
            MsgBox("Seleccione Especialidad")
            Exit Sub
        End If

        oNom = CStr(Me.txtNombre.Text)
        oSem = CInt(Me.cbSemestre.SelectedValue)
        oEsp = CInt(Me.cbEspecialidad.SelectedValue)

        Dim oBuscar As New LogicaNegocio.Matricula
        Me.dgRegistroEstudiantes.DataSource = oBuscar.Buscar(oNom, oSem, oEsp)


    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        oValidar.ValidarLetras(e)
    End Sub

    Private Sub dgRegistroEstudiantes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRegistroEstudiantes.CellClick
        Me.txtNombre.Text = CStr(Me.dgRegistroEstudiantes.CurrentRow.Cells(1).Value)

        Try
            If Me.dgRegistroEstudiantes.CurrentRow.Cells(3).Value Is DBNull.Value Then
                Me.cbEspecialidad.SelectedValue = 1
            Else
                Me.cbEspecialidad.SelectedValue = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(3).Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro - Especialidad")
        End Try


        Try
            If Me.dgRegistroEstudiantes.CurrentRow.Cells(4).Value Is DBNull.Value Then
                Me.cbSemestre.SelectedValue = 1
            Else
                Me.cbSemestre.SelectedValue = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(4).Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro - Semestre")
        End Try


        Try
            If Me.dgRegistroEstudiantes.CurrentRow.Cells(5).Value Is DBNull.Value Then
                oCic = 1
            Else
                Me.cbSemestre.SelectedValue = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(5).Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro - Ciclo")
        End Try

        'Me.cbEspecialidad.SelectedValue = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(3).Value)
        'Me.cbSemestre.SelectedValue = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(4).Value)

    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Listar()
        Me.cbSemestre.SelectedValue = 1
        Me.cbEspecialidad.SelectedValue = 1
        Me.txtNombre.Clear()
    End Sub
End Class