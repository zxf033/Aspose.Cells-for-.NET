+++
title = "Group Rows and Create Subtotal" 
description = "" 
weight = 16705 
+++

Aspose.Cells for .NET : Group Rows and Create Subtotal  

# Aspose.Cells for .NET : Group Rows and Create Subtotal


Aspose.Cells.GridWeb can create an outline for your data. This lets you show and hide levels of detail by clicking the outline symbols "+" and "-" to display only the rows that provide summaries or headings for sections in a worksheet. You can use the symbols to see details under an individual summary or heading.

When grouping rows, it is important to select only the detail rows that make up the group. Do not include the related summary row. For example, if row 6 contains totals for the data in row 3 through 5, select only row 3 through 5 to define the group. The Aspose.Cells.GridWeb control displays the **show detail** (+) and **hide detail** (-) symbols next to the row headers specifying the groups in the worksheet.

Aspose.Cells.GridWeb also allows you to create subtotals based on any field of data. A subtotal is not necessarily a sum: It can be an average, count, minimum, maximum or other statistical calculation.

This topic discusses grouping rows and creating subtotals using the Aspose.Cells.GridWeb API. Developers can group rows with any nesting level and create subtotals easily.

{{< panel title="Contents Summary" style="primary" >}}
*   1 [Grouping Rows](#GroupRowsandCreateSubtotal-GroupingRows)
    *   1.1 [Nesting Grouped Rows](#GroupRowsandCreateSubtotal-NestingGroupedRows)
    *   1.2 [Internal Process: How does the Control Work?](#GroupRowsandCreateSubtotal-InternalProcess:HowdoestheControlWork?)
*   2 [Ungroup Rows](#GroupRowsandCreateSubtotal-UngroupRows)
*   3 [Creating Subtotal](#GroupRowsandCreateSubtotal-CreatingSubtotal)
    *   3.1 [Parameters List](#GroupRowsandCreateSubtotal-ParametersList)
    *   3.2 [Summary Functions List](#GroupRowsandCreateSubtotal-SummaryFunctionsList)
*   4 [Removing Subtotal](#GroupRowsandCreateSubtotal-RemovingSubtotal)
*   5 [About the SUBTOTAL function](#GroupRowsandCreateSubtotal-AbouttheSUBTOTALfunction)
{{< /panel >}}
 

## Grouping Rows

To group a specific number of rows:

1.  Add the Aspose.Cells.GridWeb control to a Web Form.
2.  Access a worksheet.
3.  Select the desired number of cells in rows.
4.  Group the rows.

When the rows are grouped, an expand/collapse button is displayed at the top of the rows' Summary Line. You may change the direction setting. The `WebWorksheet.IsSummaryRowBelow` property is a Boolean property. Set it to false (default) and the summary row will be above the detail rows. Set it to true and the summary row will be below the detail rows. Click the expand/collapse button to expand or collapse grouped rows.

The following example groups the rows from 2nd row to 10th row.

**Grouping rows**  
![](https://docs2.aspose.com/cells/net/attachments/5013767/5115403.png)

{{< code lang="cs" >}}
// Accessing the reference of the worksheet that is currently active
GridWorksheet sheet = GridWeb1.WorkSheets[GridWeb1.ActiveSheetIndex];

// Group the rows
sheet.Cells.GroupRows(1, 9);
{{< /code >}}

### Nesting Grouped Rows

You can create levels of organization while grouping a set of rows. You may group rows among the grouped rows. The following example shows nesting grouped rows.

**Grouping rows**  
![](https://docs2.aspose.com/cells/net/attachments/5013767/5115406.png)

{{< code lang="cs" >}}
// Accessing the reference of the worksheet that is currently active
GridWorksheet sheet = GridWeb1.WorkSheets[GridWeb1.ActiveSheetIndex];

// Group the rows
sheet.Cells.GroupRows(1, 9);

// Create nested group of rows
sheet.Cells.GroupRows(4, 6);
{{< /code >}}

### Internal Process: How does the Control Work?

Each row of the sheet has an outline number. The default value of the outline number is zero. Every time you group the rows, the outline number is increased by 1. You may get the outline number by calling the `GridWorksheet.Cells.GetRowOutlineLevel()` method.

## Ungroup Rows

Aspose.Cells.GridWeb allows you to ungroup grouped rows.

To ungroup a specific number of rows:

1.  Select a number of cells in the rows in the worksheet to ungroup.
2.  Ungroup the rows.

The following example ungroups the rows from 2nd row to 10th row.

{{< code lang="cs" >}}
// Accessing the reference of the worksheet that is currently active
GridWorksheet sheet = GridWeb1.WorkSheets[GridWeb1.ActiveSheetIndex];

// Ungroup the rows
sheet.Cells.UngroupRows(1, 9); 
{{< /code >}}

When you call the `GridWorksheet.Cells.UngroupRows()` method, grouped rows' outline number is set to zero.

## Creating Subtotal

The control's subtotal feature can group the rows in the sheet with a specified column, and calculate the summary of the columns. Aspose.Cells.GridWeb can automatically calculate subtotal values for a list. When you implement subtotals, the control outlines the list so that you can display and hide the detail rows for each subtotal. Before adding subtotals, sort on the field you wish to subtotal on. To create subtotals, use any version of the overloaded `WebWorksheet.CreateSubtotal` method.

{{< code lang="cs" >}}
public void CreateSubtotal
(
           int columnNameRowIndex,
           int dataRows,
           int groupByColumnIndex,
           SubtotalFunction subtotalFunction,
           int[] subtotalColumnIndexList
);
{{< /code >}}

### Parameters List

No.

Parameter Name

Description

1

`columnNameRowIndex`

The row index of the column name row.

2

`dataRows`

The number of the data rows.

3

`groupByColumnIndex`

The column index of the column to be grouped.

4

`subtotalFunction`

The subtotal function type enumeration.

5

`subtotalColumnIndexList`

The column indexes to be subtotaled.

### Summary Functions List

There are several types of summary functions supported by the {\[SubtotalFunction}} enumeration:

No.

Function Name

Description

1

AVERAGE

Calculates the average of the values.

2

COUNT

Counts the numeric values in the cells.

3

COUNTA

Counts the non-numeric data in the cells.

4

MAX

Calculates the largest value.

5

MIN

Calculates the smallest value.

6

PRODUCT

Calculates the product of the values.

7

SUM

Calculates the sum of the values.

The following example generates the subtotals that calculates the non-numeric values grouped by the second column in the worksheet.

**Subtotals**  
![](https://docs2.aspose.com/cells/net/attachments/5013767/5115405.png)

sheet.CreateSubtotal(0, sheet.Cells.MaxRow, 1, SubtotalFunction.COUNTA, new int\[\] { 1, 2, 3, 4, 5 });

## Removing Subtotal

To remove a subtotal, use the `WebWorksheet.RemoveSubtotal` method. The following example removes the subtotals.

// Accessing the reference of the worksheet that is currently activeGridWorksheet sheet = GridWeb1.WorkSheets\[GridWeb1.ActiveSheetIndex\];//Remove the subtotalssheet.RemoveSubtotal();

## About the SUBTOTAL function

The GridWeb control makes use of the formula function SUBTOTAL to calculate the subtotal value.

Syntax: `SUBTOTAL(function_num, ref1, ref2, ...)`

`function_num` is a number specifying the type of the function used in subtotal calculation.

1

AVERAGE

2

COUNT

3

COUNTA

4

MAX

5

MIN

6

PRODUCT

7

SUM

ref1, ref2, are the areas to be subtotaled. If ref1, ref2, ... contain other subtotal functions, the referenced cells are ignored to avoid duplicate calculation.

## Attachments:

![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [Group Rows and Create Subtotal-001.png](https://docs2.aspose.com/cells/net/attachments/5013767/5115403.png) (image/png)  
![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [Group Rows and Create Subtotal-002.png](https://docs2.aspose.com/cells/net/attachments/5013767/5115406.png) (image/png)  
![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [Group Rows and Create Subtotal-003.png](https://docs2.aspose.com/cells/net/attachments/5013767/5115405.png) (image/png)  

