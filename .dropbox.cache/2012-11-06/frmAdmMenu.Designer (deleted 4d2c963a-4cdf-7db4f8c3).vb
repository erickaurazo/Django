<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmMenu
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
        Me.gbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTipoMenu = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFormulario = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNon_Estudiante = New System.Windows.Forms.Label()
        Me.gbRegistros = New System.Windows.Forms.GroupBox()
        Me.dgRegistros = New System.Windows.Forms.DataGridView()
        Me.app_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Formulario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tip_AppCod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Menus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.btlEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.gbMantenimiento = New System.Windows.Forms.GroupBox()
        Me.btnHabilitar = New System.Windows.Forms.Button()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.gbDatosGenerales.SuspendLayout()
        Me.gbRegistros.SuspendLayout()
        CType(Me.dgRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOpciones.SuspendLayout()
        Me.gbMantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatosGenerales
        '
        Me.gbDatosGenerales.Controls.Add(Me.txtNombres)
        Me.gbDatosGenerales.Controls.Add(Me.Label2)
        Me.gbDatosGenerales.Controls.Add(Me.cbTipoMenu)
        Me.gbDatosGenerales.Controls.Add(Me.Label3)
        Me.gbDatosGenerales.Controls.Add(Me.txtFormulario)
        Me.gbDatosGenerales.Controls.Add(Me.txtCodigo)
        Me.gbDatosGenerales.Controls.Add(Me.Label1)
        Me.gbDatosGenerales.Controls.Add(Me.lblNon_Estudiante)
        Me.gbDatosGenerales.Location = New System.Drawing.Point(96, 12)
        Me.gbDatosGenerales.Name = "gbDatosGenerales"
        Me.gbDatosGenerales.Size = New System.Drawing.Size(529, 127)
        Me.gbDatosGenerales.TabIndex = 1
        Me.gbDatosGenerales.TabStop = False
        Me.gbDatosGenerales.Text = "Información General"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tipo Menu:"
        '
        'cbTipoMenu
        '
        Me.cbTipoMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbTipoMenu.FormattingEnabled = True
        Me.cbTipoMenu.ItemHeight = 13
        Me.cbTipoMenu.Location = New System.Drawing.Point(151, 43)
        Me.cbTipoMenu.Name = "cbTipoMenu"
        Me.cbTipoMenu.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoMenu.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Formulario :"
        '
        'txtFormulario
        '
        Me.txtFormulario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFormulario.Location = New System.Drawing.Point(151, 95)
        Me.txtFormulario.MaxLength = 200
        Me.txtFormulario.Name = "txtFormulario"
        Me.txtFormulario.Size = New System.Drawing.Size(364, 20)
        Me.txtFormulario.TabIndex = 7
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(151, 17)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(77, 20)
        Me.txtCodigo.TabIndex = 3
        Me.txtCodigo.Text = "Autogenerado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Código :"
        '
        'lblNon_Estudiante
        '
        Me.lblNon_Estudiante.AutoSize = True
        Me.lblNon_Estudiante.Location = New System.Drawing.Point(86, 71)
        Me.lblNon_Estudiante.Name = "lblNon_Estudiante"
        Me.lblNon_Estudiante.Size = New System.Drawing.Size(50, 13)
        Me.lblNon_Estudiante.TabIndex = 4
        Me.lblNon_Estudiante.Text = "Nombre :"
        '
        'gbRegistros
        '
        Me.gbRegistros.Controls.Add(Me.dgRegistros)
        Me.gbRegistros.Location = New System.Drawing.Point(12, 209)
        Me.gbRegistros.Name = "gbRegistros"
        Me.gbRegistros.Size = New System.Drawing.Size(817, 203)
        Me.gbRegistros.TabIndex = 2
        Me.gbRegistros.TabStop = False
        Me.gbRegistros.Text = "Registros"
        '
        'dgRegistros
        '
        Me.dgRegistros.AllowUserToAddRows = False
        Me.dgRegistros.AllowUserToDeleteRows = False
        Me.dgRegistros.AllowUserToOrderColumns = True
        Me.dgRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRegistros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.app_cod, Me.Nombre, Me.Formulario, Me.Tip_AppCod, Me.Menus, Me.Estado})
        Me.dgRegistros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRegistros.Location = New System.Drawing.Point(3, 16)
        Me.dgRegistros.Name = "dgRegistros"
        Me.dgRegistros.ReadOnly = True
        Me.dgRegistros.Size = New System.Drawing.Size(811, 184)
        Me.dgRegistros.TabIndex = 0
        '
        'app_cod
        '
        Me.app_cod.DataPropertyName = "app_cod"
        Me.app_cod.HeaderText = "Código"
        Me.app_cod.Name = "app_cod"
        Me.app_cod.ReadOnly = True
        Me.app_cod.Width = 60
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 250
        '
        'Formulario
        '
        Me.Formulario.DataPropertyName = "Formulario"
        Me.Formulario.HeaderText = "Formulario"
        Me.Formulario.Name = "Formulario"
        Me.Formulario.ReadOnly = True
        Me.Formulario.Width = 250
        '
        'Tip_AppCod
        '
        Me.Tip_AppCod.DataPropertyName = "Tip_AppCod"
        Me.Tip_AppCod.HeaderText = "Tip_AppCod"
        Me.Tip_AppCod.Name = "Tip_AppCod"
        Me.Tip_AppCod.ReadOnly = True
        Me.Tip_AppCod.Visible = False
        '
        'Menus
        '
        Me.Menus.DataPropertyName = "Menu"
        Me.Menus.HeaderText = "Categoria Menu"
        Me.Menus.Name = "Menus"
        Me.Menus.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.BtnCancelar)
        Me.gbOpciones.Controls.Add(Me.btnGuardar)
        Me.gbOpciones.Controls.Add(Me.btnBuscar)
        Me.gbOpciones.Controls.Add(Me.BtnLimpiar)
        Me.gbOpciones.Location = New System.Drawing.Point(96, 148)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(529, 55)
        Me.gbOpciones.TabIndex = 3
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "Opciones"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Cancelar_Registros
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(426, 19)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(79, 25)
        Me.BtnCancelar.TabIndex = 28
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Guardar_Archivo
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(67, 20)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(82, 25)
        Me.btnGuardar.TabIndex = 27
        Me.btnGuardar.Text = "Guar&dar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Buscar_Registro
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(298, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(79, 25)
        Me.btnBuscar.TabIndex = 26
        Me.btnBuscar.Text = "B&uscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLimpiar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Limpiar_Formulario
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(182, 19)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 25)
        Me.BtnLimpiar.TabIndex = 22
        Me.BtnLimpiar.Text = "&Limpiar"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'btlEliminar
        '
        Me.btlEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btlEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btlEliminar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Cancelar_Php
        Me.btlEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btlEliminar.Location = New System.Drawing.Point(19, 120)
        Me.btlEliminar.Name = "btlEliminar"
        Me.btlEliminar.Size = New System.Drawing.Size(84, 27)
        Me.btlEliminar.TabIndex = 25
        Me.btlEliminar.Text = "&Eliminar"
        Me.btlEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btlEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Modificar_Registro
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(19, 77)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(84, 27)
        Me.btnEditar.TabIndex = 23
        Me.btnEditar.Text = "&Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNuevo.Image = Global.Matricula.Presentacion.My.Resources.Resources.Nuevo
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(19, 36)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(84, 28)
        Me.BtnNuevo.TabIndex = 21
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'gbMantenimiento
        '
        Me.gbMantenimiento.Controls.Add(Me.btnHabilitar)
        Me.gbMantenimiento.Controls.Add(Me.btnEditar)
        Me.gbMantenimiento.Controls.Add(Me.BtnNuevo)
        Me.gbMantenimiento.Controls.Add(Me.btlEliminar)
        Me.gbMantenimiento.Location = New System.Drawing.Point(664, 12)
        Me.gbMantenimiento.Name = "gbMantenimiento"
        Me.gbMantenimiento.Size = New System.Drawing.Size(118, 191)
        Me.gbMantenimiento.TabIndex = 24
        Me.gbMantenimiento.TabStop = False
        Me.gbMantenimiento.Text = "Mantenimiento"
        '
        'btnHabilitar
        '
        Me.btnHabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHabilitar.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reservar
        Me.btnHabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHabilitar.Location = New System.Drawing.Point(17, 156)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(86, 25)
        Me.btnHabilitar.TabIndex = 26
        Me.btnHabilitar.Text = "Habilitar"
        Me.btnHabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHabilitar.UseVisualStyleBackColor = True
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(151, 69)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(364, 20)
        Me.txtNombres.TabIndex = 11
        '
        'frmAdmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(841, 415)
        Me.Controls.Add(Me.gbMantenimiento)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.gbRegistros)
        Me.Controls.Add(Me.gbDatosGenerales)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "... Mantenimieto de Menus"
        Me.gbDatosGenerales.ResumeLayout(False)
        Me.gbDatosGenerales.PerformLayout()
        Me.gbRegistros.ResumeLayout(False)
        CType(Me.dgRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOpciones.ResumeLayout(False)
        Me.gbMantenimiento.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTipoMenu As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFormulario As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNon_Estudiante As System.Windows.Forms.Label
    Friend WithEvents gbRegistros As System.Windows.Forms.GroupBox
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btlEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents dgRegistros As System.Windows.Forms.DataGridView
    Friend WithEvents gbMantenimiento As System.Windows.Forms.GroupBox
    Friend WithEvents btnHabilitar As System.Windows.Forms.Button
    Friend WithEvents app_cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Formulario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tip_AppCod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Menus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
End Class
