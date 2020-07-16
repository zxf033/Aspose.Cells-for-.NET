+++
title = "Filter VBA Project while loading a workbook" 
description = "" 
weight = 12326 
+++

Aspose.Cells for .NET : Filter VBA Project while loading a workbook  

# Aspose.Cells for .NET : Filter VBA Project while loading a workbook


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738061486 {padding: 0px;}div.rbtoc1590738061486 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738061486 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#FilterVBAProjectwhileloadingaworkbook-PossibleUsageScenarios)
*   2 [Sample Code](#FilterVBAProjectwhileloadingaworkbook-SampleCode)

 

 

## Possible Usage Scenarios

Some .xlsm/.xslb files have an extremely large amount of macros (or very, very long macros). Aspose.Cells will unconditionally load this (meta) data when opening such workbooks. You may require to control this though [LoadDataFilterOptions](https://apireference.aspose.com/net/cells/aspose.cells/loaddatafilteroptions) when you really only need to extract sheet names for a large number of workbooks thus skipping over such unneeded content. This filter is provided by introducing a new option, [LoadDataFilterOptions.VBA](https://apireference.aspose.com/net/cells/aspose.cells/loaddatafilteroptions).

## Sample Code

The following sample code loads a workbook such that only VBA is filtered. A sample file for testing this feature can be downloaded from the following link:


## Attachments:


