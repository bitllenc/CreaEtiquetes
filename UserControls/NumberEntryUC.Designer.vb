<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NumberEntryUC
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.lbl_Unit = New System.Windows.Forms.Label()
        Me.txt_Val = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_ID
        '
        Me.lbl_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ID.Location = New System.Drawing.Point(3, 6)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(73, 16)
        Me.lbl_ID.TabIndex = 0
        Me.lbl_ID.Text = "ID"
        Me.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Unit
        '
        Me.lbl_Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Unit.Location = New System.Drawing.Point(169, 6)
        Me.lbl_Unit.Name = "lbl_Unit"
        Me.lbl_Unit.Size = New System.Drawing.Size(34, 16)
        Me.lbl_Unit.TabIndex = 1
        Me.lbl_Unit.Text = "unit"
        Me.lbl_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Val
        '
        Me.txt_Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Val.Location = New System.Drawing.Point(82, 3)
        Me.txt_Val.Name = "txt_Val"
        Me.txt_Val.Size = New System.Drawing.Size(81, 22)
        Me.txt_Val.TabIndex = 0
        Me.txt_Val.Text = "00.0"
        Me.txt_Val.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumberEntryUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txt_Val)
        Me.Controls.Add(Me.lbl_Unit)
        Me.Controls.Add(Me.lbl_ID)
        Me.Name = "NumberEntryUC"
        Me.Size = New System.Drawing.Size(206, 36)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_ID As Label
    Friend WithEvents lbl_Unit As Label
    Friend WithEvents txt_Val As TextBox
End Class
