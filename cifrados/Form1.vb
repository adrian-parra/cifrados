Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Function validaciontxt() As Boolean

        If txt_k.Text = "" Then
            MsgBox("Ingrese el valor de k", MsgBoxStyle.OkOnly + vbCritical, "error")
            txt_k.Focus()
            Return False
        ElseIf txt_textoclaro.Text = "" Then
            MsgBox("Ingrese texto claro", MsgBoxStyle.OkOnly + vbCritical, "error")
            txt_textoclaro.Focus()
            Return False
        ElseIf cb_metodocifrado.Text = "" Then
            MsgBox("Seleccione el m,etodo de cifrado", MsgBoxStyle.OkOnly + vbCritical, "error")
            cb_metodocifrado.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'VERIFICAR LOS TXT
        If validaciontxt() Then
            'codigo del programa de cifrado

        Else
            'error de usuario
        End If


    End Sub
End Class
