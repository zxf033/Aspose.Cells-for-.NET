+++
title = "Auto Fit Columns in Worksheet" 
description = "" 
weight = 20930 
+++

Aspose.Cells for .NET : Auto Fit Columns in Worksheet  

# Aspose.Cells for .NET : Auto Fit Columns in Worksheet


## Aspose.Cells - Auto Fit Columns in Worksheet

**C#**

//Instantiating a Workbook objectWorkbook workbook = new Workbook();//Accessing the first worksheet in the Excel fileWorksheet worksheet = workbook.Worksheets\[0\];//Auto-fitting the 1st column of the worksheet//Adding a string value to the cellworksheet.Cells\["A1"\].PutValue("This is a test input");//Adding a double value to the cellworksheet.Cells\["B1"\].PutValue(20.5);//Adding an integer  value to the cellworksheet.Cells\["C1"\].PutValue(15);//Adding a boolean value to the cellworksheet.Cells\["D1"\].PutValue(true);worksheet.AutoFitColumn(0);worksheet.AutoFitColumn(1);worksheet.AutoFitColumn(2);worksheet.AutoFitColumn(3);//Saving the modified Excel file in bin/debug folderworkbook.Save("AutoFiltRowsandColumns.xls");

## NPOI - HSSF XSSF - Auto Fit Columns in Worksheet

**C#**

HSSFWorkbook hssfworkbook = new HSSFWorkbook();ISheet sheet=hssfworkbook.CreateSheet("Sheet1");IRow row=sheet.CreateRow(0);row.CreateCell(0).SetCellValue("This is a test input");row.CreateCell(1).SetCellValue("Hello");row.CreateCell(2).SetCellValue("1234.0023");sheet.AutoSizeColumn(0);sheet.AutoSizeColumn(1);sheet.AutoSizeColumn(2);FileStream file = new FileStream(@"AutoFiltRowsandColumns(NPOI).xls", FileMode.Create);hssfworkbook.Write(file);file.Close();

## Download Running Code

Download **Auto Fit Column** form any of the below mentioned social coding sites:

*   [CodePlex](https://asposecellsnpoi.codeplex.com/downloads/get/1565289)
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/download/Aspose.Cells_Vs_NPOI_HWPF_and_XWPF_v1.3/Auto.Fit.Columns.zip)

For more details, visit [Working with Worksheets](http://www.aspose.com/docs/display/cellsnet/Working+with+Worksheets).

