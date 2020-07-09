+++
title = "Create Remove and Get GridCell Comments" 
description = "" 
weight = 16708 
+++

Aspose.Cells for .NET : Create Remove and Get GridCell Comments  

# Aspose.Cells for .NET : Create Remove and Get GridCell Comments


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738162673 {padding: 0px;}div.rbtoc1590738162673 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738162673 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#CreateRemoveandGetGridCellComments-PossibleUsageScenarios)
*   2 [Create Comment object inside Cell](#CreateRemoveandGetGridCellComments-CreateCommentobjectinsideCell)
*   3 [Remove Comment object from Cell](#CreateRemoveandGetGridCellComments-RemoveCommentobjectfromCell)
*   4 [Get Comment object from Cell](#CreateRemoveandGetGridCellComments-GetCommentobjectfromCell)

 

## Possible Usage Scenarios

The following article explains how to create, remove and get GridCell comments inside the GridWeb worksheet. It is worth noting that GridWeb displays comment as Tooltip like MS-Excel when you hover mouse over the cell as shown in this screenshot.


## Create Comment object inside Cell

Please use the `GridCell.CreateComment` method to create a comment object inside cell. The following sample code creates a sample comment in cell B4 of the first worksheet of GridWeb.

//Access first worksheet of GridWebGridWorksheet sheet = GridWeb1.WorkSheets\[0\];//Access cell B4GridCell cell = sheet.Cells\["B4"\];//Create comment with these parameters//i.e. note, author, isvisiblecell.CreateComment("This is a B4 note.", "Peter", true);

## Remove Comment object from Cell

Please use the `GridCell.RemoveComment` method to remove a comment object from cell. The following sample code removes cell B4 comment inside the first worksheet of GridWeb.

//Access first worksheet of GridWebGridWorksheet sheet = GridWeb1.WorkSheets\[0\];//Access cell B4GridCell cell = sheet.Cells\["B4"\];//Remove the comment object from this cell.cell.RemoveComment();

## Get Comment object from Cell

Please use the `GridCell.GetComment()` method to get comment object from cell. The following sample code gets the comment object from cell B4 and then accesses its various properties like Author, Note, Visibility etc.

//Access first worksheet of GridWebGridWorksheet sheet = GridWeb1.WorkSheets\[0\];//Access cell B4GridCell cell = sheet.Cells\["B4"\];//Get comment of this cellGridComment gridComm = cell.GetComment();//Access its various propertiesstring strAuth = gridComm.Author;string strNote = gridComm.Note;bool isVis = gridComm.IsVisible;

## Attachments:


