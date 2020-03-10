Public Class frmTransparency
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        lblOpacity.Text = Convert.ToDouble(TrackBar1.Value)
        frmAdmin.Opacity = Convert.ToDouble(TrackBar1.Value)
        frmAdminLogin.Opacity = Convert.ToDouble(TrackBar1.Value)
        frmComments.Opacity = Convert.ToDouble(TrackBar1.Value)
        frmLoggingSuite.Opacity = Convert.ToDouble(TrackBar1.Value)
        frmSetTimePicker.Opacity = Convert.ToDouble(TrackBar1.Value)
        Me.Opacity = Convert.ToDouble(TrackBar1.Value)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub frmTransparency_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        TrackBar1.Value = Opacity
    End Sub
End Class