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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCurso))
        Me.gbMantenimiento = New System.Windows.Forms.GroupBox
        Me.BtnInhabilitar = New System.Windows.Forms.Button
        Me.btnHabilitar = New System.Windows.Forms.Button
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnEditar = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.BtnListar = New System.Windows.Forms.Button
        Me.BtnGrabar = New System.Windows.Forms.Button
        Me.gbDetalles = New System.Windows.Forms.GroupBox
        Me.txtdesc = New System.Windows.Forms.TextBox
        Me.lblNom_Desc = New System.Windows.Forms.Label
        Me.lbl_Nom_Uni = New System.Windows.Forms.Label
        Me.txtUnidades = New System.Windows.Forms.TextBox
        Me.lbl_NomSem = New System.Windows.Forms.Label
        Me.txtSemanal = New System.Windows.Forms.TextBox
        Me.txtCurso = New System.Windows.Forms.TextBox
        Me.lblNom_Nombre = New System.Windows.Forms.Label
        Me.gbDatosEstudiante = New System.Windows.Forms.GroupBox
        Me.txtCreditos = New System.Windows.Forms.TextBox
        Me.lbl_NomCreditos = New System.Windows.Forms.Label
        Me.cbModulo = New System.Windows.Forms.ComboBox
        Me.lblNom_Mod = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblNom_Codigo = New System.Windows.Forms.Label
        Me.gbRegistro = New System.Windows.Forms.GroupBox
        Me.dgRegistro = New System.Windows.Forms.DataGridView
        Me.gbOpc = New System.Windows.Forms.GroupBox
        Me.tbMantenimiento = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbEspecialidad = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbCiclo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.gbMantenimiento.Location = New System.Drawing.Point(775, 12)
        Me.gbMantenimiento.Name = "gbMantenimiento"
        Me.gbMantenimiento.Size = New System.Drawing.Size(98, 254)
        Me.gbMantenimiento.TabIndex = 27
        Me.gbMantenimiento.TabStop = False
        Me.gbMantenimiento.Text = "Mantenimiento"
        '
        'BtnInhabilitar
        '
        Me.BtnInhabilitar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.habilitaDO
        Me.BtnInhabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnInhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnInhabilitar.Location = New System.Drawing.Point(34, 161)
        Me.BtnInhabilitar.Name = "BtnInhabilitar"
        Me.BtnInhabilitar.Size = New System.Drawing.Size(33, 32)
        Me.BtnInhabilitar.TabIndex = 27
        Me.tbMantenimiento.SetToolTip(Me.BtnInhabilitar, "Deshabilitar Registro")
        Me.BtnInhabilitar.UseVisualStyleBackColor = True
        '
        'btnHabilitar
        '
        Me.btnHabilitar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Inhabilitado_jpg
        Me.btnHabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHabilitar.Location = New System.Drawing.Point(34, 210)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(33, 32)
        Me.btnHabilitar.TabIndex = 26
        Me.tbMantenimiento.SetToolTip(Me.btnHabilitar, "Habilitar Registro")
        Me.btnHabilitar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Nuevo2
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNuevo.Location = New System.Drawing.Point(34, 22)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(33, 32)
        Me.BtnNuevo.TabIndex = 24
        Me.tbMantenimiento.SetToolTip(Me.BtnNuevo, "Nuevo  Registro")
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.datele
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Location = New System.Drawing.Point(34, 116)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(33, 32)
        Me.btnEliminar.TabIndex = 25
        Me.tbMantenimiento.SetToolTip(Me.btnEliminar, "Eliminar Registro")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.edit
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditar.Location = New System.Drawing.Point(34, 69)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(33, 31)
        Me.btnEditar.TabIndex = 23
        Me.tbMantenimiento.SetToolTip(Me.btnEditar, "Editar Registro")
        Me.btnEditar.UseVisualStyleBackColor = True
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
        Me.tbMantenimiento.SetToolTip(Me.btnBuscar, "Buscar Registro")
        Me.btnBuscar.UseVisualStyleBackColor = True
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
        Me.tbMantenimiento.SetToolTip(Me.btnCancelar, "Cancelar Registro")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'BtnListar
        '
        Me.BtnListar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.listar
        Me.BtnListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnListar.Location = New System.Drawing.Point(95, 12)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(33, 33)
        Me.BtnListar.TabIndex = 25
        Me.tbMantenimiento.SetToolTip(Me.BtnListar, "Listar Registro")
        Me.BtnListar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.save_j2pg
        Me.BtnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGrabar.Location = New System.Drawing.Point(57, 12)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(33, 33)
        Me.BtnGrabar.TabIndex = 28
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
        Me.gbDetalles.Location = New System.Drawing.Point(165, 212)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(555, 106)
        Me.gbDetalles.TabIndex = 30
        Me.gbDetalles.TabStop = False
        Me.gbDetalles.Text = "Detalles"
        '
        'txtdesc
        '
        Me.txtdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdesc.Location = New System.Drawing.Point(57, 19)
        Me.txtdesc.MaxLength = 200
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(313, 76)
        Me.txtdesc.TabIndex = 23
        '
        'lblNom_Desc
        '
        Me.lblNom_Desc.AutoSize = True
        Me.lblNom_Desc.Location = New System.Drawing.Point(6, 21)
        Me.lblNom_Desc.Name = "lblNom_Desc"
        Me.lblNom_Desc.Size = New System.Drawing.Size(41, 13)
        Me.lblNom_Desc.TabIndex = 22
        Me.lblNom_Desc.Text = "Título :"
        '
        'lbl_Nom_Uni
        '
        Me.lbl_Nom_Uni.AutoSize = True
        Me.lbl_Nom_Uni.Location = New System.Drawing.Point(424, 80)
        Me.lbl_Nom_Uni.Name = "lbl_Nom_Uni"
        Me.lbl_Nom_Uni.Size = New System.Drawing.Size(58, 13)
        Me.lbl_Nom_Uni.TabIndex = 27
        Me.lbl_Nom_Uni.Text = "Unidades :"
        '
        'txtUnidades
        '
        Me.txtUnidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnidades.Location = New System.Drawing.Point(488, 73)
        Me.txtUnidades.MaxLength = 1
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(38, 20)
        Me.txtUnidades.TabIndex = 24
        '
        'lbl_NomSem
        '
        Me.lbl_NomSem.AutoSize = True
        Me.lbl_NomSem.Location = New System.Drawing.Point(386, 29)
        Me.lbl_NomSem.Name = "lbl_NomSem"
        Me.lbl_NomSem.Size = New System.Drawing.Size(96, 13)
        Me.lbl_NomSem.TabIndex = 26
        Me.lbl_NomSem.Text = "Horas Semanales :"
        '
        'txtSemanal
        '
        Me.txtSemanal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSemanal.Location = New System.Drawing.Point(488, 21)
        Me.txtSemanal.MaxLength = 2
        Me.txtSemanal.Name = "txtSemanal"
        Me.txtSemanal.Size = New System.Drawing.Size(38, 20)
        Me.txtSemanal.TabIndex = 25
        '
        'txtCurso
        '
        Me.txtCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurso.Location = New System.Drawing.Point(74, 19)
        Me.txtCurso.MaxLength = 50
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Size = New System.Drawing.Size(255, 20)
        Me.txtCurso.TabIndex = 17
        '
        'lblNom_Nombre
        '
        Me.lblNom_Nombre.AutoSize = True
        Me.lblNom_Nombre.Location = New System.Drawing.Point(13, 21)
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
        Me.gbDatosEstudiante.Location = New System.Drawing.Point(266, 12)
        Me.gbDatosEstudiante.Name = "gbDatosEstudiante"
        Me.gbDatosEstudiante.Size = New System.Drawing.Size(350, 136)
        Me.gbDatosEstudiante.TabIndex = 29
        Me.gbDatosEstudiante.TabStop = False
        Me.gbDatosEstudiante.Text = "Informacion Principal"
        '
        'txtCreditos
        '
        Me.txtCreditos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCreditos.Location = New System.Drawing.Point(392, 19)
        Me.txtCreditos.MaxLength = 2
        Me.txtCreditos.Name = "txtCreditos"
        Me.txtCreditos.Size = New System.Drawing.Size(54, 20)
        Me.txtCreditos.TabIndex = 23
        '
        'lbl_NomCreditos
        '
        Me.lbl_NomCreditos.AutoSize = True
        Me.lbl_NomCreditos.Location = New System.Drawing.Point(335, 22)
        Me.lbl_NomCreditos.Name = "lbl_NomCreditos"
        Me.lbl_NomCreditos.Size = New System.Drawing.Size(51, 13)
        Me.lbl_NomCreditos.TabIndex = 22
        Me.lbl_NomCreditos.Text = "Créditos :"
        '
        'cbModulo
        '
        Me.cbModulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbModulo.FormattingEnabled = True
        Me.cbModulo.Location = New System.Drawing.Point(115, 95)
        Me.cbModulo.Name = "cbModulo"
        Me.cbModulo.Size = New System.Drawing.Size(174, 21)
        Me.cbModulo.TabIndex = 21
        '
        'lblNom_Mod
        '
        Me.lblNom_Mod.AutoSize = True
        Me.lblNom_Mod.Location = New System.Drawing.Point(63, 98)
        Me.lblNom_Mod.Name = "lblNom_Mod"
        Me.lblNom_Mod.Size = New System.Drawing.Size(48, 13)
        Me.lblNom_Mod.TabIndex = 20
        Me.lblNom_Mod.Text = "Modulo :"
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(115, 15)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(172, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Text = "Autogenerado"
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
        'gbRegistro
        '
        Me.gbRegistro.Controls.Add(Me.dgRegistro)
        Me.gbRegistro.Location = New System.Drawing.Point(5, 369)
        Me.gbRegistro.Name = "gbRegistro"
        Me.gbRegistro.Size = New System.Drawing.Size(1014, 296)
        Me.gbRegistro.TabIndex = 28
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
        Me.dgRegistro.Size = New System.Drawing.Size(1008, 277)
        Me.dgRegistro.TabIndex = 0
        '
        'gbOpc
        '
        Me.gbOpc.Controls.Add(Me.btnCancelar)
        Me.gbOpc.Controls.Add(Me.btnBuscar)
        Me.gbOpc.Controls.Add(Me.BtnListar)
        Me.gbOpc.Controls.Add(Me.BtnGrabar)
        Me.gbOpc.Location = New System.Drawing.Point(376, 312)
        Me.gbOpc.Name = "gbOpc"
        Me.gbOpc.Size = New System.Drawing.Size(173, 51)
        Me.gbOpc.TabIndex = 31
        Me.gbOpc.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCreditos)
        Me.GroupBox1.Controls.Add(Me.txtCurso)
        Me.GroupBox1.Controls.Add(Me.lblNom_Nombre)
        Me.GroupBox1.Controls.Add(Me.lbl_NomCreditos)
        Me.GroupBox1.Location = New System.Drawing.Point(206, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 52)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Curso"
        '
        'cbEspecialidad
        '
        Me.cbEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbEspecialidad.FormattingEnabled = True
        Me.cbEspecialidad.Location = New System.Drawing.Point(115, 41)
        Me.cbEspecialidad.Name = "cbEspecialidad"
        Me.cbEspecialidad.Size = New System.Drawing.Size(174, 21)
        Me.cbEspecialidad.TabIndex = 21
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
        'cbCiclo
        '
        Me.cbCiclo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbCiclo.FormattingEnabled = True
        Me.cbCiclo.Location = New System.Drawing.Point(115, 68)
        Me.cbCiclo.Name = "cbCiclo"
        Me.cbCiclo.Size = New System.Drawing.Size(174, 21)
        Me.cbCiclo.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Ciclo :"
        '
        'FrmCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1031, 697)
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
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
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
    Friend WithEvents dgRegistro As System.Windows.Forms.DataGridView
    Friend WithEvents gbOpc As System.Windows.Forms.GroupBox
    Friend WithEvents tbMantenimiento As System.Windows.Forms.ToolTip
    Friend WithEvents txtCreditos As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NomCreditos As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbCiclo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
