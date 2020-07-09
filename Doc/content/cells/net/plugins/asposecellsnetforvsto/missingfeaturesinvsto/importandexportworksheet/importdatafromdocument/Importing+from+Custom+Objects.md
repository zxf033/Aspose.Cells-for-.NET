+++
title = "Importing from Custom Objects" 
description = "" 
weight = 24833 
+++

Aspose.Cells for .NET : Importing from Custom Objects  

# Aspose.Cells for .NET : Importing from Custom Objects


Developers can import data from collection of objects to a worksheet using **ImportCustomObjects**. You can provide a list of columns/properties to the method to display your desired list of objects.

//Instantiate a new WorkbookWorkbook book = new Workbook();//Clear all the worksheetsbook.Worksheets.Clear();//Add a new Sheet "Data";Worksheet sheet = book.Worksheets.Add("Data");//Define ListList<WeeklyItem> list = new List<WeeklyItem>();//Add data to the list of objectslist.Add(new WeeklyItem() { AtYarnStage = 1, InWIPStage = 2, Payment = 3, Shipment = 4, Shipment2 = 5 });list.Add(new WeeklyItem() { AtYarnStage = 5, InWIPStage = 9, Payment = 7, Shipment = 2, Shipment2 = 5 });list.Add(new WeeklyItem() { AtYarnStage = 7, InWIPStage = 3, Payment = 3, Shipment = 8, Shipment2 = 3 });//We pick a few columns not all to import to the worksheetsheet.Cells.ImportCustomObjects((System.Collections.ICollection)list,new string\[\] { "Date", "InWIPStage", "Shipment", "Payment" },true,0,0,list.Count,true,"dd/mm/yyyy",false);//Auto-fit all the columnsbook.Worksheets\[0\].AutoFitColumns();//Save the Excel filebook.Save("ImportedCustomObjects.xls");

