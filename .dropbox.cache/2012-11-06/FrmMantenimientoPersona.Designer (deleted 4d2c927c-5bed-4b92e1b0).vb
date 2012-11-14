<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoPersona
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
        Me.gbMantenimiento = New System.Windows.Forms.GroupBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btlEliminar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.gbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnBuscarImagen = New System.Windows.Forms.Button()
        Me.fecNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.picPersona = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTipoPersona = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNon_Estudiante = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.gbRegistros = New System.Windows.Forms.GroupBox()
        Me.dgRegistros = New System.Windows.Forms.DataGridView()
        Me.Código = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Condicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbMantenimiento.SuspendLayout()
        Me.gbDatosGenerales.SuspendLayout()
        CType(Me.picPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRegistros.SuspendLayout()
        CType(Me.dgRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbMantenimiento
        '
        Me.gbMantenimiento.Controls.Add(Me.BtnCancelar)
        Me.gbMantenimiento.Controls.Add(Me.btnGuardar)
        Me.gbMantenimiento.Controls.Add(Me.btnBuscar)
        Me.gbMantenimiento.Controls.Add(Me.btlEliminar)
        Me.gbMantenimiento.Controls.Add(Me.BtnLimpiar)
        Me.gbMantenimiento.Controls.Add(Me.btnSalir)
        Me.gbMantenimiento.Controls.Add(Me.btnEditar)
        Me.gbMantenimiento.Controls.Add(Me.BtnNuevo)
        Me.gbMantenimiento.Location = New System.Drawing.Point(22, 500)
        Me.gbMantenimiento.Name = "gbMantenimiento"
        Me.gbMantenimiento.Size = New System.Drawing.Size(662, 47)
        Me.gbMantenimiento.TabIndex = 12
        Me.gbMantenimiento.TabStop = False
        Me.gbMantenimiento.Text = "Opciones de Mantenimiento"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Cancelar_Registros
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Location = New System.Drawing.Point(509, 21)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(65, 20)
        Me.BtnCancelar.TabIndex = 20
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Guardar_Archivo
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.Location = New System.Drawing.Point(89, 20)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 19)
        Me.btnGuardar.TabIndex = 19
        Me.btnGuardar.Text = "Guar&dar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Buscar_Registro
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Location = New System.Drawing.Point(420, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(69, 19)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.Text = "B&uscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btlEliminar
        '
        Me.btlEliminar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Actualizar
        Me.btlEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btlEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btlEliminar.Location = New System.Drawing.Point(255, 21)
        Me.btlEliminar.Name = "btlEliminar"
        Me.btlEliminar.Size = New System.Drawing.Size(67, 20)
        Me.btlEliminar.TabIndex = 11
        Me.btlEliminar.Text = "&Estado"
        Me.btlEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btlEliminar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Limpiar_Formulario
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLimpiar.Location = New System.Drawing.Point(338, 20)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(65, 19)
        Me.BtnLimpiar.TabIndex = 7
        Me.BtnLimpiar.Text = "&Limpiar"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Salir
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Location = New System.Drawing.Point(591, 19)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(65, 20)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Modificar_Registro
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditar.Location = New System.Drawing.Point(175, 20)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(65, 20)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "&Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Inicio
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNuevo.Location = New System.Drawing.Point(4, 19)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(72, 21)
        Me.BtnNuevo.TabIndex = 6
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'gbDatosGenerales
        '
        Me.gbDatosGenerales.Controls.Add(Me.txtUsuario)
        Me.gbDatosGenerales.Controls.Add(Me.lblUsuario)
        Me.gbDatosGenerales.Controls.Add(Me.btnBuscarImagen)
        Me.gbDatosGenerales.Controls.Add(Me.fecNacimiento)
        Me.gbDatosGenerales.Controls.Add(Me.Label4)
        Me.gbDatosGenerales.Controls.Add(Me.picPersona)
        Me.gbDatosGenerales.Controls.Add(Me.Label2)
        Me.gbDatosGenerales.Controls.Add(Me.cbTipoPersona)
        Me.gbDatosGenerales.Controls.Add(Me.Label3)
        Me.gbDatosGenerales.Controls.Add(Me.txtApellidos)
        Me.gbDatosGenerales.Controls.Add(Me.txtCodigo)
        Me.gbDatosGenerales.Controls.Add(Me.Label1)
        Me.gbDatosGenerales.Controls.Add(Me.lblNon_Estudiante)
        Me.gbDatosGenerales.Controls.Add(Me.txtNombres)
        Me.gbDatosGenerales.Location = New System.Drawing.Point(25, 23)
        Me.gbDatosGenerales.Name = "gbDatosGenerales"
        Me.gbDatosGenerales.Size = New System.Drawing.Size(662, 168)
        Me.gbDatosGenerales.TabIndex = 11
        Me.gbDatosGenerales.TabStop = False
        Me.gbDatosGenerales.Text = "Datos Generales"
        '
        'txtUsuario
        '
        Me.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(316, 16)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(112, 20)
        Me.txtUsuario.TabIndex = 19
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(258, 19)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(49, 13)
        Me.lblUsuario.TabIndex = 18
        Me.lblUsuario.Text = "Usuario :"
        '
        'btnBuscarImagen
        '
        Me.btnBuscarImagen.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Buscar_Registro
        Me.btnBuscarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscarImagen.Location = New System.Drawing.Point(567, 121)
        Me.btnBuscarImagen.Name = "btnBuscarImagen"
        Me.btnBuscarImagen.Size = New System.Drawing.Size(69, 25)
        Me.btnBuscarImagen.TabIndex = 9
        Me.btnBuscarImagen.Text = "&Imagen"
        Me.btnBuscarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarImagen.UseVisualStyleBackColor = True
        '
        'fecNacimiento
        '
        Me.fecNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecNacimiento.Location = New System.Drawing.Point(153, 133)
        Me.fecNacimiento.Name = "fecNacimiento"
        Me.fecNacimiento.Size = New System.Drawing.Size(121, 20)
        Me.fecNacimiento.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Nacimiento :"
        '
        'picPersona
        '
        Me.picPersona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPersona.Location = New System.Drawing.Point(558, 19)
        Me.picPersona.Name = "picPersona"
        Me.picPersona.Size = New System.Drawing.Size(85, 96)
        Me.picPersona.TabIndex = 15
        Me.picPersona.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tipo :"
        '
        'cbTipoPersona
        '
        Me.cbTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPersona.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbTipoPersona.FormattingEnabled = True
        Me.cbTipoPersona.Location = New System.Drawing.Point(153, 99)
        Me.cbTipoPersona.Name = "cbTipoPersona"
        Me.cbTipoPersona.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoPersona.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Apellidos :"
        '
        'txtApellidos
        '
        Me.txtApellidos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellidos.Location = New System.Drawing.Point(151, 69)
        Me.txtApellidos.MaxLength = 200
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(364, 20)
        Me.txtApellidos.TabIndex = 14
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(151, 17)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(77, 20)
        Me.txtCodigo.TabIndex = 12
        Me.txtCodigo.Text = "AutoGenerado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Código :"
        '
        'lblNon_Estudiante
        '
        Me.lblNon_Estudiante.AutoSize = True
        Me.lblNon_Estudiante.Location = New System.Drawing.Point(83, 47)
        Me.lblNon_Estudiante.Name = "lblNon_Estudiante"
        Me.lblNon_Estudiante.Size = New System.Drawing.Size(55, 13)
        Me.lblNon_Estudiante.TabIndex = 3
        Me.lblNon_Estudiante.Text = "Nombres :"
        '
        'txtNombres
        '
        Me.txtNombres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Location = New System.Drawing.Point(151, 43)
        Me.txtNombres.MaxLength = 200
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(364, 20)
        Me.txtNombres.TabIndex = 5
        '
        'gbRegistros
        '
        Me.gbRegistros.Controls.Add(Me.dgRegistros)
        Me.gbRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbRegistros.Location = New System.Drawing.Point(22, 197)
        Me.gbRegistros.Name = "gbRegistros"
        Me.gbRegistros.Size = New System.Drawing.Size(668, 297)
        Me.gbRegistros.TabIndex = 10
        Me.gbRegistros.TabStop = False
        Me.gbRegistros.Text = "Registros"
        '
        'dgRegistros
        '
        Me.dgRegistros.AllowUserToAddRows = False
        Me.dgRegistros.AllowUserToDeleteRows = False
        Me.dgRegistros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRegistros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Código, Me.Usuario, Me.Nombres, Me.Apellidos, Me.Tipo, Me.Condicion, Me.Estado, Me.Nacimiento})
        Me.dgRegistros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRegistros.Location = New System.Drawing.Point(3, 16)
        Me.dgRegistros.Name = "dgRegistros"
        Me.dgRegistros.ReadOnly = True
        Me.dgRegistros.Size = New System.Drawing.Size(662, 278)
        Me.dgRegistros.TabIndex = 0
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
        'Nacimiento
        '
        Me.Nacimiento.DataPropertyName = "Nacimiento"
        Me.Nacimiento.HeaderText = "Nacimiento"
        Me.Nacimiento.Name = "Nacimiento"
        Me.Nacimiento.ReadOnly = True
        Me.Nacimiento.Visible = False
        '
        'FrmMantenimientoPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(712, 559)
        Me.Controls.Add(Me.gbMantenimiento)
        Me.Controls.Add(Me.gbDatosGenerales)
        Me.Controls.Add(Me.gbRegistros)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMantenimientoPersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "... MantenimientoPersona"
        Me.gbMantenimiento.ResumeLayout(False)
        Me.gbDatosGenerales.ResumeLayout(False)
        Me.gbDatosGenerales.PerformLayout()
        CType(Me.picPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRegistros.ResumeLayout(False)
        CType(Me.dgRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbMantenimiento As System.Windows.Forms.GroupBox
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents gbDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTipoPersona As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNon_Estudiante As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents gbRegistros As System.Windows.Forms.GroupBox
    Friend WithEvents dgRegistros As System.Windows.Forms.DataGridView
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents picPersona As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents fecNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarImagen As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btlEliminar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents Código As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Condicion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Nacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
End Class
