<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarEstudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarEstudiante))
        Me.GbSemestre = New System.Windows.Forms.GroupBox()
        Me.lblNom_Semestre = New System.Windows.Forms.Label()
        Me.cbSemestre = New System.Windows.Forms.ComboBox()
        Me.gbBuscarEstudiante = New System.Windows.Forms.GroupBox()
        Me.BtnBuscarAlumno = New System.Windows.Forms.Button()
        Me.lblNon_Estudiante = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNom_Especialidad = New System.Windows.Forms.Label()
        Me.cbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.gbRegistroEstudiantes = New System.Windows.Forms.GroupBox()
        Me.dgRegistroEstudiantes = New System.Windows.Forms.DataGridView()
        Me.gbMantenimiento = New System.Windows.Forms.GroupBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnAgregarRegistro = New System.Windows.Forms.Button()
        Me.btnMatricular = New System.Windows.Forms.Button()
        Me.Código = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Esp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cod_Esp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cod_Sem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cod_Cic = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GbSemestre.SuspendLayout()
        Me.gbBuscarEstudiante.SuspendLayout()
        Me.gbRegistroEstudiantes.SuspendLayout()
        CType(Me.dgRegistroEstudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbSemestre
        '
        Me.GbSemestre.Controls.Add(Me.lblNom_Semestre)
        Me.GbSemestre.Controls.Add(Me.cbSemestre)
        Me.GbSemestre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GbSemestre.Location = New System.Drawing.Point(12, 12)
        Me.GbSemestre.Name = "GbSemestre"
        Me.GbSemestre.Size = New System.Drawing.Size(752, 47)
        Me.GbSemestre.TabIndex = 0
        Me.GbSemestre.TabStop = False
        Me.GbSemestre.Text = "Semestre"
        '
        'lblNom_Semestre
        '
        Me.lblNom_Semestre.AutoSize = True
        Me.lblNom_Semestre.Location = New System.Drawing.Point(210, 17)
        Me.lblNom_Semestre.Name = "lblNom_Semestre"
        Me.lblNom_Semestre.Size = New System.Drawing.Size(86, 13)
        Me.lblNom_Semestre.TabIndex = 1
        Me.lblNom_Semestre.Text = "Indicar Semestre"
        '
        'cbSemestre
        '
        Me.cbSemestre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbSemestre.FormattingEnabled = True
        Me.cbSemestre.Location = New System.Drawing.Point(302, 14)
        Me.cbSemestre.Name = "cbSemestre"
        Me.cbSemestre.Size = New System.Drawing.Size(166, 21)
        Me.cbSemestre.TabIndex = 0
        '
        'gbBuscarEstudiante
        '
        Me.gbBuscarEstudiante.Controls.Add(Me.BtnBuscarAlumno)
        Me.gbBuscarEstudiante.Controls.Add(Me.lblNon_Estudiante)
        Me.gbBuscarEstudiante.Controls.Add(Me.txtNombre)
        Me.gbBuscarEstudiante.Controls.Add(Me.lblNom_Especialidad)
        Me.gbBuscarEstudiante.Controls.Add(Me.cbEspecialidad)
        Me.gbBuscarEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbBuscarEstudiante.Location = New System.Drawing.Point(12, 65)
        Me.gbBuscarEstudiante.Name = "gbBuscarEstudiante"
        Me.gbBuscarEstudiante.Size = New System.Drawing.Size(752, 53)
        Me.gbBuscarEstudiante.TabIndex = 1
        Me.gbBuscarEstudiante.TabStop = False
        Me.gbBuscarEstudiante.Text = "Buscar Estudiante"
        '
        'BtnBuscarAlumno
        '
        Me.BtnBuscarAlumno.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Buscar_Registro
        Me.BtnBuscarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnBuscarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBuscarAlumno.Location = New System.Drawing.Point(658, 20)
        Me.BtnBuscarAlumno.Name = "BtnBuscarAlumno"
        Me.BtnBuscarAlumno.Size = New System.Drawing.Size(69, 26)
        Me.BtnBuscarAlumno.TabIndex = 3
        Me.BtnBuscarAlumno.Text = "Buscar"
        Me.BtnBuscarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarAlumno.UseVisualStyleBackColor = True
        '
        'lblNon_Estudiante
        '
        Me.lblNon_Estudiante.AutoSize = True
        Me.lblNon_Estudiante.Location = New System.Drawing.Point(294, 30)
        Me.lblNon_Estudiante.Name = "lblNon_Estudiante"
        Me.lblNon_Estudiante.Size = New System.Drawing.Size(47, 13)
        Me.lblNon_Estudiante.TabIndex = 2
        Me.lblNon_Estudiante.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(342, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(310, 20)
        Me.txtNombre.TabIndex = 2
        '
        'lblNom_Especialidad
        '
        Me.lblNom_Especialidad.AutoSize = True
        Me.lblNom_Especialidad.Location = New System.Drawing.Point(9, 27)
        Me.lblNom_Especialidad.Name = "lblNom_Especialidad"
        Me.lblNom_Especialidad.Size = New System.Drawing.Size(67, 13)
        Me.lblNom_Especialidad.TabIndex = 1
        Me.lblNom_Especialidad.Text = "Especialidad"
        '
        'cbEspecialidad
        '
        Me.cbEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbEspecialidad.FormattingEnabled = True
        Me.cbEspecialidad.Location = New System.Drawing.Point(78, 24)
        Me.cbEspecialidad.Name = "cbEspecialidad"
        Me.cbEspecialidad.Size = New System.Drawing.Size(209, 21)
        Me.cbEspecialidad.TabIndex = 0
        '
        'gbRegistroEstudiantes
        '
        Me.gbRegistroEstudiantes.Controls.Add(Me.dgRegistroEstudiantes)
        Me.gbRegistroEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbRegistroEstudiantes.Location = New System.Drawing.Point(48, 124)
        Me.gbRegistroEstudiantes.Name = "gbRegistroEstudiantes"
        Me.gbRegistroEstudiantes.Size = New System.Drawing.Size(669, 236)
        Me.gbRegistroEstudiantes.TabIndex = 2
        Me.gbRegistroEstudiantes.TabStop = False
        Me.gbRegistroEstudiantes.Text = "Registro de  Estudiantes"
        '
        'dgRegistroEstudiantes
        '
        Me.dgRegistroEstudiantes.AllowUserToAddRows = False
        Me.dgRegistroEstudiantes.AllowUserToDeleteRows = False
        Me.dgRegistroEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRegistroEstudiantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Código, Me.Nombres, Me.Esp, Me.Cod_Esp, Me.Cod_Sem, Me.Cod_Cic})
        Me.dgRegistroEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRegistroEstudiantes.Location = New System.Drawing.Point(3, 16)
        Me.dgRegistroEstudiantes.Name = "dgRegistroEstudiantes"
        Me.dgRegistroEstudiantes.ReadOnly = True
        Me.dgRegistroEstudiantes.Size = New System.Drawing.Size(663, 217)
        Me.dgRegistroEstudiantes.TabIndex = 0
        '
        'gbMantenimiento
        '
        Me.gbMantenimiento.Controls.Add(Me.btnActualizar)
        Me.gbMantenimiento.Controls.Add(Me.BtnSalir)
        Me.gbMantenimiento.Controls.Add(Me.BtnAgregarRegistro)
        Me.gbMantenimiento.Controls.Add(Me.btnMatricular)
        Me.gbMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbMantenimiento.Location = New System.Drawing.Point(51, 366)
        Me.gbMantenimiento.Name = "gbMantenimiento"
        Me.gbMantenimiento.Size = New System.Drawing.Size(666, 58)
        Me.gbMantenimiento.TabIndex = 3
        Me.gbMantenimiento.TabStop = False
        Me.gbMantenimiento.Text = "Opciones de Mantenimiento"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Actualizar
        Me.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnActualizar.Location = New System.Drawing.Point(22, 19)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(131, 24)
        Me.btnActualizar.TabIndex = 7
        Me.btnActualizar.Text = "&Actualizar Registros"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Salir
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.Location = New System.Drawing.Point(523, 19)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(109, 24)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "&Salir Formulario"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnAgregarRegistro
        '
        Me.BtnAgregarRegistro.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Sistema_Cuentas
        Me.BtnAgregarRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAgregarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAgregarRegistro.Location = New System.Drawing.Point(360, 19)
        Me.BtnAgregarRegistro.Name = "BtnAgregarRegistro"
        Me.BtnAgregarRegistro.Size = New System.Drawing.Size(110, 24)
        Me.BtnAgregarRegistro.TabIndex = 5
        Me.BtnAgregarRegistro.Text = "&Nuevo Alumno"
        Me.BtnAgregarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarRegistro.UseVisualStyleBackColor = True
        '
        'btnMatricular
        '
        Me.btnMatricular.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.Matricular
        Me.btnMatricular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMatricular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMatricular.Location = New System.Drawing.Point(193, 19)
        Me.btnMatricular.Name = "btnMatricular"
        Me.btnMatricular.Size = New System.Drawing.Size(123, 24)
        Me.btnMatricular.TabIndex = 4
        Me.btnMatricular.Text = "Pasar a &Matricular"
        Me.btnMatricular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMatricular.UseVisualStyleBackColor = True
        '
        'Código
        '
        Me.Código.DataPropertyName = "Per_cod"
        Me.Código.HeaderText = "Código"
        Me.Código.Name = "Código"
        Me.Código.ReadOnly = True
        Me.Código.Width = 70
        '
        'Nombres
        '
        Me.Nombres.DataPropertyName = "PerNombre"
        Me.Nombres.HeaderText = "Nombres"
        Me.Nombres.MaxInputLength = 200
        Me.Nombres.Name = "Nombres"
        Me.Nombres.ReadOnly = True
        Me.Nombres.Width = 300
        '
        'Esp
        '
        Me.Esp.DataPropertyName = "Esp_Nombre"
        Me.Esp.HeaderText = "Especialidad"
        Me.Esp.Name = "Esp"
        Me.Esp.ReadOnly = True
        Me.Esp.Width = 250
        '
        'Cod_Esp
        '
        Me.Cod_Esp.DataPropertyName = "Especialidad_cod"
        Me.Cod_Esp.HeaderText = "Código Especialidad"
        Me.Cod_Esp.Name = "Cod_Esp"
        Me.Cod_Esp.ReadOnly = True
        Me.Cod_Esp.Visible = False
        '
        'Cod_Sem
        '
        Me.Cod_Sem.DataPropertyName = "Semestre_cod"
        Me.Cod_Sem.HeaderText = "Código Semestre"
        Me.Cod_Sem.Name = "Cod_Sem"
        Me.Cod_Sem.ReadOnly = True
        Me.Cod_Sem.Visible = False
        '
        'Cod_Cic
        '
        Me.Cod_Cic.DataPropertyName = "Ciclo_Cod"
        Me.Cod_Cic.HeaderText = "Código Ciclo"
        Me.Cod_Cic.Name = "Cod_Cic"
        Me.Cod_Cic.ReadOnly = True
        Me.Cod_Cic.Visible = False
        '
        'FrmBuscarEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(775, 423)
        Me.Controls.Add(Me.gbMantenimiento)
        Me.Controls.Add(Me.gbRegistroEstudiantes)
        Me.Controls.Add(Me.gbBuscarEstudiante)
        Me.Controls.Add(Me.GbSemestre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmBuscarEstudiante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".. Buscar Estudiante"
        Me.GbSemestre.ResumeLayout(False)
        Me.GbSemestre.PerformLayout()
        Me.gbBuscarEstudiante.ResumeLayout(False)
        Me.gbBuscarEstudiante.PerformLayout()
        Me.gbRegistroEstudiantes.ResumeLayout(False)
        CType(Me.dgRegistroEstudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMantenimiento.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbSemestre As System.Windows.Forms.GroupBox
    Friend WithEvents lblNom_Semestre As System.Windows.Forms.Label
    Friend WithEvents cbSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents gbBuscarEstudiante As System.Windows.Forms.GroupBox
    Friend WithEvents lblNom_Especialidad As System.Windows.Forms.Label
    Friend WithEvents cbEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblNon_Estudiante As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscarAlumno As System.Windows.Forms.Button
    Friend WithEvents gbRegistroEstudiantes As System.Windows.Forms.GroupBox
    Friend WithEvents dgRegistroEstudiantes As System.Windows.Forms.DataGridView
    Friend WithEvents gbMantenimiento As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnAgregarRegistro As System.Windows.Forms.Button
    Friend WithEvents btnMatricular As System.Windows.Forms.Button
    Friend WithEvents tpMantenimiento As System.Windows.Forms.ToolTip
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents Código As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Esp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cod_Esp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cod_Sem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cod_Cic As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
