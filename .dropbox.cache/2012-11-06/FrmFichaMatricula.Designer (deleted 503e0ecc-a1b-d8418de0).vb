<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFichaMatricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFichaMatricula))
        Me.CR_FichaMatricula = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CR_FichaMatricula
        '
        Me.CR_FichaMatricula.ActiveViewIndex = -1
        Me.CR_FichaMatricula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        'Me.CR_FichaMatricula.DisplayGroupTree = False
        Me.CR_FichaMatricula.Location = New System.Drawing.Point(0, -2)
        Me.CR_FichaMatricula.Name = "CR_FichaMatricula"
        Me.CR_FichaMatricula.SelectionFormula = ""
        Me.CR_FichaMatricula.Size = New System.Drawing.Size(963, 601)
        Me.CR_FichaMatricula.TabIndex = 0
        Me.CR_FichaMatricula.ViewTimeSelectionFormula = ""
        '
        'FrmFichaMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(959, 598)
        Me.Controls.Add(Me.CR_FichaMatricula)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFichaMatricula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "... Ficha de Matricula"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CR_FichaMatricula As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
