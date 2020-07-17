+++
title = "Merge and Unmerge Cells" 
description = "" 
weight = 16715 
+++

Aspose.Cells for .NET : Merge and Unmerge Cells  

# Aspose.Cells for .NET : Merge and Unmerge Cells


Aspose.Cells.GridWeb has a handy utility feature that lets you merge cells into one large cell. This topic describes how to merge cells programmatically.

**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738163595 {padding: 0px;}div.rbtoc1590738163595 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738163595 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Merging Cells](#MergeandUnmergeCells-MergingCells)
*   2 [Unmerging Cells](#MergeandUnmergeCells-UnmergingCells)

 

## Merging Cells

Merge multiple cells in a worksheet into a single cell by calling the `Cells` collection's `Merge` method. Specify the range of cells that to be merged when calling the `Merge` method.

If you merge multiple cells and each cell contains data, only the content of the top left cell in the range is retained after the merge. Data in the other cells is not lost. If you unmerge the cells, each cell recovers its data.

**Four cells merged into one**  

## Unmerging Cells

To unmerge cells, use the `Cells` collection's `UnMerge` method that takes same parameters as of the `Merge` method and performs the unmerging of cells.

## Attachments:


