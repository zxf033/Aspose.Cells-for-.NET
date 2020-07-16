+++
title = "Copy a Worksheet" 
description = "" 
weight = 16687 
+++

Aspose.Cells for .NET : Copy a Worksheet  

# Aspose.Cells for .NET : Copy a Worksheet


[Add Worksheets](http://localhost:1313/cellsnet/developerguide/asposecellsgridweb/workingwithgridwebworksheets/add+worksheets) describes how to add new worksheets to Aspose.Cells.GridWeb. It's also possible to add a copy (or replica) of another worksheet to the Aspose.Cells.GridWeb control. This feature can be useful when identical or similar data in one worksheet is also required in another worksheet. When that's the case, it's easier to copy an existing worksheet and add it to Aspose.Cells.GridWeb as a new worksheet instead of creating it from scratch.

**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738160234 {padding: 0px;}div.rbtoc1590738160234 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738160234 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Copying a Worksheet](#CopyaWorksheet-CopyingaWorksheet)
    *   1.1 [Using Sheet index](#CopyaWorksheet-UsingSheetindex)
    *   1.2 [Using Sheet Name](#CopyaWorksheet-UsingSheetName)

 

## Copying a Worksheet

### Using Sheet index

The example code below shows how to add a copy of a worksheet to the GridWeb control by specifying the worksheet's index in the `GridWorksheetCollection`'s `AddCopy` method.

### Using Sheet Name

The example code below shows how to add a copy of a worksheet to the GridWeb control by specifying the worksheet's name in the `GridWorksheetCollection`'s `AddCopy` method.

The `AddCopy` method returns the newly added worksheet's index which can be used to access the worksheet instance. For more details on how to access worksheets, read [Access Worksheets](http://localhost:1313/cellsnet/developerguide/asposecellsgridweb/workingwithgridwebworksheets/access+worksheets).

