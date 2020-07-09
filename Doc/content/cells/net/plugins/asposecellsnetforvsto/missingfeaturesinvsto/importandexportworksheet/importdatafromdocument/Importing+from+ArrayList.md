+++
title = "Importing from ArrayList" 
description = "" 
weight = 24832 
+++

Aspose.Cells for .NET : Importing from ArrayList  

# Aspose.Cells for .NET : Importing from ArrayList


Developers can import data from an ArrayList to their worksheets by calling the **ImportArrayList** method of the Cells collection. ImportArray method takes the following parameters: **ArrayList** , represents the ArrayList object whose contents need to import

*   Row Number , represents the row number of the first cell where the data will be imported
*   Column Number , represents the column number of the first cell where the data will be imported
*   Is Vertical , a boolean value that specifies to import data vertically or horizontally

//Instantiating a Workbook objectWorkbook workbook = new Workbook();//Adding a new worksheet to the Workbook objectint i = workbook.Worksheets.Add();//Obtaining the reference of the newly added worksheet by passing its sheet indexWorksheet worksheet = workbook.Worksheets\[i\];//Instantiating an ArrayList objectArrayList list = new ArrayList();//Add few names to the list as string valueslist.Add("laurence chen");list.Add("roman korchagin");list.Add("kyle huang");list.Add("tommy wang");//Importing the contents of ArrayList to 1st row and first column verticallyworksheet.Cells.ImportArrayList(list, 0, 0, true);//Saving the Excel fileworkbook.Save("DataImport from Array List.xls");

