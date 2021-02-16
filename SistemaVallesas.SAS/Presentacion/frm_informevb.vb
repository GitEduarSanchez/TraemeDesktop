Public Class frm_informevb

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim rpt As New CrpEmpleado1
        Me.CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class