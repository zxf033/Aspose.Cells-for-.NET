+++
title = "Changing the Font and Color of a Row or Column" 
description = "" 
weight = 16634 
+++

Aspose.Cells for .NET : Changing the Font and Color of a Row or Column  

# Aspose.Cells for .NET : Changing the Font and Color of a Row or Column


In this topic, we will discuss about changing the font and font color of rows and columns of a worksheet. This is a basic level of formatting feature offered by Aspose.Cells.GridDesktop that empowers developers to customize the view of their worksheets for making them more presentable.

**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738145668 {padding: 0px;}div.rbtoc1590738145668 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738145668 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Changing the Font & Color of a Column](#ChangingtheFontandColorofaRoworColumn-ChangingtheFont&ColorofaColumn)
*   2 [Changing the Font & Color of a Row](#ChangingtheFontandColorofaRoworColumn-ChangingtheFont&ColorofaRow)

 

 

## Changing the Font & Color of a Column

To change the font and color of a column using Aspose.Cells.GridDesktop, please follow the steps below:

*   Access any desired **Worksheet**
*   Access a **Column** whose font and color are to be changed
*   Create a customized **Font**
*   Set the **Font** of the **Column** to the customized one
*   Finally, set **Font Color** of the **Column** to any desired **Color**

//Accessing the worksheet of the Grid that is currently activeWorksheet sheet = gridDesktop1.GetActiveWorksheet();//Accessing the first column of the worksheetGridColumn column = sheet.Columns\[0\];//Creating a customized Font objectFont font = new Font("Arial", 10, FontStyle.Bold);//Setting the font of the column to the customized Font objectcolumn.SetFont(font);//Setting the font color of the column to Bluecolumn.SetFontColor(Color.Blue);

## Changing the Font & Color of a Row

*   Access any desired **Worksheet**
*   Access a **Row** whose font and color are to be changed
*   Create a customized **Font**
*   Set the **Font** of the **Row** to the customized one
*   Finally, set **Font Color** of the **Row** to any desired **Color**

//Accessing the worksheet of the Grid that is currently activeWorksheet sheet = gridDesktop1.GetActiveWorksheet();//Accessing the first row of the worksheetGridRow row = sheet.Rows\[0\];//Creating a customized Font objectFont font = new Font("Arial", 10, FontStyle.Underline);//Setting the font of the column to the customized Font objectrow.SetFont(font);//Setting the font color of the column to Greenrow.SetFontColor(Color.Green);

## Attachments:


