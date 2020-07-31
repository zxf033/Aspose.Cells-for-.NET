---
title : "Set External Links in Formulas in Aspose.Cells" 
description : "" 
weight : 16887 
toc : false
type: docs
url: /net/plugins/openxml/missingfeaturesinopenxml/set+external+links+in+formulas+in+aspose.cells/
---

# Aspose.Cells for .NET : Set External Links in Formulas in Aspose.Cells


Sometimes, it is necessary to include links to external files in formulas, for example to evaluate a cell or range value against them. Aspose.Cells provides this feature and this document explains how to use it.

The sample code below shows how to include external files in formulas.

**C#**

string FilePath = @"..\\..\\..\\Sample Files\\";string FileName = FilePath + "Set External Links in Formula.xlsx";//Instantiate a new Workbook.Workbook workbook = new Workbook();//Get first WorksheetWorksheet sheet = workbook.Worksheets\[0\];//Get Cells collectionAspose.Cells.Cells cells = sheet.Cells;//Set formula with external linkscells\["A1"\].Formula = "=SUM('\[book1.xls\]Sheet1'!A2, '\[book1.xls\]Sheet1'!A4)";//Set formula with external linkscells\["A2"\].Formula = "='\[book1.xls\]Sheet1'!A8";//Save the workbookworkbook.Save(FileName);

### Download Sample Code

*   [Codeplex](https://asposeopenxml.codeplex.com/SourceControl/latest#Aspose.Cells Features missing in OpenXML/Set External Links in Formula/)
*   [Github](https://github.com/aspose-cells/Aspose.Cells-for-.NET/tree/master/Plugins/Aspose.Cells%20Vs%20OpenXML%20Spreadsheets/OpenXML%20Missing%20Features/Set%20External%20Links%20in%20Formula)
*   [Code.MSDN](https://code.msdn.microsoft.com/AsposeCells-Features-8fba7c3c/view/SourceCode#content)

### Download Running Example

*   [Codeplex](https://asposecellsopenxml.codeplex.com/releases/view/619160)
*   [Github](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/tag/MissingFeaturesOpenXMLExcelv1.1)
*   [Code.MSDN](https://code.msdn.microsoft.com/AsposeCells-Features-8fba7c3c)

