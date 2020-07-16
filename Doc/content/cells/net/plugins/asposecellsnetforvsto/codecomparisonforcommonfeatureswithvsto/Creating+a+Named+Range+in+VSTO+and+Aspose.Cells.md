+++
title = "Creating a Named Range in VSTO and Aspose.Cells" 
description = "" 
weight = 16797 
+++

Aspose.Cells for .NET : Creating a Named Range in VSTO and Aspose.Cells  

# Aspose.Cells for .NET : Creating a Named Range in VSTO and Aspose.Cells


To create a named range:

1.  Set up the worksheet:
    *   Instantiate an Application object.(VSTO only.)
    *   Add a Workbook.
    *   Get the first sheet.
2.  Create a named range:
    *   Define a range.
    *   Name the range.
    *   Save the file.

The code examples below show how to perform these steps using VSTO with either C#. The code examples that follow show how to do the same thing using Aspose.Cells for .NET, again with either C#.

### VSTO

//Create Excel ObjectExcel.Application xl = Application;//Create a new WorkbookExcel.Workbook wb = xl.Workbooks.Add(Missing.Value);//Get Worksheets CollectionExcel.Sheets xlsheets = wb.Sheets;//Select the first sheetExcel.Worksheet excelWorksheet = (Excel.Worksheet)xlsheets\[1\];//Select a range of cellsExcel.Range range = (Excel.Range)excelWorksheet.get\_Range("A1:B4", Type.Missing);//Add Name to Rangerange.Name = "Test\_Range";//Put data in range cellsforeach (Excel.Range cell in range.Cells){	cell.set\_Value(Missing.Value, "Test");}//Save New Workbookwb.SaveCopyAs("Test\_Range.xls");//Quit Excel Objectxl.Quit();

### Aspose.Cells

//Instantiating a Workbook objectWorkbook workbook = new Workbook();//Accessing the first worksheet in the Excel fileWorksheet worksheet = workbook.Worksheets\[0\];//Creating a named rangeRange range = worksheet.Cells.CreateRange("A1", "B4");//Setting the name of the named rangerange.Name = "Test\_Range";for (int row = 0; row < range.RowCount; row++){	for (int column = 0; column < range.ColumnCount; column++)	{		range\[row, column\].PutValue("Test");	}}//Saving the modified Excel file in default (that is Excel 2003) formatworkbook.Save("Test\_Range.xls");

## Download Sample Code

*   [Codeplex](https://asposevsto.codeplex.com/downloads/get/1459777)
*   [Github](https://github.com/asposemarketplace/Aspose_for_VSTO/releases/download/Aspose.Cells1.1/Creating.a.Named.Range.Aspose.Cells.zip)
*   [Sourceforge](https://sourceforge.net/projects/asposevsto/files/Aspose.Cells%20Vs%20VSTO%20Excel/Creating%20a%20Named%20Range%20(Aspose.Cells).zip/download)
*   [Bitbucket](https://bitbucket.org/asposemarketplace/aspose-for-vsto/downloads/Creating%20a%20Named%20Range%20(Aspose.Cells).zip)

