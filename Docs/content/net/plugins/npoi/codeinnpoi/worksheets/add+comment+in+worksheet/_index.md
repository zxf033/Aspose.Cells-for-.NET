---
title : "Add Comment In Worksheet" 
description : "" 
weight : 20928 
toc : false
type: docs
url: /net/plugins/npoi/codeinnpoi/worksheets/add+comment+in+worksheet/
---

# Aspose.Cells for .NET : Add Comment In Worksheet


## Aspose.Cells - Add Comment in Worksheet

**C#**

{{< code lang="c#" >}}
//Instantiating a Workbook object
Workbook workbook = new Workbook();

//Adding a new worksheet to the Workbook object
int sheetIndex = workbook.Worksheets.Add();

//Obtaining the reference of the newly added worksheet by passing its sheet index
Worksheet worksheet = workbook.Worksheets[sheetIndex];

//Setting the name of the newly added worksheet
worksheet.Name = "Adding Comment in Execl Cell";

//Adding a comment to "F5" cell
int commentIndex = worksheet.Comments.Add("F5");

//Adding a string value to the cell
worksheet.Cells["F5"].PutValue("Hello World");

//Accessing the newly added comment
Comment comment = worksheet.Comments[commentIndex];

//Setting the comment note
comment.Note = "Hello Aspose!";

//Saving the Excel file
workbook.Save("Output-AddingComment.xls");

{{< /code >}}

## NPOI - HSSF XSSF - Add Comment in Worksheet

**C#**

{{< code lang="c#" >}}
HSSFWorkbook hssfworkbook = new HSSFWorkbook();

ISheet sheet = hssfworkbook.CreateSheet("Cell comments in POI HSSF");

// Create the drawing patriarch. This is the top level container for all shapes including cell comments.
HSSFPatriarch patr = (HSSFPatriarch)sheet.CreateDrawingPatriarch();

//Create a cell in row 3
ICell cell1 = sheet.CreateRow(3).CreateCell(1);
cell1.SetCellValue(new HSSFRichTextString("Hello, World"));

//anchor defines size and position of the comment in worksheet
IComment comment1 = patr.CreateCellComment(new HSSFClientAnchor(0, 0, 0, 0, 4, 2, 6, 5));

// set text in the comment
comment1.String = (new HSSFRichTextString("We can set comments in POI"));

//set comment author.
//you can see it in the status bar when moving mouse over the commented cell
comment1.Author = ("Apache Software Foundation");

// The first way to assign comment to a cell is via HSSFCell.SetCellComment method
cell1.CellComment = (comment1);

//Write the stream data of workbook to the root directory
FileStream file = new FileStream(@"OutputAddedCommentInCell.xls", FileMode.Create);

hssfworkbook.Write(file);

file.Close();

{{< /code >}}

## Download Running Code

Download **Add Image in Worksheet** form any of the below mentioned social coding sites:

*   [CodePlex](https://asposecellsnpoi.codeplex.com/downloads/get/1565288)
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/download/Aspose.Cells_Vs_NPOI_HWPF_and_XWPF_v1.3/Add.Comment.zip)

For more details, visit [Working with Worksheets](http://www.aspose.com/docs/display/cellsnet/Working+with+Worksheets).

