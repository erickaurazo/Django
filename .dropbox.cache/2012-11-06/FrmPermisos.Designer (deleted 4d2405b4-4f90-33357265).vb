<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPermisos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.gbRegistroEstudiantes = New System.Windows.Forms.GroupBox()
        Me.dgRegistroEstudiantes = New System.Windows.Forms.DataGridView()
        Me.Código = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Condicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.lblNon_Estudiante = New System.Windows.Forms.Label()
        Me.gbBuscarPersona = New System.Windows.Forms.GroupBox()
        Me.cbTipoPersona = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnVerTodos = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnListarTodos = New System.Windows.Forms.Button()
        Me.gbPermisos = New System.Windows.Forms.GroupBox()
        Me.btnCuentas = New System.Windows.Forms.Button()
        Me.btnPermisos = New System.Windows.Forms.Button()
        Me.gbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCondicion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.gbRegistroEstudiantes.SuspendLayout()
        CType(Me.dgRegistroEstudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscarPersona.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbPermisos.SuspendLayout()
        Me.gbDatosGenerales.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(165, 43)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(456, 20)
        Me.txtNombre.TabIndex = 5
        '
        'gbRegistroEstudiantes
        '
        Me.gbRegistroEstudiantes.Controls.Add(Me.dgRegistroEstudiantes)
        Me.gbRegistroEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbRegistroEstudiantes.Location = New System.Drawing.Point(26, 142)
        Me.gbRegistroEstudiantes.Name = "gbRegistroEstudiantes"
        Me.gbRegistroEstudiantes.Size = New System.Drawing.Size(651, 159)
        Me.gbRegistroEstudiantes.TabIndex = 4
        Me.gbRegistroEstudiantes.TabStop = False
        Me.gbRegistroEstudiantes.Text = "Registros"
        '
        'dgRegistroEstudiantes
        '
        Me.dgRegistroEstudiantes.AllowUserToAddRows = False
        Me.dgRegistroEstudiantes.AllowUserToDeleteRows = False
        Me.dgRegistroEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgRegistroEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRegistroEstudiantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Código, Me.Usuario, Me.Nombres, Me.Apellidos, Me.Tipo, Me.Condicion, Me.Estado})
        Me.dgRegistroEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRegistroEstudiantes.Location = New System.Drawing.Point(3, 16)
        Me.dgRegistroEstudiantes.Name = "dgRegistroEstudiantes"
        Me.dgRegistroEstudiantes.ReadOnly = True
        Me.dgRegistroEstudiantes.Size = New System.Drawing.Size(645, 140)
        Me.dgRegistroEstudiantes.TabIndex = 0
        '
        'Código
        '
        Me.Código.DataPropertyName = "Código"
        Me.Código.HeaderText = "Código"
        Me.Código.Name = "Código"
        Me.Código.ReadOnly = True
        Me.Código.Width = 50
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        Me.Usuario.Width = 80
        '
        'Nombres
        '
        Me.Nombres.DataPropertyName = "Nombres"
        Me.Nombres.HeaderText = "Nombres"
        Me.Nombres.Name = "Nombres"
        Me.Nombres.ReadOnly = True
        Me.Nombres.Width = 150
        '
        'Apellidos
        '
        Me.Apellidos.DataPropertyName = "Apellidos"
        Me.Apellidos.HeaderText = "Apellidos"
        Me.Apellidos.Name = "Apellidos"
        Me.Apellidos.ReadOnly = True
        Me.Apellidos.Width = 150
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Visible = False
        '
        'Condicion
        '
        Me.Condicion.DataPropertyName = "Condicion"
        Me.Condicion.HeaderText = "Condicion"
        Me.Condicion.Name = "Condicion"
        Me.Condicion.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 50
        '
        'lblNon_Estudiante
        '
        Me.lblNon_Estudiante.AutoSize = True
        Me.lblNon_Estudiante.Location = New System.Drawing.Point(101, 49)
        Me.lblNon_Estudiante.Name = "lblNon_Estudiante"
        Me.lblNon_Estudiante.Size = New System.Drawing.Size(47, 13)
        Me.lblNon_Estudiante.TabIndex = 3
        Me.lblNon_Estudiante.Text = "Nombre:"
        '
        'gbBuscarPersona
        '
        Me.gbBuscarPersona.Controls.Add(Me.cbTipoPersona)
        Me.gbBuscarPersona.Controls.Add(Me.Label2)
        Me.gbBuscarPersona.Controls.Add(Me.lblNon_Estudiante)
        Me.gbBuscarPersona.Controls.Add(Me.txtNombre)
        Me.gbBuscarPersona.Location = New System.Drawing.Point(29, 12)
        Me.gbBuscarPersona.Name = "gbBuscarPersona"
        Me.gbBuscarPersona.Size = New System.Drawing.Size(645, 69)
        Me.gbBuscarPersona.TabIndex = 7
        Me.gbBuscarPersona.TabStop = False
        Me.gbBuscarPersona.Text = "Buscar Personal"
        '
        'cbTipoPersona
        '
        Me.cbTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPersona.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbTipoPersona.FormattingEnabled = True
        Me.cbTipoPersona.Location = New System.Drawing.Point(165, 13)
        Me.cbTipoPersona.Name = "cbTipoPersona"
        Me.cbTipoPersona.Size = New System.Drawing.Size(141, 21)
        Me.cbTipoPersona.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tipo :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnVerTodos)
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox1.Controls.Add(Me.BtnListarTodos)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 47)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'btnVerTodos
        '
        Me.btnVerTodos.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Buscar_Registro
        Me.btnVerTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVerTodos.Location = New System.Drawing.Point(275, 16)
        Me.btnVerTodos.Name = "btnVerTodos"
        Me.btnVerTodos.Size = New System.Drawing.Size(109, 25)
        Me.btnVerTodos.TabIndex = 8
        Me.btnVerTodos.Text = "Buscar Personal"
        Me.btnVerTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerTodos.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Limpiar_Formulario
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLimpiar.Location = New System.Drawing.Point(440, 16)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(107, 25)
        Me.BtnLimpiar.TabIndex = 7
        Me.BtnLimpiar.Text = "Limpiar Campos"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnListarTodos
        '
        Me.BtnListarTodos.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Buscar_Registro
        Me.BtnListarTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnListarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnListarTodos.Location = New System.Drawing.Point(117, 16)
        Me.BtnListarTodos.Name = "BtnListarTodos"
        Me.BtnListarTodos.Size = New System.Drawing.Size(109, 25)
        Me.BtnListarTodos.TabIndex = 6
        Me.BtnListarTodos.Text = "Listar Todos"
        Me.BtnListarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnListarTodos.UseVisualStyleBackColor = True
        '
        'gbPermisos
        '
        Me.gbPermisos.Controls.Add(Me.btnCuentas)
        Me.gbPermisos.Controls.Add(Me.btnPermisos)
        Me.gbPermisos.Location = New System.Drawing.Point(29, 307)
        Me.gbPermisos.Name = "gbPermisos"
        Me.gbPermisos.Size = New System.Drawing.Size(645, 43)
        Me.gbPermisos.TabIndex = 10
        Me.gbPermisos.TabStop = False
        Me.gbPermisos.Text = "Permisos"
        '
        'btnCuentas
        '
        Me.btnCuentas.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Sistema_Cuentas
        Me.btnCuentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCuentas.Location = New System.Drawing.Point(394, 12)
        Me.btnCuentas.Name = "btnCuentas"
        Me.btnCuentas.Size = New System.Drawing.Size(135, 25)
        Me.btnCuentas.TabIndex = 10
        Me.btnCuentas.Text = "&Cuenta de Usuario"
        Me.btnCuentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCuentas.UseVisualStyleBackColor = True
        '
        'btnPermisos
        '
        Me.btnPermisos.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.herramientas_Administrativas
        Me.btnPermisos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPermisos.Location = New System.Drawing.Point(161, 12)
        Me.btnPermisos.Name = "btnPermisos"
        Me.btnPermisos.Size = New System.Drawing.Size(135, 25)
        Me.btnPermisos.TabIndex = 9
        Me.btnPermisos.Text = "Administrar Permisos"
        Me.btnPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPermisos.UseVisualStyleBackColor = True
        '
        'gbDatosGenerales
        '
        Me.gbDatosGenerales.Controls.Add(Me.txtCodigo)
        Me.gbDatosGenerales.Controls.Add(Me.Label5)
        Me.gbDatosGenerales.Controls.Add(Me.txtUsuario)
        Me.gbDatosGenerales.Controls.Add(Me.Label1)
        Me.gbDatosGenerales.Controls.Add(Me.cbCondicion)
        Me.gbDatosGenerales.Controls.Add(Me.Label3)
        Me.gbDatosGenerales.Controls.Add(Me.Label4)
        Me.gbDatosGenerales.Controls.Add(Me.txtNombreCompleto)
        Me.gbDatosGenerales.Location = New System.Drawing.Point(26, 366)
        Me.gbDatosGenerales.Name = "gbDatosGenerales"
        Me.gbDatosGenerales.Size = New System.Drawing.Size(645, 103)
        Me.gbDatosGenerales.TabIndex = 11
        Me.gbDatosGenerales.TabStop = False
        Me.gbDatosGenerales.Text = "Datos Generales Personal"
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(199, 22)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(45, 20)
        Me.txtCodigo.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(147, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Código :"
        '
        'txtUsuario
        '
        Me.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(330, 22)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(144, 20)
        Me.txtUsuario.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(275, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Usuario :"
        '
        'cbCondicion
        '
        Me.cbCondicion.Enabled = False
        Me.cbCondicion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbCondicion.FormattingEnabled = True
        Me.cbCondicion.Location = New System.Drawing.Point(200, 48)
        Me.cbCondicion.Name = "cbCondicion"
        Me.cbCondicion.Size = New System.Drawing.Size(121, 21)
        Me.cbCondicion.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Condición :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(140, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombres :"
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreCompleto.Enabled = False
        Me.txtNombreCompleto.Location = New System.Drawing.Point(199, 75)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(422, 20)
        Me.txtNombreCompleto.TabIndex = 5
        '
        'FrmPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(705, 482)
        Me.Controls.Add(Me.gbDatosGenerales)
        Me.Controls.Add(Me.gbPermisos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbBuscarPersona)
        Me.Controls.Add(Me.gbRegistroEstudiantes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmPermisos"
        Me.Text = "... Permisos"
        Me.gbRegistroEstudiantes.ResumeLayout(False)
        CType(Me.dgRegistroEstudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBuscarPersona.ResumeLayout(False)
        Me.gbBuscarPersona.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbPermisos.ResumeLayout(False)
        Me.gbDatosGenerales.ResumeLayout(False)
        Me.gbDatosGenerales.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents gbRegistroEstudiantes As System.Windows.Forms.GroupBox
    Friend WithEvents dgRegistroEstudiantes As System.Windows.Forms.DataGridView
    Friend WithEvents BtnListarTodos As System.Windows.Forms.Button
    Friend WithEvents lblNon_Estudiante As System.Windows.Forms.Label
    Friend WithEvents gbBuscarPersona As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnVerTodos As System.Windows.Forms.Button
    Friend WithEvents cbTipoPersona As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPermisos As System.Windows.Forms.Button
    Friend WithEvents gbPermisos As System.Windows.Forms.GroupBox
    Friend WithEvents Código As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Condicion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnCuentas As System.Windows.Forms.Button
    Friend WithEvents gbDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCondicion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNombreCompleto As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
