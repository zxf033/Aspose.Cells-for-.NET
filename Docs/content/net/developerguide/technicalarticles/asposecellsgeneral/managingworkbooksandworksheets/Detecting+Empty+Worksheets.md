+++
title = "Detecting Empty Worksheets" 
description = "" 
weight = 20462 
+++

Aspose.Cells for .NET : Detecting Empty Worksheets  

# Aspose.Cells for .NET : Detecting Empty Worksheets


{{< panel title="Contents Summary" style="primary" >}}
*   1 [Check for Populated Cells](#DetectingEmptyWorksheets-CheckforPopulatedCells)
*   2 [Check for Empty Initialized Cells](#DetectingEmptyWorksheets-CheckforEmptyInitializedCells)
*   3 [Check for Shapes](#DetectingEmptyWorksheets-CheckforShapes)
*   4 [Programming Sample](#DetectingEmptyWorksheets-ProgrammingSample)
{{< /panel >}}
 

 

## Check for Populated Cells

Worksheets can have one or more cells populated with values where a value can be simple (text, numeric, date/time) or a formula or a formula based value. In such a case, it is easy to detect if a given worksheet is empty or not. All we have to check is the [Cells.MaxDataRow](https://apireference.aspose.com/net/cells/aspose.cells/cells/properties/maxdatarow) or [Cells.MaxDataColumn](https://apireference.aspose.com/net/cells/aspose.cells/cells/properties/maxdatacolumn) properties. If the aforementioned properties return zero or positive values that means, one or more cells have been populated, however, if any of these properties return -1 that indicates that none of the cells have been populated in the given worksheet.

The rows & columns collections have zero-based index therefore a cell at row 0 & column 0 means the first cell in the worksheet, which is A1.

## Check for Empty Initialized Cells

All cells which have values are automatically initialized, however, there is a possibility that a worksheet has cells with only formatting applied. In such a scenario, the [Cells.MaxDataRow](https://apireference.aspose.com/net/cells/aspose.cells/cells/properties/maxdatarow) or [Cells.MaxDataColumn](https://apireference.aspose.com/net/cells/aspose.cells/cells/properties/maxdatacolumn) properties will return -1 indicating the absence of any populated values but initialized cells due to the cell formatting cannot be detected using this approach. In order to check if a worksheet has empty initialized cells, it is advised to use the `IEnumerator.MoveNext` method on the enumerator acquired from [Cells](https://apireference.aspose.com/net/cells/aspose.cells/cells) collection. If the `IEnumerator.MoveNext` method returns **true** that means there are one or more initialized cells in the given worksheet.

## Check for Shapes

It is possible that a given worksheet does not have any populated cells, however, it could contain shapes & objects such as controls, charts, images and so on. If we need to check if a worksheet contains any shape, we can do it by inspecting the [ShapeCollection.Count](https://apireference.aspose.com/net/cells/aspose.cells.drawing/shapecollection) property. Any positive value indicates the presence of shape(s) in the worksheet.

## Programming Sample

