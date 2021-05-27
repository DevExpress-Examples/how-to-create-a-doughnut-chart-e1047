<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/Series_DoughnutChart/Form1.cs) (VB: [Form1.vb](./VB/Series_DoughnutChart/Form1.vb))**
<!-- default file list end -->
# How to create a Doughnut chart

The following example demonstrates how to create a [Doughnut](https://docs.devexpress.com/WindowsForms/3420/controls-and-libraries/chart-control/series-views/2d-series-views/pie-and-donut-series-views/doughnut-chart?p=netframework) chart at runtime.

Note that this series view type is associated with the [Simple Diagram](https://docs.devexpress.com/WindowsForms/5906/controls-and-libraries/chart-control/diagram/simple-diagram?p=netframework) type, and you should cast your [diagram](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.Diagram?p=netframework) object to this type, in order to access its specific options.

Starting from v14.1, text pattern properties ([AxisLabel.TextPattern](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.AxisLabel.TextPattern?p=netframework), [SeriesLabelBase.TextPattern](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesLabelBase.TextPattern?p=netframework), [SeriesBase.LegendTextPattern](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesBase.LegendTextPattern?p=netframework)) have been introduced instead of point options. Text pattern properties simplify text customization of series labels, axis labels and legend items (when the [SeriesViewColorEachSupportBase.ColorEach](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesViewColorEachSupportBase.ColorEach?p=netframework) mode is enabled).
