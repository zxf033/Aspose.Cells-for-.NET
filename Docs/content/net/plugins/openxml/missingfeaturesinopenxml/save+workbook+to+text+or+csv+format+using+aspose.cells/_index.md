---
title : "Save Workbook to Text or CSV Format using Aspose.Cells" 
description : "" 
weight : 16886 
toc : false
type: docs
url: /net/plugins/openxml/missingfeaturesinopenxml/save+workbook+to+text+or+csv+format+using+aspose.cells/
---

# Aspose.Cells for .NET : Save Workbook to Text or CSV Format using Aspose.Cells


Sometimes, you want to convert or save a workbook with multiple worksheets into text format. For text formats (for example TXT, TabDelim, CSV etc.), by default both Microsoft Excel and Aspose.Cells save the contents of the active worksheet only.

The following code example explains how to save an entire workbook into text format. Load the source workbook which could be any Microsoft Excel or OpenOffice spreadsheet file (so XLS, XLSX, XLSM, XLSB, ODS and so on) with any number of worksheets.

When the code is executed, it converts the data of all sheets in the workbook to TXT format.

You can modify the same example to save your file to CSV. By default, `TxtSaveOptions.Separator` is comma, so do not specify a separator if saving to CSV format.

**C#**

string FilePath = @"..\\..\\..\\Sample Files\\";string FileName = FilePath + "Save Workbook to Text or CSV Format.xlsx";string destFileName = FilePath + "Save Workbook to Text or CSV Format.txt";//Load your source workbookWorkbook workbook = new Workbook(FileName);//0-byte arraybyte\[\] workbookData = new byte\[0\];//Text save options. You can use any type of separatorTxtSaveOptions opts = new TxtSaveOptions();opts.Separator = '\\t';//Copy each worksheet data in text format inside workbook data arrayfor (int idx = 0; idx < workbook.Worksheets.Count; idx++){    //Save the active worksheet into text format    MemoryStream ms = new MemoryStream();    workbook.Worksheets.ActiveSheetIndex = idx;    workbook.Save(ms, opts);    //Save the worksheet data into sheet data array    ms.Position = 0;    byte\[\] sheetData = ms.ToArray();    //Combine this worksheet data into workbook data array    byte\[\] combinedArray = new byte\[workbookData.Length + sheetData.Length\];    Array.Copy(workbookData, 0, combinedArray, 0, workbookData.Length);    Array.Copy(sheetData, 0, combinedArray, workbookData.Length, sheetData.Length);    workbookData = combinedArray;}//Save entire workbook data into fileFile.WriteAllBytes(destFileName, workbookData);

### Download Sample Code

*   [Codeplex](https://asposeopenxml.codeplex.com/SourceControl/latest#Aspose.Cells Features missing in OpenXML/Save Workbook to Text or CSV Format/)
*   [Github](https://github.com/aspose-cells/Aspose.Cells-for-.NET/tree/master/Plugins/Aspose.Cells%20Vs%20OpenXML%20Spreadsheets/OpenXML%20Missing%20Features/Save%20Workbook%20to%20Text%20or%20CSV%20Format)
*   [Code.MSDN](https://code.msdn.microsoft.com/AsposeCells-Features-8fba7c3c/view/SourceCode#content)

### Download Running Example

*   [Codeplex](https://asposecellsopenxml.codeplex.com/releases/view/619160)
*   [Github](https://github.com/asposecells/Aspose.Cells-for-.NET/releases/tag/MissingFeaturesOpenXMLExcelv1.1)
*   [Code.MSDN](https://code.msdn.microsoft.com/AsposeCells-Features-8fba7c3c)

