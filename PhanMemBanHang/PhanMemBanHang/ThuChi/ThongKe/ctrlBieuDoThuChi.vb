Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing.Printing

Public Class ctrlBieuDoThuChi
    Public bsData As BindingSource
    Public TenBieuDo As String
    Public Chart1 As New Chart
    Public Sub CapNhat()
        Chart1.DataBindings.Clear()
        If Chart1.Titles.Count > 0 Then Chart1.Titles(0).Text = TenBieuDo
        If Chart1.Series.Count > 0 Then Chart1.Series(0).LegendText = "THU"
        If Chart1.Series.Count > 0 Then Chart1.Series(1).LegendText = "CHI"
        Chart1.DataBind()
    End Sub
    Private Sub CreateChart(ByVal xMember As String, ByVal yThu As String, ByVal yChi As String, ByVal format As String)
        Me.KryptonPanel1.Controls.Clear()


        Chart1 = New Chart
        Chart1.BeginInit()
        Chart1.Name = "Chart1"
        Chart1.Width = 800
        Chart1.Height = 800
        Me.SuspendLayout()

        ' Label Cột, dòng
        Dim ChartArea1 As New ChartArea
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)

        ChartArea1.AxisX.LabelStyle.Angle = -45
        ChartArea1.AxisX.LabelStyle.ForeColor = Color.Black
        ChartArea1.AxisX.LabelStyle.Format = format
        ChartArea1.AxisX.IsLabelAutoFit = True
        If format = "dd" Then
            ChartArea1.AxisX.IntervalType = DateTimeIntervalType.Days
        Else
            ChartArea1.AxisX.IntervalType = DateTimeIntervalType.Months
        End If
        ChartArea1.AxisX.Interval = 1

        ChartArea1.AxisY.LabelStyle.ForeColor = Color.Red
        ChartArea1.AxisY.LabelStyle.Format = "N0"


        ' Tiêu đề bản chú thích
        Dim Legend1 As New Legend
        Legend1.Title = "Chú thích"
        Legend1.Name = "Lengend1"
        Chart1.Legends.Add(Legend1)


        Dim Series1 As New Series
        Series1.IsValueShownAsLabel = True
        Series1.LabelBackColor = Color.White
        Series1.LabelForeColor = Color.Red
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Lengend1"
        Series1.Name = "Series1"
        Series1.LabelFormat = "N0"

        Series1.BorderWidth = 1
        'Series1.MarkerStyle = MarkerStyle.Circle
        'Series1.MarkerColor = Color.Yellow
        'Series1.MarkerSize = 6

        Series1.ChartType = SeriesChartType.Column
        Series1.XValueMember = xMember
        Series1.YValueMembers = yThu

        Chart1.Series.Add(Series1)


        ' CHI
        Dim Series2 As New Series
        Series2.IsValueShownAsLabel = True
        Series2.LabelBackColor = Color.White
        Series2.LabelForeColor = Color.Red
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Lengend1"
        Series2.Name = "Series2"
        Series2.LabelFormat = "N0"

        Series2.BorderWidth = 1
        'Series2.MarkerStyle = MarkerStyle.Circle
        'Series2.MarkerColor = Color.Yellow
        'Series2.MarkerSize = 6

        Series2.ChartType = SeriesChartType.Column
        Series2.XValueMember = xMember
        Series2.YValueMembers = yChi
        Chart1.Series.Add(Series2)

        ' Tiêu đề của Biểu Đồ
        Dim Title1 As New Title
        Title1.Name = "Title1"
        Title1.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, 0)
        Title1.ForeColor = Color.Blue
        Chart1.Titles.Add(Title1)

        Chart1.TabIndex = 0
        Chart1.Text = "Chart1"
        Chart1.DataSource = bsData

        Me.KryptonPanel1.Controls.Add(Chart1)
        Chart1.Dock = DockStyle.Fill
        Chart1.EndInit()
        Me.ResumeLayout(False)
    End Sub

    Public Sub TaoBanDau(format As String)
        CreateChart("ThoiGian", "TongThu", "TongChi", format)
    End Sub

    Private Sub btnInBieuDo_Click(sender As Object, e As EventArgs) Handles btnInBieuDo.Click
        PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Arial", 1169, 827)
        PrintDocument1.DefaultPageSettings.Landscape = True
        Chart1.Printing.PrintDocument = PrintDocument1
        Chart1.Printing.Print(True)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Chart1.Printing.PrintPaint(e.Graphics, New Rectangle(0, 0, 800, 600))
        e.Graphics.DrawString("", Me.Font, Brushes.Black, New Point(0, 802))
    End Sub
End Class
