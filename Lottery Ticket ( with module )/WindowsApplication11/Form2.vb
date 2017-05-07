Public Class Form2
    Dim i As Integer
  Dim ii As Integer
  Dim j As Integer
  Dim jj As Integer



    Private Sub assign()
        win0.Text = nums2.Item(0)
        win1.Text = nums2.Item(1)
        win2.Text = nums2.Item(2)

        mat0.Text = nums1.Item(0)
        mat1.Text = nums1.Item(1)
        mat2.Text = nums1.Item(2)
        mat3.Text = nums1.Item(3)
        mat4.Text = nums1.Item(4)
        mat5.Text = nums1.Item(5)
        mat6.Text = nums1.Item(6)
        mat7.Text = nums1.Item(7)
        mat8.Text = nums1.Item(8)
        mat9.Text = nums1.Item(9)
    End Sub


  Private Sub NU2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NU2.ValueChanged
    If NU2.Value >= NU1.Value Then
      NU2.Value = NU1.Value - 1
      MsgBox("The Maximum Range Must Be Greater Than The Amount Of [My Numbers] Chosen")
    End If

  End Sub

  Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

  End Sub

  Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    LB1.Items.Clear()
    LB2.Items.Clear()

    genNums(NU1.Value, NU2.Value, NU3.Value)
    jj = nums1.Count
    j = 0
    While j < jj
      LB1.Items.Add(nums1.Item(j))
      j += 1
    End While

    jj = nums2.Count
    j = 0
    While j < jj
      LB2.Items.Add(nums2.Item(j))
      j += 1
    End While
  End Sub

  Private Sub Cmd_Assign_Click(sender As System.Object, e As System.EventArgs) Handles Cmd_Assign.Click
    assign()
    Cmd_Assign.Enabled = False
    Cmd_Pop.Enabled = True
  End Sub

  Private Sub Cmd_Pop_Click(sender As System.Object, e As System.EventArgs) Handles Cmd_Pop.Click
    ListBox1.Items.Clear()
    ListBox2.Items.Clear()

    genNums(40, 3, 10)
    ii = nums1.Count
    i = 0
    While i < ii
      ListBox1.Items.Add(nums1.Item(i))
      i += 1
    End While

    ii = nums2.Count
    i = 0
    While i < ii
      ListBox2.Items.Add(nums2.Item(i))
      i += 1
    End While
    Cmd_Assign.Enabled = True
    Cmd_Pop.Enabled = False
  End Sub

  Private Sub win2_Click(sender As System.Object, e As System.EventArgs) Handles win2.Click

  End Sub
End Class