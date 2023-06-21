<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Portal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Portal))
        Me.btnEmp = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPayroll = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEmp
        '
        Me.btnEmp.AutoRoundedCorners = True
        Me.btnEmp.BackColor = System.Drawing.Color.Transparent
        Me.btnEmp.BorderRadius = 22
        Me.btnEmp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEmp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEmp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEmp.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnEmp.FillColor2 = System.Drawing.Color.DeepSkyBlue
        Me.btnEmp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEmp.ForeColor = System.Drawing.Color.White
        Me.btnEmp.Location = New System.Drawing.Point(134, 232)
        Me.btnEmp.Name = "btnEmp"
        Me.btnEmp.Size = New System.Drawing.Size(237, 46)
        Me.btnEmp.TabIndex = 0
        Me.btnEmp.Text = "EMPLOYEES"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(165, 61)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(169, 165)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 2
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox2.Image = CType(resources.GetObject("Guna2CirclePictureBox2.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(165, 306)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(169, 165)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox2.TabIndex = 3
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(91, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 34)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Welcome To Safe Payroll"
        '
        'btnPayroll
        '
        Me.btnPayroll.AutoRoundedCorners = True
        Me.btnPayroll.BackColor = System.Drawing.Color.Transparent
        Me.btnPayroll.BorderRadius = 22
        Me.btnPayroll.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPayroll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPayroll.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPayroll.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPayroll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPayroll.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnPayroll.FillColor2 = System.Drawing.Color.DeepSkyBlue
        Me.btnPayroll.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPayroll.ForeColor = System.Drawing.Color.White
        Me.btnPayroll.Location = New System.Drawing.Point(134, 477)
        Me.btnPayroll.Name = "btnPayroll"
        Me.btnPayroll.Size = New System.Drawing.Size(237, 46)
        Me.btnPayroll.TabIndex = 16
        Me.btnPayroll.Text = "PAYROLL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(271, 561)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "TRUSTED PAYROLL SYSTEM Ver 0.1"
        '
        'Portal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.BackgroundImage = Global.Prototype_System.My.Resources.Resources.R__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(513, 585)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnPayroll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.btnEmp)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Portal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEmp As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPayroll As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label3 As Label
End Class
