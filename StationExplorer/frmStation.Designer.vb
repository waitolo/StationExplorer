<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStation
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
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lvwStation = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(415, 354)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'lvwStation
        '
        Me.lvwStation.FullRowSelect = True
        Me.lvwStation.Location = New System.Drawing.Point(12, 12)
        Me.lvwStation.Name = "lvwStation"
        Me.lvwStation.Size = New System.Drawing.Size(478, 318)
        Me.lvwStation.TabIndex = 2
        Me.lvwStation.UseCompatibleStateImageBehavior = False
        Me.lvwStation.View = System.Windows.Forms.View.Details
        '
        'frmStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 391)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.lvwStation)
        Me.Name = "frmStation"
        Me.Text = "Station Explorer (First 100 stations)"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdClose As Button
    Friend WithEvents lvwStation As ListView
End Class
