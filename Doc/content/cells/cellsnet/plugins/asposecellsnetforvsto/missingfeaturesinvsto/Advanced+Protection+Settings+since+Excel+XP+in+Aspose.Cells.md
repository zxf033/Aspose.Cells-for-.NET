+++
title = "Advanced Protection Settings since Excel XP in Aspose.Cells" 
description = "" 
weight = 16816 
+++

Aspose.Cells for .NET : Advanced Protection Settings since Excel XP in Aspose.Cells  

# Aspose.Cells for .NET : Advanced Protection Settings since Excel XP in Aspose.Cells


*   Delete rows or columns.
*   Edit contents, objects or scenarios.
*   Format cells, rows or columns.
*   Insert rows, columns or hyperlinks.
*   Select locked or unlocked cells.
*   Use pivot tables and much more.

Aspose.Cells supports all the advanced protection settings offered by Excel XP or later versions.

### Advanced Protection Settings Using Excel XP and Later Versions

To view the protection settings available in Excel XP:

1.  From the **Tools** menu, select **Protection** followed by **Protect Sheet**.  
    A dialog is displayed.  
      
    **Dialog to show protection options in Excel XP**  
2.  Allow or restrict worksheets features or apply a password.

#### Advanced Protection Settings Using Aspose.Cells

Aspose.Cells support all of the advanced protection settings.

Aspose.Cells provides a class, [`Workbook`](/pages/createpage.action?spaceKey=cellsnet&title=Aspose.Cells.Workbook+class&linkCreation=true&fromPageId=5020675), that represents a Microsoft Excel file. The `Workbook` class contains a `Worksheets` collection that allows access to each worksheet in the Excel file. A worksheet is represented by the [`Worksheet`](/pages/createpage.action?spaceKey=cellsnet&title=Aspose.Cells.Worksheet+class&linkCreation=true&fromPageId=5020675) class.

The `Worksheet` class provides the `Protection` property that is used to apply these advanced protection settings. The `Protection` property is in fact an object of the [`Protection`](/pages/createpage.action?spaceKey=cellsnet&title=Aspose.Cells.Protection+class&linkCreation=true&fromPageId=5020675) class that encapsulates several Boolean properties for disabling or enabling restrictions.

Below is a small example application. It opens an Excel file and uses most of the advanced protection settings supported by Excel XP and later versions.

**C#**

//Creating a file stream containing the Excel file to be openedFileStream fstream = new FileStream("book1.xls", FileMode.Open);//Instantiating a Workbook object//Opening the Excel file through the file streamWorkbook excel = new Workbook(fstream);//Accessing the first worksheet in the Excel fileWorksheet worksheet = excel.Worksheets\[0\];//Restricting users to delete columns of the worksheetworksheet.Protection.AllowDeletingColumn = false;//Restricting users to delete row of the worksheetworksheet.Protection.AllowDeletingRow = false;//Restricting users to edit contents of the worksheetworksheet.Protection.AllowEditingContent = false;//Restricting users to edit objects of the worksheetworksheet.Protection.AllowEditingObject = false;//Restricting users to edit scenarios of the worksheetworksheet.Protection.AllowEditingScenario = false;//Restricting users to filterworksheet.Protection.AllowFiltering = false;//Allowing users to format cells of the worksheetworksheet.Protection.AllowFormattingCell = true;//Allowing users to format rows of the worksheetworksheet.Protection.AllowFormattingRow = true;//Allowing users to insert columns in the worksheetworksheet.Protection.AllowFormattingColumn = true;//Allowing users to insert hyperlinks in the worksheetworksheet.Protection.AllowInsertingHyperlink = true;//Allowing users to insert rows in the worksheetworksheet.Protection.AllowInsertingRow = true;//Allowing users to select locked cells of the worksheetworksheet.Protection.AllowSelectingLockedCell = true;//Allowing users to select unlocked cells of the worksheetworksheet.Protection.AllowSelectingUnlockedCell = true;//Allowing users to sortworksheet.Protection.AllowSorting = true;//Allowing users to use pivot tables in the worksheetworksheet.Protection.AllowUsingPivotTable = true;//Saving the modified Excel fileexcel.Save("output.xls", SaveFormat.Excel97To2003);//Closing the file stream to free all resourcesfstream.Close(); 

## Download Running Code

*   [CodePlex](https://asposecellsnet.codeplex.com/SourceControl/latest#Plugins/Aspose For VSTO/Aspose.Cells Features missing in VSTO/Advanced Protection Settings/)
*   [CodePlex](https://asposevsto.codeplex.com/SourceControl/latest#Aspose Only features Unavailable in VSTO/Aspose.Cells/Advanced Protection Settings/)
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/tree/master/Plugins/Aspose.Cells%20Vs%20VSTO%20Spreadsheets/Aspose.Cells%20Features%20missing%20in%20VSTO/Advanced%20Protection%20Settings)
*   [Code.MSDN](https://code.msdn.microsoft.com/Missing-features-in-VSTO-ac9ea836/view/SourceCode#content)

## Download Sample Code

*   [CodePlex](https://asposecellsnet.codeplex.com/releases/view/618484)
*   [CodePlex](https://asposevsto.codeplex.com/releases/view/618289)
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/tag/MissingFeaturesAsposeCellsForVSTO1.1)
*   [Code.MSDN](https://code.msdn.microsoft.com/Missing-features-in-VSTO-ac9ea836#content)

## Attachments:


