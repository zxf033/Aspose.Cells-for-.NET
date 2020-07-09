+++
title = "Public API Changes in Aspose.Cells 8.3.1" 
description = "" 
weight = 16758 
+++

Aspose.Cells for .NET : Public API Changes in Aspose.Cells 8.3.1  

# Aspose.Cells for .NET : Public API Changes in Aspose.Cells 8.3.1


This document describes the changes to the Aspose.Cells API from version 8.3.0 to 8.3.1 that may be of interest to module/application developers.

## Added APIs

### Property DataLabels.ShowCellRange Added

The property `ShowCellRange` have been added to the `DataLabels` class in order to mimic the Excel's functionality of formatting Chart's Data Labels at run-time. Please note, Excel provides this feature through the following steps.

1.  Select Data Labels of the Series and right click to open the pop up menu.
2.  Click the **Format Data Labels...** and it will show **Label Options**.
3.  Check or un-check the check box **Label Contains - Value From Cells**.

The sample code below accesses the Data Labels of the Chart Series and then set `DataLabels.ShowCellRange` method to true to mimic the Excel's feature of **Label Contains - Value From Cells**.

**C#**

//Create workbook from the source Excel fileWorkbook workbook = new Workbook("sample.xlsx");//Access the first worksheetWorksheet worksheet = workbook.Worksheets\[0\];//Access the chart inside the worksheetChart chart = worksheet.Charts\[0\];//Check the "Label Contains - Value From Cells"DataLabels dataLabels = chart.NSeries\[0\].DataLabels;dataLabels.ShowCellRange = true;//Save the workbookworkbook.Save("output.xlsx");

**VB.NET**

'Create workbook from the source Excel fileDim m\_workbook As Workbook = New Workbook("sample.xlsx")'Access the first worksheetDim m\_worksheet As Worksheet = m\_workbook.Worksheets(0)'Access the chart inside the worksheetDim m\_chart As Chart = m\_worksheet.Charts(0)'Check the "Label Contains - Value From Cells"Dim m\_dataLabels As DataLabels = m\_chart.NSeries(0).DataLabelsm\_dataLabels.ShowCellRange = True'Save the workbookm\_workbook.Save("output.xlsx")

