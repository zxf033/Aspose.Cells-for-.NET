+++
title = "Specify how to cross string in output HTML using HtmlCrossType" 
description = "" 
weight = 12114 
+++

Aspose.Cells for .NET : Specify how to cross string in output HTML using HtmlCrossType  

# Aspose.Cells for .NET : Specify how to cross string in output HTML using HtmlCrossType


{{< panel title="Contents Summary" style="primary" >}}
*   1 [Possible Usage Scenarios](#SpecifyhowtocrossstringinoutputHTMLusingHtmlCrossType-PossibleUsageScenarios)
*   2 [Specify how to cross string in output HTML using HtmlCrossType](#SpecifyhowtocrossstringinoutputHTMLusingHtmlCrossType-SpecifyhowtocrossstringinoutputHTMLusingHtmlCrossType)
*   3 [Sample Code](#SpecifyhowtocrossstringinoutputHTMLusingHtmlCrossType-SampleCode)
{{< /panel >}}
 

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

The following sample code loads the [sample Excel file](https://docs2.aspose.com/cells/net/attachments/51479995/51740732.xlsx) and saves it to HTML format by specifying different `HtmlCrossType`. Please download the [output HTMLs](https://docs2.aspose.com/cells/net/attachments/51479995/51740734.zip) generated with this code. The sample Excel file contains the image bordered with red color as shown in this screenshot that shows the effect of the `HtmlCrossType` values on output HTML.

![](https://docs2.aspose.com/cells/net/attachments/51479995/51740733.png)

## Sample Code

## Attachments:

![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [sampleHtmlCrossStringType.xlsx](https://docs2.aspose.com/cells/net/attachments/51479995/51740732.xlsx) (application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)  
![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [Sample-Excel-File-HtmlCrossType.png](https://docs2.aspose.com/cells/net/attachments/51479995/51740733.png) (image/png)  
![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [Output HTML Files.zip](https://docs2.aspose.com/cells/net/attachments/51479995/51740734.zip) (application/zip)  

