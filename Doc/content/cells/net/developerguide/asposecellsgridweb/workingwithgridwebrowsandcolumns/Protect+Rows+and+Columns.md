+++
title = "Protect Rows and Columns" 
description = "" 
weight = 16704 
+++

Aspose.Cells for .NET : Protect Rows and Columns  

# Aspose.Cells for .NET : Protect Rows and Columns


This topic discusses a few techniques for protecting cells in rows and columns from any kind of action performed by end users. Developers can implement this protection using two techniques: by making cells in rows and columns read only, or by restricting the Aspose.Cells.GridWeb's context menu options. Both of these techniques are discussed below with the help of examples.

**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738161994 {padding: 0px;}div.rbtoc1590738161994 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738161994 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Protecting Cells in Rows & Columns](#ProtectRowsandColumns-ProtectingCellsinRows&Columns)
    *   1.1 [Making Rows & Columns Read Only](#ProtectRowsandColumns-MakingRows&ColumnsReadOnly)
    *   1.2 [Restricting Context Menu Options](#ProtectRowsandColumns-RestrictingContextMenuOptions)

 

## Protecting Cells in Rows & Columns

### Making Rows & Columns Read Only

One way of protecting rows and columns in a worksheet is to make the cells read only. Then they cannot be deleted by end users.

To make rows and columns read only:

1.  Add the Aspose.Cells.GridWeb control to a Web Form.
2.  Access the `GridWorksheet` in the collection.
3.  Set your desired cells in rows or columns to read only.

### Restricting Context Menu Options

Aspose.Cells.GridWeb provides a context menu that end users can use to perform operations on the control. The menu provides many options for manipulating cells, rows and columns.

**Complete contextual options**  

It is possible to restrict any kind of client side operations on rows and columns by restricting the options available in the context menu. It can be done by setting the `EnableClientColumnOperations` and `EnableClientRowOperations` properties of the GridWeb control to false. It is also possible to restrict users from freezing rows and columns by setting the GridWeb control's `EnableClientFreeze` property to false.

**Context menu after restricting row & column options**  

## Attachments:


