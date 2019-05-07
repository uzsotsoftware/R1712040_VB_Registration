<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputRsultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquipmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LecturersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentsToolStripMenuItem, Me.EquipmentToolStripMenuItem, Me.LecturersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(586, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationToolStripMenuItem, Me.FeesToolStripMenuItem, Me.ResultsToolStripMenuItem})
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.StudentsToolStripMenuItem.Text = "Students"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RegistrationToolStripMenuItem.Text = "Registration"
        '
        'FeesToolStripMenuItem
        '
        Me.FeesToolStripMenuItem.Name = "FeesToolStripMenuItem"
        Me.FeesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FeesToolStripMenuItem.Text = "Fees"
        '
        'ResultsToolStripMenuItem
        '
        Me.ResultsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputRsultsToolStripMenuItem, Me.ViewResultsToolStripMenuItem})
        Me.ResultsToolStripMenuItem.Name = "ResultsToolStripMenuItem"
        Me.ResultsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ResultsToolStripMenuItem.Text = "Results"
        '
        'InputRsultsToolStripMenuItem
        '
        Me.InputRsultsToolStripMenuItem.Name = "InputRsultsToolStripMenuItem"
        Me.InputRsultsToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.InputRsultsToolStripMenuItem.Text = "Input Rsults"
        '
        'ViewResultsToolStripMenuItem
        '
        Me.ViewResultsToolStripMenuItem.Name = "ViewResultsToolStripMenuItem"
        Me.ViewResultsToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ViewResultsToolStripMenuItem.Text = "View Results"
        '
        'EquipmentToolStripMenuItem
        '
        Me.EquipmentToolStripMenuItem.Name = "EquipmentToolStripMenuItem"
        Me.EquipmentToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.EquipmentToolStripMenuItem.Text = "Equipment"
        '
        'LecturersToolStripMenuItem
        '
        Me.LecturersToolStripMenuItem.Name = "LecturersToolStripMenuItem"
        Me.LecturersToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.LecturersToolStripMenuItem.Text = "Lecturers"
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 346)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmmenu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputRsultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EquipmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LecturersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
