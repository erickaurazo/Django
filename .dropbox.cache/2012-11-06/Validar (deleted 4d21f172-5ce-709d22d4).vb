Public Class Validar
    Public oEditar As Boolean

    Public Sub ValidarLetras(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar)) >= 65 And (Asc(e.KeyChar)) <= 90 Or _
           (Asc(e.KeyChar)) >= 97 And (Asc(e.KeyChar)) <= 122 Or _
           (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or _
           (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Space Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub ValidarEnteros(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 _
           Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Function ValidarNulos(ByVal cadena As String, ByVal mensaje As String) As Boolean
        If cadena.Length = 0 Then
            MessageBox.Show(mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return True
        Else
            Return False
        End If
    End Function
    Public Function ValidarFecha(ByVal fecha As Date, ByVal mensaje As String) As Boolean
        If fecha > Now Then
            MessageBox.Show(mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return True
        Else
            Return False
        End If
    End Function

End Class
