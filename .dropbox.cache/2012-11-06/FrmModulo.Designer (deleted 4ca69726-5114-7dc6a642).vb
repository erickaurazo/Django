<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModulo))
        Me.gbMantenimiento = New System.Windows.Forms.GroupBox
        Me.BtnInhabilitar = New System.Windows.Forms.Button
        Me.btnHabilitar = New System.Windows.Forms.Button
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnEditar = New System.Windows.Forms.Button
        Me.gbDetalles = New System.Windows.Forms.GroupBox
        Me.lbl_Nom_Uni = New System.Windows.Forms.Label
        Me.lbl_NomDuracion = New System.Windows.Forms.Label
        Me.txtDuracion = New System.Windows.Forms.TextBox
        Me.txtUnidades = New System.Windows.Forms.TextBox
        Me.txtTitulo = New System.Windows.Forms.TextBox
        Me.lblNom_Titulo = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNom_Nombre = New System.Windows.Forms.Label
        Me.lblNom_Esp = New System.Windows.Forms.Label
        Me.gbDatosEstudiante = New System.Windows.Forms.GroupBox
        Me.cbCiclo = New System.Windows.Forms.ComboBox
        Me.cbEspecialidad = New System.Windows.Forms.ComboBox
        Me.lblNom_Ciclo = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblNom_Codigo = New System.Windows.Forms.Label
        Me.gbRegistro = New System.Windows.Forms.GroupBox
        Me.dgRegistro = New System.Windows.Forms.DataGridView
        Me.timMantenimiento = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbOpc = New System.Windows.Forms.GroupBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnListar = New System.Windows.Forms.Button
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.gbMantenimiento.SuspendLayout()
        Me.gbDetalles.SuspendLayout()
        Me.gbDatosEstudiante.SuspendLayout()
        Me.gbRegistro.SuspendLayout()
        CType(Me.dgRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOpc.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbMantenimiento
        '
        Me.gbMantenimiento.Controls.Add(Me.BtnInhabilitar)
        Me.gbMantenimiento.Controls.Add(Me.btnHabilitar)
        Me.gbMantenimiento.Controls.Add(Me.BtnNuevo)
        Me.gbMantenimiento.Controls.Add(Me.btnEliminar)
        Me.gbMantenimiento.Controls.Add(Me.btnEditar)
        Me.gbMantenimiento.Location = New System.Drawing.Point(643, 12)
        Me.gbMantenimiento.Name = "gbMantenimiento"
        Me.gbMantenimiento.Size = New System.Drawing.Size(98, 242)
        Me.gbMantenimiento.TabIndex = 23
        Me.gbMantenimiento.TabStop = False
        Me.gbMantenimiento.Text = "Mantenimiento"
        '
        'BtnInhabilitar
        '
        Me.BtnInhabilitar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.habilitaDO
        Me.BtnInhabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnInhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnInhabilitar.Location = New System.Drawing.Point(29, 162)
        Me.BtnInhabilitar.Name = "BtnInhabilitar"
        Me.BtnInhabilitar.Size = New System.Drawing.Size(33, 32)
        Me.BtnInhabilitar.TabIndex = 27
        Me.timMantenimiento.SetToolTip(Me.BtnInhabilitar, "Inhabilitar Registro")
        Me.BtnInhabilitar.UseVisualStyleBackColor = True
        '
        'btnHabilitar
        '
        Me.btnHabilitar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Inhabilitado_jpg
        Me.btnHabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHabilitar.Location = New System.Drawing.Point(29, 117)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(33, 32)
        Me.btnHabilitar.TabIndex = 26
        Me.timMantenimiento.SetToolTip(Me.btnHabilitar, "Habilitar Registro")
        Me.btnHabilitar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Nuevo2
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNuevo.Location = New System.Drawing.Point(29, 26)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(33, 32)
        Me.BtnNuevo.TabIndex = 24
        Me.timMantenimiento.SetToolTip(Me.BtnNuevo, "Nuevo Registro")
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.datele
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Location = New System.Drawing.Point(29, 200)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(33, 32)
        Me.btnEliminar.TabIndex = 25
        Me.timMantenimiento.SetToolTip(Me.btnEliminar, "Eliminar Registro")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.edit
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditar.Location = New System.Drawing.Point(29, 72)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(33, 31)
        Me.btnEditar.TabIndex = 23
        Me.timMantenimiento.SetToolTip(Me.btnEditar, "Editar Registro")
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'gbDetalles
        '
        Me.gbDetalles.Controls.Add(Me.lbl_Nom_Uni)
        Me.gbDetalles.Controls.Add(Me.lbl_NomDuracion)
        Me.gbDetalles.Controls.Add(Me.txtDuracion)
        Me.gbDetalles.Controls.Add(Me.txtUnidades)
        Me.gbDetalles.Controls.Add(Me.txtTitulo)
        Me.gbDetalles.Controls.Add(Me.lblNom_Titulo)
        Me.gbDetalles.Controls.Add(Me.txtNombre)
        Me.gbDetalles.Controls.Add(Me.lblNom_Nombre)
        Me.gbDetalles.Location = New System.Drawing.Point(58, 117)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(563, 120)
        Me.gbDetalles.TabIndex = 26
        Me.gbDetalles.TabStop = False
        Me.gbDetalles.Text = "Detalles"
        '
        'lbl_Nom_Uni
        '
        Me.lbl_Nom_Uni.AutoSize = True
        Me.lbl_Nom_Uni.Location = New System.Drawing.Point(79, 67)
        Me.lbl_Nom_Uni.Name = "lbl_Nom_Uni"
        Me.lbl_Nom_Uni.Size = New System.Drawing.Size(58, 13)
        Me.lbl_Nom_Uni.TabIndex = 27
        Me.lbl_Nom_Uni.Text = "Unidades :"
        '
        'lbl_NomDuracion
        '
        Me.lbl_NomDuracion.AutoSize = True
        Me.lbl_NomDuracion.Location = New System.Drawing.Point(78, 88)
        Me.lbl_NomDuracion.Name = "lbl_NomDuracion"
        Me.lbl_NomDuracion.Size = New System.Drawing.Size(56, 13)
        Me.lbl_NomDuracion.TabIndex = 26
        Me.lbl_NomDuracion.Text = "Duración :"
        '
        'txtDuracion
        '
        Me.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuracion.Location = New System.Drawing.Point(141, 87)
        Me.txtDuracion.MaxLength = 3
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(43, 20)
        Me.txtDuracion.TabIndex = 25
        '
        'txtUnidades
        '
        Me.txtUnidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnidades.Location = New System.Drawing.Point(141, 63)
        Me.txtUnidades.MaxLength = 50
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(256, 20)
        Me.txtUnidades.TabIndex = 24
        '
        'txtTitulo
        '
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitulo.Location = New System.Drawing.Point(141, 11)
        Me.txtTitulo.MaxLength = 50
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(353, 20)
        Me.txtTitulo.TabIndex = 23
        '
        'lblNom_Titulo
        '
        Me.lblNom_Titulo.AutoSize = True
        Me.lblNom_Titulo.Location = New System.Drawing.Point(94, 18)
        Me.lblNom_Titulo.Name = "lblNom_Titulo"
        Me.lblNom_Titulo.Size = New System.Drawing.Size(41, 13)
        Me.lblNom_Titulo.TabIndex = 22
        Me.lblNom_Titulo.Text = "Título :"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(141, 37)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(353, 20)
        Me.txtNombre.TabIndex = 17
        '
        'lblNom_Nombre
        '
        Me.lblNom_Nombre.AutoSize = True
        Me.lblNom_Nombre.Location = New System.Drawing.Point(85, 44)
        Me.lblNom_Nombre.Name = "lblNom_Nombre"
        Me.lblNom_Nombre.Size = New System.Drawing.Size(50, 13)
        Me.lblNom_Nombre.TabIndex = 6
        Me.lblNom_Nombre.Text = "Nombre :"
        '
        'lblNom_Esp
        '
        Me.lblNom_Esp.AutoSize = True
        Me.lblNom_Esp.Location = New System.Drawing.Point(65, 45)
        Me.lblNom_Esp.Name = "lblNom_Esp"
        Me.lblNom_Esp.Size = New System.Drawing.Size(73, 13)
        Me.lblNom_Esp.TabIndex = 20
        Me.lblNom_Esp.Text = "Especialidad :"
        '
        'gbDatosEstudiante
        '
        Me.gbDatosEstudiante.Controls.Add(Me.cbCiclo)
        Me.gbDatosEstudiante.Controls.Add(Me.cbEspecialidad)
        Me.gbDatosEstudiante.Controls.Add(Me.lblNom_Esp)
        Me.gbDatosEstudiante.Controls.Add(Me.lblNom_Ciclo)
        Me.gbDatosEstudiante.Controls.Add(Me.txtCodigo)
        Me.gbDatosEstudiante.Controls.Add(Me.lblNom_Codigo)
        Me.gbDatosEstudiante.Location = New System.Drawing.Point(139, 12)
        Me.gbDatosEstudiante.Name = "gbDatosEstudiante"
        Me.gbDatosEstudiante.Size = New System.Drawing.Size(413, 96)
        Me.gbDatosEstudiante.TabIndex = 25
        Me.gbDatosEstudiante.TabStop = False
        Me.gbDatosEstudiante.Text = "Informacion Principal"
        '
        'cbCiclo
        '
        Me.cbCiclo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbCiclo.FormattingEnabled = True
        Me.cbCiclo.Location = New System.Drawing.Point(142, 68)
        Me.cbCiclo.Name = "cbCiclo"
        Me.cbCiclo.Size = New System.Drawing.Size(174, 21)
        Me.cbCiclo.TabIndex = 22
        '
        'cbEspecialidad
        '
        Me.cbEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbEspecialidad.FormattingEnabled = True
        Me.cbEspecialidad.Location = New System.Drawing.Point(142, 42)
        Me.cbEspecialidad.Name = "cbEspecialidad"
        Me.cbEspecialidad.Size = New System.Drawing.Size(174, 21)
        Me.cbEspecialidad.TabIndex = 21
        '
        'lblNom_Ciclo
        '
        Me.lblNom_Ciclo.AutoSize = True
        Me.lblNom_Ciclo.Location = New System.Drawing.Point(102, 65)
        Me.lblNom_Ciclo.Name = "lblNom_Ciclo"
        Me.lblNom_Ciclo.Size = New System.Drawing.Size(36, 13)
        Me.lblNom_Ciclo.TabIndex = 18
        Me.lblNom_Ciclo.Text = "Ciclo :"
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(142, 16)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(78, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Text = "Autogenerado"
        '
        'lblNom_Codigo
        '
        Me.lblNom_Codigo.AutoSize = True
        Me.lblNom_Codigo.Location = New System.Drawing.Point(92, 23)
        Me.lblNom_Codigo.Name = "lblNom_Codigo"
        Me.lblNom_Codigo.Size = New System.Drawing.Size(46, 13)
        Me.lblNom_Codigo.TabIndex = 0
        Me.lblNom_Codigo.Text = "Código :"
        '
        'gbRegistro
        '
        Me.gbRegistro.Controls.Add(Me.dgRegistro)
        Me.gbRegistro.Location = New System.Drawing.Point(3, 288)
        Me.gbRegistro.Name = "gbRegistro"
        Me.gbRegistro.Size = New System.Drawing.Size(764, 449)
        Me.gbRegistro.TabIndex = 24
        Me.gbRegistro.TabStop = False
        Me.gbRegistro.Text = "Registro"
        '
        'dgRegistro
        '
        Me.dgRegistro.AllowUserToDeleteRows = False
        Me.dgRegistro.AllowUserToOrderColumns = True
        Me.dgRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRegistro.Location = New System.Drawing.Point(3, 16)
        Me.dgRegistro.Name = "dgRegistro"
        Me.dgRegistro.ReadOnly = True
        Me.dgRegistro.Size = New System.Drawing.Size(758, 430)
        Me.dgRegistro.TabIndex = 0
        '
        'gbOpc
        '
        Me.gbOpc.Controls.Add(Me.btnCancelar)
        Me.gbOpc.Controls.Add(Me.btnBuscar)
        Me.gbOpc.Controls.Add(Me.btnListar)
        Me.gbOpc.Controls.Add(Me.btnGrabar)
        Me.gbOpc.Location = New System.Drawing.Point(288, 236)
        Me.gbOpc.Name = "gbOpc"
        Me.gbOpc.Size = New System.Drawing.Size(174, 51)
        Me.gbOpc.TabIndex = 32
        Me.gbOpc.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Anular_Matricula1
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelar.Location = New System.Drawing.Point(134, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(33, 33)
        Me.btnCancelar.TabIndex = 29
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.inscripcion_estado
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Location = New System.Drawing.Point(18, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(33, 33)
        Me.btnBuscar.TabIndex = 30
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.listar
        Me.btnListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnListar.Location = New System.Drawing.Point(95, 12)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(33, 33)
        Me.btnListar.TabIndex = 25
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.save_j2pg
        Me.btnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGrabar.Location = New System.Drawing.Point(57, 12)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(33, 33)
        Me.btnGrabar.TabIndex = 28
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'FrmModulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(785, 743)
        Me.Controls.Add(Me.gbOpc)
        Me.Controls.Add(Me.gbMantenimiento)
        Me.Controls.Add(Me.gbDetalles)
        Me.Controls.Add(Me.gbDatosEstudiante)
        Me.Controls.Add(Me.gbRegistro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmModulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "... Registro de Modulos"
        Me.gbMantenimiento.ResumeLayout(False)
        Me.gbDetalles.ResumeLayout(False)
        Me.gbDetalles.PerformLayout()
        Me.gbDatosEstudiante.ResumeLayout(False)
        Me.gbDatosEstudiante.PerformLayout()
        Me.gbRegistro.ResumeLayout(False)
        CType(Me.dgRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOpc.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbMantenimiento As System.Windows.Forms.GroupBox
    Friend WithEvents BtnInhabilitar As System.Windows.Forms.Button
    Friend WithEvents btnHabilitar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents gbDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents lblNom_Titulo As System.Windows.Forms.Label
    Friend WithEvents lblNom_Esp As System.Windows.Forms.Label
    Friend WithEvents gbDatosEstudiante As System.Windows.Forms.GroupBox
    Friend WithEvents lblNom_Ciclo As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNom_Nombre As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblNom_Codigo As System.Windows.Forms.Label
    Friend WithEvents gbRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents dgRegistro As System.Windows.Forms.DataGridView
    Friend WithEvents cbEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbCiclo As System.Windows.Forms.ComboBox
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Nom_Uni As System.Windows.Forms.Label
    Friend WithEvents lbl_NomDuracion As System.Windows.Forms.Label
    Friend WithEvents txtDuracion As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidades As System.Windows.Forms.TextBox
    Friend WithEvents timMantenimiento As System.Windows.Forms.ToolTip
    Friend WithEvents gbOpc As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
End Class
