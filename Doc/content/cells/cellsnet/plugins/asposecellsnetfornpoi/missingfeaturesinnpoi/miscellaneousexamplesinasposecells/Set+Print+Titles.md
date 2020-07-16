+++
title = "Set Print Titles" 
description = "" 
weight = 20947 
+++

Aspose.Cells for .NET : Set Print Titles  

# Aspose.Cells for .NET : Set Print Titles


## Aspose.Cells - Set Print Titles

Aspose.Cells allows you to designate row and column headers to repeat on all pages of a printed worksheet. To do so, use the [PageSetup](http://www.aspose.com/docs/display/cellsnet/PageSetup) class `PrintTitleColumns` and `PrintTitleRows` properties.

The rows or columns that will be repeated are defined by passing their row or column numbers. For example, rows are defined as $1:$2 and columns are defined as $A:$B.

**C#**

//Instantiating a Workbook objectWorkbook workbook = new Workbook("../../data/test.xlsx");//Obtaining the reference of the PageSetup of the worksheetPageSetup pageSetup = workbook.Worksheets\[0\].PageSetup;//Defining column numbers A & B as title columnspageSetup.PrintTitleColumns = "$A:$B";//Defining row numbers 1 & 2 as title rowspageSetup.PrintTitleRows= "$1:$2";

## Download Running Code

Download **Set Print Titles** form any of the below mentioned social coding sites:

*   [CodePlex](https://asposenpoi.codeplex.com/downloads/get/1482194)
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/download/AsposeCellsFeaturesMissinginNPOI_v1.0/Set.Print.Titles.Aspose.Cells.zip)

For more details, visit [Setting Print Options](http://www.aspose.com/docs/display/cellsnet/Setting+Print+Options).

