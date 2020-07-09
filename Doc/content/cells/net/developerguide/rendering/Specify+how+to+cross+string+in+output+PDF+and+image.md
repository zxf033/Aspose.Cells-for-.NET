+++
title = "Specify how to cross string in output PDF and image" 
description = "" 
weight = 12099 
+++

Aspose.Cells for .NET : Specify how to cross string in output PDF and image  

# Aspose.Cells for .NET : Specify how to cross string in output PDF and image


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738029307 {padding: 0px;}div.rbtoc1590738029307 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738029307 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#SpecifyhowtocrossstringinoutputPDFandimage-PossibleUsageScenarios)
*   2 [Specify how to cross string in output PDF/Image using TextCrossType](#SpecifyhowtocrossstringinoutputPDFandimage-SpecifyhowtocrossstringinoutputPDF/ImageusingTextCrossType)

 

## Possible Usage Scenarios

When a cell contains text or string but it is larger than the width of the cell, then the string overflows if the next cell in the next column is null or empty. When you save your Excel file into PDF/Image, you can control this overflow by specifying the cross type using the [TextCrossType](https://apireference.aspose.com/net/cells/aspose.cells/textcrosstype) enumeration. It has the following values

*   **TextCrossType.Default**

Display text like MS Excel which depends on the next cell. If the next cell is null, the string will cross or it will be truncated.

*   **TextCrossType.CrossKeep**

Display the string like MS Excel exporting PDF/Image

*   **TextCrossType.CrossOverride**

Display all the text by crossing other cells and override the text of crossed cells

*   **TextCrossType.StrictInCell**

Only display the string within the width of the cell.

## Specify how to cross string in output PDF/Image using TextCrossType

The following sample code loads the sample Excel file and saves it to PDF/Image format by specifying different [TextCrossType](https://apireference.aspose.com/net/cells/aspose.cells/textcrosstype). The sample Excel file and output files can be downloaded from the following links:




Sample Code

## Attachments:


