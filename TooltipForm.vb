Public Class TooltipForm

    Dim testingShared = New ToolTipper("Testing one with a reeeeeeeeally long set of text so we can text the autoranging for the width and see what happens.", 3000)

    Private Sub Tooltip_3s_Click(sender As Object, e As EventArgs) Handles Tooltip_3s.Click
        Dim tt = New ToolTipper("Testing and should disappear after 3s",, False, 500, 500)
        tt.Show()
    End Sub

    Private Sub Tooltip_10s_Click(sender As Object, e As EventArgs) Handles Tooltip_10s.Click
        Dim tt = New ToolTipper("Testing 10 seconds now", 10)
        tt.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        testingShared.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        testingShared.Hide()
    End Sub
End Class