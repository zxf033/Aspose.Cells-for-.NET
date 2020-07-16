+++
title = "Change Data Source of the Chart to Destination Worksheet while Copying Rows or Range" 
description = "" 
weight = 20465 
+++

Aspose.Cells for .NET : Change Data Source of the Chart to Destination Worksheet while Copying Rows or Range  

# Aspose.Cells for .NET : Change Data Source of the Chart to Destination Worksheet while Copying Rows or Range


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738113601 {padding: 0px;}div.rbtoc1590738113601 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738113601 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#ChangeDataSourceoftheCharttoDestinationWorksheetwhileCopyingRowsorRange-PossibleUsageScenarios)
*   2 [Change Data Source of the Chart to Destination Worksheet while Copying Rows or Range](#ChangeDataSourceoftheCharttoDestinationWorksheetwhileCopyingRowsorRange-ChangeDataSourceoftheCharttoDestinationWorksheetwhileCopyingRowsorRange)

 

 

## Possible Usage Scenarios

When you copy rows or range which contains charts to a new worksheet, then the data source of the chart does not change. For example, if the data source of chart is `=Sheet1!$A$1:$B$4`, then after copying rows or range to new worksheet, the data source will remain the same i.e `=Sheet1!$A$1:$B$4`. It still refers to old worksheet i.e. `Sheet1`. This is also the behavior in Microsoft Excel. But if you want that it to refer to the new destination worksheet, then please use the [CopyOptions.ReferToDestinationSheet](https://apireference.aspose.com/net/cells/aspose.cells/copyoptions/properties/refertodestinationsheet) property and set it to **true **while calling the [Cells.CopyRows()](https://apireference.aspose.com/net/cells/aspose.cells/cells/methods/copyrows/index) method. Now if your destination worksheet is `DestSheet`, then the data source of your chart will change from `=Sheet1!$A$1:$B$4` to `=DestSheet!$A$1:$B$4`.

## Change Data Source of the Chart to Destination Worksheet while Copying Rows or Range



## Attachments:


