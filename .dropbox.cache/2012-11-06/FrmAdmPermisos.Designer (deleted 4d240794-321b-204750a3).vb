<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmPermisos
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
        Me.gbBuscarPersona = New System.Windows.Forms.GroupBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTipoPersona = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNon_Estudiante = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgAplicaciones = New System.Windows.Forms.DataGridView()
        Me.CodigoApp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Permiso = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cbModulos = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbPermisos = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnDefecto = New System.Windows.Forms.Button()
        Me.gbBuscarPersona.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgAplicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPermisos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBuscarPersona
        '
        Me.gbBuscarPersona.Controls.Add(Me.txtUsuario)
        Me.gbBuscarPersona.Controls.Add(Me.Label1)
        Me.gbBuscarPersona.Controls.Add(Me.cbTipoPersona)
        Me.gbBuscarPersona.Controls.Add(Me.Label2)
        Me.gbBuscarPersona.Controls.Add(Me.lblNon_Estudiante)
        Me.gbBuscarPersona.Controls.Add(Me.txtNombres)
        Me.gbBuscarPersona.Location = New System.Drawing.Point(32, 12)
        Me.gbBuscarPersona.Name = "gbBuscarPersona"
        Me.gbBuscarPersona.Size = New System.Drawing.Size(533, 103)
        Me.gbBuscarPersona.TabIndex = 8
        Me.gbBuscarPersona.TabStop = False
        Me.gbBuscarPersona.Text = "Datos Generales Personal"
        '
        'txtUsuario
        '
        Me.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(140, 17)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(122, 20)
        Me.txtUsuario.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Usuario :"
        '
        'cbTipoPersona
        '
        Me.cbTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPersona.Enabled = False
        Me.cbTipoPersona.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbTipoPersona.FormattingEnabled = True
        Me.cbTipoPersona.Location = New System.Drawing.Point(141, 43)
        Me.cbTipoPersona.Name = "cbTipoPersona"
        Me.cbTipoPersona.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoPersona.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Condición :"
        '
        'lblNon_Estudiante
        '
        Me.lblNon_Estudiante.AutoSize = True
        Me.lblNon_Estudiante.Location = New System.Drawing.Point(79, 71)
        Me.lblNon_Estudiante.Name = "lblNon_Estudiante"
        Me.lblNon_Estudiante.Size = New System.Drawing.Size(55, 13)
        Me.lblNon_Estudiante.TabIndex = 3
        Me.lblNon_Estudiante.Text = "Nombres :"
        '
        'txtNombres
        '
        Me.txtNombres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(140, 70)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(364, 20)
        Me.txtNombres.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgAplicaciones)
        Me.GroupBox1.Controls.Add(Me.cbModulos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(533, 361)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control de Accesos"
        '
        'dgAplicaciones
        '
        Me.dgAplicaciones.AllowUserToAddRows = False
        Me.dgAplicaciones.AllowUserToDeleteRows = False
        Me.dgAplicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAplicaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoApp, Me.Nombre, Me.Permiso})
        Me.dgAplicaciones.Location = New System.Drawing.Point(6, 40)
        Me.dgAplicaciones.Name = "dgAplicaciones"
        Me.dgAplicaciones.Size = New System.Drawing.Size(521, 315)
        Me.dgAplicaciones.TabIndex = 11
        '
        'CodigoApp
        '
        Me.CodigoApp.DataPropertyName = "app_cod"
        Me.CodigoApp.HeaderText = "Codigo"
        Me.CodigoApp.Name = "CodigoApp"
        Me.CodigoApp.Width = 50
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 320
        '
        'Permiso
        '
        Me.Permiso.DataPropertyName = "Permiso"
        Me.Permiso.HeaderText = "Permiso"
        Me.Permiso.Name = "Permiso"
        '
        'cbModulos
        '
        Me.cbModulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbModulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbModulos.FormattingEnabled = True
        Me.cbModulos.Location = New System.Drawing.Point(197, 13)
        Me.cbModulos.Name = "cbModulos"
        Me.cbModulos.Size = New System.Drawing.Size(121, 21)
        Me.cbModulos.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Módulos :"
        '
        'gbPermisos
        '
        Me.gbPermisos.Controls.Add(Me.btnSalir)
        Me.gbPermisos.Controls.Add(Me.btnGuardar)
        Me.gbPermisos.Controls.Add(Me.btnDefecto)
        Me.gbPermisos.Location = New System.Drawing.Point(32, 496)
        Me.gbPermisos.Name = "gbPermisos"
        Me.gbPermisos.Size = New System.Drawing.Size(533, 43)
        Me.gbPermisos.TabIndex = 14
        Me.gbPermisos.TabStop = False
        Me.gbPermisos.Text = "Permisos"
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Salir
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Location = New System.Drawing.Point(332, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(85, 25)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Guardar_Archivo
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.Location = New System.Drawing.Point(211, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(84, 25)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnDefecto
        '
        Me.btnDefecto.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Inicio
        Me.btnDefecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDefecto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDefecto.Location = New System.Drawing.Point(102, 12)
        Me.btnDefecto.Name = "btnDefecto"
        Me.btnDefecto.Size = New System.Drawing.Size(89, 25)
        Me.btnDefecto.TabIndex = 9
        Me.btnDefecto.Text = "Por &Defecto"
        Me.btnDefecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDefecto.UseVisualStyleBackColor = True
        '
        'FrmAdmPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(587, 551)
        Me.Controls.Add(Me.gbPermisos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbBuscarPersona)
        Me.MaximizeBox = False
        Me.Name = "FrmAdmPermisos"
        Me.Text = "... Administrar Permisos"
        Me.gbBuscarPersona.ResumeLayout(False)
        Me.gbBuscarPersona.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgAplicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPermisos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBuscarPersona As System.Windows.Forms.GroupBox
    Friend WithEvents cbTipoPersona As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNon_Estudiante As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbModulos As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbPermisos As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnDefecto As System.Windows.Forms.Button
    Friend WithEvents app_cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgAplicaciones As System.Windows.Forms.DataGridView
    Friend WithEvents CodigoApp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Permiso As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
