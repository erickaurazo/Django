<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIMenu))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecialidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModulosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AulasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfraestructuraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatriculasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatriculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblNombre = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolNombre = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripAdministracion = New System.Windows.Forms.ToolStrip()
        Me.toolbtnCuentas = New System.Windows.Forms.ToolStripButton()
        Me.toolbtnMatricula = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbtnPagos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbtnAdmision = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.MenusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStripAdministracion.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.MantenimientosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.OperacionToolStripMenuItem, Me.ViewMenu, Me.WindowsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuentasToolStripMenuItem, Me.CerrarToolStripMenuItem, Me.SalirDelSistemaToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "&Sistema"
        '
        'CuentasToolStripMenuItem
        '
        Me.CuentasToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.Sistema_Cuentas
        Me.CuentasToolStripMenuItem.Name = "CuentasToolStripMenuItem"
        Me.CuentasToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CuentasToolStripMenuItem.Text = "Cuentas"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Image = CType(resources.GetObject("CerrarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar ventanas"
        '
        'SalirDelSistemaToolStripMenuItem
        '
        Me.SalirDelSistemaToolStripMenuItem.Image = CType(resources.GetObject("SalirDelSistemaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirDelSistemaToolStripMenuItem.Name = "SalirDelSistemaToolStripMenuItem"
        Me.SalirDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SalirDelSistemaToolStripMenuItem.Text = "Salir del Sistema"
        '
        'MantenimientosToolStripMenuItem
        '
        Me.MantenimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalToolStripMenuItem1, Me.EspecialidadToolStripMenuItem, Me.ModulosToolStripMenuItem1, Me.CursosToolStripMenuItem1, Me.AulasToolStripMenuItem, Me.InfraestructuraToolStripMenuItem, Me.MenusToolStripMenuItem})
        Me.MantenimientosToolStripMenuItem.Name = "MantenimientosToolStripMenuItem"
        Me.MantenimientosToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.MantenimientosToolStripMenuItem.Text = "&Mantenimientos"
        '
        'PersonalToolStripMenuItem1
        '
        Me.PersonalToolStripMenuItem1.Image = Global.Matricula.Presentacion.My.Resources.Resources.Registrar_Persona
        Me.PersonalToolStripMenuItem1.Name = "PersonalToolStripMenuItem1"
        Me.PersonalToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.PersonalToolStripMenuItem1.Text = "Personal"
        '
        'EspecialidadToolStripMenuItem
        '
        Me.EspecialidadToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.herramientas_Administrativas
        Me.EspecialidadToolStripMenuItem.Name = "EspecialidadToolStripMenuItem"
        Me.EspecialidadToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.EspecialidadToolStripMenuItem.Text = "Especialidad"
        '
        'ModulosToolStripMenuItem1
        '
        Me.ModulosToolStripMenuItem1.Image = Global.Matricula.Presentacion.My.Resources.Resources.herramientas_Administrativas
        Me.ModulosToolStripMenuItem1.Name = "ModulosToolStripMenuItem1"
        Me.ModulosToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.ModulosToolStripMenuItem1.Text = "Módulos"
        '
        'CursosToolStripMenuItem1
        '
        Me.CursosToolStripMenuItem1.Image = Global.Matricula.Presentacion.My.Resources.Resources.herramientas_Administrativas
        Me.CursosToolStripMenuItem1.Name = "CursosToolStripMenuItem1"
        Me.CursosToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.CursosToolStripMenuItem1.Text = "Cursos"
        '
        'AulasToolStripMenuItem
        '
        Me.AulasToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.herramientas_Administrativas
        Me.AulasToolStripMenuItem.Name = "AulasToolStripMenuItem"
        Me.AulasToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AulasToolStripMenuItem.Text = "Aulas"
        '
        'InfraestructuraToolStripMenuItem
        '
        Me.InfraestructuraToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.herramientas_Administrativas
        Me.InfraestructuraToolStripMenuItem.Name = "InfraestructuraToolStripMenuItem"
        Me.InfraestructuraToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.InfraestructuraToolStripMenuItem.Text = "Infraestructura"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MatriculasToolStripMenuItem, Me.CursosToolStripMenuItem, Me.ModulosToolStripMenuItem, Me.HorariosToolStripMenuItem, Me.PersonalToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "&Reportes"
        '
        'MatriculasToolStripMenuItem
        '
        Me.MatriculasToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reporte_Estadisticas
        Me.MatriculasToolStripMenuItem.Name = "MatriculasToolStripMenuItem"
        Me.MatriculasToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.MatriculasToolStripMenuItem.Text = "Matriculas"
        '
        'CursosToolStripMenuItem
        '
        Me.CursosToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reporte_Estadisticas
        Me.CursosToolStripMenuItem.Name = "CursosToolStripMenuItem"
        Me.CursosToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.CursosToolStripMenuItem.Text = "Cursos"
        '
        'ModulosToolStripMenuItem
        '
        Me.ModulosToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reporte_Estadisticas
        Me.ModulosToolStripMenuItem.Name = "ModulosToolStripMenuItem"
        Me.ModulosToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ModulosToolStripMenuItem.Text = "Modulos"
        '
        'HorariosToolStripMenuItem
        '
        Me.HorariosToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reporte_Estadisticas
        Me.HorariosToolStripMenuItem.Name = "HorariosToolStripMenuItem"
        Me.HorariosToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.HorariosToolStripMenuItem.Text = "Horarios"
        '
        'PersonalToolStripMenuItem
        '
        Me.PersonalToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.Reporte_Estadisticas
        Me.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem"
        Me.PersonalToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.PersonalToolStripMenuItem.Text = "Personal"
        '
        'OperacionToolStripMenuItem
        '
        Me.OperacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagosToolStripMenuItem, Me.MatriculaToolStripMenuItem, Me.AdminisionToolStripMenuItem})
        Me.OperacionToolStripMenuItem.Name = "OperacionToolStripMenuItem"
        Me.OperacionToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.OperacionToolStripMenuItem.Text = "&Operacion"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.Costos
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'MatriculaToolStripMenuItem
        '
        Me.MatriculaToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.Matricular
        Me.MatriculaToolStripMenuItem.Name = "MatriculaToolStripMenuItem"
        Me.MatriculaToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.MatriculaToolStripMenuItem.Text = "Matricula"
        '
        'AdminisionToolStripMenuItem
        '
        Me.AdminisionToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.Sistema_Adminsion
        Me.AdminisionToolStripMenuItem.Name = "AdminisionToolStripMenuItem"
        Me.AdminisionToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AdminisionToolStripMenuItem.Text = "Adminision"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarToolStripMenuItem, Me.StatusBarToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(36, 20)
        Me.ViewMenu.Text = "&Ver"
        '
        'ToolBarToolStripMenuItem
        '
        Me.ToolBarToolStripMenuItem.Checked = True
        Me.ToolBarToolStripMenuItem.CheckOnClick = True
        Me.ToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        Me.ToolBarToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ToolBarToolStripMenuItem.Text = "&Barra de herramientas"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.StatusBarToolStripMenuItem.Text = "&Barra de estado"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(67, 20)
        Me.WindowsMenu.Text = "&Ventanas"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.NewWindowToolStripMenuItem.Text = "&Nueva ventana"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascada"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Mosaico &vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&errar todo"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Organizar iconos"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(53, 20)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contenido"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.IndexToolStripMenuItem.Text = "&Índice"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SearchToolStripMenuItem.Text = "&Buscar"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(173, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuario, Me.toolUsuario, Me.ToolStripSeparator9, Me.lblNombre, Me.toolNombre, Me.ToolStripSeparator2, Me.lblFecha, Me.toolFecha, Me.ToolStripSeparator10, Me.lblHora, Me.toolHora})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 430)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 23)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'lblUsuario
        '
        Me.lblUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(55, 18)
        Me.lblUsuario.Text = "Usuario :"
        '
        'toolUsuario
        '
        Me.toolUsuario.Name = "toolUsuario"
        Me.toolUsuario.Size = New System.Drawing.Size(10, 18)
        Me.toolUsuario.Text = " "
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 23)
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(59, 18)
        Me.lblNombre.Text = "Nombre :"
        '
        'toolNombre
        '
        Me.toolNombre.AutoSize = False
        Me.toolNombre.Name = "toolNombre"
        Me.toolNombre.Size = New System.Drawing.Size(200, 18)
        Me.toolNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(47, 18)
        Me.lblFecha.Text = "Hoy es:"
        Me.lblFecha.ToolTipText = "Hoy es :"
        '
        'toolFecha
        '
        Me.toolFecha.Name = "toolFecha"
        Me.toolFecha.Size = New System.Drawing.Size(0, 18)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 23)
        '
        'lblHora
        '
        Me.lblHora.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(98, 18)
        Me.lblHora.Text = "Ud inició sesión :"
        '
        'toolHora
        '
        Me.toolHora.Name = "toolHora"
        Me.toolHora.Size = New System.Drawing.Size(0, 18)
        '
        'ToolTip
        '
        Me.ToolTip.ToolTipTitle = "Menu Principal"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 76)
        Me.ToolStripSeparator1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270
        '
        'ToolStripAdministracion
        '
        Me.ToolStripAdministracion.AutoSize = False
        Me.ToolStripAdministracion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolbtnCuentas, Me.ToolStripSeparator1, Me.toolbtnMatricula, Me.ToolStripSeparator3, Me.toolbtnPagos, Me.ToolStripSeparator4, Me.toolbtnAdmision, Me.ToolStripSeparator5, Me.toolbtnSalir})
        Me.ToolStripAdministracion.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripAdministracion.Name = "ToolStripAdministracion"
        Me.ToolStripAdministracion.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStripAdministracion.Size = New System.Drawing.Size(632, 76)
        Me.ToolStripAdministracion.TabIndex = 6
        Me.ToolStripAdministracion.Text = "ToolStrip"
        Me.ToolStripAdministracion.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270
        '
        'toolbtnCuentas
        '
        Me.toolbtnCuentas.AutoSize = False
        Me.toolbtnCuentas.Font = New System.Drawing.Font("Arial Black", 7.75!, System.Drawing.FontStyle.Bold)
        Me.toolbtnCuentas.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.toolbtnCuentas.Image = Global.Matricula.Presentacion.My.Resources.Resources.Sesion_Usuarios
        Me.toolbtnCuentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolbtnCuentas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbtnCuentas.Name = "toolbtnCuentas"
        Me.toolbtnCuentas.Size = New System.Drawing.Size(80, 80)
        Me.toolbtnCuentas.Text = "&Cuentas "
        Me.toolbtnCuentas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolbtnCuentas.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.toolbtnCuentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.toolbtnCuentas.ToolTipText = "Administrar Cuentas de Usuario"
        '
        'toolbtnMatricula
        '
        Me.toolbtnMatricula.AutoSize = False
        Me.toolbtnMatricula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.toolbtnMatricula.Font = New System.Drawing.Font("Arial Black", 7.75!, System.Drawing.FontStyle.Bold)
        Me.toolbtnMatricula.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.toolbtnMatricula.Image = Global.Matricula.Presentacion.My.Resources.Resources.Registrar_Matricula
        Me.toolbtnMatricula.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolbtnMatricula.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolbtnMatricula.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbtnMatricula.Name = "toolbtnMatricula"
        Me.toolbtnMatricula.Size = New System.Drawing.Size(80, 80)
        Me.toolbtnMatricula.Text = "Ma&tricula"
        Me.toolbtnMatricula.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.toolbtnMatricula.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.toolbtnMatricula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.toolbtnMatricula.ToolTipText = "Registrar Matricula"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 76)
        Me.ToolStripSeparator3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270
        '
        'toolbtnPagos
        '
        Me.toolbtnPagos.AutoSize = False
        Me.toolbtnPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.toolbtnPagos.Font = New System.Drawing.Font("Arial Black", 7.75!, System.Drawing.FontStyle.Bold)
        Me.toolbtnPagos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.toolbtnPagos.Image = Global.Matricula.Presentacion.My.Resources.Resources.Pago_Dinero
        Me.toolbtnPagos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolbtnPagos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolbtnPagos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbtnPagos.Name = "toolbtnPagos"
        Me.toolbtnPagos.Size = New System.Drawing.Size(80, 80)
        Me.toolbtnPagos.Text = "&Pagos"
        Me.toolbtnPagos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.toolbtnPagos.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.toolbtnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 76)
        Me.ToolStripSeparator4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270
        '
        'toolbtnAdmision
        '
        Me.toolbtnAdmision.AutoSize = False
        Me.toolbtnAdmision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.toolbtnAdmision.Font = New System.Drawing.Font("Arial Black", 7.75!, System.Drawing.FontStyle.Bold)
        Me.toolbtnAdmision.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.toolbtnAdmision.Image = Global.Matricula.Presentacion.My.Resources.Resources.Sistema_Adminsion
        Me.toolbtnAdmision.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolbtnAdmision.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolbtnAdmision.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbtnAdmision.Name = "toolbtnAdmision"
        Me.toolbtnAdmision.Size = New System.Drawing.Size(80, 80)
        Me.toolbtnAdmision.Text = "&Admisión"
        Me.toolbtnAdmision.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.toolbtnAdmision.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.toolbtnAdmision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 76)
        Me.ToolStripSeparator5.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270
        '
        'toolbtnSalir
        '
        Me.toolbtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.toolbtnSalir.AutoSize = False
        Me.toolbtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.toolbtnSalir.Font = New System.Drawing.Font("Arial Black", 7.75!, System.Drawing.FontStyle.Bold)
        Me.toolbtnSalir.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.toolbtnSalir.Image = Global.Matricula.Presentacion.My.Resources.Resources.Log_Off
        Me.toolbtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolbtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolbtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbtnSalir.Name = "toolbtnSalir"
        Me.toolbtnSalir.Size = New System.Drawing.Size(80, 80)
        Me.toolbtnSalir.Text = "Salir"
        Me.toolbtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.toolbtnSalir.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.toolbtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MenusToolStripMenuItem
        '
        Me.MenusToolStripMenuItem.Image = Global.Matricula.Presentacion.My.Resources.Resources.herramientas_Administrativas
        Me.MenusToolStripMenuItem.Name = "MenusToolStripMenuItem"
        Me.MenusToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MenusToolStripMenuItem.Text = "Menus"
        '
        'MDIMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.ToolStripAdministracion)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "... Sistema Gestión de Académica"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStripAdministracion.ResumeLayout(False)
        Me.ToolStripAdministracion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblNombre As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolNombre As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblHora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolHora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CuentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripAdministracion As System.Windows.Forms.ToolStrip
    Friend WithEvents SalirDelSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MatriculaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MatriculasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CursosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModulosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CursosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AulasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfraestructuraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EspecialidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolbtnCuentas As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolbtnMatricula As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolbtnPagos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolbtnAdmision As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AdminisionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolbtnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
