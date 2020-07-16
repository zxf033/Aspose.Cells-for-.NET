+++
title = "Hiding Rows and Columns in Worksheet" 
description = "" 
weight = 20933 
+++

Aspose.Cells for .NET : Hiding Rows and Columns in Worksheet  

# Aspose.Cells for .NET : Hiding Rows and Columns in Worksheet


## Aspose.Cells - Hiding Rows and Columns in Worksheet

**C#**

Workbook workbook = new Workbook();//Accessing the first worksheet in the Excel fileWorksheet worksheet = workbook.Worksheets\[0\];worksheet.Cells\["A1"\].PutValue("1");worksheet.Cells\["A2"\].PutValue("2");worksheet.Cells\["B1"\].PutValue(11);//Hiding the 1st row of the worksheetworksheet.Cells.HideRow(0);//Hiding the 1st column of the worksheetworksheet.Cells.HideColumn(0);//Saving the modified Excel fileworkbook.Save("Output-HideRowsandColumns.xls");

## NPOI - HSSF XSSF - Hiding Rows and Columns in Worksheet

**C#**

HSSFWorkbook hssfworkbook = new HSSFWorkbook();ISheet s = hssfworkbook.CreateSheet("Sheet1");IRow r1 = s.CreateRow(0);IRow r2 = s.CreateRow(1);//hide Row 0r1.ZeroHeight = true;//hide column Cs.SetColumnHidden(0, true);FileStream file = new FileStream(@"HidingRowsandColumn(NPOI).xls", FileMode.Create);hssfworkbook.Write(file);file.Close();

## Download Running Code

Download **Hiding Rows and Columns in Worksheet** form any of the below mentioned social coding sites:

*   [CodePlex](https://asposecellsnpoi.codeplex.com/downloads/get/1565291)
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/download/Aspose.Cells_Vs_NPOI_HWPF_and_XWPF_v1.3/Hiding.Rows.and.Columns.zip)

For more details, visit [Working with Worksheets](http://www.aspose.com/docs/display/cellsnet/Working+with+Worksheets).

