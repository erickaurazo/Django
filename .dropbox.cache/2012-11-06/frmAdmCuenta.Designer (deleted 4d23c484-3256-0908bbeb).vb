<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmCuenta
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
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCondicion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.gbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.txtNomClave = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtNomUsuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnEdicion = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.gbDatosGenerales.SuspendLayout()
        Me.gbEdicion.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        Me.SuspendLayout()
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
        Me.gbDatosGenerales.Location = New System.Drawing.Point(57, 13)
        Me.gbDatosGenerales.Name = "gbDatosGenerales"
        Me.gbDatosGenerales.Size = New System.Drawing.Size(444, 103)
        Me.gbDatosGenerales.TabIndex = 12
        Me.gbDatosGenerales.TabStop = False
        Me.gbDatosGenerales.Text = "Datos Generales Personal"
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(138, 22)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(45, 20)
        Me.txtCodigo.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 24)
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
        Me.txtUsuario.Location = New System.Drawing.Point(269, 22)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(144, 20)
        Me.txtUsuario.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 24)
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
        Me.cbCondicion.Location = New System.Drawing.Point(139, 48)
        Me.cbCondicion.Name = "cbCondicion"
        Me.cbCondicion.Size = New System.Drawing.Size(121, 21)
        Me.cbCondicion.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Condición :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 82)
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
        Me.txtNombreCompleto.Location = New System.Drawing.Point(138, 75)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(275, 20)
        Me.txtNombreCompleto.TabIndex = 5
        '
        'gbEdicion
        '
        Me.gbEdicion.Controls.Add(Me.btnGrabar)
        Me.gbEdicion.Controls.Add(Me.txtNomClave)
        Me.gbEdicion.Controls.Add(Me.lblContraseña)
        Me.gbEdicion.Controls.Add(Me.txtNomUsuario)
        Me.gbEdicion.Controls.Add(Me.Label6)
        Me.gbEdicion.Location = New System.Drawing.Point(57, 200)
        Me.gbEdicion.Name = "gbEdicion"
        Me.gbEdicion.Size = New System.Drawing.Size(444, 116)
        Me.gbEdicion.TabIndex = 15
        Me.gbEdicion.TabStop = False
        Me.gbEdicion.Text = "Edición"
        '
        'btnGrabar
        '
        Me.btnGrabar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Guardar_Archivo
        Me.btnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGrabar.Location = New System.Drawing.Point(317, 46)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(77, 23)
        Me.btnGrabar.TabIndex = 19
        Me.btnGrabar.Text = "&Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'txtNomClave
        '
        Me.txtNomClave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtNomClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomClave.Enabled = False
        Me.txtNomClave.Location = New System.Drawing.Point(139, 49)
        Me.txtNomClave.MaxLength = 8
        Me.txtNomClave.Name = "txtNomClave"
        Me.txtNomClave.Size = New System.Drawing.Size(144, 20)
        Me.txtNomClave.TabIndex = 14
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(66, 51)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(67, 13)
        Me.lblContraseña.TabIndex = 13
        Me.lblContraseña.Text = "Contraseña :"
        '
        'txtNomUsuario
        '
        Me.txtNomUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtNomUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomUsuario.Enabled = False
        Me.txtNomUsuario.Location = New System.Drawing.Point(139, 22)
        Me.txtNomUsuario.MaxLength = 15
        Me.txtNomUsuario.Name = "txtNomUsuario"
        Me.txtNomUsuario.Size = New System.Drawing.Size(144, 20)
        Me.txtNomUsuario.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(83, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Usuario :"
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.btnEdicion)
        Me.gbOpciones.Controls.Add(Me.btnNuevo)
        Me.gbOpciones.Location = New System.Drawing.Point(57, 122)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(444, 52)
        Me.gbOpciones.TabIndex = 16
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "Opciones"
        '
        'btnEdicion
        '
        Me.btnEdicion.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Modificar_Registro
        Me.btnEdicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdicion.Location = New System.Drawing.Point(269, 21)
        Me.btnEdicion.Name = "btnEdicion"
        Me.btnEdicion.Size = New System.Drawing.Size(77, 25)
        Me.btnEdicion.TabIndex = 18
        Me.btnEdicion.Text = "Edición"
        Me.btnEdicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdicion.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Registrar_Persona
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNuevo.Location = New System.Drawing.Point(138, 19)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(77, 25)
        Me.btnNuevo.TabIndex = 17
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmAdmCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 335)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.gbEdicion)
        Me.Controls.Add(Me.gbDatosGenerales)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdmCuenta"
        Me.Text = "... Administrar Cuenta"
        Me.gbDatosGenerales.ResumeLayout(False)
        Me.gbDatosGenerales.PerformLayout()
        Me.gbEdicion.ResumeLayout(False)
        Me.gbEdicion.PerformLayout()
        Me.gbOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCondicion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNombreCompleto As System.Windows.Forms.TextBox
    Friend WithEvents gbEdicion As System.Windows.Forms.GroupBox
    Friend WithEvents txtNomUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents txtNomClave As System.Windows.Forms.TextBox
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents btnEdicion As System.Windows.Forms.Button
End Class
