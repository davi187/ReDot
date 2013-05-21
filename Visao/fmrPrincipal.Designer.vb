<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrPrincipal
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(33, 16)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cadastro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.DarkRed
        Me.Button2.Location = New System.Drawing.Point(33, 52)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 28)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Vendas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.DarkRed
        Me.Button3.Location = New System.Drawing.Point(33, 87)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 28)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Compras"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.DarkRed
        Me.Button4.Location = New System.Drawing.Point(33, 123)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 28)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Nota Fiscal"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(33, 159)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 28)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Relatórios"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(33, 194)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(87, 28)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Ajuda"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(33, 230)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(87, 28)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Sair"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'fmrPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 762)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.DarkRed
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "fmrPrincipal"
        Me.Text = "RedDot Tecnologia"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
