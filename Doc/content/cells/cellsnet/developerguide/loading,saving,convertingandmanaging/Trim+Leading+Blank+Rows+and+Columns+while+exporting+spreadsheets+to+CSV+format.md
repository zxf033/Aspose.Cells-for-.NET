+++
title = "Trim Leading Blank Rows and Columns while exporting spreadsheets to CSV format" 
description = "" 
weight = 12069 
+++

Aspose.Cells for .NET : Trim Leading Blank Rows and Columns while exporting spreadsheets to CSV format  

# Aspose.Cells for .NET : Trim Leading Blank Rows and Columns while exporting spreadsheets to CSV format


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738025276 {padding: 0px;}div.rbtoc1590738025276 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738025276 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#TrimLeadingBlankRowsandColumnswhileexportingspreadsheetstoCSVformat-PossibleUsageScenarios)
*   2 [Trim Leading Blank Rows and Columns while exporting spreadsheets to CSV format](#TrimLeadingBlankRowsandColumnswhileexportingspreadsheetstoCSVformat-TrimLeadingBlankRowsandColumnswhileexportingspreadsheetstoCSVformat)
*   3 [Sample Code](#TrimLeadingBlankRowsandColumnswhileexportingspreadsheetstoCSVformat-SampleCode)

## Possible Usage Scenarios

Sometimes, your Excel or CSV file has leading blank columns or rows. For example, consider this line

,,,data1,data2 

Here the first three cells or columns are blank. When you open such a CSV file in Microsoft Excel, then Microsoft Excel discards these leading blank rows and columns.

By default, Aspose.Cells does not discard leading blank columns and rows on saving but if you want to remove them just like Microsoft Excel does, then Aspose.Cells provides [TxtSaveOptions.TrimLeadingBlankRowAndColumn](https://apireference.aspose.com/net/cells/aspose.cells/txtsaveoptions/properties/trimleadingblankrowandcolumn) property. Please set it to **true **and then all the leading blank rows and columns will be discarded on saving.

Prior to the release of Aspose.Cells for .NET 20.4, the default value of [TxtSaveOptions.TrimLeadingBlankRowAndColumn](https://apireference.aspose.com/net/cells/aspose.cells/txtsaveoptions/properties/trimleadingblankrowandcolumn) was **false**. Since the 20.4 release, the default value of [TxtSaveOptions.TrimLeadingBlankRowAndColumn](https://apireference.aspose.com/net/cells/aspose.cells/txtsaveoptions/properties/trimleadingblankrowandcolumn) is **true.**

## Trim Leading Blank Rows and Columns while exporting spreadsheets to CSV format



## Sample Code

## Attachments:


