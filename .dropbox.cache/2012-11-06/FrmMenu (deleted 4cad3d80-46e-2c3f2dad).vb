Public Class FrmMenu

    Private Sub MatriculaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatriculaToolStripMenuItem2.Click
        Dim oBus_Est As New FrmBuscarEstudiante
        oBus_Est.ShowDialog()
    End Sub

    Private Sub MnMantenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnMantenimiento.Click
        Dim oBus_Est As New FrmEspecialidad
        oBus_Est.ShowDialog()
    End Sub

    Private Sub ModuloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModuloToolStripMenuItem.Click
        Dim oBus_Est As New FrmModulo
        oBus_Est.ShowDialog()
    End Sub

    Private Sub CursoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CursoToolStripMenuItem.Click
        Dim oBus_Est As New FrmCurso
        oBus_Est.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class