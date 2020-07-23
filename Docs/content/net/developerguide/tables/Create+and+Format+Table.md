+++
title = "Create and Format Table" 
description = "" 
weight = 12257 
+++

Aspose.Cells for .NET : Create and Format Table  

# Aspose.Cells for .NET : Create and Format Table


{{< panel title="Contents Summary" style="primary" >}}
*   1 [Create Table](#CreateandFormatTable-CreateTable)
    *   1.1 [Advantages of a List Object](#CreateandFormatTable-AdvantagesofaListObject)
    *   1.2 [Creating a List Object using Microsoft Excel](#CreateandFormatTable-CreatingaListObjectusingMicrosoftExcel)
    *   1.3 [Using Aspose.Cells API](#CreateandFormatTable-UsingAspose.CellsAPI)
*   2 [Format a Table](#CreateandFormatTable-FormataTable)
    *   2.1 [Formatting a List Object](#CreateandFormatTable-FormattingaListObject)
{{< /panel >}}
 

## Create Table

One of the advantages of spreadsheets is that they allow you to create different types of lists, for example, phone lists, task lists, lists of transactions, assets or liabilities. Several users can work together to use, create and maintain various lists.

Aspose.Cells supports creating and managing Lists.

### Advantages of a List Object

There are quite a few advantages when you convert a list of data to an actual List Object

*   New rows and columns are automatically included.
*   A total row at the bottom of your list can be easily added to display SUM, AVERAGE, COUNT, etc.
*   Columns added to the right are automatically incorporated into the List object.
*   Charts based on rows and columns will be expanded automatically.
*   Named ranges assigned to rows and columns will be expanded automatically.
*   The list is protected from accidental row and column deletion.

### Creating a List Object using Microsoft Excel

*   Selecting data range for creating a List object
*   This displays the Create List dialog.
*   Implement the List object for the data and specifying total row (Select **Data**, then **List**, followed by **Total Row**).

### Using Aspose.Cells API

Aspose.Cells provides a class, [Workbook](https://apireference.aspose.com/net/cells/aspose.cells/workbook), that represents a Microsoft Excel file. The [Workbook](https://apireference.aspose.com/net/cells/aspose.cells/workbook) class contains a [Worksheets](https://apireference.aspose.com/net/cells/aspose.cells/workbook/properties/worksheets) collection that allows access to each worksheet in an Excel file.

A worksheet is represented by the [Worksheet](https://apireference.aspose.com/net/cells/aspose.cells/worksheet) class. The [Worksheet](https://apireference.aspose.com/net/cells/aspose.cells/worksheet) class provides a wide range of properties and methods for managing a worksheet. To create a [ListObject](https://apireference.aspose.com/net/cells/aspose.cells.tables/listobject) in a worksheet, use the [ListObjects](https://apireference.aspose.com/net/cells/aspose.cells/worksheet/properties/listobjects) collection property of the [Worksheet](https://apireference.aspose.com/net/cells/aspose.cells/worksheet) class. Each [ListObject](https://apireference.aspose.com/net/cells/aspose.cells.tables/listobject) is, in fact, an object of the [ListObjectCollection](https://apireference.aspose.com/net/cells/aspose.cells.tables/listobjectcollection) class, which further provides the [Add](https://apireference.aspose.com/net/cells/aspose.cells.tables/listobjectcollection/methods/add/index) method for adding a List object and specifying a range of cells for the list.

According to the specified range of cells, the List object is created by Aspose.Cells. Use attributes (for example, [ShowTotals](https://apireference.aspose.com/net/cells/aspose.cells.tables/listobject/properties/showtotals), [ListColumns](https://apireference.aspose.com/net/cells/aspose.cells.tables/listobject/properties/listcolumns), etc.) of the [ListObject](https://apireference.aspose.com/net/cells/aspose.cells.tables/listobject) class to control the list.

In the example given below, we have created the same [ListObject](https://apireference.aspose.com/net/cells/aspose.cells.tables/listobject) using Aspose.Cells API as we created using Microsoft Excel in the above section.

## Format a Table

To manage and analyze a group of related data, it is possible to turn a range of cells into a list object (also known as an Excel table). A table is a series of rows and columns that contain related data managed independently from the data in other rows and columns. By default, every column in the table has filtering enabled in the header row so that you can filter or sort your list object data quickly. You can add a total row (a special row in a list that provides a selection of aggregate functions useful for working with numerical data) to the list object that provides a drop-down list of aggregate functions for each total row cell. Aspose.Cells provides options for creating and managing lists (or tables).

### Formatting a List Object

Aspose.Cells provides a class, [Workbook](https://apireference.aspose.com/net/cells/aspose.cells/workbook), that represents a Microsoft Excel file. The [Workbook](https://apireference.aspose.com/net/cells/aspose.cells/workbook) class contains a [Worksheets](https://apireference.aspose.com/net/cells/aspose.cells/workbook/properties/worksheets) collection that allows access to each worksheet in an Excel file.

A worksheet is represented by the [Worksheet](https://apireference.aspose.com/net/cells/aspose.cells/worksheet) class. The [Worksheet](https://apireference.aspose.com/net/cells/aspose.cells/worksheet) class provides a wide range of properties and methods for managing worksheets. To create a [ListObject](https://apireference.aspose.com/net/cells/aspose.cells.tables/listobject) in a worksheet, use [ListObjects](https://apireference.aspose.com/net/cells/aspose.cells/worksheet/properties/listobjects) collection property of the [Worksheet](https://apireference.aspose.com/net/cells/aspose.cells/worksheet) class. Each [ListObject](https://apireference.aspose.com/net/cells/aspose.cells.tables/listobject) is, in fact, an object of the [ListObjectCollection](https://apireference.aspose.com/net/cells/aspose.cells.tables/listobjectcollection) class, which further provides the [Add](https://apireference.aspose.com/net/cells/aspose.cells.tables/listobjectcollection/methods/add/index) method to add a List object and specify the range of cells it should encompass. According to the specified range of cells, a [ListObject](https://apireference.aspose.com/net/cells/aspose.cells.tables/listobject) is created in the worksheet by Aspose.Cells. Use attributes (for example, [TableStyleType](https://apireference.aspose.com/net/cells/aspose.cells.tables/listobject/properties/tablestyletype)) of the [ListObject](https://apireference.aspose.com/net/cells/aspose.cells.tables/listobject) class to format the table for your requirement.

The example below adds sample data to a worksheet, adds a [ListObject](https://apireference.aspose.com/net/cells/aspose.cells.tables/listobject) and apply default styles to it. [ListObject](https://apireference.aspose.com/net/cells/aspose.cells.tables/listobject) styles are supported by Microsoft Excel 2007/2010.

