+++
title = "Different Ways to Save Files" 
description = "" 
weight = 12063 
+++

Aspose.Cells for .NET : Different Ways to Save Files  

# Aspose.Cells for .NET : Different Ways to Save Files


//<!\[CDATA\[function debug() { }// \]\]>//<!\[CDATA\[// \]\]>//<!\[CDATA\[// \]\]>//<!\[CDATA\[// \]\]>//<!\[CDATA\[// \]\]>//<!\[CDATA\[Cloak.closeHTML = "<img src=\\'/download/resources/net.customware.confluence.plugin.composition:toggle-cloak/img/navigate\_down\_10.gif\\'/>";Cloak.openHTML = "<img src=\\'/download/resources/net.customware.confluence.plugin.composition:toggle-cloak/img/navigate\_right\_10.gif\\'/>";Cloak.toggleZone = true;Cloak.memoryDuration = 0;Cloak.memoryPrefix = "contentId:5013527";Cloak.memoryPath = "/";// \]\]>.cloakToggle { /\* Definition for state toggling image \*/cursor:hand;cursor:pointer;}//<!\[CDATA\[// \]\]>//<!\[CDATA\[// \]\]>//<!\[CDATA\[Deck.memoryDuration = 0;Deck.memoryPrefix = "contentId:5013527";Deck.memoryPath = "/";// \]\]>

Aspose.Cells makes it possible to create and save files. This article explains the various ways in which files can be saved.

**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738023613 {padding: 0px;}div.rbtoc1590738023613 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738023613 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Different Ways to Save Files](#DifferentWaystoSaveFiles-DifferentWaystoSaveFiles)
*   2 [Saving File to Some Location](#DifferentWaystoSaveFiles-SavingFiletoSomeLocation)
*   3 [Saving Workbook to Text or CSV Format](#DifferentWaystoSaveFiles-SavingWorkbooktoTextorCSVFormat)
*   4 [Saving Text Files with Custom Separator](#DifferentWaystoSaveFiles-SavingTextFileswithCustomSeparator)
*   5 [Saving File to a Stream](#DifferentWaystoSaveFiles-SavingFiletoaStream)

 

## Different Ways to Save Files

Aspose.Cells provides the [Workbook](https://apireference.aspose.com/net/cells/aspose.cells/workbook) which represents a Microsoft Excel file and provides the properties and methods necessary to work with Excel files. The [Workbook](https://apireference.aspose.com/net/cells/aspose.cells/workbook) class provides the [Save](https://apireference.aspose.com/net/cells/aspose.cells/workbook/methods/save/index) method used to save Excel files. The [Save](https://apireference.aspose.com/net/cells/aspose.cells/workbook/methods/save/index) method has many overloads that are used to save files in different ways.

The file format that the file is saved to is decided by the [SaveFormat](https://apireference.aspose.com/net/cells/aspose.cells/saveformat) enumeration

File Format Types

Description

CSV

Represents a CSV file

Excel97To2003

Represents an Excel 97 - 2003 file

Xlsx

Represents an Excel 2007 XLSX file

Xlsm

Represents an Excel 2007 XLSM file

Xltx

Represents an Excel 2007 template XLTX file

Xltm

Represents an Excel 2007 macro-enabled XLTM file

Xlsb

Represents an Excel 2007 binary XLSB file

SpreadsheetML

Represents a Spreadsheet XML file

TSV

Represents a Tab-separated values file

TabDelimited

Represents a Tab Delimited text file

ODS

Represents an ODS file

Html

Represents HTML file(s)

MHtml

Represents an MHTML file(s)

Pdf

Represents a PDF file

XPS

Represents an XPS document

TIFF

Represents Tagged Image File Format (TIFF)

## Saving File to Some Location

To save files to a storage location, specify the file name (complete with storage path) and the desired file format (from the [SaveFormat](https://apireference.aspose.com/net/cells/aspose.cells/saveformat) enumeration) when calling the [Workbook](https://apireference.aspose.com/net/cells/aspose.cells/workbook) object's [Save](https://apireference.aspose.com/net/cells/aspose.cells/workbook/methods/save/index) method.

## Saving Workbook to Text or CSV Format

Sometimes, you want to convert or save a workbook with multiple worksheets into text format. For text formats (for example TXT, TabDelim, CSV, etc.), by default both Microsoft Excel and Aspose.Cells save the contents of the active worksheet only.

The following code example explains how to save an entire workbook into text format. Load the source workbook which could be any Microsoft Excel or OpenOffice spreadsheet file (so XLS, XLSX, XLSM, XLSB, ODS and so on) with any number of worksheets.

When the code is executed, it converts the data of all sheets in the workbook to the TXT format.

You can modify the same example to save your file to CSV. By default, [TxtSaveOptions.Separator](https://apireference.aspose.com/net/cells/aspose.cells/txtsaveoptions/properties/separator) is comma, so do not specify a separator if saving to CSV format.

## Saving Text Files with Custom Separator

Text files contain spreadsheet data without formatting. The file is a kind of plain text file that can have some customized delimiters between its data.

## Saving File to a Stream

To save files to a stream, create a *MemoryStream *or *FileStream *object and save the file to that stream object by calling the [Workbook](https://apireference.aspose.com/net/cells/aspose.cells/workbook) object's [Save](https://apireference.aspose.com/net/cells/aspose.cells/workbook/methods/save/index) method. Specify the desired file format using the [SaveFormat](https://apireference.aspose.com/net/cells/aspose.cells/saveformat) enumeration when calling the [Save](https://apireference.aspose.com/net/cells/aspose.cells/workbook/methods/save/index) method.

