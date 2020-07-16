+++
title = "Working with Headers and Footers" 
description = "" 
weight = 20938 
+++

Aspose.Cells for .NET : Working with Headers and Footers  

# Aspose.Cells for .NET : Working with Headers and Footers


## Aspose.Cells - Working with Headers and Footers

**C#**

//Instantiating a Workbook objectWorkbook workbook = new Workbook();//Adding a new worksheet to the Workbook objectWorksheetCollection worksheets = workbook.Worksheets;Worksheet worksheet = worksheets.Add("My Worksheet");//Obtaining the reference of the PageSetup of the worksheetPageSetup pageSetup = worksheet.PageSetup;//Setting worksheet name at the left  headerpageSetup.SetHeader(0, "&A");//Setting current date and current time at the central header//and changing the font of the headerpageSetup.SetHeader(1, "&\\"Times New Roman,Bold\\"&D-&T");//Setting current file name at the right header and changing the font of the headerpageSetup.SetHeader(2, "&\\"Times New Roman,Bold\\"&12&F");//Setting a string at the left footer and changing the font of the footerpageSetup.SetFooter(0, "Hello World! &\\"Courier New\\"&14 123");//Setting picture at the central footerpageSetup.SetFooter(1, "&G");workbook.Save("../../data/headerfooter.xlsx");

## NPOI - HSSF XSSF - Working with Headers and Footers

**C#**

IWorkbook wb = new XSSFWorkbook();ISheet sheet1 = wb.CreateSheet("First Sheet");IHeader header = sheet1.Header;header.Center = "Center Header";header.Left = "Left Header";header.Right = "Right Header";            FileStream sw = File.Create("../../data/header.xls");wb.Write(sw);sw.Close(); 

## Download Running Code

Download **Working with Headers and Footers** form any of the below mentioned social coding sites:

*   [CodePlex](https://aspose-cellsnpoi.codeplex.com/downloads/get/1536887)
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/download/Aspose.Cells_Vs_NPOI_HWPF_and_XWPF_v1.2/Headers.and.Footers.zip)

For more details, visit [Working with Worksheets](http://www.aspose.com/docs/display/cellsnet/Working+with+Worksheets).

