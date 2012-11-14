Option Explicit On
Option Strict On
Public Class FrmMatricula
    Public oMatricula As Integer
    Dim Mat_Cod, nCont As Integer
    Dim _Fecha As DateTime
    Dim _Per_Cod, numeroCreditos As Integer
    Dim _TipMat_Cod As Integer
    Dim _Especialidad_Cod As Integer
    Dim _Ciclo_Cod As Integer
    Dim _Turno_Cod As Integer
    Dim _Semestre_Cod As Integer
    Dim _Mat_tip As Integer
    Dim _Mat_Condicion As Integer
    Dim _Mar_Estado As Integer
    Dim oMat As New LogicaNegocio.Matricula
    Dim oDet As New LogicaNegocio.Matricula_Detalle

    Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Sub New(ByVal codigo As Integer, ByVal _Nombre As String, ByVal _Especialidad As Integer, ByVal _Semestre As Integer, ByVal _Ciclo As Integer)
        InitializeComponent()
        Cargar_Combo()
        Fecha()   
        Try
            Me.txtCodigo.Text = CStr(codigo)
            Me.txtNombre.Text = CStr(_Nombre)
            Me.cbEspecialidad.SelectedValue = CInt(_Especialidad)
            Me.cbSemestre.SelectedValue = CInt(_Semestre)
            Me.cbCiclo.SelectedValue = CInt(_Ciclo)
        Catch ex As Exception
            Throw ex
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro")
        End Try
    End Sub

    Public Sub Cargar_Combo()
        Condicion()
        Turno()
        Tipo_Matricula()
        Ciclo()
        Semestre()
        Especialidad()
    End Sub

    Public Sub Fecha()
        txtfecha.Text = CStr(Today) & " " & Format(Now, "hh:mm:ss")
        'txtfecha.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub FrmMatricula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim _Fichas As New FrmFichaMatricula(oMatricula)
        _Fichas.ShowDialog()
    End Sub

    Private Sub btnMatricular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMatricular.Click

        _Fecha = Now.Date()
        _Per_Cod = CInt(Me.txtCodigo.Text)
        _TipMat_Cod = CInt(Me.cbTipo.SelectedValue)
        _Especialidad_Cod = CInt(Me.cbEspecialidad.SelectedValue)
        _Ciclo_Cod = CInt(Me.cbCiclo.SelectedValue)
        _Turno_Cod = CInt(Me.cbTurno.SelectedValue)
        _Semestre_Cod = CInt(Me.cbSemestre.SelectedValue)
        _Mat_tip = 1
        _Mat_Condicion = CInt(Me.cbCondicion.SelectedValue)
        _Mar_Estado = 1

        Try
            With oMat
                ._Mat_Cod = oMatricula
                ._Fecha = _Fecha
                ._Per_Cod = _Per_Cod
                ._TipMat_Cod = _TipMat_Cod
                ._Especialidad_Cod = _Especialidad_Cod
                ._Ciclo_Cod = _Ciclo_Cod
                ._Turno_Cod = _Turno_Cod
                ._Semestre_Cod = _Semestre_Cod
                ._Mat_Condicion = _Mat_Condicion
                ._Mar_Estado = _Mar_Estado
                .Agregar()
            End With
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Matricula")
        End Try

        Dim oCurso As Integer
        Try
            For nCont = 0 To dgDetCurso.RowCount - 1
                oCurso = CInt((dgDetCurso.Item(0, nCont).Value))
                oDet.Agregar(oMatricula, oCurso)
                oCurso = 0
            Next
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Ficha de Matricula")
        End Try
        MsgBox("Se ha registrado la Matricula Correctamente", MsgBoxStyle.OkOnly, "Registro de Matricula")

        'Insertar Cursos a la ficha de matricula
        Me.btnMatricular.Enabled = False
    End Sub

#Region " ComboBox "
    'combobox Turno
    Public Sub Turno()
        Try
            Dim oMat As New LogicaNegocio.Matricula
            Me.cbTurno.DataSource = oMat.cb_Turno
            Me.cbTurno.DisplayMember = "Turno_Nombre"
            Me.cbTurno.ValueMember = "Turno_Cod"
        Catch ex As Exception
            Throw ex
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro")

        End Try
    End Sub

    'combobox Ciclo
    Public Sub Ciclo()
        Try
            Dim oMat As New LogicaNegocio.Matricula
            Me.cbCiclo.DataSource = oMat.cb_Ciclo
            Me.cbCiclo.DisplayMember = "Ciclo_desc"
            Me.cbCiclo.ValueMember = "Ciclo_Cod"
        Catch ex As Exception
            Throw ex
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro")

        End Try
    End Sub

    'combobox Tipo_Matricula()
    Public Sub Tipo_Matricula()
        Try
            Dim oMat As New LogicaNegocio.Matricula
            Me.cbTipo.DataSource = oMat.cb_TipoMatricula
            Me.cbTipo.DisplayMember = "tipMat_Nombre"
            Me.cbTipo.ValueMember = "tipMat_Cod"
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro")

        End Try
    End Sub

    'combobox Tipo_Matricula()
    Public Sub Condicion()
        Try
            Dim oMat As New LogicaNegocio.Matricula
            Me.cbCondicion.DataSource = oMat.cb_Condicion
            Me.cbCondicion.DisplayMember = "Nombre"
            Me.cbCondicion.ValueMember = "Valor"
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Seleccione un Registro")

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
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Semestre")
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

    Private Sub cbCiclo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbCiclo.MouseClick
        Dim oSem As New LogicaNegocio.Matricula
        Me.dgCursos.DataSource = oSem.Listar_Cursos(CInt(Me.cbEspecialidad.SelectedValue), CInt(Me.cbCiclo.SelectedValue))

        Me.dgDetCurso.ColumnCount = Me.dgCursos.ColumnCount
        Dim x As Integer
        For x = 0 To Me.dgCursos.ColumnCount - 1
            Me.dgDetCurso.Columns(x).Name = Me.dgCursos.Columns(x).Name
            Me.dgDetCurso.Columns(x).HeaderText = Me.dgCursos.Columns(x).HeaderText
        Next

    End Sub

