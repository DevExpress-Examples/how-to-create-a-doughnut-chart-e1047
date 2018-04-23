Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace Series_DoughnutChart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create a new chart.
			Dim DoughnutChart As New ChartControl()

			' Create a doughnut series.
			Dim series1 As New Series("Series 1", ViewType.Doughnut)

			' Populate the series with points.
			series1.Points.Add(New SeriesPoint("Russia", 17.0752))
			series1.Points.Add(New SeriesPoint("Canada", 9.98467))
			series1.Points.Add(New SeriesPoint("USA", 9.63142))
			series1.Points.Add(New SeriesPoint("China", 9.59696))
			series1.Points.Add(New SeriesPoint("Brazil", 8.511965))
			series1.Points.Add(New SeriesPoint("Australia", 7.68685))
			series1.Points.Add(New SeriesPoint("India", 3.28759))
			series1.Points.Add(New SeriesPoint("Others", 81.2))

			' Add the series to the chart.
			DoughnutChart.Series.Add(series1)

			' Specify the text pattern of series labels.
			series1.Label.TextPattern = "{A}: {VP:P0}"

			' Specify how series points are sorted.
			series1.SeriesPointsSorting = SortingMode.Ascending
			series1.SeriesPointsSortingKey = SeriesPointKey.Argument

			' Specify the behavior of series labels.
			CType(series1.Label, DoughnutSeriesLabel).Position = PieSeriesLabelPosition.TwoColumns
			CType(series1.Label, DoughnutSeriesLabel).ResolveOverlappingMode = ResolveOverlappingMode.Default
			CType(series1.Label, DoughnutSeriesLabel).ResolveOverlappingMinIndent = 5

			' Adjust the view-type-specific options of the series.
			CType(series1.View, DoughnutSeriesView).ExplodedPoints.Add(series1.Points(0))
			CType(series1.View, DoughnutSeriesView).ExplodedDistancePercentage = 30

			' Access the diagram's options.
			CType(DoughnutChart.Diagram, SimpleDiagram).Dimension = 2

			' Add a title to the chart and hide the legend.
			Dim chartTitle1 As New ChartTitle()
			chartTitle1.Text = "2D Doughnut Chart"
			DoughnutChart.Titles.Add(chartTitle1)
			DoughnutChart.Legend.Visible = False

			' Add the chart to the form.
			DoughnutChart.Dock = DockStyle.Fill
			Me.Controls.Add(DoughnutChart)
		End Sub

	End Class
End Namespace