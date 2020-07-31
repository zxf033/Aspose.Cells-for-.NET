---
title : "Rotating Cell Text in VSTO and Aspose.Cells" 
description : "" 
weight : 16809 
toc : false
type: docs
url: /net/plugins/vsto/codeinvsto/rotating+cell+text+in+vsto+and+aspose.cells/
---

# Aspose.Cells for .NET : Rotating Cell Text in VSTO and Aspose.Cells


To rotate text in a cell on a worksheet, take the following steps:

1.  Create a workbook and get a worksheet.
2.  Add samples text.
3.  Format the text: rotate, add background colour.
4.  Save the file.  
    The code samples that follow show how to perform these steps first in VSTO, using either C#, and then in Aspose.Cells, again using either C#.

### VSTO

{{< code lang="cs" >}}
//intiate Application object
Excel.Application ExcelApp = Application;
//Add a Workbook.
Excel.Workbook objBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);

//Get the First sheet.
Excel.Worksheet objSheet = (Excel.Worksheet)objBook.Sheets["Sheet1"];

//Put some text into cell B2.
objSheet.Cells[2, 2] = "Aspose Heading";

//Define a range object(B2).
Excel.Range _range;
_range = objSheet.get_Range("B2", "B2");

//Specify the angle of rotation of the text.
_range.Orientation = 45;

//Set the background color.
_range.Interior.Color = System.Drawing.ColorTranslator.ToWin32(Color.FromArgb(0, 51, 105));

//Set the font color of cell text
_range.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);

//Save the excel file.
objBook.SaveCopyAs("VSTO_RotateText_test.xlsx");

//Quit the Application.
ExcelApp.Quit();
{{< /code >}}

### Aspose.Cells

{{< code lang="cs" >}}
// Instantiate a new Workbook.
Workbook objworkbook = new Workbook();
// Get the First sheet.
Worksheet objworksheet = objworkbook.Worksheets[0];
// Get Cells.
Cells objcells = objworksheet.Cells;// Get a particular Cell.
Cell objcell = objcells["B2"];// Put some text value.
objcell.PutValue("Aspose Heading");

// Get associated style object of the cell.
Style objstyle = objcell.GetStyle();

// Specify the angle of rotation of the text.
objstyle.RotationAngle = 45;

// Set the custom fill color of the cells.
objstyle.ForegroundColor = Color.FromArgb(0, 51, 105);

// Set the background pattern for fillment color.
objstyle.Pattern = BackgroundType.Solid;

// Set the font color of cell text
objstyle.Font.Color = Color.White;

// Assign the updated style object back to the cell
objcell.SetStyle(objstyle);

// Save the work book
objworkbook.Save("RotateText_test.xlsx");
{{< /code >}}

## Download Sample Code

*   [Codeplex](https://asposevsto.codeplex.com/downloads/get/1459786)
*   [Github](https://github.com/asposemarketplace/Aspose_for_VSTO/releases/download/Aspose.Cells1.1/Rotating.Cell.Text.Aspose.Cells.zip)
*   [Sourceforge](https://sourceforge.net/projects/asposevsto/files/Aspose.Cells%20Vs%20VSTO%20Excel/Rotating%20Cell%20Text%20(Aspose.Cells).zip/download)
*   [Bitbucket](https://bitbucket.org/asposemarketplace/aspose-for-vsto/downloads/Rotating%20Cell%20Text%20(Aspose.Cells).zip)

