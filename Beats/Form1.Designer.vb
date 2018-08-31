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
        Me.components = New System.ComponentModel.Container()
        Me.command1 = New System.Windows.Forms.Button()
        Me.command2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Memoria = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'command1
        '
        Me.command1.Location = New System.Drawing.Point(22, 79)
        Me.command1.Name = "command1"
        Me.command1.Size = New System.Drawing.Size(75, 23)
        Me.command1.TabIndex = 0
        Me.command1.Text = "Obtener"
        Me.command1.UseVisualStyleBackColor = True
        '
        'command2
        '
        Me.command2.Location = New System.Drawing.Point(22, 108)
        Me.command2.Name = "command2"
        Me.command2.Size = New System.Drawing.Size(75, 23)
        Me.command2.TabIndex = 1
        Me.command2.Text = "Detener"
        Me.command2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Memoria
        '
        Me.Memoria.AutoSize = True
        Me.Memoria.Location = New System.Drawing.Point(36, 31)
        Me.Memoria.Name = "Memoria"
        Me.Memoria.Size = New System.Drawing.Size(0, 13)
        Me.Memoria.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Memoria)
        Me.Controls.Add(Me.command2)
        Me.Controls.Add(Me.command1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents command1 As Button
    Friend WithEvents command2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Memoria As Label
End Class
