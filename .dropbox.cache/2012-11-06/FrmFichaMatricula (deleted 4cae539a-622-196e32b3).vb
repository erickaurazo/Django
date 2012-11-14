Option Explicit On
Option Strict On
Public Class FrmFichaMatricula
    Dim oMat As New LogicaNegocio.Matricula
    Dim oDet As New LogicaNegocio.Matricula_Detalle
    Dim _Codigo As Integer
    Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Sub New(ByVal codigo As Integer)
        InitializeComponent()
        
        _Codigo = codigo



    End Sub

    Private Sub FrmFichaMatricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim reporte As New Cr_FichaMatricula
            Dim oMat As New LogicaNegocio.Matricula
            Dim tabla As New DataTable
            tabla = oMat.Cr_FichaMatricula(_Codigo)
            reporte.SetDataSource(tabla)
            Me.CR_FichaMatricula.ReportSource = reporte

        Catch ex As Exception
            Throw ex
            MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Reporte")
        End Try

        'Try
        '    Dim reporte2 As New Cr_FichaMatricula
        '    Dim tabla2 As New DataTable
        '    tabla2 = oDet.Cr_DetalleMatricula(_Codigo)
        '    reporte2.SetDataSource(tabla2)
        '    Me.CR_FichaMatricula.ReportSource = reporte2

        'Catch ex As Exception
        '    Throw ex
        '    MsgBox(ex.Source & "; " & ex.Message, MsgBoxStyle.OkOnly, "Reporte")
        'End Try
    End Sub
End Class