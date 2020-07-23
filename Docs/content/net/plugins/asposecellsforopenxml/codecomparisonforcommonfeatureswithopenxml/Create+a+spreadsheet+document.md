+++
title = "Create a spreadsheet document" 
description = "" 
weight = 16846 
+++

Aspose.Cells for .NET : Create a spreadsheet document  

# Aspose.Cells for .NET : Create a spreadsheet document


## OpenXML Excel

string FilePath = @"..\\..\\..\\..\\Sample Files\\";string FileName = FilePath + "Create a spreadsheet document.xlsx";CreateSpreadsheetWorkbook(FileName);private static void CreateSpreadsheetWorkbook(string filepath){    // Create a spreadsheet document by supplying the filepath.    // By default, AutoSave = true, Editable = true, and Type = xlsx.    SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.        Create(filepath, SpreadsheetDocumentType.Workbook);    // Add a WorkbookPart to the document.    WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart();    workbookpart.Workbook = new Workbook();    // Add a WorksheetPart to the WorkbookPart.    WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();    worksheetPart.Worksheet = new Worksheet(new SheetData());    // Add Sheets to the Workbook.    Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.        AppendChild<Sheets>(new Sheets());    // Append a new worksheet and associate it with the workbook.    Sheet sheet = new Sheet()    {        Id = spreadsheetDocument.WorkbookPart.            GetIdOfPart(worksheetPart),        SheetId = 1,        Name = "mySheet"    };    sheets.Append(sheet);    workbookpart.Workbook.Save();    // Close the document.    spreadsheetDocument.Close();}}

## Aspose.Cells

string FilePath = @"..\\..\\..\\..\\Sample Files\\";string FileName = FilePath + "Create a spreadsheet document.xlsx";CreateSpreadsheetWorkbook(FileName);private static void CreateSpreadsheetWorkbook(string filepath){    //Instantiating a Workbook object    Workbook workbook = new Workbook();    //Adding a new worksheet to the Excel object    Worksheet worksheet = workbook.Worksheets.Add("MySheet");    //Saving the Excel file    workbook.Save(filepath);}

## Download Sample Code

*   [CodePlex](https://asposeopenxml.codeplex.com/releases/view/616479)
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/tag/AsposeCellsVsOpenXMLv1.1)
*   [Sourceforge](https://sourceforge.net/projects/asposeopenxml/files/Aspose.Cells%20Vs%20OpenXML/Create%20a%20spreadsheet%20document%20(Aspose.Cells).zip/download)
*   [Bitbucket](https://bitbucket.org/asposemarketplace/aspose-for-openxml/downloads/Create%20a%20spreadsheet%20document%20(Aspose.Cells).zip)

