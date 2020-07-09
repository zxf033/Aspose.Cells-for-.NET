+++
title = "Saving File to Response Object" 
description = "" 
weight = 12064 
+++

Aspose.Cells for .NET : Saving File to Response Object  

# Aspose.Cells for .NET : Saving File to Response Object


//<!\[CDATA\[function debug() { }// \]\]>//<!\[CDATA\[// \]\]>//<!\[CDATA\[// \]\]>//<!\[CDATA\[// \]\]>//<!\[CDATA\[// \]\]>//<!\[CDATA\[Cloak.closeHTML = "<img src=\\'/download/resources/net.customware.confluence.plugin.composition:toggle-cloak/img/navigate\_down\_10.gif\\'/>";Cloak.openHTML = "<img src=\\'/download/resources/net.customware.confluence.plugin.composition:toggle-cloak/img/navigate\_right\_10.gif\\'/>";Cloak.toggleZone = true;Cloak.memoryDuration = 0;Cloak.memoryPrefix = "contentId:5013528";Cloak.memoryPath = "/";// \]\]>.cloakToggle { /\* Definition for state toggling image \*/cursor:hand;cursor:pointer;}//<!\[CDATA\[// \]\]>//<!\[CDATA\[// \]\]>//<!\[CDATA\[Deck.memoryDuration = 0;Deck.memoryPrefix = "contentId:5013528";Deck.memoryPath = "/";// \]\]>

Aspose.Cells makes it possible to manipulate files. This article explains the various ways in which files can be saved to a response object.

**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738023635 {padding: 0px;}div.rbtoc1590738023635 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738023635 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Saving File to Response Object](#SavingFiletoResponseObject-SavingFiletoResponseObject)
    *   1.1 [XLS Files](#SavingFiletoResponseObject-XLSFiles)
    *   1.2 [XLSX Files](#SavingFiletoResponseObject-XLSXFiles)
    *   1.3 [PDF Files](#SavingFiletoResponseObject-PDFFiles)

 

## Saving File to Response Object

It is also possible to generate a file dynamically and send it directly to a client browser. In order to do so, use a special overloaded version of the [Save](https://apireference.aspose.com/net/cells/aspose.cells.workbook/save/methods/5) method that accepts the following parameters:

*   ASP.NET [HttpResponse](https://docs.microsoft.com/en-gb/dotnet/api/system.web.httpresponse?view=netframework-4.8) object.
*   File name.
*   [ContentDisposition](https://apireference.aspose.com/net/cells/aspose.cells/contentdisposition), the content-disposition type of the output file.
*   [SaveOptions](https://apireference.aspose.com/net/cells/aspose.cells/saveoptions), the file format type

The [ContentDisposition](https://apireference.aspose.com/net/cells/aspose.cells/contentdisposition) enumeration determines whether the file being sent to the browser provides the option to open by itself directly in the browser or in an application associated with .xls/.xlsx or another extension.

The enumeration contains the following pre-defined save types:

Type

Description

Attachment

Sends the spreadsheet to the browser and opens in an application as an attachment associated with .xls/.xlsx or other extensions

Inline

Sends the document to the browser and presents an option to save the spreadsheet to disk or open inside the browser

### XLS Files

### XLSX Files

### PDF Files

  
  

