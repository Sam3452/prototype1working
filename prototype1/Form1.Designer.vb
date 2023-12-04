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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1menuhide = New System.Windows.Forms.Timer(Me.components)
        Me.menupanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.picbuttonhome = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.picbuttonmenu = New System.Windows.Forms.PictureBox()
        Me.Timer2menushow = New System.Windows.Forms.Timer(Me.components)
        Me.menupanel.SuspendLayout()
        CType(Me.picbuttonhome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbuttonmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1menuhide
        '
        Me.Timer1menuhide.Interval = 1
        '
        'menupanel
        '
        Me.menupanel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.menupanel.Controls.Add(Me.picbuttonhome)
        Me.menupanel.Controls.Add(Me.PictureBox2)
        Me.menupanel.Controls.Add(Me.PictureBox3)
        Me.menupanel.Controls.Add(Me.PictureBox4)
        Me.menupanel.Controls.Add(Me.PictureBox5)
        Me.menupanel.Location = New System.Drawing.Point(1, 0)
        Me.menupanel.Name = "menupanel"
        Me.menupanel.Size = New System.Drawing.Size(126, 557)
        Me.menupanel.TabIndex = 1
        '
        'picbuttonhome
        '
        Me.picbuttonhome.Image = CType(resources.GetObject("picbuttonhome.Image"), System.Drawing.Image)
        Me.picbuttonhome.Location = New System.Drawing.Point(3, 3)
        Me.picbuttonhome.Name = "picbuttonhome"
        Me.picbuttonhome.Size = New System.Drawing.Size(112, 103)
        Me.picbuttonhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbuttonhome.TabIndex = 0
        Me.picbuttonhome.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(3, 112)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(123, 103)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(3, 221)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(123, 103)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(3, 330)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(123, 103)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(3, 439)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(123, 103)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'picbuttonmenu
        '
        Me.picbuttonmenu.Image = CType(resources.GetObject("picbuttonmenu.Image"), System.Drawing.Image)
        Me.picbuttonmenu.Location = New System.Drawing.Point(128, 0)
        Me.picbuttonmenu.Name = "picbuttonmenu"
        Me.picbuttonmenu.Size = New System.Drawing.Size(64, 59)
        Me.picbuttonmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbuttonmenu.TabIndex = 2
        Me.picbuttonmenu.TabStop = False
        '
        'Timer2menushow
        '
        Me.Timer2menushow.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 553)
        Me.Controls.Add(Me.picbuttonmenu)
        Me.Controls.Add(Me.menupanel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.menupanel.ResumeLayout(False)
        CType(Me.picbuttonhome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbuttonmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1menuhide As Timer
    Friend WithEvents menupanel As FlowLayoutPanel
    Friend WithEvents picbuttonhome As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents picbuttonmenu As PictureBox
    Friend WithEvents Timer2menushow As Timer
End Class
