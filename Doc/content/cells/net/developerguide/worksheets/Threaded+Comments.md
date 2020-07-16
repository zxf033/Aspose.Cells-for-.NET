+++
title = "Threaded Comments" 
description = "" 
weight = 12173 
+++

Aspose.Cells for .NET : Threaded Comments  

# Aspose.Cells for .NET : Threaded Comments


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738039613 {padding: 0px;}div.rbtoc1590738039613 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738039613 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Threaded Comments](#ThreadedComments-ThreadedComments)
    *   1.1 [Add Threaded Comments](#ThreadedComments-AddThreadedComments)
        *   1.1.1 [Add Threaded comment with Excel](#ThreadedComments-AddThreadedcommentwithExcel)
        *   1.1.2 [Add Threaded Comment using Aspose.Cells](#ThreadedComments-AddThreadedCommentusingAspose.Cells)
            *   1.1.2.1 [Sample Code](#ThreadedComments-SampleCode)
    *   1.2 [Read Threaded Comments](#ThreadedComments-ReadThreadedComments)
        *   1.2.1 [Read Threaded comments with Excel](#ThreadedComments-ReadThreadedcommentswithExcel)
        *   1.2.2 [Read Threaded comments using Aspose.Cells](#ThreadedComments-ReadThreadedcommentsusingAspose.Cells)
            *   1.2.2.1 [Sample Code](#ThreadedComments-SampleCode.1)
            *   1.2.2.2 [Console Output](#ThreadedComments-ConsoleOutput)
        *   1.2.3 [Read Created Time of threaded comments](#ThreadedComments-ReadCreatedTimeofthreadedcomments)
            *   1.2.3.1 [Sample Code](#ThreadedComments-SampleCode.2)
            *   1.2.3.2 [Console Output](#ThreadedComments-ConsoleOutput.1)
    *   1.3 [Edit Threaded Comments](#ThreadedComments-EditThreadedComments)
        *   1.3.1 [Edit Threaded comment with Excel](#ThreadedComments-EditThreadedcommentwithExcel)
        *   1.3.2 [Edit Threaded comment using Aspose.Cells](#ThreadedComments-EditThreadedcommentusingAspose.Cells)
            *   1.3.2.1 [Sample Code](#ThreadedComments-SampleCode.3)
    *   1.4 [Remove Threaded Comments](#ThreadedComments-RemoveThreadedComments)
        *   1.4.1 [Remove Threaded comments with Excel](#ThreadedComments-RemoveThreadedcommentswithExcel)
        *   1.4.2 [Remove Threaded comments using Aspose.Cells](#ThreadedComments-RemoveThreadedcommentsusingAspose.Cells)
            *   1.4.2.1 [Sample Code](#ThreadedComments-SampleCode.4)

 

# Threaded Comments

MS Excel 365 provides a feature to add threaded comments. These comments work as conversations and can be used for discussions. The comments now come with a Reply box that allows for threaded conversations. The old comments are called Notes in Excel 365. The screenshot below shows how threaded comments are displayed when opened in Excel.


Threaded comments are shown like this in older versions of Excel. The following images have been taken by opening the sample file in Excel 2016.


Aspose.Cells also provides the feature to manage threaded comments. 

## Add Threaded Comments

### Add Threaded comment with Excel

To add threaded comments in Excel 365, follow the following steps.

*   Method 1
    *   Click the **Review** Tab
    *   Click the **New Comment** button
    *   This will open a dialogue to enter comments in the active cell.
*   Method 2
    *   Right click on the cell where you want to insert the comment.
    *   Click the **New Comment** option.
    *   This will open a dialogue to enter comments in the active cell.

### Add Threaded Comment using Aspose.Cells

Aspose.Cells provides [Comments.AddThreadedComment](https://apireference.aspose.com/net/cells/aspose.cells.commentcollection/addthreadedcomment/methods/1) method to add threaded comments.The [Comments.AddThreadedComment](https://apireference.aspose.com/net/cells/aspose.cells.commentcollection/addthreadedcomment/methods/1) method accepts the following three parameters.

*   Cell Name: The name of the cell where the comment will be inserted.
*   Comment Text: The text of the comment.
*   [ThreadedCommentAuthor](https://apireference.aspose.com/net/cells/aspose.cells/threadedcommentauthor): The author of the comment


#### Sample Code

## Read Threaded Comments

### Read Threaded comments with Excel

To read threaded comments in Excel, simply hover your mouse over the cell containing comments to view the comments. The comments view will look like the view in the following image.


### Read Threaded comments using Aspose.Cells

Aspose.Cells provides [Comments.GetThreadedComments](https://apireference.aspose.com/net/cells/aspose.cells.commentcollection/getthreadedcomments/methods/1) method to retrieve threaded comments for the specified column. [Comments.GetThreadedComments](https://apireference.aspose.com/net/cells/aspose.cells.commentcollection/getthreadedcomments/methods/1) method accepts the column name as a parameter and returns the [ThreadedCommentCollection](https://apireference.aspose.com/net/cells/aspose.cells/threadedcommentcollection). You can iterate over the [ThreadedCommentCollection](https://apireference.aspose.com/net/cells/aspose.cells/threadedcommentcollection) to view the comments.


#### Sample Code

#### Console Output

Comment: Test Threaded CommentAuthor: Aspose Test

### Read Created Time of threaded comments

Aspose.Cells provides [Comments.GetThreadedComments](https://apireference.aspose.com/net/cells/aspose.cells.commentcollection/getthreadedcomments/methods/1) method to retrieve threaded comments for the specified column. [Comments.GetThreadedComments](https://apireference.aspose.com/net/cells/aspose.cells.commentcollection/getthreadedcomments/methods/1) method accepts the column name as a parameter and returns the [ThreadedCommentCollection](https://apireference.aspose.com/net/cells/aspose.cells/threadedcommentcollection). You can iterate over the [ThreadedCommentCollection](https://apireference.aspose.com/net/cells/aspose.cells/threadedcommentcollection) and use the [ThreadedComment.CreatedTime](https://apireference.aspose.com/net/cells/aspose.cells/threadedcomment/properties/createdtime) property. 


#### Sample Code

#### Console Output

Comment: Test Threaded CommentAuthor: Aspose TestCreated Time: 5/15/2019 12:46:23 PM

## Edit Threaded Comments

### Edit Threaded comment with Excel

To edit a threaded comment in Excel, click the **Edit** link on the comment as shown in the following image.


### Edit Threaded comment using Aspose.Cells

Aspose.Cells provides [Comments.GetThreadedComments](https://apireference.aspose.com/net/cells/aspose.cells.commentcollection/getthreadedcomments/methods/1) method to retrieve threaded comments for the specified column. [Comments.GetThreadedComments](https://apireference.aspose.com/net/cells/aspose.cells.commentcollection/getthreadedcomments/methods/1) method accepts the column name as a parameter and returns the [ThreadedCommentCollection](https://apireference.aspose.com/net/cells/aspose.cells/threadedcommentcollection). You can update the required comment in the [ThreadedCommentCollection](https://apireference.aspose.com/net/cells/aspose.cells/threadedcommentcollection) and save the workbook.


#### Sample Code

## Remove Threaded Comments

### Remove Threaded comments with Excel

To remove threaded comments in Excel, right click on the cell containing the comments and click the **Delete Comment** option as shown in the following image.


### Remove Threaded comments using Aspose.Cells

Aspose.Cells provides [Comments.RemoveAt](https://apireference.aspose.com/net/cells/aspose.cells/commentcollection/methods/removeat/index) method to remove comments for the specified column. [Comments.RemoveAt](https://apireference.aspose.com/net/cells/aspose.cells/commentcollection/methods/removeat/index) method accepts the column name as a parameter removes the comments in that column. 


#### Sample Code

Please note that by removing comment with Aspose.Cells, the author is not removed automatically. If you need to remove the author as well, please use the RemoveAt method of [ThreadedCommentAuthorCollection](https://apireference.aspose.com/net/cells/aspose.cells/threadedcommentauthorcollection) class as shown in the example above.

## Attachments:


