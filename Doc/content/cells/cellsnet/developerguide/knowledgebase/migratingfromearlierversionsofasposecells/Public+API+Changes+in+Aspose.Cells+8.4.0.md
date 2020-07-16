+++
title = "Public API Changes in Aspose.Cells 8.4.0" 
description = "" 
weight = 16760 
+++

Aspose.Cells for .NET : Public API Changes in Aspose.Cells 8.4.0  

# Aspose.Cells for .NET : Public API Changes in Aspose.Cells 8.4.0


This document describes the changes to the Aspose.Cells API from version 8.3.2 to 8.4.0 that may be of interest to module/application developers. It includes not only new and updated public methods, [added classes etc.](http://localhost:1313/cellsnet/developerguide/knowledgebase/migratingfromearlierversionsofasposecells/public+api+changes+in+aspose.cells+8.4.0) and [removed classes etc.](http://localhost:1313/cellsnet/developerguide/knowledgebase/migratingfromearlierversionsofasposecells/public+api+changes+in+aspose.cells+8.4.0), but also a description of any changes in the behavior behind the scenes in Aspose.Cells.

## Added APIs

### Mechanism to Modify the VBA/Macro Code in Spreadsheets

In order to provide the feature of [VBA/Macro Code Manipulation](http://localhost:1313/cellsnet/developerguide/workbookvbaproject/modifying+vba+or+macro+code+using+aspose.cells), the Aspose.Cells for .NET 8.4.0 has exposed a series of new classes and properties in the `Aspose.Cells.Vba` namespace. A few of the important details of these new classes are as follow.

*   `VbaProject` class can be used to fetch the VBA project from a given spreadsheet.
*   `VbaModuleCollection` class represents the collection of VBA modules that are part of a given `VbaProject`.
*   `VbaModule` class represents a single module from the `VbaModuleCollection`.

The following code snippet shows how to dynamically modify the VBA code segments.

**C#**

//Create workbook object from source Excel fileWorkbook workbook = new Workbook("source.xlsm");//Change the VBA Module Codeforeach (VbaModule module in workbook.VbaProject.Modules){    string code = module.Codes;    //Replace the original message with the modified message    if (code.Contains("This is test message."))    {        code = code.Replace("This is test message.", "This is Aspose.Cells message.");        module.Codes = code;    }}//Save the output Excel fileworkbook.Save("output.xlsm");

### Ability to Remove Pivot Table

Aspose.Cells for .NET 8.4.0 has exposed two methods for the `PivotTableCollection` to provide the feature of Pivot Table removal from a given spreadsheet. The details of aforesaid methods are as follow.

*   `PivotTableCollection.Remove` method accepts an object of PivotTable, and removes it from the collection.
*   `PivotTableCollection.RemoveAt` method accepts a zero index based integer value and removes the particular PivotTable from the collection.

The following code snippet shows how to remove the PivotTable using both above mentioned methods.

**C#**

//Create workbook object from source Excel fileWorkbook workbook = new Workbook("source.xlsx");//Access the first worksheetWorksheet worksheet = workbook.Worksheets\[0\];//Access the first pivot table objectPivotTable pivotTable = worksheet.PivotTables\[0\];//Remove pivot table using pivot table objectworksheet.PivotTables.Remove(pivotTable);//Remove pivot table using pivot table positionworksheet.PivotTables.RemoveAt(0);//Save the workbookworkbook.Save("output.xlsx");

### Support for Different Pivot Table Layouts

Aspose.Cells for .NET 8.4.0 provides the support for different predefined layouts for Pivot Tables. In order to provide this feature, the Aspose.Cells APIs have exposed three methods for the `PivotTable` class as detailed below.

*   `PivotTable.ShowInCompactForm` method renders the Pivot Table in Compact layout.
*   `PivotTable.ShowInOutlineForm` method renders the Pivot Table in Outline layout.
*   `PivotTable.ShowInTabularForm` method renders the Pivot Table in Tabular layout.

It is important to call the `PivotTable.RefreshData` & `PivotTable.CalculateData` after setting any of the above mentioned layouts.

The following sample code sets different layouts for a Pivot Table and stores the result on disc.

**C#**

//Create workbook object from source excel fileWorkbook workbook = new Workbook("source.xlsx");//Access first worksheetWorksheet worksheet = workbook.Worksheets\[0\];//Access first pivot tablePivotTable pivotTable = worksheet.PivotTables\[0\];//Render the pivot table in compact formpivotTable.ShowInCompactForm();//Refresh the pivot tablepivotTable.RefreshData();pivotTable.CalculateData();//Save the outputworkbook.Save("CompactForm.xlsx");//Render the pivot table in outline formpivotTable.ShowInOutlineForm();//Refresh the pivot tablepivotTable.RefreshData();pivotTable.CalculateData();//Save the outputworkbook.Save("OutlineForm.xlsx");//Render the pivot table in tabular formpivotTable.ShowInTabularForm();//Refresh the pivot tablepivotTable.RefreshData();pivotTable.CalculateData();//Save the outputworkbook.Save("TabularForm.xlsx");

### Class TxtLoadStyleStrategy & Property TxtLoadOptions.LoadStyleStrategy Added

Aspose.Cells for .NET 8.4.0 has exposed the `TxtLoadStyleStrategy` class and `TxtLoadOptions.LoadStyleStrategy` property in order to specify the strategy to format the parsed values while converting string value to number or date time.

### Method DataBar.ToImage Added

With the release of v8.4.0, the Aspose.Cells API has provided the `DataBar.ToImage` method to save the conditionally formatted DataBars in image format. The {DataBar.ToImage}} method accepts two parameters as detailed below.

*   The first parameter is of type `Aspose.Cells.Cell` on which conditional formatting has been applied.
*   The second parameter is of type `Aspose.Cells.Rendering.ImageOrPrintOptions` in order to set different parameters of the resultant image.

The following sample code demonstrates the use of `DataBar.ToImage` method to render the DataBar in image format.

**C#**

//Create workbook object from source excel fileWorkbook workbook = new Workbook("source.xlsx");//Access first worksheetWorksheet worksheet = workbook.Worksheets\[0\];//Access the cell which contains conditional formatting databarCell cell = worksheet.Cells\["C1"\];//Get the conditional formatting of the cellFormatConditionCollection fcc = cell.GetFormatConditions();//Access the conditional formatting databarDataBar dbar = fcc\[0\].DataBar;//Create image or print optionsImageOrPrintOptions opts = new ImageOrPrintOptions();opts.ImageFormat = ImageFormat.Png;//Get the image bytes of the databarbyte\[\] imgBytes = dbar.ToImage(cell, opts);//Write image bytes on the diskFile.WriteAllBytes("databar.png", imgBytes);

### Property Border.ThemeColor Added

Aspose.Cells APIs allow to extract theme related formatting data from the spreadsheets. With the release of Aspose.Cells for .NET 8.4.0, the API has exposed the `Border.ThemeColor` property that can be used to retrieve the theme color attributes of `Cell` borders.

### Property DrawObject.ImageBytes Added

Aspose.Cells for .NET 8.4.0 has exposed the `DrawObject.ImageBytes` property to get the image data from Chart or Shape.

### Property HtmlSaveOptions.ExportBogusRowData Added

Aspose.Cells for .NET 8.4.0 has provided the {HtmlSaveOptions.ExportBogusRowData}} property. The Boolean type property determines if API will inject bogus bottom row data while exporting spreadsheet to HTML format.

The default value is `true`.

The following sample code illustrates the use of aforesaid property.

**C#**

//Create an object of HtmlSaveOptions classHtmlSaveOptions options = new HtmlSaveOptions();//Set the ExportBogusRowData to trueoptions.ExportBogusRowData = true;//Create workbook object from source excel fileWorkbook workbook = new Workbook("source.xlsx");//Save the workbookworkbook.Save("output.xlsx");

### Property HtmlSaveOptions.CellCssPrefix Added

Newly added property `HtmlSaveOptions.CellCssPrefix` allows to set the prefix for the CSS files while exporting spreadsheets to HTML format.

The default value is "" (empty string).

## Obseleted APIs

### Methods Cells.GetCellByIndex & Row.GetCellByIndex Obsoleted

Use the `GetEnumerator` method to iterate all cells instead.

### Property DrawObject.Image Obsoleted

Use the `DrawObject.ImageBytes` property to get image data instead.

