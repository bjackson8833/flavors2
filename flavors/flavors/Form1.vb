Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub lstFlavor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFlavor.SelectedIndexChanged
        If lstFlavor.SelectedItem = "Strawberry" Then
            picFlavor.Image = My.Resources.strawbberry
        End If
        If lstFlavor.SelectedItem = "Cookies n Cream" Then
            picFlavor.Image = My.Resources.cooknes
        End If
        If lstFlavor.SelectedItem = "Mint" Then
            picFlavor.Image = My.Resources.mint
        End If
        If lstFlavor.SelectedItem = "Butter Peacon" Then
            picFlavor.Image = My.Resources.buter_peacon
        End If
        If lstFlavor.SelectedItem = "Banana" Then
            picFlavor.Image = My.Resources.banana_ice_cream
        End If


    End Sub
End Class
