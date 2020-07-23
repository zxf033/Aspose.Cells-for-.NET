+++
title = "Wrapping Cell Text in VSTO and Aspose.Cells" 
description = "" 
weight = 16813 
+++

Aspose.Cells for .NET : Wrapping Cell Text in VSTO and Aspose.Cells  

# Aspose.Cells for .NET : Wrapping Cell Text in VSTO and Aspose.Cells


To create a worksheet with two cells, one with wrapped text and one without:

1.  Set up the worksheet:
    *   Create a workbook.
    *   Access the first worksheet.
2.  Add text:
    *   Add text to cell A1.
    *   Add wrapped text to cell A5.
3.  Save the spreadsheet.  
    The code samples below show how to perform these steps using VSTO with either C#. Code samples that show how to do the same thing using Aspose.Cells for .NET, again using either C# follow immediately after.

Running the code results in a spreadsheet with two cells, one that has text that hasn't been wrapped, and one that has:

### Output using VSTO Excel

![](download/thumbnails/5020836/684639929)

### Output using Aspose.Cells for .NET

![](download/thumbnails/5020836/1728440716)

### VSTO

{{< code lang="cs" >}}
//Access vsto application
Microsoft.Office.Interop.Excel.Application app = Globals.ThisAddIn.Application;

//Access workbook
Microsoft.Office.Interop.Excel.Workbook workbook = app.ActiveWorkbook;

//Access worksheet
Microsoft.Office.Interop.Excel.Worksheet m_sheet = workbook.Worksheets[1];

//Access vsto worksheet
Microsoft.Office.Tools.Excel.Worksheet sheet = Globals.Factory.GetVstoObject(m_sheet);

//Place some text in cell A1 without wrapping
Microsoft.Office.Interop.Excel.Range cellA1 = sheet.Cells.get_Range("A1");
cellA1.Value = "Sample Text Unwrapped";

//Place some text in cell A5 with wrapping
Microsoft.Office.Interop.Excel.Range cellA5 = sheet.Cells.get_Range("A5");
cellA5.Value = "Sample Text Wrapped";
cellA5.WrapText = true;

//Save the workbook
workbook.SaveAs("OutputVsto.xlsx");

//Quit the application
app.Quit();
{{< /code >}}

### Aspose.Cells

{{< code lang="cs" >}}
private static void WrappingCellText()
{
	//Create workbook
	Workbook workbook = new Workbook();

	//Access worksheet
	Worksheet worksheet = workbook.Worksheets[0];

	//Place some text in cell A1 without wrapping
	Cell cellA1 = worksheet.Cells["A1"];
	cellA1.PutValue("Some Text Unwrapped");

	//Place some text in cell A5 wrapping
	Cell cellA5 = worksheet.Cells["A5"];
	cellA5.PutValue("Some Text Wrapped");
	Style style = cellA5.GetStyle();
	style.IsTextWrapped = true;
	cellA5.SetStyle(style);

	//Autofit rows
	worksheet.AutoFitRows();

	//Save the workbook
	workbook.Save("OutputAspose.xlsx", SaveFormat.Xlsx);

}
{{< /code >}}

## Download Sample Code

*   [Codeplex](https://asposevsto.codeplex.com/downloads/get/1459782)
*   [Github](https://github.com/asposemarketplace/Aspose_for_VSTO/releases/download/Aspose.Cells1.1/Wrapping.Cell.Text.Aspose.Cells.zip)
*   [Sourceforge](https://sourceforge.net/projects/asposevsto/files/Aspose.Cells%20Vs%20VSTO%20Excel/Wrapping%20Cell%20Text%20(Aspose.Cells).zip/download)
*   [Bitbucket](https://bitbucket.org/asposemarketplace/aspose-for-vsto/downloads/Wrapping%20Cell%20Text%20(Aspose.Cells).zip)

## Attachments:

![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [Wrapping Cell Text-003.png](https://docs2.aspose.com/cells/net/attachments/5020836/5115085.png) (image/png)  
![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [Wrapping Cell Text-004.png](https://docs2.aspose.com/cells/net/attachments/5020836/5115086.png) (image/png)  

