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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListView_Aob = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox_Output = New System.Windows.Forms.TextBox()
        Me.Button_Generate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Full = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Half = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Asterisk = New System.Windows.Forms.RadioButton()
        Me.RadioButton_QuestionMark = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvertSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopySelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteIntoListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(532, 509)
        Me.SplitContainer1.SplitterDistance = 198
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ListView_Aob, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(532, 198)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'ListView_Aob
        '
        Me.ListView_Aob.CheckBoxes = True
        Me.ListView_Aob.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView_Aob.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_Aob.FullRowSelect = True
        Me.ListView_Aob.Location = New System.Drawing.Point(3, 3)
        Me.ListView_Aob.Name = "ListView_Aob"
        Me.ListView_Aob.Size = New System.Drawing.Size(526, 192)
        Me.ListView_Aob.TabIndex = 0
        Me.ListView_Aob.UseCompatibleStateImageBehavior = False
        Me.ListView_Aob.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "# bytes"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Aob"
        Me.ColumnHeader3.Width = 200
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Output, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button_Generate, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(532, 307)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TextBox_Output
        '
        Me.TextBox_Output.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Output.Location = New System.Drawing.Point(3, 3)
        Me.TextBox_Output.Multiline = True
        Me.TextBox_Output.Name = "TextBox_Output"
        Me.TextBox_Output.Size = New System.Drawing.Size(526, 176)
        Me.TextBox_Output.TabIndex = 0
        '
        'Button_Generate
        '
        Me.Button_Generate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_Generate.Location = New System.Drawing.Point(3, 260)
        Me.Button_Generate.Name = "Button_Generate"
        Me.Button_Generate.Size = New System.Drawing.Size(526, 44)
        Me.Button_Generate.TabIndex = 1
        Me.Button_Generate.Text = "Generate!"
        Me.Button_Generate.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 185)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 69)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(335, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 50)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "<- Settings"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton_Full)
        Me.GroupBox2.Controls.Add(Me.RadioButton_Half)
        Me.GroupBox2.Location = New System.Drawing.Point(83, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(142, 63)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Full/Half Bytes"
        '
        'RadioButton_Full
        '
        Me.RadioButton_Full.AutoSize = True
        Me.RadioButton_Full.Checked = True
        Me.RadioButton_Full.Location = New System.Drawing.Point(6, 18)
        Me.RadioButton_Full.Name = "RadioButton_Full"
        Me.RadioButton_Full.Size = New System.Drawing.Size(51, 21)
        Me.RadioButton_Full.TabIndex = 6
        Me.RadioButton_Full.TabStop = True
        Me.RadioButton_Full.Text = "Full"
        Me.RadioButton_Full.UseVisualStyleBackColor = True
        '
        'RadioButton_Half
        '
        Me.RadioButton_Half.AutoSize = True
        Me.RadioButton_Half.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton_Half.Name = "RadioButton_Half"
        Me.RadioButton_Half.Size = New System.Drawing.Size(54, 21)
        Me.RadioButton_Half.TabIndex = 4
        Me.RadioButton_Half.Text = "Half"
        Me.RadioButton_Half.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_Asterisk)
        Me.GroupBox1.Controls.Add(Me.RadioButton_QuestionMark)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(75, 63)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Format"
        '
        'RadioButton_Asterisk
        '
        Me.RadioButton_Asterisk.AutoSize = True
        Me.RadioButton_Asterisk.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton_Asterisk.Name = "RadioButton_Asterisk"
        Me.RadioButton_Asterisk.Size = New System.Drawing.Size(34, 21)
        Me.RadioButton_Asterisk.TabIndex = 5
        Me.RadioButton_Asterisk.Text = "*"
        Me.RadioButton_Asterisk.UseVisualStyleBackColor = True
        '
        'RadioButton_QuestionMark
        '
        Me.RadioButton_QuestionMark.AutoSize = True
        Me.RadioButton_QuestionMark.Checked = True
        Me.RadioButton_QuestionMark.Location = New System.Drawing.Point(6, 18)
        Me.RadioButton_QuestionMark.Name = "RadioButton_QuestionMark"
        Me.RadioButton_QuestionMark.Size = New System.Drawing.Size(37, 21)
        Me.RadioButton_QuestionMark.TabIndex = 4
        Me.RadioButton_QuestionMark.TabStop = True
        Me.RadioButton_QuestionMark.Text = "?"
        Me.RadioButton_QuestionMark.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(532, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(135, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(135, 26)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(135, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(135, 26)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.AddToolStripMenuItem, Me.EditSelectedToolStripMenuItem, Me.RemoveSelectedToolStripMenuItem, Me.InvertSelectionToolStripMenuItem, Me.CopySelectionToolStripMenuItem, Me.PasteIntoListToolStripMenuItem, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditSelectedToolStripMenuItem
        '
        Me.EditSelectedToolStripMenuItem.Name = "EditSelectedToolStripMenuItem"
        Me.EditSelectedToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.EditSelectedToolStripMenuItem.Text = "Edit Selection"
        '
        'RemoveSelectedToolStripMenuItem
        '
        Me.RemoveSelectedToolStripMenuItem.Name = "RemoveSelectedToolStripMenuItem"
        Me.RemoveSelectedToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.RemoveSelectedToolStripMenuItem.Text = "Remove Selection"
        '
        'InvertSelectionToolStripMenuItem
        '
        Me.InvertSelectionToolStripMenuItem.Name = "InvertSelectionToolStripMenuItem"
        Me.InvertSelectionToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.InvertSelectionToolStripMenuItem.Text = "Invert Selection"
        '
        'CopySelectionToolStripMenuItem
        '
        Me.CopySelectionToolStripMenuItem.Name = "CopySelectionToolStripMenuItem"
        Me.CopySelectionToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.CopySelectionToolStripMenuItem.Text = "Copy Selection"
        '
        'PasteIntoListToolStripMenuItem
        '
        Me.PasteIntoListToolStripMenuItem.Name = "PasteIntoListToolStripMenuItem"
        Me.PasteIntoListToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.PasteIntoListToolStripMenuItem.Text = "Paste Into List"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 537)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(550, 584)
        Me.Name = "Form1"
        Me.Text = "Aob tool -"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBox_Output As TextBox
    Friend WithEvents Button_Generate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton_Half As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton_Asterisk As RadioButton
    Friend WithEvents RadioButton_QuestionMark As RadioButton
    Friend WithEvents RadioButton_Full As RadioButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ListView_Aob As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvertSelectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopySelectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteIntoListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
