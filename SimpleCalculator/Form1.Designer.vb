<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorForm
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
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.OneButton = New System.Windows.Forms.Button()
        Me.TwoButton = New System.Windows.Forms.Button()
        Me.ThreeButton = New System.Windows.Forms.Button()
        Me.FourButton = New System.Windows.Forms.Button()
        Me.FiveButton = New System.Windows.Forms.Button()
        Me.SixButton = New System.Windows.Forms.Button()
        Me.SevenButton = New System.Windows.Forms.Button()
        Me.EightButton = New System.Windows.Forms.Button()
        Me.NineButton = New System.Windows.Forms.Button()
        Me.ZeroButton = New System.Windows.Forms.Button()
        Me.EnterButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.AdditionButton = New System.Windows.Forms.Button()
        Me.MultiplicationButton = New System.Windows.Forms.Button()
        Me.SubtractButton = New System.Windows.Forms.Button()
        Me.DivisionButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ExponentButton = New System.Windows.Forms.Button()
        Me.OutputListBox = New System.Windows.Forms.ListBox()
        Me.NegativeButton = New System.Windows.Forms.Button()
        Me.DecimalButton = New System.Windows.Forms.Button()
        Me.KeypadGroupBox = New System.Windows.Forms.GroupBox()
        Me.MathOperatorsGroupBox = New System.Windows.Forms.GroupBox()
        Me.KeypadGroupBox.SuspendLayout()
        Me.MathOperatorsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputTextBox
        '
        Me.InputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputTextBox.Location = New System.Drawing.Point(9, 12)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.ReadOnly = True
        Me.InputTextBox.Size = New System.Drawing.Size(370, 32)
        Me.InputTextBox.TabIndex = 0
        '
        'OneButton
        '
        Me.OneButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OneButton.Location = New System.Drawing.Point(0, 0)
        Me.OneButton.Name = "OneButton"
        Me.OneButton.Size = New System.Drawing.Size(88, 58)
        Me.OneButton.TabIndex = 1
        Me.OneButton.Text = "&1"
        Me.OneButton.UseVisualStyleBackColor = True
        '
        'TwoButton
        '
        Me.TwoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TwoButton.Location = New System.Drawing.Point(94, 0)
        Me.TwoButton.Name = "TwoButton"
        Me.TwoButton.Size = New System.Drawing.Size(88, 58)
        Me.TwoButton.TabIndex = 2
        Me.TwoButton.Text = "&2"
        Me.TwoButton.UseVisualStyleBackColor = True
        '
        'ThreeButton
        '
        Me.ThreeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThreeButton.Location = New System.Drawing.Point(188, 0)
        Me.ThreeButton.Name = "ThreeButton"
        Me.ThreeButton.Size = New System.Drawing.Size(88, 58)
        Me.ThreeButton.TabIndex = 3
        Me.ThreeButton.Text = "&3"
        Me.ThreeButton.UseVisualStyleBackColor = True
        '
        'FourButton
        '
        Me.FourButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FourButton.Location = New System.Drawing.Point(0, 61)
        Me.FourButton.Name = "FourButton"
        Me.FourButton.Size = New System.Drawing.Size(88, 58)
        Me.FourButton.TabIndex = 4
        Me.FourButton.Text = "&4"
        Me.FourButton.UseVisualStyleBackColor = True
        '
        'FiveButton
        '
        Me.FiveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiveButton.Location = New System.Drawing.Point(94, 61)
        Me.FiveButton.Name = "FiveButton"
        Me.FiveButton.Size = New System.Drawing.Size(88, 58)
        Me.FiveButton.TabIndex = 5
        Me.FiveButton.Text = "&5"
        Me.FiveButton.UseVisualStyleBackColor = True
        '
        'SixButton
        '
        Me.SixButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SixButton.Location = New System.Drawing.Point(188, 61)
        Me.SixButton.Name = "SixButton"
        Me.SixButton.Size = New System.Drawing.Size(88, 58)
        Me.SixButton.TabIndex = 6
        Me.SixButton.Text = "&6"
        Me.SixButton.UseVisualStyleBackColor = True
        '
        'SevenButton
        '
        Me.SevenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SevenButton.Location = New System.Drawing.Point(0, 122)
        Me.SevenButton.Name = "SevenButton"
        Me.SevenButton.Size = New System.Drawing.Size(88, 58)
        Me.SevenButton.TabIndex = 7
        Me.SevenButton.Text = "&7"
        Me.SevenButton.UseVisualStyleBackColor = True
        '
        'EightButton
        '
        Me.EightButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EightButton.Location = New System.Drawing.Point(94, 122)
        Me.EightButton.Name = "EightButton"
        Me.EightButton.Size = New System.Drawing.Size(88, 58)
        Me.EightButton.TabIndex = 8
        Me.EightButton.Text = "&8"
        Me.EightButton.UseVisualStyleBackColor = True
        '
        'NineButton
        '
        Me.NineButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NineButton.Location = New System.Drawing.Point(188, 122)
        Me.NineButton.Name = "NineButton"
        Me.NineButton.Size = New System.Drawing.Size(88, 58)
        Me.NineButton.TabIndex = 9
        Me.NineButton.Text = "&9"
        Me.NineButton.UseVisualStyleBackColor = True
        '
        'ZeroButton
        '
        Me.ZeroButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZeroButton.Location = New System.Drawing.Point(94, 183)
        Me.ZeroButton.Name = "ZeroButton"
        Me.ZeroButton.Size = New System.Drawing.Size(88, 58)
        Me.ZeroButton.TabIndex = 10
        Me.ZeroButton.Text = "&0"
        Me.ZeroButton.UseVisualStyleBackColor = True
        '
        'EnterButton
        '
        Me.EnterButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterButton.Location = New System.Drawing.Point(197, 298)
        Me.EnterButton.Name = "EnterButton"
        Me.EnterButton.Size = New System.Drawing.Size(88, 58)
        Me.EnterButton.TabIndex = 11
        Me.EnterButton.Text = "&Enter"
        Me.EnterButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(103, 298)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(88, 58)
        Me.ClearButton.TabIndex = 12
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'AdditionButton
        '
        Me.AdditionButton.Enabled = False
        Me.AdditionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdditionButton.Location = New System.Drawing.Point(0, 0)
        Me.AdditionButton.Name = "AdditionButton"
        Me.AdditionButton.Size = New System.Drawing.Size(88, 58)
        Me.AdditionButton.TabIndex = 15
        Me.AdditionButton.Text = "+"
        Me.AdditionButton.UseVisualStyleBackColor = True
        '
        'MultiplicationButton
        '
        Me.MultiplicationButton.Enabled = False
        Me.MultiplicationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiplicationButton.Location = New System.Drawing.Point(0, 122)
        Me.MultiplicationButton.Name = "MultiplicationButton"
        Me.MultiplicationButton.Size = New System.Drawing.Size(88, 58)
        Me.MultiplicationButton.TabIndex = 14
        Me.MultiplicationButton.Text = "&*"
        Me.MultiplicationButton.UseVisualStyleBackColor = True
        '
        'SubtractButton
        '
        Me.SubtractButton.Enabled = False
        Me.SubtractButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubtractButton.Location = New System.Drawing.Point(0, 61)
        Me.SubtractButton.Name = "SubtractButton"
        Me.SubtractButton.Size = New System.Drawing.Size(88, 58)
        Me.SubtractButton.TabIndex = 13
        Me.SubtractButton.Text = "&-"
        Me.SubtractButton.UseVisualStyleBackColor = True
        '
        'DivisionButton
        '
        Me.DivisionButton.Enabled = False
        Me.DivisionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivisionButton.Location = New System.Drawing.Point(0, 183)
        Me.DivisionButton.Name = "DivisionButton"
        Me.DivisionButton.Size = New System.Drawing.Size(88, 58)
        Me.DivisionButton.TabIndex = 18
        Me.DivisionButton.Text = "&/"
        Me.DivisionButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(9, 298)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(88, 58)
        Me.ExitButton.TabIndex = 17
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ExponentButton
        '
        Me.ExponentButton.Enabled = False
        Me.ExponentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExponentButton.Location = New System.Drawing.Point(0, 244)
        Me.ExponentButton.Name = "ExponentButton"
        Me.ExponentButton.Size = New System.Drawing.Size(88, 58)
        Me.ExponentButton.TabIndex = 16
        Me.ExponentButton.Text = "&^"
        Me.ExponentButton.UseVisualStyleBackColor = True
        '
        'OutputListBox
        '
        Me.OutputListBox.FormattingEnabled = True
        Me.OutputListBox.Location = New System.Drawing.Point(388, 12)
        Me.OutputListBox.Name = "OutputListBox"
        Me.OutputListBox.Size = New System.Drawing.Size(196, 342)
        Me.OutputListBox.TabIndex = 19
        '
        'NegativeButton
        '
        Me.NegativeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NegativeButton.Location = New System.Drawing.Point(0, 183)
        Me.NegativeButton.Name = "NegativeButton"
        Me.NegativeButton.Size = New System.Drawing.Size(88, 58)
        Me.NegativeButton.TabIndex = 20
        Me.NegativeButton.Text = "+/-"
        Me.NegativeButton.UseVisualStyleBackColor = True
        '
        'DecimalButton
        '
        Me.DecimalButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecimalButton.Location = New System.Drawing.Point(188, 183)
        Me.DecimalButton.Name = "DecimalButton"
        Me.DecimalButton.Size = New System.Drawing.Size(88, 58)
        Me.DecimalButton.TabIndex = 21
        Me.DecimalButton.Text = "&."
        Me.DecimalButton.UseVisualStyleBackColor = True
        '
        'KeypadGroupBox
        '
        Me.KeypadGroupBox.Controls.Add(Me.ThreeButton)
        Me.KeypadGroupBox.Controls.Add(Me.OneButton)
        Me.KeypadGroupBox.Controls.Add(Me.DecimalButton)
        Me.KeypadGroupBox.Controls.Add(Me.TwoButton)
        Me.KeypadGroupBox.Controls.Add(Me.NegativeButton)
        Me.KeypadGroupBox.Controls.Add(Me.FourButton)
        Me.KeypadGroupBox.Controls.Add(Me.FiveButton)
        Me.KeypadGroupBox.Controls.Add(Me.SixButton)
        Me.KeypadGroupBox.Controls.Add(Me.SevenButton)
        Me.KeypadGroupBox.Controls.Add(Me.EightButton)
        Me.KeypadGroupBox.Controls.Add(Me.NineButton)
        Me.KeypadGroupBox.Controls.Add(Me.ZeroButton)
        Me.KeypadGroupBox.Location = New System.Drawing.Point(9, 54)
        Me.KeypadGroupBox.Name = "KeypadGroupBox"
        Me.KeypadGroupBox.Size = New System.Drawing.Size(279, 243)
        Me.KeypadGroupBox.TabIndex = 22
        Me.KeypadGroupBox.TabStop = False
        '
        'MathOperatorsGroupBox
        '
        Me.MathOperatorsGroupBox.Controls.Add(Me.AdditionButton)
        Me.MathOperatorsGroupBox.Controls.Add(Me.SubtractButton)
        Me.MathOperatorsGroupBox.Controls.Add(Me.MultiplicationButton)
        Me.MathOperatorsGroupBox.Controls.Add(Me.DivisionButton)
        Me.MathOperatorsGroupBox.Controls.Add(Me.ExponentButton)
        Me.MathOperatorsGroupBox.Location = New System.Drawing.Point(291, 54)
        Me.MathOperatorsGroupBox.Name = "MathOperatorsGroupBox"
        Me.MathOperatorsGroupBox.Size = New System.Drawing.Size(91, 305)
        Me.MathOperatorsGroupBox.TabIndex = 23
        Me.MathOperatorsGroupBox.TabStop = False
        '
        'CalculatorForm
        '
        Me.AcceptButton = Me.EnterButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(592, 365)
        Me.Controls.Add(Me.MathOperatorsGroupBox)
        Me.Controls.Add(Me.KeypadGroupBox)
        Me.Controls.Add(Me.OutputListBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.EnterButton)
        Me.Controls.Add(Me.InputTextBox)
        Me.Name = "CalculatorForm"
        Me.Text = "Calculator"
        Me.KeypadGroupBox.ResumeLayout(False)
        Me.MathOperatorsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InputTextBox As TextBox
    Friend WithEvents OneButton As Button
    Friend WithEvents TwoButton As Button
    Friend WithEvents ThreeButton As Button
    Friend WithEvents FourButton As Button
    Friend WithEvents FiveButton As Button
    Friend WithEvents SixButton As Button
    Friend WithEvents SevenButton As Button
    Friend WithEvents EightButton As Button
    Friend WithEvents NineButton As Button
    Friend WithEvents ZeroButton As Button
    Friend WithEvents EnterButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents AdditionButton As Button
    Friend WithEvents MultiplicationButton As Button
    Friend WithEvents SubtractButton As Button
    Friend WithEvents DivisionButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ExponentButton As Button
    Friend WithEvents OutputListBox As ListBox
    Friend WithEvents NegativeButton As Button
    Friend WithEvents DecimalButton As Button
    Friend WithEvents KeypadGroupBox As GroupBox
    Friend WithEvents MathOperatorsGroupBox As GroupBox
End Class
