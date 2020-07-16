+++
title = "Adding New Worksheets to Workbook and Activating a Sheet in VSTO and Aspose.Cells" 
description = "" 
weight = 16791 
+++

Aspose.Cells for .NET : Adding New Worksheets to Workbook and Activating a Sheet in VSTO and Aspose.Cells  

# Aspose.Cells for .NET : Adding New Worksheets to Workbook and Activating a Sheet in VSTO and Aspose.Cells


## Migration tip:

1.  Add new worksheets to an existing Microsoft Excel file.
2.  Fill data into the cells of each new worksheet.
3.  Activate a sheet in the workbook.
4.  Save as Microsoft Excel file.

Below, are parallel code snippets for VSTO (C#) and Aspose.Cells for .NET (C#), that show how to achieve these tasks.

**VSTO**

//intiate application objectExcel.Application excelApp = Application;//Specify the template excel file path.string myPath = "Book1.xls";//Open the excel file.excelApp.Workbooks.Open(myPath, Missing.Value, Missing.Value,Missing.Value, Missing.Value,Missing.Value, Missing.Value,Missing.Value, Missing.Value,Missing.Value, Missing.Value,Missing.Value, Missing.Value,Missing.Value, Missing.Value);//Declare a Worksheet object.Excel.Worksheet newWorksheet;//Add 5 new worksheets to the workbook and fill some data//into the cells.for (int i = 1; i < 6; i++){                //Add a worksheet to the workbook.                newWorksheet = (Excel.Worksheet)excelApp.Worksheets.Add(Missing.Value, Missing.Value,                Missing.Value, Missing.Value);                //Name the sheet.                newWorksheet.Name = "New\_Sheet" + i.ToString();                //Get the Cells collection.                Excel.Range cells = newWorksheet.Cells;                //Input a string value to a cell of the sheet.                cells.set\_Item(i, i, "New\_Sheet" + i.ToString());            }//Activate the first worksheet by default.((Excel.Worksheet)excelApp.ActiveWorkbook.Sheets\[1\]).Activate();//Save As the excel file.excelApp.ActiveWorkbook.SaveCopyAs("out\_Book1.xls");//Quit the Application.excelApp.Quit();

**Aspose.Cells**

//Instantiate an instance of license and set the license file//through its pathAspose.Cells.License license = new Aspose.Cells.License();license.SetLicense("Aspose.Total.lic");//Specify the template excel file path.string myPath = "Book1.xls";//Instantiate a new Workbook.//Open the excel file.Workbook workbook = new Workbook(myPath);//Declare a Worksheet object.Worksheet newWorksheet;//Add 5 new worksheets to the workbook and fill some data//into the cells.for (int i = 0; i < 5; i++){                //Add a worksheet to the workbook.                newWorksheet = workbook.Worksheets\[workbook.Worksheets.Add()\];                //Name the sheet.                newWorksheet.Name = "New\_Sheet" + (i + 1).ToString();                //Get the Cells collection.                Cells cells = newWorksheet.Cells;                //Input a string value to a cell of the sheet.                cells\[i, i\].PutValue("New\_Sheet" + (i + 1).ToString());            }//Activate the first worksheet by default.workbook.Worksheets.ActiveSheetIndex = 0;//Save As the excel file.workbook.Save("out\_My\_Book1.xls");

## Download Sample Code

*   [Codeplex](https://asposevsto.codeplex.com/downloads/get/1459772)
*   [Github](https://github.com/asposemarketplace/Aspose_for_VSTO/releases/download/Aspose.Cells1.1/Adding.New.Worksheets.to.Workbook.and.Activating.a.Sheet.Aspose.Cells.zip)
*   [Sourceforge](http://goo.gl/tLdAKr)
*   [Bitbucket](https://bitbucket.org/asposemarketplace/aspose-for-vsto/downloads/Adding%20New%20Worksheets%20to%20Workbook%20and%20Activating%20a%20Sheet%20(Aspose.Cells).zip)

