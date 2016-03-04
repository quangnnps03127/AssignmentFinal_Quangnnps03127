Public Class frmMain

    Private Sub ThêmSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmSảnPhẩmToolStripMenuItem.Click
        frmCapnhatsanpham.Show()
    End Sub

    Private Sub XemKhácHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemKhácHàngToolStripMenuItem.Click
        frmKH.Show()
    End Sub

    Private Sub ChỉnhSữaKHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChỉnhSữaKHToolStripMenuItem.Click
        frmDieuchinhKH.Show()
    End Sub

    Private Sub XemSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemSảnPhẩmToolStripMenuItem.Click
        frmXemsanpham.Show()
    End Sub

    Private Sub LoạiSànPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmLoaisanpham.Show()
    End Sub

    

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub KhácHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhácHàngToolStripMenuItem.Click

    End Sub

    Private Sub GiớiThiệuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiớiThiệuToolStripMenuItem.Click
        frmGioithieu.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Dim dialog As DialogResult = MessageBox.Show("Bạn có thật sự muốn kết thúc ứng dụng ?",
        "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (dialog = DialogResult.Yes) Then
            Me.Close()
            Application.Exit()
        End If
    End Sub
End Class
