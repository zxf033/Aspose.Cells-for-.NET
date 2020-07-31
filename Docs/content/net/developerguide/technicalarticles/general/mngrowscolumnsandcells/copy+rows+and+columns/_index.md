---
title : "Copy Rows and Columns" 
description : "" 
weight : 20477 
toc : false
type: docs
url: /net/developerguide/technicalarticles/general/mngrowscolumnsandcells/copy+rows+and+columns/
---

# Aspose.Cells for .NET : Copy Rows and Columns


Aspose.Cells APIs provide the facility to copy rows and columns within or between the workbooks. While copying row or column, all the data is copied along with the styling, formulas (with updated references) and resulting values, comments, cell styles, hidden cells, images and drawing objects.

{{< panel title="Contents Summary" style="primary" >}}
*   1 [Copying Rows](#copying-rows)
    *   1.1 [Copying Single Row](#copying-single-row)
    *   1.2 [Copying Multiple Rows](#copying-multiple-rows)
*   2 [Copying Columns](#copying-columns)
    *   2.1 [Copying Single Column](#copying-single-column)
    *   2.2 [Copying Multiple Columns](#copying-multiple-columns)
{{< /panel >}}
 

 

## Copying Rows

### Copying Single Row

The following example shows how to copy a single row in a worksheet. The example uses a Microsoft Excel spreadsheet as input and copies the first row to the next 10 rows in the same worksheet.

### Copying Multiple Rows

You can also copy multiple rows onto a new destination while using the [Cells.CopyRows](https://apireference.aspose.com/net/cells/aspose.cells/cells/methods/copyrows/index) method which takes an additional parameter of type integer to specify the number of source rows to be copied.

## Copying Columns

### Copying Single Column

The following example shows how to copy a column in a worksheet. This example uses an existing spreadsheet as input to the process and copies the first column to the next 10 columns using two different approaches.

### Copying Multiple Columns

Similar to [Cells.CopyRows](https://apireference.aspose.com/net/cells/aspose.cells/cells/methods/copyrows/index) method, the Aspose.Cells APIs also provide the [Cells.CopyColumns](https://apireference.aspose.com/net/cells/aspose.cells/cells/methods/copycolumns/index) method in order to copy multiple source columns to a new location.

