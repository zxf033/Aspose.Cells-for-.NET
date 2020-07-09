+++
title = "Handling Events after Deleting Columns and Rows in GridDesktop" 
description = "" 
weight = 16603 
+++

Aspose.Cells for .NET : Handling Events after Deleting Columns and Rows in GridDesktop  

# Aspose.Cells for .NET : Handling Events after Deleting Columns and Rows in GridDesktop


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738141536 {padding: 0px;}div.rbtoc1590738141536 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738141536 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#HandlingEventsafterDeletingColumnsandRowsinGridDesktop-PossibleUsageScenarios)
*   2 [Handling Events after Deleting Columns and Rows in GridDesktop](#HandlingEventsafterDeletingColumnsandRowsinGridDesktop-HandlingEventsafterDeletingColumnsandRowsinGridDesktop)
*   3 [Sample Code](#HandlingEventsafterDeletingColumnsandRowsinGridDesktop-SampleCode)

 

## Possible Usage Scenarios

`Aspose.Cells for GridDesktop` has added two new events i.e. `AfterDeleteColumns` and `AfterDeleteRows` as shown in the following screenshot. These events are fired when you delete columns and rows respectively.


## Handling Events after Deleting Columns and Rows in GridDesktop

The following sample code explains how to make use of `AfterDeleteColumns` and `AfterDeleteRows` events. Whenever you delete some columns or rows, the given function will be called and show a message box that displays the index of the deleted column or row.

## Sample Code

private void gridDesktop1\_AfterDeleteColumnsAndRows(object sender, Aspose.Cells.GridDesktop.WorksheetEventArgs args){    if(args.SheetEvents == Aspose.Cells.GridDesktop.WorksheetEvents.ColumnDeleted)    {        MessageBox.Show("Deleted Column Index: " + args.Index);    }    if (args.SheetEvents == Aspose.Cells.GridDesktop.WorksheetEvents.RowDeleted)    {        MessageBox.Show("Deleted Row Index: " + args.Index);    }}

## Attachments:


