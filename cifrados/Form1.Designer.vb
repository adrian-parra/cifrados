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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(328, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cifrados simetricos y asimetricos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(33, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Metodo de cifrado"
        '
        'cb_metodocifrado
        '
        Me.cb_metodocifrado.FormattingEnabled = True
        Me.cb_metodocifrado.Items.AddRange(New Object() {"Encadenamiento de bloques (i num aleatorios)", "Encadenamiento de bloquez (1 num aleatorio)"})
        Me.cb_metodocifrado.Location = New System.Drawing.Point(263, 92)
        Me.cb_metodocifrado.Name = "cb_metodocifrado"
        Me.cb_metodocifrado.Size = New System.Drawing.Size(256, 33)
        Me.cb_metodocifrado.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(33, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Texto en claro"
        '
        'txt_textoclaro
        '
        Me.txt_textoclaro.Location = New System.Drawing.Point(263, 150)
        Me.txt_textoclaro.Name = "txt_textoclaro"
        Me.txt_textoclaro.Size = New System.Drawing.Size(256, 31)
        Me.txt_textoclaro.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(33, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Texto cifrado"
        '
        'txt_textocifrado
        '
        Me.txt_textocifrado.Location = New System.Drawing.Point(263, 204)
        Me.txt_textocifrado.Name = "txt_textocifrado"
        Me.txt_textocifrado.Size = New System.Drawing.Size(256, 31)
        Me.txt_textocifrado.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(33, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 32)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Texto descifrado"
        '
        'txt_textodescifrado
        '
        Me.txt_textodescifrado.Location = New System.Drawing.Point(263, 254)
        Me.txt_textodescifrado.Name = "txt_textodescifrado"
        Me.txt_textodescifrado.Size = New System.Drawing.Size(256, 31)
        Me.txt_textodescifrado.TabIndex = 8
        '
        'txt_k
        '
        Me.txt_k.Location = New System.Drawing.Point(709, 150)
        Me.txt_k.Name = "txt_k"
        Me.txt_k.Size = New System.Drawing.Size(78, 31)
        Me.txt_k.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(657, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 32)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "k:"
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(143, 365)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(555, 305)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(754, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(243, 34)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Ver tabla"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(754, 455)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(243, 34)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cifrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(754, 546)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(243, 34)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Descifrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(754, 636)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(243, 34)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Limpiar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(33, 365)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 32)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Metodo:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 721)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
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
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label7 As Label
End Class
