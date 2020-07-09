+++
title = "Split Cells in Worksheet" 
description = "" 
weight = 20936 
+++

Aspose.Cells for .NET : Split Cells in Worksheet  

# Aspose.Cells for .NET : Split Cells in Worksheet


## Aspose.Cells - Split Cells in Worksheet

**C#**

Workbook workbook = new Workbook();//Accessing the first worksheet in the Excel fileWorksheet worksheet = workbook.Worksheets\[0\];          //Set the active cellworkbook.Worksheets\[0\].ActiveCell = "A10";//Split the worksheet windowworkbook.Worksheets\[0\].Split();workbook.Save("output-Split.xls");

## NPOI - HSSF XSSF - Split Cells in Worksheet

**C#**

HSSFWorkbook hssfworkbook = new HSSFWorkbook();ISheet sheet1 = hssfworkbook.CreateSheet("new sheet");ISheet sheet2 = hssfworkbook.CreateSheet("second sheet");//Create a split with the lower left side being the active quadrantsheet2.CreateSplitPane(2000, 2000, 0, 0, PanePosition.LowerLeft);//Write the stream data of workbook to the root directoryFileStream file = new FileStream(@"output-Split.xls", FileMode.Create);hssfworkbook.Write(file);file.Close();

## Download Running Code

Download **Split Cells in Worksheet** form any of the below mentioned social coding sites:

*   [CodePlex](https://asposecellsnpoi.codeplex.com/downloads/get/1565292)

For more details, visit [Working with Worksheets](http://www.aspose.com/docs/display/cellsnet/Working+with+Worksheets).

