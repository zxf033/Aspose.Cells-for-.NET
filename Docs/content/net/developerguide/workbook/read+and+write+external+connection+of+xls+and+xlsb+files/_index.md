---
title : "Read and Write External Connection of XLS and XLSB files" 
description : "" 
weight : 12123 
toc : false
type: docs
url: /net/developerguide/workbook/read+and+write+external+connection+of+xls+and+xlsb+files/
---

# Aspose.Cells for .NET : Read and Write External Connection of XLS and XLSB files


{{< panel title="Contents Summary" style="primary" >}}
*   1 [Possible Usage Scenarios](#possible-usage-scenarios)
*   2 [Read and Write External Connection of XLS/XLSB file](#read-and-write-external-connection-of-xls/xlsb-file)
*   3 [Sample Code](#sample-code)
*   4 [Console Output](#console-output)
{{< /panel >}}
 

## Possible Usage Scenarios

Aspose.Cells already supports read and write external connection of XLSX file but now, it also supports this feature for XLSB and XLS file. However, the code is the same for all types of formats.

## Read and Write External Connection of XLS/XLSB file

The following sample code loads the sample XLSB file (XLS can also be loaded) and reads its first External Connection which is actually a Microsoft Access DB Connection. It then modifies the [DBConnection.Name](https://apireference.aspose.com/net/cells/aspose.cells.externalconnections/externalconnection/properties/name) property and saves it as output XLS/XLSB file. The screenshot shows the effect of code on [sample XLSB file](https://docs2.aspose.com/cells/net/attachments/51479843/51740722.xlsb) and [output XLSB file](https://docs2.aspose.com/cells/net/attachments/51479843/51740723.xlsb) after its execution. Please also see the console output of the sample code given below for a reference.

![](https://docs2.aspose.com/cells/net/attachments/51479843/51740721.png)

## Sample Code

The following code shall work for both XLSB and XLS files by loading and saving files with the appropriate extension.

## Console Output

Connection Name: CustCommand: CustomerConnection Info: Provider=Microsoft.ACE.OLEDB.12.0;Password="";User ID=Admin;Data Source=C:\\TempSha\\Cust.accdb;Mode=Share Deny Write;Extended Properties="";Jet OLEDB:System database="";Jet OLEDB:Registry Path="";Jet OLEDB:Database Password="";Jet OLEDB:Engine Type=6;Jet OLEDB:Database Locking Mode=0;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False;Jet OLEDB:Support Complex Data=False;Jet OLEDB:Bypass UserInfo Validation=False;Jet OLEDB:Limited DB Caching=False;Jet OLEDB:Bypass ChoiceField Validation=False

