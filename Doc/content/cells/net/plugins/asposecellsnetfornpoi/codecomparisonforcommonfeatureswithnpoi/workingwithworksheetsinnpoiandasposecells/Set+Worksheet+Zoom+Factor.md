+++
title = "Set Worksheet Zoom Factor" 
description = "" 
weight = 20935 
+++

Aspose.Cells for .NET : Set Worksheet Zoom Factor  

# Aspose.Cells for .NET : Set Worksheet Zoom Factor


## Aspose.Cells - Set Worksheet Zoom Factor

**C#**

//Instantiating a Workbook objectWorkbook workbook = new Workbook();//Adding a new worksheet to the Workbook objectWorksheetCollection worksheets = workbook.Worksheets;Worksheet worksheet = worksheets.Add("My Worksheet");worksheet.Zoom = 75;//Saving the Excel fileworkbook.Save("../../data/newWorksheet.xls");

## NPOI - HSSF XSSF - Set Worksheet Zoom Factor

**C#**

IWorkbook wb = new XSSFWorkbook();ISheet sheet1 = wb.CreateSheet("First Sheet");sheet1.SetZoom(3, 4); // 75 percentFileStream sw = File.Create("../../data/newWorksheet.xls");wb.Write(sw);sw.Close();

## Download Running Code

Download **Set Worksheet Zoom Factor** form any of the below mentioned social coding sites:

*   [CodePlex](https://asposecellsnpoi.codeplex.com/downloads/get/1536892)
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/download/Aspose.Cells_Vs_NPOI_HWPF_and_XWPF_v1.2/Zoom.Factor.zip)

For more details, visit [Working with Worksheets](http://www.aspose.com/docs/display/cellsnet/Working+with+Worksheets).

