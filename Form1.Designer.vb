<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TB_Name = New System.Windows.Forms.TextBox()
        Me.TB_Pass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(602, 73)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Log in"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TB_Name
        '
        Me.TB_Name.Location = New System.Drawing.Point(12, 12)
        Me.TB_Name.Name = "TB_Name"
        Me.TB_Name.Size = New System.Drawing.Size(205, 20)
        Me.TB_Name.TabIndex = 1
        '
        'TB_Pass
        '
        Me.TB_Pass.Location = New System.Drawing.Point(409, 12)
        Me.TB_Pass.Name = "TB_Pass"
        Me.TB_Pass.Size = New System.Drawing.Size(205, 20)
        Me.TB_Pass.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 132)
        Me.Controls.Add(Me.TB_Pass)
        Me.Controls.Add(Me.TB_Name)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TB_Name As TextBox
    Friend WithEvents TB_Pass As TextBox
End Class
