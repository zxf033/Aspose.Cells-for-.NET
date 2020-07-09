+++
title = "Using Nested Objects in Aspose.Cells" 
description = "" 
weight = 24869 
+++

Aspose.Cells for .NET : Using Nested Objects in Aspose.Cells  

# Aspose.Cells for .NET : Using Nested Objects in Aspose.Cells


Aspose.Cells supports nested objects in smart markers, the nested objects should be simple.**Individual** class need to be defined by user for below code.

We use a simple template file. See the designer spreadsheet that contains some nested smart markers.

//Initialize WorkbookDesigner objectWorkbookDesigner designer = new WorkbookDesigner();//Load the template filedesigner.Workbook = new Workbook("SM\_NestedObjects.xlsx");//Instantiate the List based on the classSystem.Collections.Generic.ICollection<Individual> list = new System.Collections.Generic.List<Individual>();//Create an object for the Individual classIndividual p1 = new Individual("Damian", 30);//Create the relevant Wife class for the Individualp1.Wife = new Wife("Dalya", 28);//Create another object for the Individual classIndividual p2 = new Individual("Mack", 31);//Create the relevant Wife class for the Individualp2.Wife = new Wife("Maaria", 29);//Add the objects to the listlist.Add(p1);list.Add(p2);//Specify the DataSourcedesigner.SetDataSource("Individual", list);//Process the markersdesigner.Process(false);//Save the Excel file.designer.Workbook.Save("out\_SM\_NestedObjects.xlsx");

## Download Sample Code

*   [Codeplex](https://asposeopenxml.codeplex.com/downloads/get/809005)
*   [Github](https://github.com/asposemarketplace/Aspose_for_OpenXML/releases/download/4/Using.Nested.Object.Aspose.Cells.zip)
*   [Bitbucket](https://bitbucket.org/asposemarketplace/aspose-for-openxml/downloads/Using%20Nested%20Object%20%28Aspose.Cells%29.zip)