Please check the article [Showing Cell Range as the Data Labels](http://aspose.com/docs/display/cellsnet/Showing+Cell+Range+as+the+Data+Labels) for more information.

  

### Methods Cell.GetTable & ListObject.PutCellValue Added

The methods `Cell.GetTable` & `ListObject.PutCellValue` have been added with Aspose.Cells for .NET 8.3.1 in order to facilitate the users to access the `ListObject` from a cell and add values inside it using the row and column offsets. The following sample code loads the source spreadsheet, and adds values inside the table.

**C#**

//Create workbook from source Excel fileWorkbook workbook = new Workbook("source.xlsx");//Access first worksheetWorksheet worksheet = workbook.Worksheets\[0\];//Access cell D5 which lies inside the tableCell cell = worksheet.Cells\["D5"\];//Put value inside the cell D5cell.PutValue("D5 Data");//Access the Table from this cellListObject table = cell.GetTable();//Add some value using Row and Column Offsettable.PutCellValue(2, 2, "Offset \[2,2\]");//Save the workbookworkbook.Save("output.xlsx");

**VB.NET**

'Create workbook from source Excel fileDim m\_workbook As Workbook = New Workbook("source.xlsx")'Access first worksheetDim m\_worksheet As Worksheet = m\_workbook.Worksheets(0)'Access cell D5 which lies inside the tableDim m\_cell As Cell = m\_worksheet.Cells("D5")'Put value inside the cell D5m\_cell.PutValue("D5 Data")'Access the Table from this cellDim table As ListObject = m\_cell.GetTable()'Add some value using Row and Column Offsettable.PutCellValue(2, 2, "Offset \[2,2\]")'Save the workbookm\_workbook.Save("output.xlsx")

Please check the article [Accessing Table from Cell and Adding Values inside it using Row and Column Offsets](http://aspose.com/docs/display/cellsnet/Accessing+Table+from+Cell+and+Adding+Values+inside+it+using+Row+and+Column+Offsets) for more information.

  

### Property OdsSaveOptions.IsStrictSchema11 Added

The property `IsStrictSchema11` has been added to the `OdsSaveOptions` class in order to allow the developers to save the spreadsheet in format conforming to ODF v1.2 specification. The default value of `IsStrictSchema11` property is `false`, means, from version 8.3.1 of Aspose.Cells APIs the ODS files will be saved as ODF format version 1.2 by default.

Below provided code snippet saves the ODS file in ODF 1.2 format.

**C#**

//Create workbookWorkbook workbook = new Workbook();//Access first worksheetWorksheet worksheet = workbook.Worksheets\[0\];//Put some value in cell A1Cell cell = worksheet.Cells\["A1"\];cell.PutValue("Welcome to Aspose!");//Save ODS in ODF 1.2 version which is defaultOdsSaveOptions options = new OdsSaveOptions();workbook.Save("ODF1.2.ods", options);//Save ODS in ODF 1.1 versionoptions.IsStrictSchema11 = true;workbook.Save("ODF1.1.ods", options);

**VB.NET**

'Create workbook Dim m\_workbook As Workbook = New Workbook()'Access first worksheetDim m\_worksheet As Worksheet = m\_workbook.Worksheets(0)'Put some value in cell A1Dim m\_cell As Cell = m\_worksheet.Cells("A1")m\_cell.PutValue("Welcome to Aspose!")'Save ODS in ODF 1.2 version which is defaultDim options As OdsSaveOptions = New OdsSaveOptions()m\_workbook.Save("ODF1.2.ods", options)'Save ODS in ODF 1.1 versionoptions.IsStrictSchema11 = Truem\_workbook.Save("ODF1.1.ods", options)

Please check the article [Save ODS file in ODF 1.1 and 1.2 Specifications](http://aspose.com/docs/display/cellsnet/Save+ODS+file+in+ODF+1.1+and+1.2+Specifications) for more information.

  

### Method SparklineCollection.Add Added

Aspose.Cells APIs have exposed the `SparklineCollection.Add(string dataRange, int row, int column)` method to specify the Data Range and Location of Sparkline Group. Please note, Excel provides the same feature through following steps.

1.  Select the cell containing your Sparkline.
2.  Select **Edit Data from the Sparkline** section inside the **Design** tab
3.  Choose **Edit Group Location & Data**.
4.  Specify **Data Range** & **Location**.

The following sample code loads the source spreadsheet, accesses the first sparkline group and adds new data ranges and locations for the sparkline group.

**C#**

//Create workbook from source Excel fileWorkbook workbook = new Workbook("source.xlsx");//Access first worksheetWorksheet worksheet = workbook.Worksheets\[0\];//Access the first sparkline groupSparklineGroup group = worksheet.SparklineGroupCollection\[0\];//Add Data Ranges and Locations inside this sparkline groupgroup.SparklineCollection.Add("D5:O5", 4, 15);group.SparklineCollection.Add("D6:O6", 5, 15);group.SparklineCollection.Add("D7:O7", 6, 15);group.SparklineCollection.Add("D8:O8", 7, 15);//Save the workbookworkbook.Save("output.xlsx");

**VB.NET**

'Create workbook from source Excel fileDim m\_workbook As Workbook = New Workbook("source.xlsx")'Access first worksheetDim m\_worksheet As Worksheet = m\_workbook.Worksheets(0)'Access the first sparkline groupDim group As SparklineGroup = m\_worksheet.SparklineGroupCollection(0)'Add Data Ranges and Locations inside this sparkline groupgroup.SparklineCollection.Add("D5:O5", 4, 15)group.SparklineCollection.Add("D6:O6", 5, 15)group.SparklineCollection.Add("D7:O7", 6, 15)group.SparklineCollection.Add("D8:O8", 7, 15)'Save the workbookm\_workbook.Save("output.xlsx")

Please check the article [Copy Sparkline by Specifying Data Range and Location of Sparkline Group](http://aspose.com/docs/display/cellsnet/Copy+Sparkline+by+Specifying+Data+Range+and+Location+of+Sparkline+Group) for more information.

