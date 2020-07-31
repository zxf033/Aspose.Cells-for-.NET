---
title : "Changing the Font and Color of a Row or Column" 
description : "" 
weight : 16634 
toc : false
type: docs
url: /net/developerguide/griddesktop/rowsandcolumns/changing+the+font+and+color+of+a+row+or+column/
---

# Aspose.Cells for .NET : Changing the Font and Color of a Row or Column


In this topic, we will discuss about changing the font and font color of rows and columns of a worksheet. This is a basic level of formatting feature offered by Aspose.Cells.GridDesktop that empowers developers to customize the view of their worksheets for making them more presentable.

{{< panel title="Contents Summary" style="primary" >}}
*   1 [Changing the Font & Color of a Column](#changing-the-font-&-color-of-a-column)
*   2 [Changing the Font & Color of a Row](#changing-the-font-&-color-of-a-row)
{{< /panel >}}
 

 

## Changing the Font & Color of a Column

To change the font and color of a column using Aspose.Cells.GridDesktop, please follow the steps below:

*   Access any desired **Worksheet**
*   Access a **Column** whose font and color are to be changed
*   Create a customized **Font**
*   Set the **Font** of the **Column** to the customized one
*   Finally, set **Font Color** of the **Column** to any desired **Color**

{{< code lang="cs" >}}
//Accessing the worksheet of the Grid that is currently active
Worksheet sheet = gridDesktop1.GetActiveWorksheet();

//Accessing the first column of the worksheet
GridColumn column = sheet.Columns[0];

//Creating a customized Font object
Font font = new Font("Arial", 10, FontStyle.Bold);

//Setting the font of the column to the customized Font object
column.SetFont(font);

//Setting the font color of the column to Blue
column.SetFontColor(Color.Blue);
{{< /code >}}

## Changing the Font & Color of a Row

*   Access any desired **Worksheet**
*   Access a **Row** whose font and color are to be changed
*   Create a customized **Font**
*   Set the **Font** of the **Row** to the customized one
*   Finally, set **Font Color** of the **Row** to any desired **Color**

{{< code lang="cs" >}}
//Accessing the worksheet of the Grid that is currently active
Worksheet sheet = gridDesktop1.GetActiveWorksheet();

//Accessing the first row of the worksheet
GridRow row = sheet.Rows[0];

//Creating a customized Font object
Font font = new Font("Arial", 10, FontStyle.Underline);

//Setting the font of the column to the customized Font object
row.SetFont(font);

//Setting the font color of the column to Green
row.SetFontColor(Color.Green);
{{< /code >}}

