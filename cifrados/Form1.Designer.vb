<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_metodocifrado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_textoclaro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_textocifrado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_textodescifrado = New System.Windows.Forms.TextBox()
        Me.txt_k = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lv_metodo = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(230, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cifrados simetricos y asimetricos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(23, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Metodo de cifrado"
        '
        'cb_metodocifrado
        '
        Me.cb_metodocifrado.FormattingEnabled = True
        Me.cb_metodocifrado.Items.AddRange(New Object() {"Encadenamiento de bloques (i num aleatorios)", "Encadenamiento de bloquez (1 num aleatorio)"})
        Me.cb_metodocifrado.Location = New System.Drawing.Point(184, 55)
        Me.cb_metodocifrado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cb_metodocifrado.Name = "cb_metodocifrado"
        Me.cb_metodocifrado.Size = New System.Drawing.Size(180, 23)
        Me.cb_metodocifrado.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(23, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Texto en claro"
        '
        'txt_textoclaro
        '
        Me.txt_textoclaro.Location = New System.Drawing.Point(184, 90)
        Me.txt_textoclaro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_textoclaro.Name = "txt_textoclaro"
        Me.txt_textoclaro.Size = New System.Drawing.Size(180, 23)
        Me.txt_textoclaro.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(23, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Texto cifrado"
        '
        'txt_textocifrado
        '
        Me.txt_textocifrado.Location = New System.Drawing.Point(184, 122)
        Me.txt_textocifrado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_textocifrado.Name = "txt_textocifrado"
        Me.txt_textocifrado.Size = New System.Drawing.Size(180, 23)
        Me.txt_textocifrado.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(23, 151)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Texto descifrado"
        '
        'txt_textodescifrado
        '
        Me.txt_textodescifrado.Location = New System.Drawing.Point(184, 152)
        Me.txt_textodescifrado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_textodescifrado.Name = "txt_textodescifrado"
        Me.txt_textodescifrado.Size = New System.Drawing.Size(180, 23)
        Me.txt_textodescifrado.TabIndex = 8
        '
        'txt_k
        '
        Me.txt_k.Location = New System.Drawing.Point(496, 90)
        Me.txt_k.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_k.Name = "txt_k"
        Me.txt_k.Size = New System.Drawing.Size(56, 23)
        Me.txt_k.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(460, 90)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "k:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(528, 219)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 20)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Ver tabla"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(528, 273)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 20)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cifrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(528, 328)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 20)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Descifrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(528, 382)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(170, 20)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Limpiar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(23, 219)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Metodo:"
        '
        'lv_metodo
        '
        Me.lv_metodo.FormattingEnabled = True
        Me.lv_metodo.ItemHeight = 15
        Me.lv_metodo.Location = New System.Drawing.Point(100, 216)
        Me.lv_metodo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lv_metodo.Name = "lv_metodo"
        Me.lv_metodo.Size = New System.Drawing.Size(425, 199)
        Me.lv_metodo.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 433)
        Me.Controls.Add(Me.lv_metodo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_k)
        Me.Controls.Add(Me.txt_textodescifrado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_textocifrado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_textoclaro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_metodocifrado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "cifrados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_metodocifrado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_textoclaro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_textocifrado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_textodescifrado As TextBox
    Friend WithEvents txt_k As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lv_metodo As ListBox
End Class