#End Region

#Region " Ficha de Matricula "

    Private Sub btnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiar.Click
        'VALIDAD QUE SE REPITAN LOS CURSOS
        'For nCont = 0 To Me.dgDetCurso.RowCount - 1
        '    If Me.dgDetCurso.Item(nCont, 0) Is Me.dgCursos.Item(nCont, 0) Then
        '        MessageBox.Show("Documento duplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Exit Sub
        '    End If
        'Next


        'Variable que guardara el valor
        Dim total As Integer = 0
        Dim iTotal As Integer = Me.dgDetCurso.Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla
        'Definimos la variable i para controlar el ciclo for
        Dim i As Integer
        'Definimos del ciclo que va desde que i vale cero hasta que i valga itotal menos uno, osea el penultimo regsitro de la tabla
        For i = 0 To iTotal - 1
            'INTEGER.parse()<---es para convertir a double el valor que se encuentre entre lso parentesis
            'me.datagridview1(3,i).value <----toma todos los valores de la columna 3... 3 es el numero de columna y i es el numero de fila asi toma todos los 
            'valores de esa columna, recuerda que las columnas inician en 0... asi que la 3 enrealidad sera la 5 visualmente
            'Sumar valores de las columna creditos
            total = total + Integer.Parse(CStr(Me.dgDetCurso(3, i).Value))
        Next
        Try
            If Me.dgCursos.SelectedRows.Count > 0 Then
                If total >= 20 Then
                    MsgBox("Excede el número de Créditos", MsgBoxStyle.OkOnly, "Matricula")
                    Exit Sub
                Else
                    CopiarSeleccion()
                End If
            Else
                MsgBox("Selecione un registro", MsgBoxStyle.OkOnly, "Matricula")
            End If
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Matricula")
        End Try

        'Mostramos el total en la caja de texto TxtTotal, en este caso la caja de texto tiene definido un formato como se mostrara el resultado, como dinero..
        'TxtTotal.Text = Format(total, "$ #,##0.00")
        'Sin el formato seria:
        numeroCreditos = CInt(total)
        Me.dgCursos.Rows.Remove(Me.dgCursos.CurrentRow)

    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        'Variable que guardara el valor
        Dim total As Integer = 0
        Dim iTotal As Integer = Me.dgDetCurso.Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla
        'Definimos la variable i para controlar el ciclo for
        Dim i As Integer
        'Definimos del ciclo que va desde que i vale cero hasta que i valga itotal menos uno, osea el penultimo regsitro de la tabla
        For i = 0 To iTotal - 1
            'INTEGER.parse()<---es para convertir a double el valor que se encuentre entre lso parentesis
            'me.datagridview1(4,i).value <----toma todos los valores de la columna 4... 4 es el numero de columna y i es el numero de fila asi toma todos los 
            'valores de esa columna, recuerda que las columnas inician en 0... asi que la 4 enrealidad sera la 5 visualmente
            'Sumar valores de las columna creditos
            total = total - Integer.Parse(CStr(Me.dgDetCurso(3, i).Value))
        Next

        Try
            If Me.dgDetCurso.SelectedRows.Count > 0 Then
                If total = 4 Then
                    MsgBox("No hay Cursos para eliminar", MsgBoxStyle.OkOnly, "Matricula")
                    Exit Sub
                Else
                    BorrarSeleccion()
                End If
            Else
                MsgBox("Selecione un registro", MsgBoxStyle.OkOnly, "Matricula")
            End If
        Catch ex As Exception
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Matricula")
        End Try

        'Mostramos el total en la caja de texto TxtTotal, en este caso la caja de texto tiene definido un formato como se mostrara el resultado, como dinero..
        'TxtTotal.Text = Format(total, "$ #,##0.00")
        'Sin el formato seria:
        numeroCreditos = CInt(total)

    End Sub

    Public Sub CopiarSeleccion()
        For Each Seleccion As DataGridViewRow In Me.dgCursos.SelectedRows
            Me.dgDetCurso.Rows.Add(ObtenerValoresFila(Seleccion))
        Next
        Me.dgCursos.ClearSelection()
    End Sub

    Public Sub BorrarSeleccion()
        For Each Seleccion As DataGridViewRow In Me.dgDetCurso.SelectedRows
            Me.dgDetCurso.Rows.Remove(Me.dgDetCurso.CurrentRow)
        Next
        Me.dgCursos.ClearSelection()
    End Sub

    Function ObtenerValoresFila(ByVal fila As DataGridViewRow) As String()
        'Dimensionar el array al tamaño de columnas del DGV
        Dim Contenido(Me.dgCursos.ColumnCount - 1) As String
        'Rellenar el contenido con el valor de las celdas de la fila
        Dim Ndx As Integer
        For Ndx = 0 To Contenido.Length - 1
            Contenido(Ndx) = CStr((fila.Cells(Ndx).Value))
        Next
        Return Contenido
    End Function

#End Region

    Private Sub FrmMatricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgCodigo.DataSource = oMat.Codigo()
        oMatricula = CInt(Me.dgCodigo.CurrentRow.Cells(0).Value)
    End Sub

End Class

