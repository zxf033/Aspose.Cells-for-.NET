+++
title = "Using the DropDownList, List, FreeList Cell with GridWeb" 
description = "" 
weight = 20352 
+++

Aspose.Cells for .NET : Using the DropDownList, List, FreeList Cell with GridWeb  

# Aspose.Cells for .NET : Using the DropDownList, List, FreeList Cell with GridWeb


With Aspose.Cells, there are various ways to create a dropdown list: `ValidationType.DropDownList`, `List` and `FreeList` all offer this feature. The control supports a value/text pair in dropdown lists, lists and freelists. Use the `Validation.ValueList.Add` method to add a new value/text pair into the list.

In the code below, "1" is the value of the list item, and "1:test" is the list item's displayed text.

**C#**

// Adds to a bindcolumnGridWeb1.WebWorksheets\[0\].BindColumns\["CategoryID"\].Validation.ValueList.Add("1,1:test");// Adds to a validation cellGridWeb1.WebWorksheets\[1\].Cells\["A1"\].Validation.ValueList.Add("1,1:test"); 

**VB**

' Adds to a bindcolumnGridWeb1.WebWorksheets(0).BindColumns("CategoryID").Validation.ValueList.Add("1,1:test")' Adds to a validation cellGridWeb1.WebWorksheets(1).Cells("A1").Validation.ValueList.Add("1,1:test") 

Use the `LoadValueList` method to load list items from a `dataview` object:

**C#**

GridWeb1.WebWorksheets\[0\].BindColumns\["CategoryID"\].Validation.LoadValueList(dataSet31.Categories.DefaultView, "CategoryID", "CategoryName", true); 

**VB**

GridWeb1.WebWorksheets(0).BindColumns("CategoryID").Validation.LoadValueList(dataSet31.Categories.DefaultView, "CategoryID", "CategoryName", True) 

