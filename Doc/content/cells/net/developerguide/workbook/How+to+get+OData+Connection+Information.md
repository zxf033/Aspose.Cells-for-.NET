+++
title = "How to get OData Connection Information" 
description = "" 
weight = 12121 
+++

Aspose.Cells for .NET : How to get OData Connection Information  

# Aspose.Cells for .NET : How to get OData Connection Information


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738031805 {padding: 0px;}div.rbtoc1590738031805 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738031805 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Get OData Connection Information](#HowtogetODataConnectionInformation-GetODataConnectionInformation)
    *   1.1 [Sample Code](#HowtogetODataConnectionInformation-SampleCode)
    *   1.2 [Console Output](#HowtogetODataConnectionInformation-ConsoleOutput)

 

# Get OData Connection Information

There might be cases where developers need to extract OData information from the excel file. Aspose.Cells provides the [Workbook.DataMashup](https://apireference.aspose.com/net/cells/aspose.cells/workbook/properties/datamashup) property which returns the DataMashup information present in the Excel file. This information is represented by the [DataMashup](https://apireference.aspose.com/net/cells/aspose.cells.querytables/datamashup) class. The [DataMashup](https://apireference.aspose.com/net/cells/aspose.cells.querytables/datamashup) class provides the [PowerQueryFormulas](https://apireference.aspose.com/net/cells/aspose.cells.querytables/datamashup/properties/powerqueryformulas) property that returns the [PowerQueryFormulaCollction](https://apireference.aspose.com/net/cells/aspose.cells.querytables/powerqueryformulacollction) collection. From the [PowerQueryFormulaCollction](https://apireference.aspose.com/net/cells/aspose.cells.querytables/powerqueryformulacollction), you can get access to [PowerQueryFormula](https://apireference.aspose.com/net/cells/aspose.cells.querytables/powerqueryformula) and [PowerQueryFormulaItem](https://apireference.aspose.com/net/cells/aspose.cells.querytables/powerqueryformulaitem).

The following code snippet demonstrates the use of these classes to retrieve the OData information.

The Source file used in the following code snippet is attached for your reference.


### Sample Code

### Console Output

Connection Name: Orders

Name: Source

Value: OData.Feed("https://services.odata.org/V3/Northwind/Northwind.svc/", null, \[Implementation="2.0"\])

Name: Orders\_table

Value: Source{\[Name="Orders",Signature="table"\]}\[Data\]

## Attachments:


