<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.MnMen� = New System.Windows.Forms.MenuStrip
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MatriculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MatriculaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistroDePostulanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MatriculasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.M�dulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CursosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MpMatr�cula = New System.Windows.Forms.ToolStripMenuItem
        Me.MatriculaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.MpMantenimiento = New System.Windows.Forms.ToolStripMenuItem
        Me.MnMantenimiento = New System.Windows.Forms.ToolStripMenuItem
        Me.ModuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CursoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MnMen�.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnMen�
        '
        Me.MnMen�.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagosToolStripMenuItem, Me.MatriculaToolStripMenuItem, Me.MatriculaToolStripMenuItem1, Me.ReportesToolStripMenuItem, Me.MpMatr�cula, Me.MpMantenimiento})
        Me.MnMen�.Location = New System.Drawing.Point(0, 0)
        Me.MnMen�.Name = "MnMen�"
        Me.MnMen�.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MnMen�.Size = New System.Drawing.Size(1064, 24)
        Me.MnMen�.TabIndex = 2
        Me.MnMen�.Text = "Men�"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(56, 18)
        Me.PagosToolStripMenuItem.Text = "Sistema"
        '
        'IngresarToolStripMenuItem
        '
        Me.IngresarToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.Inicio_Sesiion
        Me.IngresarToolStripMenuItem.Name = "IngresarToolStripMenuItem"
        Me.IngresarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IngresarToolStripMenuItem.Text = "Ingresar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.Salir2
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MatriculaToolStripMenuItem
        '
        Me.MatriculaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagoToolStripMenuItem})
        Me.MatriculaToolStripMenuItem.Name = "MatriculaToolStripMenuItem"
        Me.MatriculaToolStripMenuItem.Size = New System.Drawing.Size(48, 18)
        Me.MatriculaToolStripMenuItem.Text = "Pagos"
        '
        'PagoToolStripMenuItem
        '
        Me.PagoToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.pagos
        Me.PagoToolStripMenuItem.Name = "PagoToolStripMenuItem"
        Me.PagoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PagoToolStripMenuItem.Text = "Pagos"
        '
        'MatriculaToolStripMenuItem1
        '
        Me.MatriculaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroDePostulanteToolStripMenuItem})
        Me.MatriculaToolStripMenuItem1.Name = "MatriculaToolStripMenuItem1"
        Me.MatriculaToolStripMenuItem1.Size = New System.Drawing.Size(61, 18)
        Me.MatriculaToolStripMenuItem1.Text = "Admisi�n"
        '
        'RegistroDePostulanteToolStripMenuItem
        '
        Me.RegistroDePostulanteToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.untitled
        Me.RegistroDePostulanteToolStripMenuItem.Name = "RegistroDePostulanteToolStripMenuItem"
        Me.RegistroDePostulanteToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.RegistroDePostulanteToolStripMenuItem.Text = "Registro de Postulante"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MatriculasToolStripMenuItem, Me.RegistrosToolStripMenuItem, Me.M�dulosToolStripMenuItem, Me.CursosToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(63, 18)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'MatriculasToolStripMenuItem
        '
        Me.MatriculasToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reporte
        Me.MatriculasToolStripMenuItem.Name = "MatriculasToolStripMenuItem"
        Me.MatriculasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MatriculasToolStripMenuItem.Text = "Matriculas"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reporte
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RegistrosToolStripMenuItem.Text = "Registros"
        '
        'M�dulosToolStripMenuItem
        '
        Me.M�dulosToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reporte
        Me.M�dulosToolStripMenuItem.Name = "M�dulosToolStripMenuItem"
        Me.M�dulosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.M�dulosToolStripMenuItem.Text = "M�dulos"
        '
        'CursosToolStripMenuItem1
        '
        Me.CursosToolStripMenuItem1.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reporte
        Me.CursosToolStripMenuItem1.Name = "CursosToolStripMenuItem1"
        Me.CursosToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.CursosToolStripMenuItem1.Text = "Cursos"
        '
        'MpMatr�cula
        '
        Me.MpMatr�cula.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MatriculaToolStripMenuItem2})
        Me.MpMatr�cula.Name = "MpMatr�cula"
        Me.MpMatr�cula.Size = New System.Drawing.Size(62, 18)
        Me.MpMatr�cula.Text = "Matr�cula"
        '
        'MatriculaToolStripMenuItem2
        '
        Me.MatriculaToolStripMenuItem2.Image = Global.Matricula.Presentacion.My.Resources.Resources.Registro_Matricular
        Me.MatriculaToolStripMenuItem2.Name = "MatriculaToolStripMenuItem2"
        Me.MatriculaToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.MatriculaToolStripMenuItem2.Text = "Matricula"
        '
        'MpMantenimiento
        '
        Me.MpMantenimiento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnMantenimiento, Me.ModuloToolStripMenuItem, Me.CursoToolStripMenuItem})
        Me.MpMantenimiento.Name = "MpMantenimiento"
        Me.MpMantenimiento.Size = New System.Drawing.Size(89, 18)
        Me.MpMantenimiento.Text = "Mantenimiento"
        '
        'MnMantenimiento
        '
        Me.MnMantenimiento.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reservar4
        Me.MnMantenimiento.Name = "MnMantenimiento"
        Me.MnMantenimiento.Size = New System.Drawing.Size(152, 22)
        Me.MnMantenimiento.Text = "Especialidad"
        '
        'ModuloToolStripMenuItem
        '
        Me.ModuloToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reservar4
        Me.ModuloToolStripMenuItem.Name = "ModuloToolStripMenuItem"
        Me.ModuloToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModuloToolStripMenuItem.Text = "Modulo"
        '
        'CursoToolStripMenuItem
        '
        Me.CursoToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reservar4
        Me.CursoToolStripMenuItem.Name = "CursoToolStripMenuItem"
        Me.CursoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CursoToolStripMenuItem.Text = "Curso"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Matricula.Presentacion.My.Resources.Resources.matricula
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1064, 677)
        Me.Controls.Add(Me.MnMen�)
        Me.Name = "FrmMenu"
        Me.Text = ".. Sistema de Gestion Acad�mica (SIGA)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MnMen�.ResumeLayout(False)
        Me.MnMen�.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MnMen� As System.Windows.Forms.MenuStrip
    Friend WithEvents PagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MatriculaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MatriculaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MatriculasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MpMatr�cula As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M�dulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CursosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MatriculaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MpMantenimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnMantenimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModuloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CursoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDePostulanteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
