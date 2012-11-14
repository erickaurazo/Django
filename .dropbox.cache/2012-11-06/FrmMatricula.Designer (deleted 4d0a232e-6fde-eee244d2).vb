<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMatricula
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMatricula))
        Me.gbDatosInstitucion = New System.Windows.Forms.GroupBox()
        Me.cbSemestre = New System.Windows.Forms.ComboBox()
        Me.cbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbDatosEstudiante = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbDocumento = New System.Windows.Forms.ComboBox()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbDatosMatricula = New System.Windows.Forms.GroupBox()
        Me.gbCursos = New System.Windows.Forms.GroupBox()
        Me.dgCursos = New System.Windows.Forms.DataGridView()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtModoIngreso = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbCondicion = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbTurno = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.cbCiclo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgCodigo = New System.Windows.Forms.DataGridView()
        Me.gbCursoCargo = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgDetCurso = New System.Windows.Forms.DataGridView()
        Me.gbMantenimiento = New System.Windows.Forms.GroupBox()
        Me.btnCopiar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.gbFoto = New System.Windows.Forms.GroupBox()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.btnReservar = New System.Windows.Forms.Button()
        Me.btnMatricular = New System.Windows.Forms.Button()
        Me.gbDatosInstitucion.SuspendLayout()
        Me.gbDatosEstudiante.SuspendLayout()
        Me.gbDatosMatricula.SuspendLayout()
        Me.gbCursos.SuspendLayout()
        CType(Me.dgCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCursoCargo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDetCurso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMantenimiento.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbFoto.SuspendLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDatosInstitucion
        '
        Me.gbDatosInstitucion.Controls.Add(Me.cbSemestre)
        Me.gbDatosInstitucion.Controls.Add(Me.cbEspecialidad)
        Me.gbDatosInstitucion.Controls.Add(Me.Label2)
        Me.gbDatosInstitucion.Controls.Add(Me.Label1)
        Me.gbDatosInstitucion.Location = New System.Drawing.Point(12, 12)
        Me.gbDatosInstitucion.Name = "gbDatosInstitucion"
        Me.gbDatosInstitucion.Size = New System.Drawing.Size(635, 39)
        Me.gbDatosInstitucion.TabIndex = 0
        Me.gbDatosInstitucion.TabStop = False
        Me.gbDatosInstitucion.Text = "Datos de la Institución"
        '
        'cbSemestre
        '
        Me.cbSemestre.FormattingEnabled = True
        Me.cbSemestre.Location = New System.Drawing.Point(478, 16)
        Me.cbSemestre.Name = "cbSemestre"
        Me.cbSemestre.Size = New System.Drawing.Size(151, 21)
        Me.cbSemestre.TabIndex = 4
        '
        'cbEspecialidad
        '
        Me.cbEspecialidad.FormattingEnabled = True
        Me.cbEspecialidad.Location = New System.Drawing.Point(108, 13)
        Me.cbEspecialidad.Name = "cbEspecialidad"
        Me.cbEspecialidad.Size = New System.Drawing.Size(205, 21)
        Me.cbEspecialidad.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(420, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Semestre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Especialidad"
        '
        'gbDatosEstudiante
        '
        Me.gbDatosEstudiante.Controls.Add(Me.txtNombre)
        Me.gbDatosEstudiante.Controls.Add(Me.Label5)
        Me.gbDatosEstudiante.Controls.Add(Me.cbDocumento)
        Me.gbDatosEstudiante.Controls.Add(Me.txtDocumento)
        Me.gbDatosEstudiante.Controls.Add(Me.Label3)
        Me.gbDatosEstudiante.Controls.Add(Me.txtCodigo)
        Me.gbDatosEstudiante.Controls.Add(Me.Label4)
        Me.gbDatosEstudiante.Location = New System.Drawing.Point(12, 57)
        Me.gbDatosEstudiante.Name = "gbDatosEstudiante"
        Me.gbDatosEstudiante.Size = New System.Drawing.Size(635, 78)
        Me.gbDatosEstudiante.TabIndex = 1
        Me.gbDatosEstudiante.TabStop = False
        Me.gbDatosEstudiante.Text = "Datos del Estudiante"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(98, 50)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(531, 20)
        Me.txtNombre.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nombre:"
        '
        'cbDocumento
        '
        Me.cbDocumento.Enabled = False
        Me.cbDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbDocumento.FormattingEnabled = True
        Me.cbDocumento.Location = New System.Drawing.Point(370, 21)
        Me.cbDocumento.Name = "cbDocumento"
        Me.cbDocumento.Size = New System.Drawing.Size(101, 21)
        Me.cbDocumento.TabIndex = 5
        '
        'txtDocumento
        '
        Me.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDocumento.Enabled = False
        Me.txtDocumento.Location = New System.Drawing.Point(487, 19)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(142, 20)
        Me.txtDocumento.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(297, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Documento"
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(98, 22)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(145, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Código"
        '
        'gbDatosMatricula
        '
        Me.gbDatosMatricula.Controls.Add(Me.gbCursos)
        Me.gbDatosMatricula.Controls.Add(Me.txtMotivo)
        Me.gbDatosMatricula.Controls.Add(Me.Label12)
        Me.gbDatosMatricula.Controls.Add(Me.txtModoIngreso)
        Me.gbDatosMatricula.Controls.Add(Me.Label11)
        Me.gbDatosMatricula.Controls.Add(Me.cbCondicion)
        Me.gbDatosMatricula.Controls.Add(Me.Label9)
        Me.gbDatosMatricula.Controls.Add(Me.cbTurno)
        Me.gbDatosMatricula.Controls.Add(Me.Label8)
        Me.gbDatosMatricula.Controls.Add(Me.cbTipo)
        Me.gbDatosMatricula.Controls.Add(Me.cbCiclo)
        Me.gbDatosMatricula.Controls.Add(Me.Label6)
        Me.gbDatosMatricula.Controls.Add(Me.Label7)
        Me.gbDatosMatricula.Location = New System.Drawing.Point(12, 141)
        Me.gbDatosMatricula.Name = "gbDatosMatricula"
        Me.gbDatosMatricula.Size = New System.Drawing.Size(778, 288)
        Me.gbDatosMatricula.TabIndex = 2
        Me.gbDatosMatricula.TabStop = False
        Me.gbDatosMatricula.Text = "Datos de Matrícula"
        '
        'gbCursos
        '
        Me.gbCursos.Controls.Add(Me.dgCursos)
        Me.gbCursos.Location = New System.Drawing.Point(25, 71)
        Me.gbCursos.Name = "gbCursos"
        Me.gbCursos.Size = New System.Drawing.Size(733, 209)
        Me.gbCursos.TabIndex = 14
        Me.gbCursos.TabStop = False
        Me.gbCursos.Text = "Cursos"
        '
        'dgCursos
        '
        Me.dgCursos.AllowUserToAddRows = False
        Me.dgCursos.AllowUserToDeleteRows = False
        Me.dgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCursos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCursos.Location = New System.Drawing.Point(3, 16)
        Me.dgCursos.Name = "dgCursos"
        Me.dgCursos.ReadOnly = True
        Me.dgCursos.Size = New System.Drawing.Size(727, 190)
        Me.dgCursos.TabIndex = 0
        '
        'txtMotivo
        '
        Me.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMotivo.Location = New System.Drawing.Point(608, 47)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.ReadOnly = True
        Me.txtMotivo.Size = New System.Drawing.Size(150, 20)
        Me.txtMotivo.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(548, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Motivo"
        '
        'txtModoIngreso
        '
        Me.txtModoIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtModoIngreso.Location = New System.Drawing.Point(642, 20)
        Me.txtModoIngreso.Name = "txtModoIngreso"
        Me.txtModoIngreso.ReadOnly = True
        Me.txtModoIngreso.Size = New System.Drawing.Size(113, 20)
        Me.txtModoIngreso.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(548, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Modo de Ingreso"
        '
        'cbCondicion
        '
        Me.cbCondicion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbCondicion.FormattingEnabled = True
        Me.cbCondicion.Location = New System.Drawing.Point(98, 44)
        Me.cbCondicion.Name = "cbCondicion"
        Me.cbCondicion.Size = New System.Drawing.Size(117, 21)
        Me.cbCondicion.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Condicion"
        '
        'cbTurno
        '
        Me.cbTurno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbTurno.FormattingEnabled = True
        Me.cbTurno.Location = New System.Drawing.Point(262, 17)
        Me.cbTurno.Name = "cbTurno"
        Me.cbTurno.Size = New System.Drawing.Size(99, 21)
        Me.cbTurno.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(221, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Turno"
        '
        'cbTipo
        '
        Me.cbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(401, 17)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(141, 21)
        Me.cbTipo.TabIndex = 4
        '
        'cbCiclo
        '
        Me.cbCiclo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbCiclo.FormattingEnabled = True
        Me.cbCiclo.Location = New System.Drawing.Point(98, 17)
        Me.cbCiclo.Name = "cbCiclo"
        Me.cbCiclo.Size = New System.Drawing.Size(117, 21)
        Me.cbCiclo.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(367, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tipo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Ciclo"
        '
        'dgCodigo
        '
        Me.dgCodigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCodigo.Location = New System.Drawing.Point(664, 54)
        Me.dgCodigo.Name = "dgCodigo"
        Me.dgCodigo.Size = New System.Drawing.Size(173, 101)
        Me.dgCodigo.TabIndex = 15
        '
        'gbCursoCargo
        '
        Me.gbCursoCargo.Controls.Add(Me.GroupBox2)
        Me.gbCursoCargo.Location = New System.Drawing.Point(17, 435)
        Me.gbCursoCargo.Name = "gbCursoCargo"
        Me.gbCursoCargo.Size = New System.Drawing.Size(773, 233)
        Me.gbCursoCargo.TabIndex = 3
        Me.gbCursoCargo.TabStop = False
        Me.gbCursoCargo.Text = "Cursos a Cargo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgDetCurso)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(728, 198)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cursos"
        '
        'dgDetCurso
        '
        Me.dgDetCurso.AllowUserToAddRows = False
        Me.dgDetCurso.AllowUserToDeleteRows = False
        Me.dgDetCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetCurso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDetCurso.Location = New System.Drawing.Point(3, 16)
        Me.dgDetCurso.Name = "dgDetCurso"
        Me.dgDetCurso.ReadOnly = True
        Me.dgDetCurso.Size = New System.Drawing.Size(722, 179)
        Me.dgDetCurso.TabIndex = 0
        '
        'gbMantenimiento
        '
        Me.gbMantenimiento.Controls.Add(Me.btnImprimir)
        Me.gbMantenimiento.Controls.Add(Me.Salir)
        Me.gbMantenimiento.Controls.Add(Me.btnAnular)
        Me.gbMantenimiento.Controls.Add(Me.btnReservar)
        Me.gbMantenimiento.Controls.Add(Me.btnMatricular)
        Me.gbMantenimiento.Location = New System.Drawing.Point(17, 674)
        Me.gbMantenimiento.Name = "gbMantenimiento"
        Me.gbMantenimiento.Size = New System.Drawing.Size(747, 51)
        Me.gbMantenimiento.TabIndex = 4
        Me.gbMantenimiento.TabStop = False
        Me.gbMantenimiento.Text = "Mantenimiento"
        '
        'btnCopiar
        '
        Me.btnCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCopiar.Location = New System.Drawing.Point(796, 239)
        Me.btnCopiar.Name = "btnCopiar"
        Me.btnCopiar.Size = New System.Drawing.Size(33, 32)
        Me.btnCopiar.TabIndex = 9
        Me.btnCopiar.Text = ">>"
        Me.btnCopiar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBorrar.Location = New System.Drawing.Point(796, 470)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(33, 32)
        Me.btnBorrar.TabIndex = 10
        Me.btnBorrar.Text = "<<"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Location = New System.Drawing.Point(658, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 39)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha"
        '
        'txtfecha
        '
        Me.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfecha.Enabled = False
        Me.txtfecha.Location = New System.Drawing.Point(6, 16)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(120, 20)
        Me.txtfecha.TabIndex = 9
        '
        'gbFoto
        '
        Me.gbFoto.Controls.Add(Me.picFoto)
        Me.gbFoto.Location = New System.Drawing.Point(686, 54)
        Me.gbFoto.Name = "gbFoto"
        Me.gbFoto.Size = New System.Drawing.Size(81, 81)
        Me.gbFoto.TabIndex = 6
        Me.gbFoto.TabStop = False
        '
        'picFoto
        '
        Me.picFoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picFoto.Location = New System.Drawing.Point(3, 16)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(75, 62)
        Me.picFoto.TabIndex = 0
        Me.picFoto.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Imprimir
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimir.Location = New System.Drawing.Point(25, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(145, 21)
        Me.btnImprimir.TabIndex = 9
        Me.btnImprimir.Text = "Imprimir Ficha Matricula"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Salir
        Me.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Salir.Location = New System.Drawing.Point(643, 17)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(84, 22)
        Me.Salir.TabIndex = 8
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'btnAnular
        '
        Me.btnAnular.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Cancelar_Php
        Me.btnAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnular.Location = New System.Drawing.Point(505, 17)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(110, 22)
        Me.btnAnular.TabIndex = 7
        Me.btnAnular.Text = " Anular Matricula"
        Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAnular.UseVisualStyleBackColor = True
        '
        'btnReservar
        '
        Me.btnReservar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Reservar
        Me.btnReservar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReservar.Location = New System.Drawing.Point(353, 17)
        Me.btnReservar.Name = "btnReservar"
        Me.btnReservar.Size = New System.Drawing.Size(125, 22)
        Me.btnReservar.TabIndex = 6
        Me.btnReservar.Text = "Reservar Matrícula"
        Me.btnReservar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReservar.UseVisualStyleBackColor = True
        '
        'btnMatricular
        '
        Me.btnMatricular.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Matricular
        Me.btnMatricular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMatricular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMatricular.Location = New System.Drawing.Point(198, 18)
        Me.btnMatricular.Name = "btnMatricular"
        Me.btnMatricular.Size = New System.Drawing.Size(126, 21)
        Me.btnMatricular.TabIndex = 5
        Me.btnMatricular.Text = "Registrar Matricular"
        Me.btnMatricular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMatricular.UseVisualStyleBackColor = True
        '
        'FrmMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(843, 738)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.dgCodigo)
        Me.Controls.Add(Me.btnCopiar)
        Me.Controls.Add(Me.gbFoto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbMantenimiento)
        Me.Controls.Add(Me.gbCursoCargo)
        Me.Controls.Add(Me.gbDatosMatricula)
        Me.Controls.Add(Me.gbDatosEstudiante)
        Me.Controls.Add(Me.gbDatosInstitucion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMatricula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".. Registro de Matricula"
        Me.gbDatosInstitucion.ResumeLayout(False)
        Me.gbDatosInstitucion.PerformLayout()
        Me.gbDatosEstudiante.ResumeLayout(False)
        Me.gbDatosEstudiante.PerformLayout()
        Me.gbDatosMatricula.ResumeLayout(False)
        Me.gbDatosMatricula.PerformLayout()
        Me.gbCursos.ResumeLayout(False)
        CType(Me.dgCursos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCursoCargo.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgDetCurso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMantenimiento.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbFoto.ResumeLayout(False)
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbDatosInstitucion As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbDatosEstudiante As System.Windows.Forms.GroupBox
    Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbDatosMatricula As System.Windows.Forms.GroupBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cbCiclo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbCondicion As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtModoIngreso As System.Windows.Forms.TextBox
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents gbCursos As System.Windows.Forms.GroupBox
    Friend WithEvents dgCursos As System.Windows.Forms.DataGridView
    Friend WithEvents gbCursoCargo As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgDetCurso As System.Windows.Forms.DataGridView
    Friend WithEvents gbMantenimiento As System.Windows.Forms.GroupBox
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents btnReservar As System.Windows.Forms.Button
    Friend WithEvents tpMantenimiento As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbFoto As System.Windows.Forms.GroupBox
    Friend WithEvents txtfecha As System.Windows.Forms.TextBox
    Friend WithEvents picFoto As System.Windows.Forms.PictureBox
    Friend WithEvents cbSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents cbEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnCopiar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents dgCodigo As System.Windows.Forms.DataGridView
    Friend WithEvents btnMatricular As System.Windows.Forms.Button
End Class
