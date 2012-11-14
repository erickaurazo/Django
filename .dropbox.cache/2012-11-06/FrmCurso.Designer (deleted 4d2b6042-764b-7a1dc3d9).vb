<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCurso
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCurso))
        Me.gbMantenimiento = New System.Windows.Forms.GroupBox()
        Me.BtnInhabilitar = New System.Windows.Forms.Button()
        Me.btnHabilitar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.BtnListar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.gbDetalles = New System.Windows.Forms.GroupBox()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.lblNom_Desc = New System.Windows.Forms.Label()
        Me.lbl_Nom_Uni = New System.Windows.Forms.Label()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.lbl_NomSem = New System.Windows.Forms.Label()
        Me.txtSemanal = New System.Windows.Forms.TextBox()
        Me.txtCurso = New System.Windows.Forms.TextBox()
        Me.lblNom_Nombre = New System.Windows.Forms.Label()
        Me.gbDatosEstudiante = New System.Windows.Forms.GroupBox()
        Me.cbCiclo = New System.Windows.Forms.ComboBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.cbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.lblNom_Codigo = New System.Windows.Forms.Label()
        Me.cbModulo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNom_Mod = New System.Windows.Forms.Label()
        Me.txtCreditos = New System.Windows.Forms.TextBox()
        Me.lbl_NomCreditos = New System.Windows.Forms.Label()
        Me.gbRegistro = New System.Windows.Forms.GroupBox()
        Me.dgRegistro = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mod_Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Curso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Uni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Est = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Esp_Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cil_Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbOpc = New System.Windows.Forms.GroupBox()
        Me.tbMantenimiento = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gbMantenimiento.SuspendLayout()
        Me.gbDetalles.SuspendLayout()
        Me.gbDatosEstudiante.SuspendLayout()
        Me.gbRegistro.SuspendLayout()
        CType(Me.dgRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOpc.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbMantenimiento
        '
        Me.gbMantenimiento.Controls.Add(Me.BtnInhabilitar)
        Me.gbMantenimiento.Controls.Add(Me.btnHabilitar)
        Me.gbMantenimiento.Controls.Add(Me.BtnNuevo)
        Me.gbMantenimiento.Controls.Add(Me.btnEliminar)
        Me.gbMantenimiento.Controls.Add(Me.btnEditar)
        Me.gbMantenimiento.Location = New System.Drawing.Point(791, 27)
        Me.gbMantenimiento.Name = "gbMantenimiento"
        Me.gbMantenimiento.Size = New System.Drawing.Size(152, 254)
        Me.gbMantenimiento.TabIndex = 27
        Me.gbMantenimiento.TabStop = False
        Me.gbMantenimiento.Text = "Mantenimiento"
        '
        'BtnInhabilitar
        '
        Me.BtnInhabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnInhabilitar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reservar
        Me.BtnInhabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInhabilitar.Location = New System.Drawing.Point(34, 162)
        Me.BtnInhabilitar.Name = "BtnInhabilitar"
        Me.BtnInhabilitar.Size = New System.Drawing.Size(101, 32)
        Me.BtnInhabilitar.TabIndex = 13
        Me.BtnInhabilitar.Text = "Deshabilitar"
        Me.BtnInhabilitar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.tbMantenimiento.SetToolTip(Me.BtnInhabilitar, "Deshabilitar Registro")
        Me.BtnInhabilitar.UseVisualStyleBackColor = True
        '
        'btnHabilitar
        '
        Me.btnHabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHabilitar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reservar
        Me.btnHabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHabilitar.Location = New System.Drawing.Point(34, 209)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(101, 32)
        Me.btnHabilitar.TabIndex = 14
        Me.btnHabilitar.Text = "Habilitar"
        Me.btnHabilitar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.tbMantenimiento.SetToolTip(Me.btnHabilitar, "Habilitar Registro")
        Me.btnHabilitar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNuevo.Image = Global.Matricula.Presentacion.My.Resources.Resources.Nuevo
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(34, 22)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(101, 32)
        Me.BtnNuevo.TabIndex = 10
        Me.BtnNuevo.Text = "Nuevo "
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbMantenimiento.SetToolTip(Me.BtnNuevo, "Nuevo  Registro")
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Cancelar_Php
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(34, 116)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(101, 32)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbMantenimiento.SetToolTip(Me.btnEliminar, "Eliminar Registro")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Modificar_Registro
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(34, 69)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(101, 31)
        Me.btnEditar.TabIndex = 11
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbMantenimiento.SetToolTip(Me.btnEditar, "Editar Registro")
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Cancelar_Registros
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(408, 19)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(81, 26)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbMantenimiento.SetToolTip(Me.btnCancelar, "Cancelar Registro")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'BtnListar
        '
        Me.BtnListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnListar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Listar_icono
        Me.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnListar.Location = New System.Drawing.Point(297, 19)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(72, 26)
        Me.BtnListar.TabIndex = 17
        Me.BtnListar.Text = "Listar"
        Me.BtnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbMantenimiento.SetToolTip(Me.BtnListar, "Listar Registro")
        Me.BtnListar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGrabar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Guardar_Archivo
        Me.BtnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGrabar.Location = New System.Drawing.Point(179, 19)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(81, 26)
        Me.BtnGrabar.TabIndex = 16
        Me.BtnGrabar.Text = "&Grabar"
        Me.BtnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbMantenimiento.SetToolTip(Me.BtnGrabar, "Grabar Registro")
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'gbDetalles
        '
        Me.gbDetalles.Controls.Add(Me.txtdesc)
        Me.gbDetalles.Controls.Add(Me.lblNom_Desc)
        Me.gbDetalles.Controls.Add(Me.lbl_Nom_Uni)
        Me.gbDetalles.Controls.Add(Me.txtUnidades)
        Me.gbDetalles.Controls.Add(Me.lbl_NomSem)
        Me.gbDetalles.Controls.Add(Me.txtSemanal)
        Me.gbDetalles.Location = New System.Drawing.Point(122, 172)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(635, 78)
        Me.gbDetalles.TabIndex = 30
        Me.gbDetalles.TabStop = False
        Me.gbDetalles.Text = "Detalles"
        '
        'txtdesc
        '
        Me.txtdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdesc.Location = New System.Drawing.Point(115, 19)
        Me.txtdesc.MaxLength = 200
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(343, 46)
        Me.txtdesc.TabIndex = 7
        '
        'lblNom_Desc
        '
        Me.lblNom_Desc.AutoSize = True
        Me.lblNom_Desc.Location = New System.Drawing.Point(68, 16)
        Me.lblNom_Desc.Name = "lblNom_Desc"
        Me.lblNom_Desc.Size = New System.Drawing.Size(41, 13)
        Me.lblNom_Desc.TabIndex = 22
        Me.lblNom_Desc.Text = "Título :"
        '
        'lbl_Nom_Uni
        '
        Me.lbl_Nom_Uni.AutoSize = True
        Me.lbl_Nom_Uni.Location = New System.Drawing.Point(514, 52)
        Me.lbl_Nom_Uni.Name = "lbl_Nom_Uni"
        Me.lbl_Nom_Uni.Size = New System.Drawing.Size(58, 13)
        Me.lbl_Nom_Uni.TabIndex = 27
        Me.lbl_Nom_Uni.Text = "Unidades :"
        '
        'txtUnidades
        '
        Me.txtUnidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnidades.Location = New System.Drawing.Point(582, 45)
        Me.txtUnidades.MaxLength = 1
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(38, 20)
        Me.txtUnidades.TabIndex = 9
        '
        'lbl_NomSem
        '
        Me.lbl_NomSem.AutoSize = True
        Me.lbl_NomSem.Location = New System.Drawing.Point(476, 26)
        Me.lbl_NomSem.Name = "lbl_NomSem"
        Me.lbl_NomSem.Size = New System.Drawing.Size(96, 13)
        Me.lbl_NomSem.TabIndex = 26
        Me.lbl_NomSem.Text = "Horas Semanales :"
        '
        'txtSemanal
        '
        Me.txtSemanal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSemanal.Location = New System.Drawing.Point(582, 19)
        Me.txtSemanal.MaxLength = 2
        Me.txtSemanal.Name = "txtSemanal"
        Me.txtSemanal.Size = New System.Drawing.Size(38, 20)
        Me.txtSemanal.TabIndex = 8
        '
        'txtCurso
        '
        Me.txtCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurso.Location = New System.Drawing.Point(115, 11)
        Me.txtCurso.MaxLength = 50
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Size = New System.Drawing.Size(343, 20)
        Me.txtCurso.TabIndex = 5
        '
        'lblNom_Nombre
        '
        Me.lblNom_Nombre.AutoSize = True
        Me.lblNom_Nombre.Location = New System.Drawing.Point(63, 13)
        Me.lblNom_Nombre.Name = "lblNom_Nombre"
        Me.lblNom_Nombre.Size = New System.Drawing.Size(40, 13)
        Me.lblNom_Nombre.TabIndex = 6
        Me.lblNom_Nombre.Text = "Curso :"
        '
        'gbDatosEstudiante
        '
        Me.gbDatosEstudiante.Controls.Add(Me.cbCiclo)
        Me.gbDatosEstudiante.Controls.Add(Me.txtCodigo)
        Me.gbDatosEstudiante.Controls.Add(Me.cbEspecialidad)
        Me.gbDatosEstudiante.Controls.Add(Me.lblNom_Codigo)
        Me.gbDatosEstudiante.Controls.Add(Me.cbModulo)
        Me.gbDatosEstudiante.Controls.Add(Me.Label2)
        Me.gbDatosEstudiante.Controls.Add(Me.Label1)
        Me.gbDatosEstudiante.Controls.Add(Me.lblNom_Mod)
        Me.gbDatosEstudiante.Location = New System.Drawing.Point(161, 13)
        Me.gbDatosEstudiante.Name = "gbDatosEstudiante"
        Me.gbDatosEstudiante.Size = New System.Drawing.Size(552, 95)
        Me.gbDatosEstudiante.TabIndex = 29
        Me.gbDatosEstudiante.TabStop = False
        Me.gbDatosEstudiante.Text = "Informacion Principal"
        '
        'cbCiclo
        '
        Me.cbCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCiclo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbCiclo.FormattingEnabled = True
        Me.cbCiclo.Location = New System.Drawing.Point(431, 41)
        Me.cbCiclo.Name = "cbCiclo"
        Me.cbCiclo.Size = New System.Drawing.Size(94, 21)
        Me.cbCiclo.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(115, 15)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(91, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Text = "Autogenerado"
        '
        'cbEspecialidad
        '
        Me.cbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEspecialidad.FormattingEnabled = True
        Me.cbEspecialidad.Location = New System.Drawing.Point(115, 41)
        Me.cbEspecialidad.Name = "cbEspecialidad"
        Me.cbEspecialidad.Size = New System.Drawing.Size(268, 21)
        Me.cbEspecialidad.TabIndex = 2
        '
        'lblNom_Codigo
        '
        Me.lblNom_Codigo.AutoSize = True
        Me.lblNom_Codigo.Location = New System.Drawing.Point(63, 22)
        Me.lblNom_Codigo.Name = "lblNom_Codigo"
        Me.lblNom_Codigo.Size = New System.Drawing.Size(46, 13)
        Me.lblNom_Codigo.TabIndex = 0
        Me.lblNom_Codigo.Text = "Código :"
        '
        'cbModulo
        '
        Me.cbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbModulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbModulo.FormattingEnabled = True
        Me.cbModulo.Location = New System.Drawing.Point(115, 68)
        Me.cbModulo.Name = "cbModulo"
        Me.cbModulo.Size = New System.Drawing.Size(174, 21)
        Me.cbModulo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Especialidad :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(389, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Ciclo :"
        '
        'lblNom_Mod
        '
        Me.lblNom_Mod.AutoSize = True
        Me.lblNom_Mod.Location = New System.Drawing.Point(61, 73)
        Me.lblNom_Mod.Name = "lblNom_Mod"
        Me.lblNom_Mod.Size = New System.Drawing.Size(48, 13)
        Me.lblNom_Mod.TabIndex = 20
        Me.lblNom_Mod.Text = "Modulo :"
        '
        'txtCreditos
        '
        Me.txtCreditos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCreditos.Location = New System.Drawing.Point(582, 11)
        Me.txtCreditos.MaxLength = 2
        Me.txtCreditos.Name = "txtCreditos"
        Me.txtCreditos.Size = New System.Drawing.Size(38, 20)
        Me.txtCreditos.TabIndex = 6
        '
        'lbl_NomCreditos
        '
        Me.lbl_NomCreditos.AutoSize = True
        Me.lbl_NomCreditos.Location = New System.Drawing.Point(466, 16)
        Me.lbl_NomCreditos.Name = "lbl_NomCreditos"
        Me.lbl_NomCreditos.Size = New System.Drawing.Size(106, 13)
        Me.lbl_NomCreditos.TabIndex = 22
        Me.lbl_NomCreditos.Text = "Número de Créditos :"
        '
        'gbRegistro
        '
        Me.gbRegistro.Controls.Add(Me.dgRegistro)
        Me.gbRegistro.Location = New System.Drawing.Point(11, 321)
        Me.gbRegistro.Name = "gbRegistro"
        Me.gbRegistro.Size = New System.Drawing.Size(1029, 216)
        Me.gbRegistro.TabIndex = 28
        Me.gbRegistro.TabStop = False
        Me.gbRegistro.Text = "Registro"
        '
        'dgRegistro
        '
        Me.dgRegistro.AllowUserToAddRows = False
        Me.dgRegistro.AllowUserToDeleteRows = False
        Me.dgRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRegistro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Mod_Cod, Me.Modulo, Me.Curso, Me.Desc, Me.Sem, Me.Uni, Me.Cre, Me.Est, Me.Esp_Cod, Me.Cil_Cod})
        Me.dgRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRegistro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgRegistro.Location = New System.Drawing.Point(3, 16)
        Me.dgRegistro.Name = "dgRegistro"
        Me.dgRegistro.ReadOnly = True
        Me.dgRegistro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgRegistro.Size = New System.Drawing.Size(1023, 197)
        Me.dgRegistro.TabIndex = 0
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 50
        '
        'Mod_Cod
        '
        Me.Mod_Cod.DataPropertyName = "Mod_Cod"
        Me.Mod_Cod.HeaderText = "Código Módulo"
        Me.Mod_Cod.Name = "Mod_Cod"
        Me.Mod_Cod.ReadOnly = True
        Me.Mod_Cod.Visible = False
        '
        'Modulo
        '
        Me.Modulo.DataPropertyName = "Modulo"
        Me.Modulo.HeaderText = "Modulo"
        Me.Modulo.Name = "Modulo"
        Me.Modulo.ReadOnly = True
        Me.Modulo.Width = 300
        '
        'Curso
        '
        Me.Curso.DataPropertyName = "Curso"
        Me.Curso.HeaderText = "Curso"
        Me.Curso.Name = "Curso"
        Me.Curso.ReadOnly = True
        Me.Curso.Width = 300
        '
        'Desc
        '
        Me.Desc.DataPropertyName = "Desc"
        Me.Desc.HeaderText = "Descripción"
        Me.Desc.Name = "Desc"
        Me.Desc.ReadOnly = True
        Me.Desc.Visible = False
        '
        'Sem
        '
        Me.Sem.DataPropertyName = "Sem"
        Me.Sem.HeaderText = "Horas a la semana"
        Me.Sem.Name = "Sem"
        Me.Sem.ReadOnly = True
        Me.Sem.Width = 80
        '
        'Uni
        '
        Me.Uni.DataPropertyName = "Uni"
        Me.Uni.HeaderText = "Unidades académicas"
        Me.Uni.Name = "Uni"
        Me.Uni.ReadOnly = True
        Me.Uni.Width = 80
        '
        'Cre
        '
        Me.Cre.DataPropertyName = "Cre"
        Me.Cre.HeaderText = "Número de Créditos"
        Me.Cre.Name = "Cre"
        Me.Cre.ReadOnly = True
        Me.Cre.Width = 90
        '
        'Est
        '
        Me.Est.DataPropertyName = "Est"
        Me.Est.HeaderText = "Estado"
        Me.Est.Name = "Est"
        Me.Est.ReadOnly = True
        '
        'Esp_Cod
        '
        Me.Esp_Cod.DataPropertyName = "Esp_Cod"
        Me.Esp_Cod.HeaderText = "Código de Especialidad"
        Me.Esp_Cod.Name = "Esp_Cod"
        Me.Esp_Cod.ReadOnly = True
        Me.Esp_Cod.Visible = False
        '
        'Cil_Cod
        '
        Me.Cil_Cod.DataPropertyName = "Cil_Cod"
        Me.Cil_Cod.HeaderText = "Código del Ciclo"
        Me.Cil_Cod.Name = "Cil_Cod"
        Me.Cil_Cod.ReadOnly = True
        Me.Cil_Cod.Visible = False
        '
        'gbOpc
        '
        Me.gbOpc.Controls.Add(Me.btnCancelar)
        Me.gbOpc.Controls.Add(Me.btnBuscar)
        Me.gbOpc.Controls.Add(Me.BtnListar)
        Me.gbOpc.Controls.Add(Me.BtnGrabar)
        Me.gbOpc.Location = New System.Drawing.Point(161, 256)
        Me.gbOpc.Name = "gbOpc"
        Me.gbOpc.Size = New System.Drawing.Size(552, 51)
        Me.gbOpc.TabIndex = 31
        Me.gbOpc.TabStop = False
        Me.gbOpc.Text = "Opciones"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCreditos)
        Me.GroupBox1.Controls.Add(Me.txtCurso)
        Me.GroupBox1.Controls.Add(Me.lblNom_Nombre)
        Me.GroupBox1.Controls.Add(Me.lbl_NomCreditos)
        Me.GroupBox1.Location = New System.Drawing.Point(122, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 40)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Curso"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Buscar_Registro
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(66, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(82, 26)
        Me.btnBuscar.TabIndex = 15
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbMantenimiento.SetToolTip(Me.btnBuscar, "Buscar Registro")
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'FrmCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(1039, 550)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbOpc)
        Me.Controls.Add(Me.gbMantenimiento)
        Me.Controls.Add(Me.gbDetalles)
        Me.Controls.Add(Me.gbDatosEstudiante)
        Me.Controls.Add(Me.gbRegistro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCurso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "... Registro de Curso"
        Me.gbMantenimiento.ResumeLayout(False)
        Me.gbDetalles.ResumeLayout(False)
        Me.gbDetalles.PerformLayout()
        Me.gbDatosEstudiante.ResumeLayout(False)
        Me.gbDatosEstudiante.PerformLayout()
        Me.gbRegistro.ResumeLayout(False)
        CType(Me.dgRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOpc.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbMantenimiento As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnListar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents BtnInhabilitar As System.Windows.Forms.Button
    Friend WithEvents btnHabilitar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents gbDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Nom_Uni As System.Windows.Forms.Label
    Friend WithEvents lbl_NomSem As System.Windows.Forms.Label
    Friend WithEvents txtSemanal As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidades As System.Windows.Forms.TextBox
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents lblNom_Desc As System.Windows.Forms.Label
    Friend WithEvents txtCurso As System.Windows.Forms.TextBox
    Friend WithEvents lblNom_Nombre As System.Windows.Forms.Label
    Friend WithEvents gbDatosEstudiante As System.Windows.Forms.GroupBox
    Friend WithEvents cbModulo As System.Windows.Forms.ComboBox
    Friend WithEvents lblNom_Mod As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblNom_Codigo As System.Windows.Forms.Label
    Friend WithEvents gbRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents gbOpc As System.Windows.Forms.GroupBox
    Friend WithEvents tbMantenimiento As System.Windows.Forms.ToolTip
    Friend WithEvents txtCreditos As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NomCreditos As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbCiclo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents dgRegistro As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mod_Cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Curso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Uni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Est As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Esp_Cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cil_Cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
