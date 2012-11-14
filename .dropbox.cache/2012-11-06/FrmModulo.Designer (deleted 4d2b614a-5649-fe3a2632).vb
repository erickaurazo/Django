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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModulo))
        Me.gbMantenimiento = New System.Windows.Forms.GroupBox()
        Me.BtnInhabilitar = New System.Windows.Forms.Button()
        Me.btnHabilitar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.gbDetalles = New System.Windows.Forms.GroupBox()
        Me.lbl_Nom_Uni = New System.Windows.Forms.Label()
        Me.lbl_NomDuracion = New System.Windows.Forms.Label()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.lblNom_Titulo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNom_Nombre = New System.Windows.Forms.Label()
        Me.lblNom_Esp = New System.Windows.Forms.Label()
        Me.gbDatosEstudiante = New System.Windows.Forms.GroupBox()
        Me.cbCiclo = New System.Windows.Forms.ComboBox()
        Me.cbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.lblNom_Ciclo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblNom_Codigo = New System.Windows.Forms.Label()
        Me.gbRegistro = New System.Windows.Forms.GroupBox()
        Me.dgRegistro = New System.Windows.Forms.DataGridView()
        Me.gbOpc = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
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
        Me.gbMantenimiento.Location = New System.Drawing.Point(594, 54)
        Me.gbMantenimiento.Name = "gbMantenimiento"
        Me.gbMantenimiento.Size = New System.Drawing.Size(127, 234)
        Me.gbMantenimiento.TabIndex = 23
        Me.gbMantenimiento.TabStop = False
        Me.gbMantenimiento.Text = "Mantenimiento"
        '
        'BtnInhabilitar
        '
        Me.BtnInhabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnInhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnInhabilitar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reservar
        Me.BtnInhabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInhabilitar.Location = New System.Drawing.Point(17, 144)
        Me.BtnInhabilitar.Name = "BtnInhabilitar"
        Me.BtnInhabilitar.Size = New System.Drawing.Size(86, 32)
        Me.BtnInhabilitar.TabIndex = 11
        Me.BtnInhabilitar.Text = "Inhabilitar"
        Me.BtnInhabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInhabilitar.UseVisualStyleBackColor = True
        '
        'btnHabilitar
        '
        Me.btnHabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHabilitar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reservar
        Me.btnHabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHabilitar.Location = New System.Drawing.Point(17, 103)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(86, 32)
        Me.btnHabilitar.TabIndex = 10
        Me.btnHabilitar.Text = "Habilitar"
        Me.btnHabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHabilitar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNuevo.Image = Global.Matricula.Presentacion.My.Resources.Resources.Nuevo
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(17, 26)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(86, 32)
        Me.BtnNuevo.TabIndex = 8
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Cancelar_Php
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(17, 186)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(86, 32)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Modificar_Registro
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(17, 64)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(86, 31)
        Me.btnEditar.TabIndex = 9
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.gbDetalles.Location = New System.Drawing.Point(79, 123)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(500, 120)
        Me.gbDetalles.TabIndex = 26
        Me.gbDetalles.TabStop = False
        Me.gbDetalles.Text = "Detalles"
        '
        'lbl_Nom_Uni
        '
        Me.lbl_Nom_Uni.AutoSize = True
        Me.lbl_Nom_Uni.Location = New System.Drawing.Point(44, 69)
        Me.lbl_Nom_Uni.Name = "lbl_Nom_Uni"
        Me.lbl_Nom_Uni.Size = New System.Drawing.Size(58, 13)
        Me.lbl_Nom_Uni.TabIndex = 27
        Me.lbl_Nom_Uni.Text = "Unidades :"
        '
        'lbl_NomDuracion
        '
        Me.lbl_NomDuracion.AutoSize = True
        Me.lbl_NomDuracion.Location = New System.Drawing.Point(43, 90)
        Me.lbl_NomDuracion.Name = "lbl_NomDuracion"
        Me.lbl_NomDuracion.Size = New System.Drawing.Size(56, 13)
        Me.lbl_NomDuracion.TabIndex = 26
        Me.lbl_NomDuracion.Text = "Duración :"
        '
        'txtDuracion
        '
        Me.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuracion.Location = New System.Drawing.Point(106, 89)
        Me.txtDuracion.MaxLength = 3
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(43, 20)
        Me.txtDuracion.TabIndex = 7
        '
        'txtUnidades
        '
        Me.txtUnidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnidades.Location = New System.Drawing.Point(106, 65)
        Me.txtUnidades.MaxLength = 50
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(256, 20)
        Me.txtUnidades.TabIndex = 6
        '
        'txtTitulo
        '
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitulo.Location = New System.Drawing.Point(106, 13)
        Me.txtTitulo.MaxLength = 50
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(353, 20)
        Me.txtTitulo.TabIndex = 4
        '
        'lblNom_Titulo
        '
        Me.lblNom_Titulo.AutoSize = True
        Me.lblNom_Titulo.Location = New System.Drawing.Point(59, 20)
        Me.lblNom_Titulo.Name = "lblNom_Titulo"
        Me.lblNom_Titulo.Size = New System.Drawing.Size(41, 13)
        Me.lblNom_Titulo.TabIndex = 22
        Me.lblNom_Titulo.Text = "Título :"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(106, 39)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(353, 20)
        Me.txtNombre.TabIndex = 5
        '
        'lblNom_Nombre
        '
        Me.lblNom_Nombre.AutoSize = True
        Me.lblNom_Nombre.Location = New System.Drawing.Point(50, 46)
        Me.lblNom_Nombre.Name = "lblNom_Nombre"
        Me.lblNom_Nombre.Size = New System.Drawing.Size(50, 13)
        Me.lblNom_Nombre.TabIndex = 6
        Me.lblNom_Nombre.Text = "Nombre :"
        '
        'lblNom_Esp
        '
        Me.lblNom_Esp.AutoSize = True
        Me.lblNom_Esp.Location = New System.Drawing.Point(38, 45)
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
        Me.gbDatosEstudiante.Location = New System.Drawing.Point(185, 12)
        Me.gbDatosEstudiante.Name = "gbDatosEstudiante"
        Me.gbDatosEstudiante.Size = New System.Drawing.Size(329, 109)
        Me.gbDatosEstudiante.TabIndex = 25
        Me.gbDatosEstudiante.TabStop = False
        Me.gbDatosEstudiante.Text = "Informacion Principal"
        '
        'cbCiclo
        '
        Me.cbCiclo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbCiclo.FormattingEnabled = True
        Me.cbCiclo.Location = New System.Drawing.Point(115, 68)
        Me.cbCiclo.Name = "cbCiclo"
        Me.cbCiclo.Size = New System.Drawing.Size(174, 21)
        Me.cbCiclo.TabIndex = 3
        '
        'cbEspecialidad
        '
        Me.cbEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbEspecialidad.FormattingEnabled = True
        Me.cbEspecialidad.Location = New System.Drawing.Point(115, 42)
        Me.cbEspecialidad.Name = "cbEspecialidad"
        Me.cbEspecialidad.Size = New System.Drawing.Size(174, 21)
        Me.cbEspecialidad.TabIndex = 2
        '
        'lblNom_Ciclo
        '
        Me.lblNom_Ciclo.AutoSize = True
        Me.lblNom_Ciclo.Location = New System.Drawing.Point(75, 65)
        Me.lblNom_Ciclo.Name = "lblNom_Ciclo"
        Me.lblNom_Ciclo.Size = New System.Drawing.Size(36, 13)
        Me.lblNom_Ciclo.TabIndex = 18
        Me.lblNom_Ciclo.Text = "Ciclo :"
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(115, 16)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(78, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Text = "Autogenerado"
        '
        'lblNom_Codigo
        '
        Me.lblNom_Codigo.AutoSize = True
        Me.lblNom_Codigo.Location = New System.Drawing.Point(65, 23)
        Me.lblNom_Codigo.Name = "lblNom_Codigo"
        Me.lblNom_Codigo.Size = New System.Drawing.Size(46, 13)
        Me.lblNom_Codigo.TabIndex = 0
        Me.lblNom_Codigo.Text = "Código :"
        '
        'gbRegistro
        '
        Me.gbRegistro.Controls.Add(Me.dgRegistro)
        Me.gbRegistro.Location = New System.Drawing.Point(25, 305)
        Me.gbRegistro.Name = "gbRegistro"
        Me.gbRegistro.Size = New System.Drawing.Size(696, 222)
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
        Me.dgRegistro.Size = New System.Drawing.Size(690, 203)
        Me.dgRegistro.TabIndex = 0
        '
        'gbOpc
        '
        Me.gbOpc.Controls.Add(Me.btnCancelar)
        Me.gbOpc.Controls.Add(Me.btnBuscar)
        Me.gbOpc.Controls.Add(Me.btnListar)
        Me.gbOpc.Controls.Add(Me.btnGrabar)
        Me.gbOpc.Location = New System.Drawing.Point(80, 249)
        Me.gbOpc.Name = "gbOpc"
        Me.gbOpc.Size = New System.Drawing.Size(499, 50)
        Me.gbOpc.TabIndex = 32
        Me.gbOpc.TabStop = False
        Me.gbOpc.Text = "Opciones"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Cancelar_Registros
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(394, 14)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(78, 30)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Buscar_Registro
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(71, 14)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(77, 30)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnListar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Listar_icono
        Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListar.Location = New System.Drawing.Point(286, 14)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(75, 30)
        Me.btnListar.TabIndex = 15
        Me.btnListar.Text = "Listar"
        Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGrabar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Guardar_Archivo
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrabar.Location = New System.Drawing.Point(173, 14)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(78, 30)
        Me.btnGrabar.TabIndex = 14
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'FrmModulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(753, 534)
        Me.Controls.Add(Me.gbOpc)
        Me.Controls.Add(Me.gbMantenimiento)
        Me.Controls.Add(Me.gbDetalles)
        Me.Controls.Add(Me.gbDatosEstudiante)
        Me.Controls.Add(Me.gbRegistro)
        Me.ForeColor = System.Drawing.Color.Navy
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
