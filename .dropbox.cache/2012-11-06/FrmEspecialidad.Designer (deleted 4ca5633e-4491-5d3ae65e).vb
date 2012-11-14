<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEspecialidad
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEspecialidad))
        Me.gbRegistro = New System.Windows.Forms.GroupBox
        Me.dgRegistro = New System.Windows.Forms.DataGridView
        Me.gbDatosEstudiante = New System.Windows.Forms.GroupBox
        Me.txtSiglas = New System.Windows.Forms.TextBox
        Me.lblNom_Siglas = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNom_Nombre = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblNom_Codigo = New System.Windows.Forms.Label
        Me.lblNom_Desc = New System.Windows.Forms.Label
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.gbDetalles = New System.Windows.Forms.GroupBox
        Me.lblNom_Perfil = New System.Windows.Forms.Label
        Me.txtPerfil = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.timMantenimiento = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.BtnListar = New System.Windows.Forms.Button
        Me.BtnGrabar = New System.Windows.Forms.Button
        Me.BtnInhabilitar = New System.Windows.Forms.Button
        Me.btnHabilitar = New System.Windows.Forms.Button
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnEditar = New System.Windows.Forms.Button
        Me.gbRegistro.SuspendLayout()
        CType(Me.dgRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosEstudiante.SuspendLayout()
        Me.gbDetalles.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbRegistro
        '
        Me.gbRegistro.Controls.Add(Me.dgRegistro)
        Me.gbRegistro.Location = New System.Drawing.Point(25, 361)
        Me.gbRegistro.Name = "gbRegistro"
        Me.gbRegistro.Size = New System.Drawing.Size(733, 243)
        Me.gbRegistro.TabIndex = 15
        Me.gbRegistro.TabStop = False
        Me.gbRegistro.Text = "Registro"
        '
        'dgRegistro
        '
        Me.dgRegistro.AllowUserToAddRows = False
        Me.dgRegistro.AllowUserToDeleteRows = False
        Me.dgRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRegistro.Location = New System.Drawing.Point(3, 16)
        Me.dgRegistro.Name = "dgRegistro"
        Me.dgRegistro.ReadOnly = True
        Me.dgRegistro.Size = New System.Drawing.Size(727, 224)
        Me.dgRegistro.TabIndex = 0
        '
        'gbDatosEstudiante
        '
        Me.gbDatosEstudiante.Controls.Add(Me.txtSiglas)
        Me.gbDatosEstudiante.Controls.Add(Me.lblNom_Siglas)
        Me.gbDatosEstudiante.Controls.Add(Me.txtNombre)
        Me.gbDatosEstudiante.Controls.Add(Me.lblNom_Nombre)
        Me.gbDatosEstudiante.Controls.Add(Me.txtCodigo)
        Me.gbDatosEstudiante.Controls.Add(Me.lblNom_Codigo)
        Me.gbDatosEstudiante.Location = New System.Drawing.Point(46, 12)
        Me.gbDatosEstudiante.Name = "gbDatosEstudiante"
        Me.gbDatosEstudiante.Size = New System.Drawing.Size(560, 74)
        Me.gbDatosEstudiante.TabIndex = 16
        Me.gbDatosEstudiante.TabStop = False
        Me.gbDatosEstudiante.Text = "Informacion Principal"
        '
        'txtSiglas
        '
        Me.txtSiglas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSiglas.Location = New System.Drawing.Point(431, 45)
        Me.txtSiglas.MaxLength = 6
        Me.txtSiglas.Name = "txtSiglas"
        Me.txtSiglas.Size = New System.Drawing.Size(67, 20)
        Me.txtSiglas.TabIndex = 19
        '
        'lblNom_Siglas
        '
        Me.lblNom_Siglas.AutoSize = True
        Me.lblNom_Siglas.Location = New System.Drawing.Point(384, 48)
        Me.lblNom_Siglas.Name = "lblNom_Siglas"
        Me.lblNom_Siglas.Size = New System.Drawing.Size(41, 13)
        Me.lblNom_Siglas.TabIndex = 18
        Me.lblNom_Siglas.Text = "Siglas :"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(70, 45)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(286, 20)
        Me.txtNombre.TabIndex = 17
        '
        'lblNom_Nombre
        '
        Me.lblNom_Nombre.AutoSize = True
        Me.lblNom_Nombre.Location = New System.Drawing.Point(6, 48)
        Me.lblNom_Nombre.Name = "lblNom_Nombre"
        Me.lblNom_Nombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNom_Nombre.TabIndex = 6
        Me.lblNom_Nombre.Text = "Nombre:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(70, 19)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(78, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Text = "Autogenerado"
        '
        'lblNom_Codigo
        '
        Me.lblNom_Codigo.AutoSize = True
        Me.lblNom_Codigo.Location = New System.Drawing.Point(6, 22)
        Me.lblNom_Codigo.Name = "lblNom_Codigo"
        Me.lblNom_Codigo.Size = New System.Drawing.Size(40, 13)
        Me.lblNom_Codigo.TabIndex = 0
        Me.lblNom_Codigo.Text = "Código"
        '
        'lblNom_Desc
        '
        Me.lblNom_Desc.AutoSize = True
        Me.lblNom_Desc.Location = New System.Drawing.Point(6, 28)
        Me.lblNom_Desc.Name = "lblNom_Desc"
        Me.lblNom_Desc.Size = New System.Drawing.Size(66, 13)
        Me.lblNom_Desc.TabIndex = 20
        Me.lblNom_Desc.Text = "Descripción:"
        '
        'txtDesc
        '
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Location = New System.Drawing.Point(73, 28)
        Me.txtDesc.MaxLength = 200
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(170, 206)
        Me.txtDesc.TabIndex = 21
        '
        'gbDetalles
        '
        Me.gbDetalles.Controls.Add(Me.lblNom_Perfil)
        Me.gbDetalles.Controls.Add(Me.txtPerfil)
        Me.gbDetalles.Controls.Add(Me.lblNom_Desc)
        Me.gbDetalles.Controls.Add(Me.txtDesc)
        Me.gbDetalles.Location = New System.Drawing.Point(46, 92)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(560, 263)
        Me.gbDetalles.TabIndex = 22
        Me.gbDetalles.TabStop = False
        Me.gbDetalles.Text = "Detalles"
        '
        'lblNom_Perfil
        '
        Me.lblNom_Perfil.AutoSize = True
        Me.lblNom_Perfil.Location = New System.Drawing.Point(252, 30)
        Me.lblNom_Perfil.Name = "lblNom_Perfil"
        Me.lblNom_Perfil.Size = New System.Drawing.Size(104, 13)
        Me.lblNom_Perfil.TabIndex = 22
        Me.lblNom_Perfil.Text = "Perfil de Estudiante :"
        '
        'txtPerfil
        '
        Me.txtPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPerfil.Location = New System.Drawing.Point(362, 28)
        Me.txtPerfil.MaxLength = 200
        Me.txtPerfil.Multiline = True
        Me.txtPerfil.Name = "txtPerfil"
        Me.txtPerfil.Size = New System.Drawing.Size(179, 206)
        Me.txtPerfil.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnListar)
        Me.GroupBox1.Controls.Add(Me.BtnGrabar)
        Me.GroupBox1.Controls.Add(Me.BtnInhabilitar)
        Me.GroupBox1.Controls.Add(Me.btnHabilitar)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Location = New System.Drawing.Point(624, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(95, 343)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Anular_Matricula1
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelar.Location = New System.Drawing.Point(32, 306)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(33, 31)
        Me.btnCancelar.TabIndex = 29
        Me.timMantenimiento.SetToolTip(Me.btnCancelar, "Cancelar  Registro")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'BtnListar
        '
        Me.BtnListar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.listar
        Me.BtnListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnListar.Location = New System.Drawing.Point(32, 19)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(33, 38)
        Me.BtnListar.TabIndex = 25
        Me.timMantenimiento.SetToolTip(Me.BtnListar, "Listar Registro")
        Me.BtnListar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.save_j2pg
        Me.BtnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGrabar.Location = New System.Drawing.Point(32, 267)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(33, 33)
        Me.BtnGrabar.TabIndex = 28
        Me.timMantenimiento.SetToolTip(Me.BtnGrabar, "Guardar Registro")
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'BtnInhabilitar
        '
        Me.BtnInhabilitar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.habilitaDO
        Me.BtnInhabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnInhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnInhabilitar.Location = New System.Drawing.Point(32, 231)
        Me.BtnInhabilitar.Name = "BtnInhabilitar"
        Me.BtnInhabilitar.Size = New System.Drawing.Size(33, 30)
        Me.BtnInhabilitar.TabIndex = 27
        Me.timMantenimiento.SetToolTip(Me.BtnInhabilitar, "Inhabilitar Registro")
        Me.BtnInhabilitar.UseVisualStyleBackColor = True
        '
        'btnHabilitar
        '
        Me.btnHabilitar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Inhabilitado_jpg
        Me.btnHabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHabilitar.Location = New System.Drawing.Point(32, 186)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(33, 39)
        Me.btnHabilitar.TabIndex = 26
        Me.timMantenimiento.SetToolTip(Me.btnHabilitar, "Habilitar Registro")
        Me.btnHabilitar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Nuevo2
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNuevo.Location = New System.Drawing.Point(32, 63)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(33, 38)
        Me.BtnNuevo.TabIndex = 24
        Me.timMantenimiento.SetToolTip(Me.BtnNuevo, "Nuevo Registro")
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.datele
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Location = New System.Drawing.Point(32, 149)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(33, 34)
        Me.btnEliminar.TabIndex = 25
        Me.timMantenimiento.SetToolTip(Me.btnEliminar, "Eliminar Registro")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.edit
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditar.Location = New System.Drawing.Point(32, 107)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(33, 36)
        Me.btnEditar.TabIndex = 23
        Me.timMantenimiento.SetToolTip(Me.btnEditar, "Editar Registro")
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'FrmEspecialidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(770, 605)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbDetalles)
        Me.Controls.Add(Me.gbDatosEstudiante)
        Me.Controls.Add(Me.gbRegistro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEspecialidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "... Mantenimiento de Especialidad"
        Me.gbRegistro.ResumeLayout(False)
        CType(Me.dgRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosEstudiante.ResumeLayout(False)
        Me.gbDatosEstudiante.PerformLayout()
        Me.gbDetalles.ResumeLayout(False)
        Me.gbDetalles.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents dgRegistro As System.Windows.Forms.DataGridView
    Friend WithEvents gbDatosEstudiante As System.Windows.Forms.GroupBox
    Friend WithEvents lblNom_Nombre As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblNom_Codigo As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtSiglas As System.Windows.Forms.TextBox
    Friend WithEvents lblNom_Siglas As System.Windows.Forms.Label
    Friend WithEvents lblNom_Desc As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents gbDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents lblNom_Perfil As System.Windows.Forms.Label
    Friend WithEvents txtPerfil As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnInhabilitar As System.Windows.Forms.Button
    Friend WithEvents btnHabilitar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents timMantenimiento As System.Windows.Forms.ToolTip
    Friend WithEvents BtnListar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
