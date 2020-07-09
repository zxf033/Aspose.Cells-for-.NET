+++
title = "Adding or Inserting a Column into Worksheet" 
description = "" 
weight = 16624 
+++

Aspose.Cells for .NET : Adding or Inserting a Column into Worksheet  

# Aspose.Cells for .NET : Adding or Inserting a Column into Worksheet


In this topic, we will describe the basic feature of adding and inserting columns to the worksheets at runtime using the API of Aspose.Cells.GridDesktop. The basic difference between addition and insertion is that in addition, column is added at the end of the columns collection of the worksheet where as in insertion, column can be added to any specified position in the worksheet.

**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738144956 {padding: 0px;}div.rbtoc1590738144956 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738144956 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Adding a Column to Worksheet](#AddingorInsertingaColumnintoWorksheet-AddingaColumntoWorksheet)
*   2 [Inserting a Column into Worksheet](#AddingorInsertingaColumnintoWorksheet-InsertingaColumnintoWorksheet)

 

 

## Adding a Column to Worksheet

To add a new column to the worksheet, please follow the steps below:

*   Add Aspose.Cells.GridDesktop control to your **Form**
*   Access any desired **Worksheet**
*   Add **Column** to the **Worksheet**

## Inserting a Column into Worksheet

To insert a new column into worksheet at a specified position, please follow the steps below:

*   Add Aspose.Cells.GridDesktop control to your **Form**
*   Access any desired **Worksheet**
*   Insert **Column** into **Worksheet** (at a specific position by specifying the index of the column where to insert it)

// Accessing first worksheet of the GridAspose.Cells.GridDesktop.Worksheet sheet = gridDesktop1.Worksheets\[0\];// Inserting column to the worksheet to the first position.sheet.Cells.InsertColumn(0);

