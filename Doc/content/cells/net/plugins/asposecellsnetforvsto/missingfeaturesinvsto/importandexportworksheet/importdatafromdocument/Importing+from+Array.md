+++
title = "Importing from Array" 
description = "" 
weight = 24831 
+++

Aspose.Cells for .NET : Importing from Array  

# Aspose.Cells for .NET : Importing from Array


Developers can import data from an array to their worksheets by calling the **ImportArray** method of the Cells collection. There are many overloaded versions of the ImportArray method but a typical overload takes the following parameters:

*   Array, represents the array object whose contents need to import
*   Row Number, represents the row number of the first cell where the data will be imported
*   Column Number, represents the column number of the first cell where the data will be imported
*   Is Vertical, a boolean value that specifies to import data vertically or horizontally

//Instantiating a Workbook objectWorkbook workbook = new Workbook();//Adding a new worksheet to the Workbook objectint i = workbook.Worksheets.Add();//Obtaining the reference of the newly added worksheet by passing its sheet indexWorksheet worksheet = workbook.Worksheets\[i\];//Creating an array containing names as string valuesstring\[\] names = new string\[\] { "laurence chen", "roman korchagin", "kyle huang" };//Importing the array of names to 1st row and first column verticallyworksheet.Cells.ImportArray(names, 0, 0, true);//Saving the Excel fileworkbook.Save("DataImport from Array.xls");

