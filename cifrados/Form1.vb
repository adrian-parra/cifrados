Public Class Form1
    Dim Tsalida, Tentrada, Vtabla, Valeatorio, valcifrado As New ArrayList

    Dim m As String = ""

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

    'FUNCIO PARA CONVERTIR VALOR A BINARIO
    Private Function ConvBin(val As String) As String
        Dim b As String = ""
        Dim baux As String = ""
        Do Until val < 2
            b = b + Str(val Mod 2)
            val = Int(val / 2)
        Loop

        b = b + val

        b = StrReverse(b)
        For i = 1 To b.Length
            If Mid(b, i, 1) <> " " Then
                baux += Mid(b, i, 1)
            End If
        Next
        Return baux
    End Function

    'FUNCION PARA AGREGAR 0 LEFT
    Private Function addCero(val As String, k As String) As String
        Dim addc As Integer = 0
        Dim addValCeros As String = ""


        If val.Length < Int(k) Then
            addc = Int(k) - val.Length

            'add 0
            For i = 1 To addc
                addValCeros += "0"
            Next


        End If
        Return addValCeros + val
    End Function

    'BUTTON PARA CIFRAR
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Mi parte 
        If cb_metodocifrado.Text = "Encadenamiento de bloques (i num aleatorios)" Then

            If txt_textoclaro.Text.Length = 1 Then
                m = ConvBin(Str(Asc(txt_textoclaro.Text)))
                m = addCero(m, "9")

                'generar num random
                For i = 0 To CInt(txt_k.Text) - 1
                    Valeatorio.Add(addCero(ConvBin(Str(NumR(txt_k.Text))), txt_k.Text))
                    'MsgBox(Valeatorio(i))

                Next

                'agrupar mensaje en tres
                Dim contPareja As Integer = 0
                Dim val As String = ""
                For i = 1 To m.Length
                    contPareja += 1
                    val += Mid(m, i, 1)

                    MsgBox("val  " + val)
                    MsgBox("cont " + Str(contPareja))
                    If contPareja = 3 Then

                        'buscar valor en la tabla
                        For j = 0 To Tentrada.Count - 1
                            If val = Tentrada(j) Then
                                Vtabla.Add(Tsalida(j))
                                MsgBox(Tsalida(j))
                                Exit For
                            End If
                        Next

                        contPareja = 0
                        val = ""
                    End If
                Next

            End If
            'su parte 
        ElseIf cb_metodocifrado.Text = "Encadenamiento de bloquez (1 num aleatorio)" Then


        End If
    End Sub

    'FUNCION PARA GENERAR NUMEROS RANDOM
    Private Function NumR(k As String) As Integer
        Dim v As Integer = (2 ^ CInt(k))


        Return CInt(Rnd() * v)

    End Function

    'BUTTON PARA GENERAR TABLA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'VERIFICAR LOS TXT
        If validaciontxt() Then
            'codigo para generar tabla


            GenerarTabla(CInt(txt_k.Text))

            'MOSTRAR TABLA
            For i = 0 To Tsalida.Count - 1
                lv_metodo.Items.Add("entrada " + addCero(ConvBin((Tentrada(i))), txt_k.Text) + " --> salida " + addCero(ConvBin(Tsalida(i)), txt_k.Text))
            Next
        End If


    End Sub
End Class
