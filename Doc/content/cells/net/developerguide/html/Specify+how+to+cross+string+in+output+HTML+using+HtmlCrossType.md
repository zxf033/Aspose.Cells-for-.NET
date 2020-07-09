+++
title = "Specify how to cross string in output HTML using HtmlCrossType" 
description = "" 
weight = 12114 
+++

Aspose.Cells for .NET : Specify how to cross string in output HTML using HtmlCrossType  

# Aspose.Cells for .NET : Specify how to cross string in output HTML using HtmlCrossType


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738031062 {padding: 0px;}div.rbtoc1590738031062 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738031062 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#SpecifyhowtocrossstringinoutputHTMLusingHtmlCrossType-PossibleUsageScenarios)
*   2 [Specify how to cross string in output HTML using HtmlCrossType](#SpecifyhowtocrossstringinoutputHTMLusingHtmlCrossType-SpecifyhowtocrossstringinoutputHTMLusingHtmlCrossType)
*   3 [Sample Code](#SpecifyhowtocrossstringinoutputHTMLusingHtmlCrossType-SampleCode)

 

## Possible Usage Scenarios

When cell contains text or string but it is larger than the width of the cell, then the string overflows if the next cell in next column is null or empty. When you save your Excel file into HTML, you can control this overflow by specifying the cross type using the `HtmlCrossType` enumeration. It has the following values

*   **HtmlCrossType.Default**

Display like MS Excel, depends on the next cell. If the next cell is null, the string will cross or it will be truncated.

*   **HtmlCrossType.MSExport**

Display the string like MS Excel exporting Html.

*   **HtmlCrossType.Cross**

Display HTML cross string, the performance for creating large html files will be more than ten times faster than setting the value to Deault or FitToCell.

*   **HtmlCrossType.FitToCell**

Only displaying the string within the width of cell.

## Specify how to cross string in output HTML using HtmlCrossType



## Sample Code

## Attachments:


