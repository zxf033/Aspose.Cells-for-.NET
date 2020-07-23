+++
title = "Merging and Unmerging Cells" 
description = "" 
weight = 12207 
+++

Aspose.Cells for .NET : Merging and Unmerging Cells  

# Aspose.Cells for .NET : Merging and Unmerging Cells


Aspose.Cells supports this feature and can also merge cells in a worksheet. You may unmerge, or split, the merged cells too. A merged cell's cell reference is the reference for the top left cell in the original selected range.

{{< panel title="Contents Summary" style="primary" >}}
*   1 [Introduction](#MergingandUnmergingCells-Introduction)
*   2 [Merging Cells in a Worksheet](#MergingandUnmergingCells-MergingCellsinaWorksheet)
    *   2.1 [Merging Cells in Microsoft Excel](#MergingandUnmergingCells-MergingCellsinMicrosoftExcel)
    *   2.2 [Merging Cells with Aspose.Cells](#MergingandUnmergingCells-MergingCellswithAspose.Cells)
*   3 [Unmerging (Splitting) Merged Cells](#MergingandUnmergingCells-Unmerging(Splitting)MergedCells)
    *   3.1 [Using Microsoft Excel](#MergingandUnmergingCells-UsingMicrosoftExcel)
    *   3.2 [Using Aspose.Cells](#MergingandUnmergingCells-UsingAspose.Cells)
{{< /panel >}}
 

## Introduction

You don't always want the same number of cells in every row or column. For example, you might want to put a title in a cell that spans several columns. Or, if creating an invoice, you might want fewer columns for the total. To make one cell from two or more cells, merge them. Microsoft Excel lets users select files and merge them to structure the spreadsheet the way they want.

Note that when cells are merged, only the data in the top left cells is retained. If there is data in the other cells in the range, this data is deleted.  
Formatting, likewise, is based on the reference cell so that when you merge cells, the formatting settings of the top left cell in the range are applied on the merged cell. When the cell is split, the new cells keep their original format settings.

## Merging Cells in a Worksheet

### Merging Cells in Microsoft Excel

The following steps describe how to merge cells in the worksheet using MS Excel.

1.  Copy the data you want into the upper-leftmost cell within the range.
2.  Select the cells you want to merge.
3.  To merge cells in a row or column and center the cell contents, click **Merge and Center** icon on the **Formatting** toolbar.

### Merging Cells with Aspose.Cells

The `Aspose.Cells.Cells` Class has some useful methods for the task. For example, the method `Merge()` merges the cells into a single cell within a specified range.

The following example shows how to merge cells (C6:E7) in a worksheet.

## Unmerging (Splitting) Merged Cells

### Using Microsoft Excel

The following steps describe how to split merged cells using Microsoft Excel.

1.  Select the merged cell.  
    When cells have been combined, **Merge and Center** is selected on the **Formatting** toolbar.
2.  Click **Merge and Center** on the **Formatting** toolbar.

### Using Aspose.Cells

The class `Aspose.Cells.Cells` has a method named `UnMerge()` that splits the cells into their original state. The method unmerges the cells using the cell's reference in the merged cell range.

The following example shows how to split the merged cells (C6). The example uses the file created in the previous example and splits the merged cells.

