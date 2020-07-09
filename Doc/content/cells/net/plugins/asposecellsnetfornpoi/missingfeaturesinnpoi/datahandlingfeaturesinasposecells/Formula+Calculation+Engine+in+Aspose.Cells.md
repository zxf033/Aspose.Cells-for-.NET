+++
title = "Formula Calculation Engine in Aspose.Cells" 
description = "" 
weight = 20943 
+++

Aspose.Cells for .NET : Formula Calculation Engine in Aspose.Cells  

# Aspose.Cells for .NET : Formula Calculation Engine in Aspose.Cells


## Aspose.Cells - Formula Calculation Engine

The formula calculation engine is embedded in Aspose.Cells. It can not only re-calculate the formula imported from a designer spreadsheet file but also supports to calculate the results of formulas added at runtime.

**C#**

//Instantiating a Workbook objectWorkbook book = new Workbook();//Obtaining the reference of the newly added worksheetint sheetIndex = book.Worksheets.Add();Worksheet worksheet = book.Worksheets\[sheetIndex\];Cells cells = worksheet.Cells;Cell cell = null;//Adding a value to "A1" cellcell = cells\["A1"\];cell.Value = 1;//Adding a value to "A2" cellcell = cells\["A2"\];cell.Value = 2;//Adding a value to "A3" cellcell = cells\["A3"\];cell.Value = 3;//Adding a SUM formula to "A4" cellcell = cells\["A4"\];cell.Formula = "=SUM(A1:A3)";//Calculating the results of formulasbook.CalculateFormula();//Saving the Excel filebook.Save("AsposeFormulaEngine.xls");

## Download Running Code

Download **Formula Calculation Engine** form any of the below mentioned social coding sites:

*   [CodePlex](https://asposenpoi.codeplex.com/downloads/get/1482191)
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/download/AsposeCellsFeaturesMissinginNPOI_v1.0/Formula.Calculation.Engine.Aspose.Cells.zip)

For more details, visit [Formula Calculation Engine](http://www.aspose.com/docs/display/cellsnet/Formula+Calculation+Engine).

