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
        Me.Convert_String_Input = New System.Windows.Forms.TextBox()
        Me.Convert_ASCII_Input = New System.Windows.Forms.TextBox()
        Me.Convert = New System.Windows.Forms.Button()
        Me.Deconvert = New System.Windows.Forms.Button()
        Me.Deconvert_String_input = New System.Windows.Forms.TextBox()
        Me.Deconvert_ASCII_input = New System.Windows.Forms.TextBox()
        Me.Current_Date = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Convert_String_Input
        '
        Me.Convert_String_Input.Location = New System.Drawing.Point(112, 28)
        Me.Convert_String_Input.Name = "Convert_String_Input"
        Me.Convert_String_Input.Size = New System.Drawing.Size(170, 20)
        Me.Convert_String_Input.TabIndex = 0
        '
        'Convert_ASCII_Input
        '
        Me.Convert_ASCII_Input.Location = New System.Drawing.Point(112, 63)
        Me.Convert_ASCII_Input.Name = "Convert_ASCII_Input"
        Me.Convert_ASCII_Input.Size = New System.Drawing.Size(170, 20)
        Me.Convert_ASCII_Input.TabIndex = 1
        '
        'Convert
        '
        Me.Convert.Location = New System.Drawing.Point(12, 47)
        Me.Convert.Name = "Convert"
        Me.Convert.Size = New System.Drawing.Size(75, 23)
        Me.Convert.TabIndex = 2
        Me.Convert.Text = "Convert"
        Me.Convert.UseVisualStyleBackColor = True
        '
        'Deconvert
        '
        Me.Deconvert.Location = New System.Drawing.Point(12, 151)
        Me.Deconvert.Name = "Deconvert"
        Me.Deconvert.Size = New System.Drawing.Size(75, 23)
        Me.Deconvert.TabIndex = 5
        Me.Deconvert.Text = "Deconvert"
        Me.Deconvert.UseVisualStyleBackColor = True
        '
        'Deconvert_String_input
        '
        Me.Deconvert_String_input.Location = New System.Drawing.Point(112, 167)
        Me.Deconvert_String_input.Name = "Deconvert_String_input"
        Me.Deconvert_String_input.Size = New System.Drawing.Size(170, 20)
        Me.Deconvert_String_input.TabIndex = 4
        '
        'Deconvert_ASCII_input
        '
        Me.Deconvert_ASCII_input.Location = New System.Drawing.Point(112, 132)
        Me.Deconvert_ASCII_input.Name = "Deconvert_ASCII_input"
        Me.Deconvert_ASCII_input.Size = New System.Drawing.Size(170, 20)
        Me.Deconvert_ASCII_input.TabIndex = 3
        '
        'Current_Date
        '
        Me.Current_Date.AutoSize = True
        Me.Current_Date.Location = New System.Drawing.Point(109, 280)
        Me.Current_Date.Name = "Current_Date"
        Me.Current_Date.Size = New System.Drawing.Size(39, 13)
        Me.Current_Date.TabIndex = 6
        Me.Current_Date.Text = "Label1"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(242, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "By Oussama"
        Me.Label1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 322)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Current_Date)
        Me.Controls.Add(Me.Deconvert)
        Me.Controls.Add(Me.Deconvert_String_input)
        Me.Controls.Add(Me.Deconvert_ASCII_input)
        Me.Controls.Add(Me.Convert)
        Me.Controls.Add(Me.Convert_ASCII_Input)
        Me.Controls.Add(Me.Convert_String_Input)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Convert_String_Input As System.Windows.Forms.TextBox
    Friend WithEvents Convert_ASCII_Input As System.Windows.Forms.TextBox
    Friend WithEvents Convert As System.Windows.Forms.Button
    Friend WithEvents Deconvert As System.Windows.Forms.Button
    Friend WithEvents Deconvert_String_input As System.Windows.Forms.TextBox
    Friend WithEvents Deconvert_ASCII_input As System.Windows.Forms.TextBox
    Friend WithEvents Current_Date As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
