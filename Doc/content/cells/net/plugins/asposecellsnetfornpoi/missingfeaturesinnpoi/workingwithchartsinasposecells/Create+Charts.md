+++
title = "Create Charts" 
description = "" 
weight = 20950 
+++

Aspose.Cells for .NET : Create Charts  

# Aspose.Cells for .NET : Create Charts


## Aspose.Cells - Create Charts

It is possible to add a variety of charts to spreadsheets with Aspose.Cells. Aspose.Cells provides many flexible charting objects.

**C#**

// Instantiating a Workbook objectWorkbook workbook = new Workbook();// Obtaining the reference of the first worksheetWorksheetCollection worksheets = workbook.Worksheets;Worksheet sheet = worksheets\[0\];// Adding some sample value to cellsCells cells = sheet.Cells;Cell cell = cells\["A1"\];cell.Value = 50;cell = cells\["A2"\];cell.Value = 100;cell = cells\["A3"\];cell.Value = 150;cell = cells\["B1"\];cell.Value = 4;cell = cells\["B2"\];cell.Value = 20;cell = cells\["B3"\];cell.Value = 50;ChartCollection charts = sheet.Charts;// Adding a chart to the worksheetint chartIndex = charts.Add(ChartType.Pyramid, 5, 0, 15, 5);Chart chart = charts\[chartIndex\];// Adding NSeries (chart data source) to the chart ranging from "A1" cell to "B3"SeriesCollection serieses = chart.NSeries;serieses.Add("A1:B3", true);// Saving the Excel fileworkbook.Save("Chart\_Aspose.xls");

## Download Running Code

Download **Create Charts** form any of the below mentioned social coding sites:

*   [CodePlex](https://asposenpoi.codeplex.com/downloads/get/1482209)
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/download/AsposeCellsFeaturesMissinginNPOI_v1.0/Create.Charts.Aspose.Cells.zip)

For more details, visit [How to Create a Chart](http://www.aspose.com/docs/display/cellsnet/How+to+Create+a+Chart).

