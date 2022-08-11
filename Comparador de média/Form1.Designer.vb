<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.Lingua = New System.Windows.Forms.Label()
        Me.Human = New System.Windows.Forms.Label()
        Me.Natureza = New System.Windows.Forms.Label()
        Me.Mat = New System.Windows.Forms.Label()
        Me.Redacao = New System.Windows.Forms.Label()
        Me.Result1 = New System.Windows.Forms.TextBox()
        Me.Result2 = New System.Windows.Forms.TextBox()
        Me.Result3 = New System.Windows.Forms.TextBox()
        Me.Result4 = New System.Windows.Forms.TextBox()
        Me.Result5 = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Titulo.Location = New System.Drawing.Point(108, 23)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(217, 32)
        Me.Titulo.TabIndex = 0
        Me.Titulo.Text = "Média do Enem"
        '
        'Lingua
        '
        Me.Lingua.AutoSize = True
        Me.Lingua.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lingua.Location = New System.Drawing.Point(12, 102)
        Me.Lingua.Name = "Lingua"
        Me.Lingua.Size = New System.Drawing.Size(284, 19)
        Me.Lingua.TabIndex = 1
        Me.Lingua.Text = "Linguagens, Códigos e suas Tecnologias"
        '
        'Human
        '
        Me.Human.AutoSize = True
        Me.Human.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Human.Location = New System.Drawing.Point(12, 149)
        Me.Human.Name = "Human"
        Me.Human.Size = New System.Drawing.Size(268, 19)
        Me.Human.TabIndex = 2
        Me.Human.Text = "Ciências Humanas e suas Tecnologias"
        '
        'Natureza
        '
        Me.Natureza.AutoSize = True
        Me.Natureza.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Natureza.Location = New System.Drawing.Point(13, 192)
        Me.Natureza.Name = "Natureza"
        Me.Natureza.Size = New System.Drawing.Size(288, 19)
        Me.Natureza.TabIndex = 3
        Me.Natureza.Text = "Ciências da Natureza e suas Tecnologias"
        '
        'Mat
        '
        Me.Mat.AutoSize = True
        Me.Mat.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mat.Location = New System.Drawing.Point(13, 232)
        Me.Mat.Name = "Mat"
        Me.Mat.Size = New System.Drawing.Size(223, 19)
        Me.Mat.TabIndex = 4
        Me.Mat.Text = "Matemática e suas Tecnologias"
        '
        'Redacao
        '
        Me.Redacao.AutoSize = True
        Me.Redacao.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Redacao.Location = New System.Drawing.Point(22, 272)
        Me.Redacao.Name = "Redacao"
        Me.Redacao.Size = New System.Drawing.Size(67, 19)
        Me.Redacao.TabIndex = 5
        Me.Redacao.Text = "Redação"
        '
        'Result1
        '
        Me.Result1.Location = New System.Drawing.Point(307, 98)
        Me.Result1.MaxLength = 6
        Me.Result1.Name = "Result1"
        Me.Result1.Size = New System.Drawing.Size(100, 23)
        Me.Result1.TabIndex = 6
        '
        'Result2
        '
        Me.Result2.Location = New System.Drawing.Point(307, 145)
        Me.Result2.MaxLength = 6
        Me.Result2.Name = "Result2"
        Me.Result2.Size = New System.Drawing.Size(100, 23)
        Me.Result2.TabIndex = 7
        '
        'Result3
        '
        Me.Result3.Location = New System.Drawing.Point(307, 188)
        Me.Result3.MaxLength = 6
        Me.Result3.Name = "Result3"
        Me.Result3.Size = New System.Drawing.Size(100, 23)
        Me.Result3.TabIndex = 8
        '
        'Result4
        '
        Me.Result4.Location = New System.Drawing.Point(307, 228)
        Me.Result4.MaxLength = 6
        Me.Result4.Name = "Result4"
        Me.Result4.Size = New System.Drawing.Size(100, 23)
        Me.Result4.TabIndex = 9
        '
        'Result5
        '
        Me.Result5.Location = New System.Drawing.Point(307, 268)
        Me.Result5.MaxLength = 6
        Me.Result5.Name = "Result5"
        Me.Result5.Size = New System.Drawing.Size(100, 23)
        Me.Result5.TabIndex = 10
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(307, 310)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(100, 23)
        Me.Calcular.TabIndex = 11
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 345)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Result5)
        Me.Controls.Add(Me.Result4)
        Me.Controls.Add(Me.Result3)
        Me.Controls.Add(Me.Result2)
        Me.Controls.Add(Me.Result1)
        Me.Controls.Add(Me.Redacao)
        Me.Controls.Add(Me.Mat)
        Me.Controls.Add(Me.Natureza)
        Me.Controls.Add(Me.Human)
        Me.Controls.Add(Me.Lingua)
        Me.Controls.Add(Me.Titulo)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Média do Enem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulo As Label
    Friend WithEvents Lingua As Label
    Friend WithEvents Human As Label
    Friend WithEvents Natureza As Label
    Friend WithEvents Mat As Label
    Friend WithEvents Redacao As Label
    Friend WithEvents Result1 As TextBox
    Friend WithEvents Result2 As TextBox
    Friend WithEvents Result3 As TextBox
    Friend WithEvents Result4 As TextBox
    Friend WithEvents Result5 As TextBox
    Friend WithEvents Calcular As Button
End Class
