<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128573349/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1047)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/Series_DoughnutChart/Form1.cs) (VB: [Form1.vb](./VB/Series_DoughnutChart/Form1.vb))**
<!-- default file list end -->
# How to create a Doughnut chart

The following example demonstrates how to create a [Doughnut](https://docs.devexpress.com/WindowsForms/3420/controls-and-libraries/chart-control/series-views/2d-series-views/pie-and-donut-series-views/doughnut-chart?p=netframework) chart at runtime.

Note that this series view type is associated with the [Simple Diagram](https://docs.devexpress.com/WindowsForms/5906/controls-and-libraries/chart-control/diagram/simple-diagram?p=netframework) type, and you should cast your [diagram](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.Diagram?p=netframework) object to this type, in order to access its specific options.

Starting from v14.1, text pattern properties ([AxisLabel.TextPattern](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.AxisLabel.TextPattern?p=netframework), [SeriesLabelBase.TextPattern](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesLabelBase.TextPattern?p=netframework), [SeriesBase.LegendTextPattern](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesBase.LegendTextPattern?p=netframework)) have been introduced instead of point options. Text pattern properties simplify text customization of series labels, axis labels and legend items (when the [SeriesViewColorEachSupportBase.ColorEach](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesViewColorEachSupportBase.ColorEach?p=netframework) mode is enabled).
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-create-a-doughnut-chart-e1047&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-create-a-doughnut-chart-e1047&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
