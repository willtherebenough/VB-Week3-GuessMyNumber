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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GuessTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckMyGuessButton = New System.Windows.Forms.Button()
        Me.NewGameButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Your guess:"
        '
        'GuessTextBox
        '
        Me.GuessTextBox.Location = New System.Drawing.Point(195, 80)
        Me.GuessTextBox.Name = "GuessTextBox"
        Me.GuessTextBox.Size = New System.Drawing.Size(34, 20)
        Me.GuessTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 60)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "I'm Thinking of a number between 1 and 10. Enter your guess and click on the Chec" &
    "k My Guess button"
        '
        'CheckMyGuessButton
        '
        Me.CheckMyGuessButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckMyGuessButton.Location = New System.Drawing.Point(45, 131)
        Me.CheckMyGuessButton.Name = "CheckMyGuessButton"
        Me.CheckMyGuessButton.Size = New System.Drawing.Size(102, 23)
        Me.CheckMyGuessButton.TabIndex = 4
        Me.CheckMyGuessButton.Text = "Check My Guess"
        Me.CheckMyGuessButton.UseVisualStyleBackColor = True
        '
        'NewGameButton
        '
        Me.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewGameButton.Location = New System.Drawing.Point(154, 131)
        Me.NewGameButton.Name = "NewGameButton"
        Me.NewGameButton.Size = New System.Drawing.Size(111, 23)
        Me.NewGameButton.TabIndex = 5
        Me.NewGameButton.Text = "Start a New Game"
        Me.NewGameButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ExitButton.Location = New System.Drawing.Point(271, 131)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(384, 162)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.NewGameButton)
        Me.Controls.Add(Me.CheckMyGuessButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GuessTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Guess My Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GuessTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckMyGuessButton As Button
    Friend WithEvents NewGameButton As Button
    Friend WithEvents ExitButton As Button
End Class
