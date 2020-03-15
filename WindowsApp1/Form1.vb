Imports System.IO

Public Class Form1
    Public snapshots As List(Of String) = New List(Of String)
    Dim currentSnapshotIndex As Integer = -1 'If -1, no items
    
    Dim saved As Boolean = True
    Dim workingfilename As String = "" 'No file opened when empty string

    Private Sub ListView_Aob_DoubleClick(sender As Object, e As EventArgs) Handles ListView_Aob.DoubleClick
        If ListView_Aob.SelectedItems.Count > 0 Then
            Form2.SetMode("Edit")
            Form2.ShowDialog()
        End If
    End Sub
    Private Sub Button_Generate_Click(sender As Object, e As EventArgs) Handles Button_Generate.Click
        'Dont generate anything if there are < 2 aobs
        If ListView_Aob.CheckedItems.Count < 2 Then
            System.Media.SystemSounds.Hand.Play()
            MessageBox.Show("Please select at least two aobs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If
        'Determines the longest aob
        Dim longestAobLength As Integer = ListView_Aob.CheckedItems(0).SubItems(1).Text.Length
        For i As Integer = 1 To ListView_Aob.CheckedItems.Count - 1
            If ListView_Aob.CheckedItems(i).SubItems(1).Text.Length > longestAobLength Then
                longestAobLength = ListView_Aob.CheckedItems(i).SubItems(1).Text.Length
            End If
        Next
        'Determines which character to generate wildcards with
        Dim character As String = "?"
        If RadioButton_Asterisk.Checked Then
            character = "*"
        End If
        'Determines the first aob to use to compare the aobs on the list
        Dim firstAob As String = ListView_Aob.CheckedItems(0).SubItems(1).Text
        Dim workingAob As String = ""
        For i As Integer = 1 To ListView_Aob.CheckedItems.Count - 1
            'Determines the other aob to compare to
            Dim secondAob As String = ListView_Aob.CheckedItems(i).SubItems(1).Text
            'Generated aob
            For j As Integer = 0 To longestAobLength - 1 Step 3
                'If the current index is higher than one of the two aob's lengths
                If j > firstAob.Length - 1 Or j > secondAob.Length - 1 Then
                    'Just wildcard it
                    workingAob += character + character
                ElseIf RadioButton_Full.Checked Then
                    If firstAob(j) = secondAob(j) AndAlso firstAob(j + 1) = secondAob(j + 1) Then
                        workingAob += firstAob(j) + firstAob(j + 1)
                    Else
                        workingAob += character + character

                    End If
                Else
                    For k As Integer = 0 To 1
                        If firstAob(j + k) = secondAob(j + k) Then
                            workingAob += firstAob(j + k)
                        Else
                            workingAob += character
                        End If
                    Next
                End If
                If j <> longestAobLength - 2 Then
                    workingAob += " "
                End If
            Next
            firstAob = workingAob
            'Reset the working aob
            If i <> ListView_Aob.CheckedItems.Count - 1 Then
                workingAob = ""
            End If
        Next
        TextBox_Output.Text = workingAob
        Interaction.Beep()
    End Sub

    Sub Save() 'Save to current file name
        If workingfilename = "" Then
            SaveAs()
        Else
            SaveToCurrentFile()
        End If
    End Sub

    Sub UpdateFormText()
        Dim unsavedChar As String = "* "
        If saved Then
            unsavedChar = ""
        End If
        Me.Text = "Aob tool " + unsavedChar + "- " + workingfilename
    End Sub

    Sub ResetSnapshots()
        snapshots.Clear()
        currentSnapshotIndex = -1
    End Sub

    Sub Open()
        If Not saved Then
            Select Case MessageBox.Show("Save before opening another file?", "Save", MessageBoxButtons.YesNoCancel)
                Case DialogResult.Yes
                    If workingfilename <> "" Then
                        SaveToCurrentFile()
                    Else
                        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                            workingfilename = SaveFileDialog1.FileName
                            SaveToCurrentFile()
                        Else
                            Exit Sub
                        End If
                    End If
                Case DialogResult.Cancel
                    Exit Sub
            End Select
        End If
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            workingfilename = OpenFileDialog1.FileName
            ListView_Aob.Items.Clear()

            Dim sr As StreamReader = New StreamReader(workingfilename)
            Dim text As String = sr.ReadToEnd()
            Dim aobs As String() = text.Split(ControlChars.CrLf.ToCharArray, StringSplitOptions.RemoveEmptyEntries)
            For Each aob As String In aobs
                ListView_Aob.Items.Add(New ListViewItem({GetNumberOfBytes(aob), aob}))
                ListView_Aob.Items(ListView_Aob.Items.Count - 1).Checked = True
            Next
            SetSaved(True)
            sr.Close()
            ResetSnapshots()
        End If
    End Sub

    Sub SaveAs()
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            workingfilename = SaveFileDialog1.FileName
            SaveToCurrentFile()
        End If
    End Sub

    Sub SaveToCurrentFile()
        Dim sw As StreamWriter = New StreamWriter(workingfilename)
        For Each item As ListViewItem In ListView_Aob.Items
            sw.WriteLine(item.SubItems(1).Text)
        Next
        sw.Close()
        SetSaved(True)
    End Sub

    Sub CreateNew()
        If Not saved Then
            Select Case MessageBox.Show("Save before creating new file?", "Save", MessageBoxButtons.YesNoCancel)
                Case DialogResult.Yes
                    If workingfilename <> "" Then
                        SaveToCurrentFile()
                    Else
                        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                            workingfilename = SaveFileDialog1.FileName
                            SaveToCurrentFile()
                        Else
                            Exit Sub
                        End If
                    End If
                Case DialogResult.Cancel
                    Exit Sub
            End Select
        End If
        workingfilename = ""
        ResetSnapshots()
        ListView_Aob.Items.Clear()
        SetSaved(True)
    End Sub

    Sub SetSaved(b As Boolean)
        saved = b
        UpdateFormText()
    End Sub

    Sub CopySelection()
        If Not TextBox_Output.Focused AndAlso ListView_Aob.SelectedItems.Count > 0 Then
            Dim textToCopy As String = ""
            For Each item As ListViewItem In ListView_Aob.SelectedItems
                textToCopy += item.SubItems(1).Text + vbCrLf
            Next
            Clipboard.SetText(textToCopy)
        End If
    End Sub

    Sub InvertSelection()
        If Not TextBox_Output.Focused Then
            For Each item As ListViewItem In ListView_Aob.Items
                item.Selected = Not item.Selected
            Next
        End If
    End Sub

    Sub RemoveSelection()
        If Not TextBox_Output.Focused And ListView_Aob.SelectedItems.Count > 0 Then
            If snapshots.Count = 0 Then
                CreateSnapshot()
            End If
            For i As Integer = ListView_Aob.SelectedItems.Count - 1 To 0 Step -1
                ListView_Aob.Items.Remove(ListView_Aob.SelectedItems(i))
            Next
            CreateSnapshot()
            SetSaved(False)
        End If
    End Sub

    Sub ShowAddForm()
        Form2.SetMode("Add")
        Form2.ShowDialog()
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Modifiers = Keys.Control Then
            Select Case e.KeyCode
                Case Keys.T
                    ShowAddForm()
                Case Keys.D
                    SaveAs()
                Case Keys.S
                    Save()
                Case Keys.N
                    CreateNew()
                Case Keys.O
                    Open()
                Case Keys.E
                    EditSelection()
                Case Keys.I
                    InvertSelection()
                Case Keys.C
                    CopySelection()
                Case Keys.A
                    SelectAll()
                Case Keys.X
                    RemoveSelection()
                Case Keys.V
                    PasteSelection()
                Case Keys.Z
                    Undo()
                Case Keys.Y
                    Redo()
            End Select
        End If
        Select Case e.KeyCode
            Case Keys.F1
                Help()
            Case Keys.F2
                About()
        End Select
    End Sub

    Sub About()
        MessageBox.Show("Made by [redacted]", "About Me")
    End Sub
    Sub Help()
        Dim shortcuts As String = "Ctrl + N: New File
Ctrl + O: Open File
Ctrl + S: Save
Ctrl + D: Save As
Ctrl + Z: Undo
Ctrl + Y: Redo
Ctrl + T: Add
Ctrl + E: Edit Selection
Ctrl + X: Remove Selection
Ctrl + I: Invert Selection
Ctrl + C: Copy Selection
Ctrl + V: Paste Clipboard onto list
Ctrl + A: Select All
F1: Help
F2: About"
        MessageBox.Show(shortcuts, "Help")
    End Sub
    Sub SelectAll()
        If Not TextBox_Output.Focused Then
            For i As Integer = 0 To ListView_Aob.Items.Count - 1
                ListView_Aob.Items(i).Selected = True
            Next
        End If
    End Sub

    Sub PasteSelection()
        If Not TextBox_Output.Focused AndAlso Clipboard.ContainsText Then
            If snapshots.Count = 0 Then
                CreateSnapshot()
            End If
            Dim workingAob = ""
            Dim copiedAobs = Clipboard.GetText()
            Dim aoblist As String() = copiedAobs.Split(ControlChars.CrLf.ToCharArray, StringSplitOptions.RemoveEmptyEntries)
            For Each aob As String In aoblist
                AddAobToList(aob)
            Next
            CreateSnapshot()
            SetSaved(False)
        End If
    End Sub

    Sub EditSelection()
        If ListView_Aob.SelectedItems.Count > 0 Then
            Form2.SetMode("Edit")
            Form2.ShowDialog()
        End If
    End Sub

    Sub CreateSnapshot()
        Dim snapshot As String = ""
        For Each item As ListViewItem In ListView_Aob.Items
            snapshot += item.SubItems(1).Text + vbCrLf
        Next
        'Trim snapshots up to the current index
        snapshots.RemoveRange(currentSnapshotIndex + 1, snapshots.Count - (currentSnapshotIndex + 1))
        snapshots.Add(snapshot)
        currentSnapshotIndex += 1
    End Sub

    Sub ParseSnapshotInCurrentIndex()
        Dim aoblist As String() = snapshots(currentSnapshotIndex).Split(ControlChars.CrLf.ToCharArray, StringSplitOptions.RemoveEmptyEntries)
        ListView_Aob.Items.Clear()
        For Each aob As String In aoblist
            AddAobToList(aob)
        Next
    End Sub

    Sub Undo()
        If currentSnapshotIndex <= 0 Then
            Interaction.Beep()
            Exit Sub
        End If
        currentSnapshotIndex -= 1
        ParseSnapshotInCurrentIndex()
        SetSaved(False)
    End Sub

    Sub Redo()
        If currentSnapshotIndex = snapshots.Count - 1 Then
            Interaction.Beep()
            Exit Sub
        End If
        currentSnapshotIndex += 1
        ParseSnapshotInCurrentIndex()
        SetSaved(False)
    End Sub

    Function GetNumberOfBytes(aob As String) As Integer
        Dim count As Integer = 1
        'Count number of spaces
        For i As Integer = 0 To aob.Length - 1
            If aob(i) = " " Then
                count += 1
            End If
        Next
        Return count
    End Function

    Sub AddAobToList(aob As String)
        ListView_Aob.Items.Add(New ListViewItem({GetNumberOfBytes(aob), aob}))
        ListView_Aob.Items(ListView_Aob.Items.Count - 1).Checked = True
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        Redo()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        CreateNew()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Open()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Save()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveAs()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        ShowAddForm()
    End Sub

    Private Sub EditSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSelectedToolStripMenuItem.Click
        EditSelection()
    End Sub

    Private Sub RemoveSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSelectedToolStripMenuItem.Click
        RemoveSelection()
    End Sub

    Private Sub InvertSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvertSelectionToolStripMenuItem.Click
        InvertSelection()
    End Sub

    Private Sub CopySelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopySelectionToolStripMenuItem.Click
        CopySelection()
    End Sub

    Private Sub PasteIntoListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteIntoListToolStripMenuItem.Click
        PasteSelection()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        SelectAll()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Help()
    End Sub

    Private Sub ProgramClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not saved Then
            Select Case MessageBox.Show("Do you want to save your work before exiting?", "Save?", MessageBoxButtons.YesNoCancel)
                Case DialogResult.Yes
                    If workingfilename <> "" Then
                        SaveToCurrentFile()
                    Else
                        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                            workingfilename = SaveFileDialog1.FileName
                            SaveToCurrentFile()
                        Else
                            e.Cancel = True
                        End If
                    End If
                Case DialogResult.Cancel
                    e.Cancel = True
            End Select
        End If
    End Sub
End Class
