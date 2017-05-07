Module Module1
    Dim i As Integer = 0
    Dim r As Integer = 0
    Dim ii As Integer = 0
    Dim tot As Integer = 40

    Public nums1 As New List(Of Integer)()
    Public nums2 As New List(Of Integer)()
    Public nums3 As New List(Of Integer)()
    Public nums4 As New List(Of Integer)()





    Public Function Rand(ByVal Max As Double, Optional ByVal Min As Double = 0) As Double
        Static sbRandomized As Boolean
        If Not sbRandomized Then                        '   Returns a pseudo-random number  between 'Min' and 'Max'.
            Randomize()
            sbRandomized = True                         '   Calls Randomize the first time the function is called.
        End If
        Rand = Int(Rnd() * (Max - Min + 1)) + Min
    End Function

    Public Sub genNums(ByVal tot As Integer, Optional ByVal winnum As Integer = 3, Optional ByVal matchnum As Integer = 5)

        nums1.Clear()
        nums2.Clear()
        nums3.Clear()
        nums4.Clear()
        i = 0
        ii = 0
        r = 0
        Dim match(matchnum) As Integer
        Dim win(winnum) As Integer


        While i < (35 + matchnum)
            r = Rand(tot, 1)
            nums3.Add(r)
            i += 1
        End While
        While ii < matchnum
            r = Rand(34 + matchnum, 0)
            match(ii) = nums3.Item(r)
            nums1.Add(nums3.Item(r))        'MsgBox(match(ii) & "    " & ii)
            ii += 1
        End While

        i = 1

        While i < tot + 1
            nums4.Add(i)
            i = i + 1
        End While
        ii = tot - 1
        i = 0
        While i < winnum
            r = Rand(ii, 0)
            win(i) = nums4.Item(r)
            nums2.Add(nums4.Item(r))        'MsgBox(win(i) & "  --  " & ii & "//" & i)
            nums4.RemoveAt(r)
            i = i + 1
            ii = ii - 1
        End While

    End Sub
End Module
