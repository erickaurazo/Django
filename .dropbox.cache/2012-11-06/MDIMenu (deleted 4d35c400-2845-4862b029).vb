Imports System.Windows.Forms

Public Class MDIMenu

    Private _codigo As Integer
    Private _nombres As String
    Private _usuario As String
    Private _tipo As Integer

    Dim Tabla As New DataTable
    Dim oCuentas As New LogicaNegocio.ClsCuentas

    Private fhActual As DateTime = Date.Now()
    Private mnFecha, mnHora As String

    Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Sub New(ByVal Codigo As Integer, ByVal Nombres As String, ByVal Usuario As String, ByVal Tipo As Integer)
        InitializeComponent()
        ' TODO: Complete member initialization 
        Inicio()

        Dim mnFecha As String = fhActual.Day.ToString().Trim().PadLeft(2, "0") & "-" & _
                                fhActual.Month.ToString().Trim().PadLeft(2, "0") & "-" & _
                                fhActual.Year.ToString().Trim()

        Dim mnHora As String = fhActual.Hour.ToString().Trim().PadLeft(2, "0") & ":" & _
                                fhActual.Minute.ToString().Trim().PadLeft(2, "0") & ":" & _
                                fhActual.Second.ToString().Trim().PadLeft(2, "0") & " horas"

        _codigo = Codigo
        _nombres = Nombres
        _usuario = Usuario
        _tipo = Tipo

        Tabla = oCuentas.Listar_aplicaciones_por_Usuario(_codigo)
        Dim ncount2 As Integer
        ncount2 = Tabla.Rows.Count - 1

        Me.toolUsuario.Text = _usuario
        Me.toolNombre.Text = _nombres
        Me.toolFecha.Text = mnFecha
        Me.toolHora.Text = mnHora

    End Sub

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStripAdministracion.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer


    Private Sub CuentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentasToolStripMenuItem.Click
        Dim ofrm As New FrmPermisos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub SalirDelSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirDelSistemaToolStripMenuItem.Click
        Dim Resp As Integer
        Resp = MsgBox("" & vbCrLf & "Desea salir del Sistema.", vbQuestion + vbYesNo + vbDefaultButton2, "Gestión Administrativa")
        If Resp = 6 Then
            Me.Close()
        Else
        End If

       


    End Sub

    Private Sub CursosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CursosToolStripMenuItem1.Click
        Dim ofrm As New FrmCurso
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub ModulosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModulosToolStripMenuItem1.Click
        Dim ofrm As New FrmModulo
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub EspecialidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EspecialidadToolStripMenuItem.Click
        Dim ofrm As New FrmEspecialidad
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MatriculaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatriculaToolStripMenuItem.Click
        Dim ofrm As New FrmBuscarEstudiante
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub toolbtnCuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtnCuentas.Click
        Dim ofrm As New FrmPermisos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub toolbtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtnSalir.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        Me.Close()
    End Sub

    Private Sub PersonalToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalToolStripMenuItem1.Click
        Dim ofrm As New FrmMantenimientoPersona
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MDIMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub toolbtnMatricula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtnMatricula.Click
        Dim ofrm As New FrmBuscarEstudiante
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenusToolStripMenuItem.Click
        Dim ofrm As New frmAdmMenu
        ofrm.MdiParent = Me
        ofrm.Show()

    End Sub


    Public Sub Inicio()

        'CuentasToolStripMenuItem.Enabled = False
        'CerrarToolStripMenuItem.Enabled = False
        'SalirDelSistemaToolStripMenuItem.Enabled = False

        'PersonalToolStripMenuItem1.Enabled = False
        'EspecialidadToolStripMenuItem.Enabled = False
        'ModulosToolStripMenuItem1.Enabled = False
        'CursosToolStripMenuItem1.Enabled = False
        'AulasToolStripMenuItem.Enabled = False
        'InfraestructuraToolStripMenuItem.Enabled = False
        'MenusToolStripMenuItem.Enabled = False

        'MatriculasToolStripMenuItem.Enabled = False
        'CursosToolStripMenuItem.Enabled = False
        'ModulosToolStripMenuItem.Enabled = False
        'HorariosToolStripMenuItem.Enabled = False
        'PersonalToolStripMenuItem.Enabled = False

        'PagosToolStripMenuItem.Enabled = False
        'MatriculaToolStripMenuItem.Enabled = False
        'AdminisionToolStripMenuItem.Enabled = False

    End Sub

End Class
