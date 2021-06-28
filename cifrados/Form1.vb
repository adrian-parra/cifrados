Public Class Form1
    Dim Tsalida, Tentrada, Vtabla, Valeatorio, valcifrado As New ArrayList

    Dim m As String = ""
    Dim valcifr As String = ""

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
                    '     MsgBox(Valeatorio(i))

                Next

                'agrupar mensaje en tres
                Dim contPareja As Integer = 0
                Dim val As String = ""
                For i = 1 To m.Length
                    contPareja += 1
                    val += Mid(m, i, 1)

                    'MsgBox("val  " + val)
                    'MsgBox("cont " + Str(contPareja))
                    If contPareja = 3 Then

                        'buscar valor en la tabla
                        For j = 0 To Tentrada.Count - 1
                            ' MsgBox("entro val " + val)
                            ' MsgBox(Tentrada(j))

                            If val = addCero(ConvBin(Tentrada(j)), txt_k.Text) Then
                                Vtabla.Add(addCero(ConvBin(Tsalida(j)), txt_k.Text))
                                'MsgBox(addCero(ConvBin(Tsalida(j)), txt_k.Text))
                                Exit For
                            End If
                        Next

                        contPareja = 0
                        val = ""
                    End If
                Next

                'cifrado
                Dim valC As String = ""
                For j = 0 To CInt(txt_k.Text) - 1
                    For i = 1 To CInt(txt_k.Text)
                        If Mid(Vtabla(j), i, 1) <> Mid(Valeatorio(j), i, 1) Then
                            valC += "1"
                        Else
                            valC += "0"
                        End If

                    Next
                    'valcifrado.Add(valC)
                    'MsgBox(valC)
                    valC = ""

                Next

            Else
                'cuando es mas de un caracter
                Dim caracter As String = ""
                For k = 1 To txt_textoclaro.Text.Length
                    caracter = Mid(txt_textoclaro.Text, k, 1)

                    m = ConvBin(Str(Asc(caracter)))
                    m = addCero(m, "9")

                    If k = 1 Then
                        'tutorial
                        lv_metodo.Items.Add("paso 1:")
                        lv_metodo.Items.Add("convertir el caracter " + caracter + " ascii")
                        lv_metodo.Items.Add("del valor ascii " + Str(Asc(caracter)))
                        lv_metodo.Items.Add("a binario " + m)
                    End If



                    'generar num random
                    For i = 0 To CInt(txt_k.Text) - 1
                        Valeatorio.Add(addCero(ConvBin(Str(NumR(txt_k.Text))), txt_k.Text))
                        ' MsgBox(Valeatorio(i))
                        If k = 1 And i = 0 Then
                            lv_metodo.Items.Add("paso 2")
                            lv_metodo.Items.Add("sacar 3 numeros randoms")



                        End If

                    Next
                    If k = 1 Then
                        lv_metodo.Items.Add(Valeatorio(0) + " " + Valeatorio(1) + " " + Valeatorio(2))
                    End If

                    'agrupar mensaje en tres
                    If k = 1 Then
                        lv_metodo.Items.Add("paso 3")
                        lv_metodo.Items.Add("agrupar mensaje en 3 bits")
                        lv_metodo.Items.Add(m)

                    End If


                    Dim contPareja As Integer = 0
                    Dim val As String = ""
                    For i = 1 To m.Length
                        contPareja += 1
                        val += Mid(m, i, 1)

                        'MsgBox("val  " + val)
                        'MsgBox("cont " + Str(contPareja))
                        If contPareja = 3 Then

                            'buscar valor en la tabla
                            For j = 0 To Tentrada.Count - 1
                                ' MsgBox("entro val " + val)
                                ' MsgBox(Tentrada(j))

                                If val = addCero(ConvBin(Tentrada(j)), txt_k.Text) Then
                                    Vtabla.Add(addCero(ConvBin(Tsalida(j)), txt_k.Text))
                                    If k = 1 And j = 0 Then
                                        lv_metodo.Items.Add("grupo  " + Str(j + 1) + " " + val)
                                        lv_metodo.Items.Add("tabla " + addCero(ConvBin(Tsalida(j)), txt_k.Text))


                                    End If
                                    ' MsgBox(addCero(ConvBin(Tsalida(j)), txt_k.Text))
                                    Exit For
                                End If
                            Next

                            contPareja = 0
                            val = ""
                        End If
                    Next

                    'cifrado
                    Dim valC As String = ""
                    For j = 0 To CInt(txt_k.Text) - 1
                        For i = 1 To CInt(txt_k.Text)
                            If Mid(Vtabla(j), i, 1) <> Mid(Valeatorio(j), i, 1) Then
                                valC += "1"
                            Else
                                valC += "0"
                            End If

                        Next
                        valcifrado.Add(valC)
                        'MsgBox(valC)
                        valC = ""
                        If k = 1 And j = 0 Then
                            lv_metodo.Items.Add("paso 4")
                            lv_metodo.Items.Add("aplicar xor entre valor de tabla y valor aleatorio")
                            lv_metodo.Items.Add(Vtabla(0) + " xor " + Valeatorio(0))

                            lv_metodo.Items.Add("cifrado")






                        End If
                    Next
                Next
                valcifr = ""
                Dim valn As String = ""
                For i = 0 To valcifrado.Count - 1
                    valcifr += valcifrado(i)
                    valn += Valeatorio(i)
                    ' MsgBox("cifrado " + valcifr)
                Next
                lv_metodo.Items.Add(valcifr)


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
