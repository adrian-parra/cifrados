Public Class Form1
    Dim Tsalida, Tentrada As New ArrayList

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    'FUNCION PARA VALIDAR CAMPOS DE TEXTO
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

    'FUNCION PARA GENERAR TABLA
    Private Function GenerarTabla(k As Integer)
        Dim valFin As String = Str(2 ^ k)
        MsgBox(valFin)


        For i = 0 To CInt(valFin)
            Tentrada.Add(Str(i))
        Next

        Tsalida.Add(Str(valFin - 2))
        Tsalida.Add(Str(valFin - 1))
        For i = CInt(valFin - 3) To 0 Step -1
            If i = 1 Then
                Tsalida.Add("0")
            ElseIf i = 0 Then
                Tsalida.Add("1")
            Else
                Tsalida.Add(Str(i))

            End If
        Next



    End Function

    'BUTTON PARA GENERAR TABLA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'VERIFICAR LOS TXT
        If validaciontxt() Then
            'codigo para generar tabla


            GenerarTabla(CInt(txt_k.Text))

            'MOSTRAR TABLA
            For i = 0 To Tsalida.Count - 1
                lv_metodo.Items.Add("entrada " + Tentrada(i) + " --> salida " + Tsalida(i))
            Next
        End If


    End Sub
End Class
