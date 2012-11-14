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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEspecialidad))
        Me.gbRegistro = New System.Windows.Forms.GroupBox()
        Me.dgRegistro = New System.Windows.Forms.DataGridView()
        Me.gbDatosEstudiante = New System.Windows.Forms.GroupBox()
        Me.txtSiglas = New System.Windows.Forms.TextBox()
        Me.lblNom_Siglas = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNom_Nombre = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblNom_Codigo = New System.Windows.Forms.Label()
        Me.lblNom_Desc = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.gbDetalles = New System.Windows.Forms.GroupBox()
        Me.lblNom_Perfil = New System.Windows.Forms.Label()
        Me.txtPerfil = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.BtnListar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.BtnInhabilitar = New System.Windows.Forms.Button()
        Me.btnHabilitar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.timMantenimiento = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gbRegistro.SuspendLayout()
        CType(Me.dgRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosEstudiante.SuspendLayout()
        Me.gbDetalles.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbRegistro
        '
        Me.gbRegistro.Controls.Add(Me.dgRegistro)
        Me.gbRegistro.Location = New System.Drawing.Point(14, 340)
        Me.gbRegistro.Name = "gbRegistro"
        Me.gbRegistro.Size = New System.Drawing.Size(725, 208)
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
        Me.dgRegistro.Size = New System.Drawing.Size(719, 189)
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
        Me.gbDatosEstudiante.Location = New System.Drawing.Point(14, 5)
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
        Me.lblNom_Desc.Location = New System.Drawing.Point(6, 17)
        Me.lblNom_Desc.Name = "lblNom_Desc"
        Me.lblNom_Desc.Size = New System.Drawing.Size(66, 13)
        Me.lblNom_Desc.TabIndex = 20
        Me.lblNom_Desc.Text = "Descripción:"
        '
        'txtDesc
        '
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Location = New System.Drawing.Point(70, 32)
        Me.txtDesc.MaxLength = 200
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(470, 66)
        Me.txtDesc.TabIndex = 21
        '
        'gbDetalles
        '
        Me.gbDetalles.Controls.Add(Me.lblNom_Perfil)
        Me.gbDetalles.Controls.Add(Me.txtPerfil)
        Me.gbDetalles.Controls.Add(Me.lblNom_Desc)
        Me.gbDetalles.Controls.Add(Me.txtDesc)
        Me.gbDetalles.Location = New System.Drawing.Point(14, 85)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(560, 194)
        Me.gbDetalles.TabIndex = 22
        Me.gbDetalles.TabStop = False
        Me.gbDetalles.Text = "Detalles"
        '
        'lblNom_Perfil
        '
        Me.lblNom_Perfil.AutoSize = True
        Me.lblNom_Perfil.Location = New System.Drawing.Point(6, 105)
        Me.lblNom_Perfil.Name = "lblNom_Perfil"
        Me.lblNom_Perfil.Size = New System.Drawing.Size(104, 13)
        Me.lblNom_Perfil.TabIndex = 22
        Me.lblNom_Perfil.Text = "Perfil de Estudiante :"
        '
        'txtPerfil
        '
        Me.txtPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPerfil.Location = New System.Drawing.Point(70, 123)
        Me.txtPerfil.MaxLength = 200
        Me.txtPerfil.Multiline = True
        Me.txtPerfil.Name = "txtPerfil"
        Me.txtPerfil.Size = New System.Drawing.Size(470, 64)
        Me.txtPerfil.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnInhabilitar)
        Me.GroupBox1.Controls.Add(Me.btnHabilitar)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Location = New System.Drawing.Point(597, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 285)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Cancelar_Registros
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(444, 19)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 27)
        Me.btnCancelar.TabIndex = 29
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.timMantenimiento.SetToolTip(Me.btnCancelar, "Cancelar  Registro")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'BtnListar
        '
        Me.BtnListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnListar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Listar_icono
        Me.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnListar.Location = New System.Drawing.Point(332, 19)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(82, 27)
        Me.BtnListar.TabIndex = 25
        Me.BtnListar.Text = "Listar"
        Me.BtnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.timMantenimiento.SetToolTip(Me.BtnListar, "Listar Registro")
        Me.BtnListar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGrabar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Guardar_Archivo
        Me.BtnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGrabar.Location = New System.Drawing.Point(198, 19)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(85, 27)
        Me.BtnGrabar.TabIndex = 28
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.timMantenimiento.SetToolTip(Me.BtnGrabar, "Guardar Registro")
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'BtnInhabilitar
        '
        Me.BtnInhabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnInhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnInhabilitar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reservar
        Me.BtnInhabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInhabilitar.Location = New System.Drawing.Point(22, 234)
        Me.BtnInhabilitar.Name = "BtnInhabilitar"
        Me.BtnInhabilitar.Size = New System.Drawing.Size(96, 35)
        Me.BtnInhabilitar.TabIndex = 27
        Me.BtnInhabilitar.Text = "Inhabilitar"
        Me.BtnInhabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.timMantenimiento.SetToolTip(Me.BtnInhabilitar, "Inhabilitar Registro")
        Me.BtnInhabilitar.UseVisualStyleBackColor = True
        '
        'btnHabilitar
        '
        Me.btnHabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHabilitar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reservar
        Me.btnHabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHabilitar.Location = New System.Drawing.Point(21, 185)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(96, 37)
        Me.btnHabilitar.TabIndex = 26
        Me.btnHabilitar.Text = "Habilitar"
        Me.btnHabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.timMantenimiento.SetToolTip(Me.btnHabilitar, "Habilitar Registro")
        Me.btnHabilitar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNuevo.Image = Global.Matricula.Presentacion.My.Resources.Resources.Nuevo
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(21, 34)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(96, 29)
        Me.BtnNuevo.TabIndex = 24
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.timMantenimiento.SetToolTip(Me.BtnNuevo, "Nuevo Registro")
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Cancelar_Php
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(21, 136)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(96, 34)
        Me.btnEliminar.TabIndex = 25
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.timMantenimiento.SetToolTip(Me.btnEliminar, "Eliminar Registro")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Modificar_Registro
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(21, 84)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(96, 29)
        Me.btnEditar.TabIndex = 23
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.timMantenimiento.SetToolTip(Me.btnEditar, "Editar Registro")
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.btnBuscar)
        Me.gbOpciones.Controls.Add(Me.btnCancelar)
        Me.gbOpciones.Controls.Add(Me.BtnGrabar)
        Me.gbOpciones.Controls.Add(Me.BtnListar)
        Me.gbOpciones.Location = New System.Drawing.Point(14, 282)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(560, 52)
        Me.gbOpciones.TabIndex = 20
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "Opciones"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Buscar_Registro
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(74, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(89, 27)
        Me.btnBuscar.TabIndex = 23
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'FrmEspecialidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(758, 569)
        Me.Controls.Add(Me.gbOpciones)
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
        Me.gbOpciones.ResumeLayout(False)
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
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
