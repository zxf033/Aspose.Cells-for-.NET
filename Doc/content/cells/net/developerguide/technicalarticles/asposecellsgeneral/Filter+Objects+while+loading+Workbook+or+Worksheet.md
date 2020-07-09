+++
title = "Filter Objects while loading Workbook or Worksheet" 
description = "" 
weight = 16589 
+++

Aspose.Cells for .NET : Filter Objects while loading Workbook or Worksheet  

# Aspose.Cells for .NET : Filter Objects while loading Workbook or Worksheet


## Possible Usage Scenarios

Please use [LoadOptions.LoadFilter](https://apireference.aspose.com/net/cells/aspose.cells/loadoptions/properties/loadfilter) property while filtering data from the workbook. But if you want to filter data from individual worksheets, then you will have to override the [LoadFilter.StartSheet](https://apireference.aspose.com/net/cells/aspose.cells/loadfilter/methods/startsheet) method. Please provide appropriate value from the [LoadDataFilterOptions](https://apireference.aspose.com/net/cells/aspose.cells/loaddatafilteroptions) enumeration while creating or working with [LoadFilter](https://apireference.aspose.com/net/cells/aspose.cells/loadfilter).

The [LoadDataFilterOptions](https://apireference.aspose.com/net/cells/aspose.cells/loaddatafilteroptions) enumeration has the following possible values.

*   All
*   BookSettings
*   CellBlank
*   CellBool
*   CellData
*   CellError
*   CellNumeric
*   CellString
*   CellValue
*   Chart
*   ConditionalFormatting
*   DataValidation
*   DefinedNames
*   DocumentProperties
*   Formula
*   Hyperlinks
*   MergedArea
*   PivotTable
*   Settings
*   Shape
*   SheetData
*   SheetSettings
*   Structure
*   Style
*   Table
*   VBA
*   XmlMap

## Filter Objects while loading Workbook


## Filter Objects while loading Worksheet


*   It filters Charts from worksheet named `NoCharts`.
*   It filters Shapes from worksheet named `NoShapes`.
*   It filters Conditional Formatting from worksheet named `NoConditionalFormatting`.



  
This is how to use the `CustomLoadFilter` class as per worksheet names.

## Attachments:


