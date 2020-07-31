---
title : "Reorder Worksheets" 
description : "" 
weight : 20934 
toc : false
type: docs
url: /net/plugins/npoi/codeinnpoi/worksheets/reorder+worksheets/
---

# Aspose.Cells for .NET : Reorder Worksheets


## Aspose.Cells - Reorder Worksheets

**C#**

{{< code lang="c#" >}}
//Create a new Workbook.
Workbook workbook = new Workbook();

WorksheetCollection worksheets = workbook.Worksheets;
Worksheet worksheet1 = worksheets[0];
Worksheet worksheet2 = worksheets.Add("Sheet2");
Worksheet worksheet3 = worksheets.Add("Sheet3");

//Move Sheets with in Workbook.
worksheet2.MoveTo(0);
worksheet1.MoveTo(1);
worksheet3.MoveTo(2);

//Save the excel file.
workbook.Save("../../data/AsposeMoveSheet.xls");
{{< /code >}}

## NPOI - HSSF XSSF - Reorder Worksheets

**C#**

{{< code lang="c#" >}}
IWorkbook wb = new XSSFWorkbook();
wb.CreateSheet("new sheet");
wb.CreateSheet("second sheet");
wb.CreateSheet("third sheet");

wb.SetSheetOrder("second sheet", 0);
wb.SetSheetOrder("new sheet", 1);
wb.SetSheetOrder("third sheet", 2);

FileStream sw = File.Create("../../data/Reordered.xls");
wb.Write(sw);
sw.Close();
{{< /code >}}

## Download Running Code

Download **Reorder Worksheets** form any of the below mentioned social coding sites:

*   [CodePlex](https://asposecellsnpoi.codeplex.com/downloads/get/1536888)
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/download/Aspose.Cells_Vs_NPOI_HWPF_and_XWPF_v1.2/ReOrder.WorkSheets.zip)

For more details, visit [Working with Worksheets](http://www.aspose.com/docs/display/cellsnet/Working+with+Worksheets).

