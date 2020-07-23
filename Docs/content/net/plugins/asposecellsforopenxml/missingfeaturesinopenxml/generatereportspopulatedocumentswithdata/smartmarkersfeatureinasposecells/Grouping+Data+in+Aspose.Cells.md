+++
title = "Grouping Data in Aspose.Cells" 
description = "" 
weight = 24866 
+++

Aspose.Cells for .NET : Grouping Data in Aspose.Cells  

# Aspose.Cells for .NET : Grouping Data in Aspose.Cells


In some Excel reports you might need to break the data into groups to make it easier to read and analyze. One of the primary purposes for breaking data into groups is to run calculations (perform summary operations) on each group of records.

Aspose.Cells smart markers allow you to group your data by field(s) and place summary rows in between data sets or data groups. For example, if grouping data by Customers.CustomerID, you can add a summary record every time the group changes.

The example code snippets that follow shows how to group data in an Excel report using smart markers.

### Parameters

Following are some of the smart marker parameters used for grouping data.  
**group:normal/merge/repeat**

We support three types of group that you can choose between.

*   normal - The group by field(s) value is not be repeated for the corresponding records in the column; instead they are printed once per data group.
*   merge - The same behavior as for the normal parameter, except that it merges the cells in the group by field(s) for each group set.
*   repeat - The group by field(s) value is repeated for the corresponding records.

If you have multiple parameters, separate them with a commas, but no space: parameterA,parameterB,parameterC

### Example

This example shows some of the grouping parameters in action. It uses the Northwind.mdb Microsoft Access database and extract data from the table named "Order Details". We create a designer file called SmartMarker\_Designer.xls in Microsoft Excel and put smart markers into various cells in worksheets. The markers are processed to fill the worksheets. The data is placed and organized by a group field.

The designer file has two worksheets. In the first we put smart markers with grouping parameters as shown in the screenshot below. Three smart markers (with grouping parameters) are placed:  
&=Order Details.OrderID(group:merge,skip:1),  
&=Order Details.Quantity(subtotal9:Order Details.OrderID), and  
&=Order Details.UnitPrice(subtotal9:Order Details.OrderID) go into A5, B5 and C5 respectively.

{{< code lang="cs" >}}
//Create a connection object, specify the provider info and set the data source.
OleDbConnection con = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=Northwind.mdb");

//Open the connection object.
con.Open();

//Create a command object and specify the SQL query.
OleDbCommand cmd = new OleDbCommand("Select * from [Order Details]", con);

//Create a data adapter object.
OleDbDataAdapter da = new OleDbDataAdapter();

//Specify the command.
da.SelectCommand = cmd;

//Create a dataset object.
DataSet ds = new DataSet();

//Fill the dataset with the table records.
da.Fill(ds, "Order Details");

//Create a datatable with respect to dataset table.
DataTable dt = ds.Tables["Order Details"];

//Create WorkbookDesigner object.
WorkbookDesigner wd = new WorkbookDesigner();

//Open the template file (which contains smart markers).
wd.Workbook = new Workbook("SmartMarkerDesigner.xls");

//Set the datatable as the data source.
wd.SetDataSource(dt);

//Process the smart markers to fill the data into the worksheets.
wd.Process(true);

//Save the excel file.
wd.Workbook.Save("outSmartMarker_Designer.xls");
{{< /code >}}

## Download Sample Code

*   [Codeplex](https://asposeopenxml.codeplex.com/downloads/get/808997)
*   [Github](https://github.com/asposemarketplace/Aspose_for_OpenXML/releases/download/4/Work.with.Rows.n.Columns.Aspose.Cells.zip)
*   [Bitbucket](https://bitbucket.org/asposemarketplace/aspose-for-openxml/downloads/Grouping%20Data%20OLE%20DB%20%28Aspose.Cells%29.zip)

