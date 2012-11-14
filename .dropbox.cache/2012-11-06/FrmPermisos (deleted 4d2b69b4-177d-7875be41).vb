Public Class FrmPermisos
    Dim oObj As New LogicaNegocio.ClsCuentas
    Dim oConst As New LogicaNegocio.ClsConstante
    Public perCodigo As Integer = 0
    Public perTipo As Integer = 0
    Public perUsuario As String = " "
    Public perNombres As String = ""


    Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        

        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub FrmPermisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cb_CondicionPersona()
        Listar_todos_Registros()
    End Sub


    'Cargar ComboBox TipoPersona
    Public Sub cb_CondicionPersona()
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

    Public Sub Listar_todos_Registros()
        Me.dgRegistroEstudiantes.DataSource = oObj.Listar_Todos()

    End Sub

    Private Sub BtnBuscarAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnListarTodos.Click
        Listar_todos_Registros()
    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click

        Me.txtNombre.Clear()
        Me.cbTipoPersona.SelectedValue = 0
        Listar_todos_Registros()
        Me.txtNombre.Focus()

    End Sub


    Private Sub btnVerTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerTodos.Click
        Dim tbApellido As String
        Dim tbTipo As Integer

        tbApellido = CStr(Me.txtNombre.Text)
        tbTipo = CInt(Me.cbTipoPersona.SelectedValue)


        If Me.txtNombre.Text = "" Then
            MessageBox.Show("Ingrese Apellido del Personal que desea encontrar")
            Exit Sub
        End If

        If Me.cbTipoPersona.SelectedValue = 0 Or Nothing Then
            MessageBox.Show("Seleccione Condicion del Personal que se desea encontrar")
            Exit Sub
        End If


        Me.dgRegistroEstudiantes.DataSource = oObj.Listar_NombreTipo(tbApellido, tbTipo)

    End Sub

    Private Sub btnPermisos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPermisos.Click

        Try
            perCodigo = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(0).Value)
            perUsuario = CStr(Me.dgRegistroEstudiantes.CurrentRow.Cells(1).Value)
            perNombres = CStr(Me.dgRegistroEstudiantes.CurrentRow.Cells(2).Value) & " " & CStr(Me.dgRegistroEstudiantes.CurrentRow.Cells(3).Value)
            perTipo = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(4).Value)
        Catch ex As Exception
            MessageBox.Show("Seleccione un registro Completo")
            Exit Sub
        End Try

        If perCodigo = 0 And perUsuario = "" And perNombres = "" And perTipo = 0 Then
            MessageBox.Show("Seleccione un registro Completo")
            Exit Sub
        End If

        Dim oFrm As New FrmAdmPermisos(perCodigo, perUsuario, perTipo, perNombres)
        oFrm.ShowDialog()

    End Sub

    Private Sub btnCuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuentas.Click
        Try
            If dgRegistroEstudiantes.CurrentRow.Cells(1).Value Is DBNull.Value Then
                perUsuario = "No Asignado"
            Else
                perUsuario = CStr(Me.dgRegistroEstudiantes.CurrentRow.Cells(1).Value)
            End If
        Catch ex As Exception
            MessageBox.Show("Seleccione un registro completo")
            Exit Sub
        End Try

        Try
            perCodigo = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(0).Value)
            perNombres = CStr(Me.dgRegistroEstudiantes.CurrentRow.Cells(2).Value) & " " & CStr(Me.dgRegistroEstudiantes.CurrentRow.Cells(3).Value)
            perTipo = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(4).Value)
        Catch ex As Exception
            MessageBox.Show("Seleccione un registro completo")
            Exit Sub
        End Try

        If perCodigo = 0 And perNombres = "" And perTipo = 0 Then
            MessageBox.Show("Seleccione un registro completo")
            Exit Sub
        End If
        Dim oFrm2 As New frmAdmCuenta(perCodigo, perUsuario, perTipo, perNombres)
        oFrm2.ShowDialog()
    End Sub

    Private Sub dgRegistroEstudiantes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRegistroEstudiantes.CellClick

        Try
            Dim oUsuario As New LogicaNegocio.ClsUsuario
            cbCondicion.DataSource = oConst.Condicion_Persona(1)
            cbCondicion.DisplayMember = "Nombre"
            cbCondicion.ValueMember = "Valor"
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Error al cargar datos al combo")
            Exit Sub
        End Try

        Me.txtCodigo.Text = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(0).Value)
        Me.cbCondicion.SelectedValue = CInt(Me.dgRegistroEstudiantes.CurrentRow.Cells(4).Value)
        Me.txtNombreCompleto.Text = CStr(Me.dgRegistroEstudiantes.CurrentRow.Cells(2).Value) & " " & CStr(Me.dgRegistroEstudiantes.CurrentRow.Cells(3).Value)


        If dgRegistroEstudiantes.CurrentRow.Cells(1).Value Is DBNull.Value Then
            Me.txtUsuario.Text = "No Asignado"
        Else
            Me.txtUsuario.Text = CStr(Me.dgRegistroEstudiantes.CurrentRow.Cells(1).Value)
        End If


    End Sub


End Class