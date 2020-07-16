+++
title = "Add Image in Worksheet" 
description = "" 
weight = 20929 
+++

Aspose.Cells for .NET : Add Image in Worksheet  

# Aspose.Cells for .NET : Add Image in Worksheet


## Aspose.Cells - Add Image in Worksheet

**C#**

//Instantiating a Workbook objectWorkbook workbook = new Workbook();//Adding a new worksheet to the Workbook objectWorksheetCollection worksheets = workbook.Worksheets;Worksheet worksheet = worksheets.Add("My Worksheet");//Insert a string value to a cellworksheet.Cells\["C2"\].Value = "Image";//Set the 4th row heightworksheet.Cells.SetRowHeight(3, 150);//Set the C column widthworksheet.Cells.SetColumnWidth(2, 50);//Add a picture to the C4 cellint index = worksheet.Pictures.Add(3, 2, 3, 2, "../../data/aspose.png");//Get the picture object//Picture pic = worksheet.getPictures().get(index);Picture pic = worksheet.Pictures\[index\];//Set the placement typepic.Placement = PlacementType.FreeFloating;workbook.Save("../../data/image.xlsx");

## NPOI - HSSF XSSF - Add Image in Worksheet

**C#**

IWorkbook wb = new XSSFWorkbook();ISheet sheet1 = wb.CreateSheet("First Sheet");//add picture data to this workbook.byte\[\] bytes = File.ReadAllBytes("../../data/aspose.png");int pictureIdx = wb.AddPicture(bytes, PictureType.PNG);ICreationHelper helper = wb.GetCreationHelper();// Create the drawing patriarch.  This is the top level container for all shapes.IDrawing drawing = sheet1.CreateDrawingPatriarch();// add a picture shapeIClientAnchor anchor = helper.CreateClientAnchor();//set top-left corner of the picture,//subsequent call of Picture#resize() will operate relative to itanchor.Col1 = 3;anchor.Row1 = 2;IPicture pict = drawing.CreatePicture(anchor, pictureIdx);//auto-size picture relative to its top-left cornerpict.Resize();FileStream sw = File.Create("../../data/image.xlsx");wb.Write(sw);sw.Close();

## Download Running Code

Download **Add Image in Worksheet** form any of the below mentioned social coding sites:

*   [CodePlex](https://https://asposecellsnpoi.codeplex.com/downloads/get/1536884)
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/download/Aspose.Cells_Vs_NPOI_HWPF_and_XWPF_v1.2/Add.Image.in.Worksheet.zip)

For more details, visit [Working with Worksheets](http://www.aspose.com/docs/display/cellsnet/Working+with+Worksheets).

