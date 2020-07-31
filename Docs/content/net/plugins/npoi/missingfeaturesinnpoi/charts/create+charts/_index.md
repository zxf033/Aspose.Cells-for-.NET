---
title : "Create Charts" 
description : "" 
weight : 20950 
toc : false
type: docs
url: /net/plugins/npoi/missingfeaturesinnpoi/charts/create+charts/
---

# Aspose.Cells for .NET : Create Charts


## Aspose.Cells - Create Charts

It is possible to add a variety of charts to spreadsheets with Aspose.Cells. Aspose.Cells provides many flexible charting objects.

**C#**

{{< code lang="c#" >}}
// Instantiating a Workbook object
Workbook workbook = new Workbook();

// Obtaining the reference of the first worksheet
WorksheetCollection worksheets = workbook.Worksheets;
Worksheet sheet = worksheets[0];

// Adding some sample value to cells
Cells cells = sheet.Cells;
Cell cell = cells["A1"];
cell.Value = 50;
cell = cells["A2"];
cell.Value = 100;
cell = cells["A3"];
cell.Value = 150;
cell = cells["B1"];
cell.Value = 4;
cell = cells["B2"];
cell.Value = 20;
cell = cells["B3"];
cell.Value = 50;

ChartCollection charts = sheet.Charts;

// Adding a chart to the worksheet
int chartIndex = charts.Add(ChartType.Pyramid, 5, 0, 15, 5);
Chart chart = charts[chartIndex];

// Adding NSeries (chart data source) to the chart ranging from "A1" cell to "B3"
SeriesCollection serieses = chart.NSeries;
serieses.Add("A1:B3", true);

// Saving the Excel file
workbook.Save("Chart_Aspose.xls");
{{< /code >}}

## Download Running Code

Download **Create Charts** form any of the below mentioned social coding sites:

*   [CodePlex](https://asposenpoi.codeplex.com/downloads/get/1482209)
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/download/AsposeCellsFeaturesMissinginNPOI_v1.0/Create.Charts.Aspose.Cells.zip)

For more details, visit [How to Create a Chart](http://www.aspose.com/docs/display/cellsnet/How+to+Create+a+Chart).

