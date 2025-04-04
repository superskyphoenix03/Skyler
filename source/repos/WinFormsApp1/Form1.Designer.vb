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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        MenuToolStripMenuItem = New ToolStripMenuItem()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExplrerToolStripMenuItem = New ToolStripMenuItem()
        ToolStripComboBox1 = New ToolStripComboBox()
        ToolStripComboBox2 = New ToolStripComboBox()
        ToolStripComboBox3 = New ToolStripComboBox()
        ToolStripComboBox4 = New ToolStripComboBox()
        ToolStripComboBox5 = New ToolStripComboBox()
        PictureBox1 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem, ToolStripComboBox1, ToolStripComboBox2, ToolStripComboBox3, ToolStripComboBox4, ToolStripComboBox5})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 27)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FileToolStripMenuItem, ExplrerToolStripMenuItem})
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Size = New Size(50, 23)
        MenuToolStripMenuItem.Text = "Menu"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(180, 22)
        FileToolStripMenuItem.Text = "All Files"
        ' 
        ' ExplrerToolStripMenuItem
        ' 
        ExplrerToolStripMenuItem.Name = "ExplrerToolStripMenuItem"
        ExplrerToolStripMenuItem.Size = New Size(180, 22)
        ExplrerToolStripMenuItem.Text = "Explorer"
        ' 
        ' ToolStripComboBox1
        ' 
        ToolStripComboBox1.Name = "ToolStripComboBox1"
        ToolStripComboBox1.Size = New Size(121, 23)
        ' 
        ' ToolStripComboBox2
        ' 
        ToolStripComboBox2.Name = "ToolStripComboBox2"
        ToolStripComboBox2.Size = New Size(121, 23)
        ' 
        ' ToolStripComboBox3
        ' 
        ToolStripComboBox3.Name = "ToolStripComboBox3"
        ToolStripComboBox3.Size = New Size(121, 23)
        ' 
        ' ToolStripComboBox4
        ' 
        ToolStripComboBox4.Name = "ToolStripComboBox4"
        ToolStripComboBox4.Size = New Size(121, 23)
        ' 
        ' ToolStripComboBox5
        ' 
        ToolStripComboBox5.Name = "ToolStripComboBox5"
        ToolStripComboBox5.Size = New Size(121, 23)
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1719, 727)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExplrerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents ToolStripComboBox2 As ToolStripComboBox
    Friend WithEvents ToolStripComboBox3 As ToolStripComboBox
    Friend WithEvents ToolStripComboBox4 As ToolStripComboBox
    Friend WithEvents ToolStripComboBox5 As ToolStripComboBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
