+++
title = "Add Worksheets" 
description = "" 
weight = 16684 
+++

Aspose.Cells for .NET : Add Worksheets  

# Aspose.Cells for .NET : Add Worksheets


Worksheets are an integral part of Aspose.Cells.GridWeb. All data is managed and stored in the form of worksheets. Aspose.Cells.GridWeb allows developers to add one or more worksheets to the Aspose.Cells.GridWeb control. This topic shows simple approaches to adding worksheets to Aspose.Cells.GridWeb.

**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738159945 {padding: 0px;}div.rbtoc1590738159945 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738159945 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Adding a Worksheet](#AddWorksheets-AddingaWorksheet)
    *   1.1 [Without Specifying Sheet Name](#AddWorksheets-WithoutSpecifyingSheetName)
    *   1.2 [With Specified Sheet Name](#AddWorksheets-WithSpecifiedSheetName)

 

## Adding a Worksheet

### Without Specifying Sheet Name

The simplest way to add a worksheet to Aspose.Cells.GridWeb is to call the `GridWorksheetCollection` collection's `Add` method in the GridWeb control. This creates worksheets that use default names (that is Sheet1, Sheet2, Sheet3 and so on) and adds them to the GridWeb control.

**Output: a worksheet with default name has been added to GridWeb**  

The `Add` method returns the new worksheet's index which can be used to access the instance of this worksheet. For more details on how to access worksheets, read [Access Worksheets](http://localhost:1313/cellsnet/developerguide/asposecellsgridweb/workingwithgridwebworksheets/access+worksheets).

### With Specified Sheet Name

To add a worksheet with a specific name to the GridWeb control instead of using the default naming scheme, call an overloaded version of the `Add` method that takes the specified `SheetName`. For an instance, the example below adds a worksheet named Invoice.

**Output: a worksheet with a specified name has been added to GridWeb**  

The `Add` method accepting the worksheet name as string returns an instance of `GridWorksheet`.

## Attachments:


