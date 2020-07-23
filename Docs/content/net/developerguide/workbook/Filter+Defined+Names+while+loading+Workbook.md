+++
title = "Filter Defined Names while loading Workbook" 
description = "" 
weight = 12120 
+++

Aspose.Cells for .NET : Filter Defined Names while loading Workbook  

# Aspose.Cells for .NET : Filter Defined Names while loading Workbook


{{< panel title="Contents Summary" style="primary" >}}
*   1 [Possible Usage Scenarios](#FilterDefinedNameswhileloadingWorkbook-PossibleUsageScenarios)
*   2 [Filter Defined Names while loading Workbook](#FilterDefinedNameswhileloadingWorkbook-FilterDefinedNameswhileloadingWorkbook)
*   3 [Sample Code](#FilterDefinedNameswhileloadingWorkbook-SampleCode)
{{< /panel >}}
 

## Possible Usage Scenarios

Aspose.Cells allows you to filter or remove defined names present inside the workbook. Please use [LoadDataFilterOptions.DefinedNames](https://apireference.aspose.com/net/cells/aspose.cells/loaddatafilteroptions) to load defined names and use ~`[LoadDataFilterOptions.DefinedNames](https://apireference.aspose.com/net/cells/aspose.cells/loaddatafilteroptions)` to remove them while loading the workbook. Please note, if you will remove defined names, then formulas inside the workbook may break up. 

## Filter Defined Names while loading Workbook

The following sample code loads the [sample Excel file](https://docs2.aspose.com/cells/net/attachments/61542294/61767860.xlsx) which has a formula in cell **C1** containing the defined names i.e. *\=SUM(MyName1, MyName2)*. Since we are using ~`[LoadDataFilterOptions.DefinedNames](https://apireference.aspose.com/net/cells/aspose.cells/loaddatafilteroptions)` to remove the defined names while loading the workbook, the formula in cell C1 in [output Excel file](https://docs2.aspose.com/cells/net/attachments/61542294/61767861.xlsx) breaks up and you see *#NAME?* instead. Please see the following screenshot that shows the effect of the code on the sample Excel file.

![](https://docs2.aspose.com/cells/net/attachments/61542294/61767858.png)  

## Sample Code

## Attachments:

![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [LoadDataFilterOptions-DefinedNames.png](https://docs2.aspose.com/cells/net/attachments/61542294/61767858.png) (image/png)  
![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [sampleFilterDefinedNames.xlsx](https://docs2.aspose.com/cells/net/attachments/61542294/61767860.xlsx) (application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)  
![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [outputFilterDefinedNames.xlsx](https://docs2.aspose.com/cells/net/attachments/61542294/61767861.xlsx) (application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)  

