<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregistrationform
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lbldateofbirth = New System.Windows.Forms.Label()
        Me.lbllevel = New System.Windows.Forms.Label()
        Me.lblspecialization = New System.Windows.Forms.Label()
        Me.lblsports = New System.Windows.Forms.Label()
        Me.lblregistrationnumber = New System.Windows.Forms.Label()
        Me.txtregistrationnumber = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.DateTimePickerdateofbirth = New System.Windows.Forms.DateTimePicker()
        Me.CheckedListsport = New System.Windows.Forms.CheckedListBox()
        Me.ComboBoxspecialization = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLevel = New System.Windows.Forms.ComboBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Fill In The Deatils"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(54, 141)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(39, 13)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "Name"
        '
        'lbldateofbirth
        '
        Me.lbldateofbirth.AutoSize = True
        Me.lbldateofbirth.Location = New System.Drawing.Point(54, 184)
        Me.lbldateofbirth.Name = "lbldateofbirth"
        Me.lbldateofbirth.Size = New System.Drawing.Size(81, 13)
        Me.lbldateofbirth.TabIndex = 2
        Me.lbldateofbirth.Text = "Date Of Birth"
        '
        'lbllevel
        '
        Me.lbllevel.AutoSize = True
        Me.lbllevel.Location = New System.Drawing.Point(54, 241)
        Me.lbllevel.Name = "lbllevel"
        Me.lbllevel.Size = New System.Drawing.Size(38, 13)
        Me.lbllevel.TabIndex = 3
        Me.lbllevel.Text = "Level"
        '
        'lblspecialization
        '
        Me.lblspecialization.AutoSize = True
        Me.lblspecialization.Location = New System.Drawing.Point(54, 286)
        Me.lblspecialization.Name = "lblspecialization"
        Me.lblspecialization.Size = New System.Drawing.Size(86, 13)
        Me.lblspecialization.TabIndex = 4
        Me.lblspecialization.Text = "Specialization"
        '
        'lblsports
        '
        Me.lblsports.AutoSize = True
        Me.lblsports.Location = New System.Drawing.Point(54, 393)
        Me.lblsports.Name = "lblsports"
        Me.lblsports.Size = New System.Drawing.Size(43, 13)
        Me.lblsports.TabIndex = 5
        Me.lblsports.Text = "Sports"
        '
        'lblregistrationnumber
        '
        Me.lblregistrationnumber.AutoSize = True
        Me.lblregistrationnumber.Location = New System.Drawing.Point(54, 92)
        Me.lblregistrationnumber.Name = "lblregistrationnumber"
        Me.lblregistrationnumber.Size = New System.Drawing.Size(122, 13)
        Me.lblregistrationnumber.TabIndex = 6
        Me.lblregistrationnumber.Text = "Registration Number"
        '
        'txtregistrationnumber
        '
        Me.txtregistrationnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtregistrationnumber.Location = New System.Drawing.Point(378, 92)
        Me.txtregistrationnumber.Name = "txtregistrationnumber"
        Me.txtregistrationnumber.Size = New System.Drawing.Size(233, 20)
        Me.txtregistrationnumber.TabIndex = 7
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(378, 141)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(233, 20)
        Me.txtname.TabIndex = 8
        '
        'DateTimePickerdateofbirth
        '
        Me.DateTimePickerdateofbirth.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DateTimePickerdateofbirth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePickerdateofbirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerdateofbirth.Location = New System.Drawing.Point(378, 184)
        Me.DateTimePickerdateofbirth.Name = "DateTimePickerdateofbirth"
        Me.DateTimePickerdateofbirth.Size = New System.Drawing.Size(233, 20)
        Me.DateTimePickerdateofbirth.TabIndex = 9
        '
        'CheckedListsport
        '
        Me.CheckedListsport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListsport.FormattingEnabled = True
        Me.CheckedListsport.Items.AddRange(New Object() {"Football", "Tennis", "Rugby"})
        Me.CheckedListsport.Location = New System.Drawing.Point(378, 379)
        Me.CheckedListsport.Name = "CheckedListsport"
        Me.CheckedListsport.Size = New System.Drawing.Size(233, 49)
        Me.CheckedListsport.TabIndex = 10
        '
        'ComboBoxspecialization
        '
        Me.ComboBoxspecialization.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxspecialization.FormattingEnabled = True
        Me.ComboBoxspecialization.Items.AddRange(New Object() {"Software", "Network", "Hardware"})
        Me.ComboBoxspecialization.Location = New System.Drawing.Point(378, 298)
        Me.ComboBoxspecialization.Name = "ComboBoxspecialization"
        Me.ComboBoxspecialization.Size = New System.Drawing.Size(233, 21)
        Me.ComboBoxspecialization.TabIndex = 11
        '
        'ComboBoxLevel
        '
        Me.ComboBoxLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxLevel.FormattingEnabled = True
        Me.ComboBoxLevel.Items.AddRange(New Object() {"Certificate", "Diploma", "Degree"})
        Me.ComboBoxLevel.Location = New System.Drawing.Point(378, 241)
        Me.ComboBoxLevel.Name = "ComboBoxLevel"
        Me.ComboBoxLevel.Size = New System.Drawing.Size(233, 21)
        Me.ComboBoxLevel.TabIndex = 12
        '
        'btnsave
        '
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnsave.Location = New System.Drawing.Point(85, 483)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(87, 23)
        Me.btnsave.TabIndex = 13
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(310, 483)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(87, 23)
        Me.btnclose.TabIndex = 14
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'frmregistrationform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 537)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.ComboBoxLevel)
        Me.Controls.Add(Me.ComboBoxspecialization)
        Me.Controls.Add(Me.CheckedListsport)
        Me.Controls.Add(Me.DateTimePickerdateofbirth)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtregistrationnumber)
        Me.Controls.Add(Me.lblregistrationnumber)
        Me.Controls.Add(Me.lblsports)
        Me.Controls.Add(Me.lblspecialization)
        Me.Controls.Add(Me.lbllevel)
        Me.Controls.Add(Me.lbldateofbirth)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmregistrationform"
        Me.Text = "Registration Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lbldateofbirth As System.Windows.Forms.Label
    Friend WithEvents lbllevel As System.Windows.Forms.Label
    Friend WithEvents lblspecialization As System.Windows.Forms.Label
    Friend WithEvents lblsports As System.Windows.Forms.Label
    Friend WithEvents lblregistrationnumber As System.Windows.Forms.Label
    Friend WithEvents txtregistrationnumber As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerdateofbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckedListsport As System.Windows.Forms.CheckedListBox
    Friend WithEvents ComboBoxspecialization As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxLevel As System.Windows.Forms.ComboBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
End Class
