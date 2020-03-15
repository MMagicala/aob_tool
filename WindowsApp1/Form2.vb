Public Class Form2
    Public Mode As String = ""
    Public AobIndicesToEdit As List(Of Integer) = New List(Of Integer)
    
    'Click button to submit changes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Form1.snapshots.Count = 0 Then
            Form1.CreateSnapshot()
        End If
        If Mode = "Edit" Then
            For Each index As Integer In AobIndicesToEdit
                Form1.ListView_Aob.Items(index).SubItems(1).Text = TextBox1.Text
                Form1.ListView_Aob.Items(index).SubItems(0).Text = Form1.GetNumberOfBytes(TextBox1.Text)
            Next
        Else
            Form1.AddAobToList(TextBox1.Text)
        End If
        Form1.CreateSnapshot()
        Form1.SetSaved(False)
        Me.Hide()
    End Sub

    'Determines whether to edit or add an aob
    Public Sub SetMode(passedMode As String)
        Mode = passedMode
        If Mode = "Edit" Then
            Button1.Text = "Apply changes"
            Me.Text = "Edit"
            TextBox1.Text = Form1.ListView_Aob.SelectedItems(0).SubItems(1).Text
            AobIndicesToEdit.Clear()
            For Each item As ListViewItem In Form1.ListView_Aob.SelectedItems
                AobIndicesToEdit.Add(Form1.ListView_Aob.Items.IndexOf(item))
            Next
        Else
            Button1.Text = "Add to list"
            Me.Text = "Add aob to list"
            TextBox1.Text = ""
        End If
    End Sub
End Class
