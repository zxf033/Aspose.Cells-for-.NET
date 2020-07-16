+++
title = "Applying Style on a Row or Column" 
description = "" 
weight = 16628 
+++

Aspose.Cells for .NET : Applying Style on a Row or Column  

# Aspose.Cells for .NET : Applying Style on a Row or Column


In this topic, we will discuss about changing the font and font color of rows and columns of a worksheet. This is a basic level of formatting feature offered by Aspose.Cells.GridDesktop that empowers developers to customize the view of their worksheets for making them more presentable.

**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738145107 {padding: 0px;}div.rbtoc1590738145107 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738145107 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Applying Style on a Column](#ApplyingStyleonaRoworColumn-ApplyingStyleonaColumn)
*   2 [Applying Style on a Row](#ApplyingStyleonaRoworColumn-ApplyingStyleonaRow)

 

 

## Applying Style on a Column

To apply a custom style on a column using Aspose.Cells.GridDesktop, please follow the steps below:

*   Access any desired **Worksheet**
*   Access a **Column** on which we want to apply a **Style**
*   Get **Style** of the **Column**
*   Set **Style** properties according to your custom needs
*   Finally, set **Style** of the **Column** with the updated one

There are many useful properties and methods offered by **Style** object that can be used by developers to customize the style according to their requirements.

## Applying Style on a Row

To apply a custom style on a row using Aspose.Cells.GridDesktop, please follow the steps below:

*   Access any desired **Worksheet**
*   Access a **Row** on which we want to apply a **Style**
*   Get **Style** of the **Row**
*   Set **Style** properties according to your custom needs
*   Finally, set **Style** of the **Row** with the updated one

There are many useful properties and methods offered by **Style** object that can be used by developers to customize the style according to their requirements.

// Accessing the worksheet of the Grid that is currently activeWorksheet sheet = gridDesktop1.GetActiveWorksheet();// Accessing the first row of the worksheetAspose.Cells.GridDesktop.Data.GridRow row = sheet.Rows\[0\];// Getting the Style object for the rowStyle style = row.GetStyle();// Setting Style properties i.e. border, color, alignment, background color etc.style.SetBorderLine(BorderType.Right, BorderLineType.Thick);style.SetBorderColor(BorderType.Right, Color.Blue);style.HAlignment = HorizontalAlignmentType.Centred;style.Color = Color.Yellow;// Setting the style of the row with the customized Style objectrow.SetStyle(style);

## Attachments:


