+++
title = "Public API Changes in Aspose.Cells 8.8.0" 
description = "" 
weight = 16773 
+++

Aspose.Cells for .NET : Public API Changes in Aspose.Cells 8.8.0  

# Aspose.Cells for .NET : Public API Changes in Aspose.Cells 8.8.0


This document describes the changes to the Aspose.Cells API from version 8.7.2 to 8.8.0 that may be of interest to module/application developers. It includes not only new and updated public methods, added & removed classes etc., but also a description of any changes in the behavior behind the scenes in Aspose.Cells.

## Added APIs

### Get Cell References for External Connection

Aspose.Cells for .NET 8.8.0 has exposed the following new properties that are helpful in retrieving the target & output cell references for external connections stored in the spreadsheet.

1.  `QueryTable.ConnectionId`: Gets the connection Id of the query table.
2.  `ExternalConnection.Id`: Gets the Id of the external connection.
3.  `ListObject.QueryTable`: Gets the linked QueryTable.

For more details on this feature, please review the detailed article on [Find Query Tables and List Objects related to External Data Connections](http://www.aspose.com/docs/display/cellsnet/Find+Query+Tables+and+List+Objects+related+to+External+Data+Connections)

### Added HTMLLoadOptions.KeepPrecision Property

Aspose.Cells for .NET 8.8.0 has added the `HTMLLoadOptions.KeepPrecision` property in order to control the conversion of long numeric values to exponential notation while importing HTML files. By default, any value longer than 15 digits gets converted to exponential notation if the data is being imported from HTML string or file. However, now the users can control this behaviour with the help of `HTMLLoadOptions.KeepPrecision` property. If the said property is set to true, the values will be imported as they are in the source.

For more details on this feature, please review the detailed article on [Avoid the Conversion of Large Numeric Values to Exponential Notation](http://www.aspose.com/docs/display/cellsnet/Avoid+exponential+notation+of+large+numbers+while+importing+from+Html)

Following is the simple usage scenario.

**C#**

{{< code lang="c#" >}}
string html = @" 
<table data-cache=""not-cached"" class=""sortable""> 
   <tbody> 
    <tr> 
     <td class=""even"">9999999999999999</td> 
     <td class=""odd"">10.8%</td> 
    </tr> 
   </tbody> 
</table> 
";

byte[] byteArray = Encoding.UTF8.GetBytes(html);
HTMLLoadOptions loadOptions = new Aspose.Cells.HTMLLoadOptions(LoadFormat.Html);
loadOptions.KeepPrecision = true;
MemoryStream stream = new MemoryStream(byteArray);
Workbook workbook = new Workbook(stream, loadOptions);
Worksheet sheet = workbook.Worksheets[0];
sheet.AutoFitColumns();
workbook.Save(dir + "output.xlsx");
{{< /code >}}

### Added HTMLLoadOptions.DeleteRedundantSpaces Property

Aspose.Cells for .NET 8.8.0 has exposed the `HTMLLoadOptions.DeleteRedundantSpaces` property in order to keep or delete the extra spaces after the line break tag (<br> Tag) while importing the data from the HTML string or file. The `HTMLLoadOptions.DeleteRedundantSpaces` property has the default value as false that means, all extra spaces will be preserved and imported to the `Workbook` object, however, when set to true, the API will delete all the redundant spaces coming after the line break tag.

For more details on this feature, please review the detailed article on [Delete Redundant Spaces from HTML](http://www.aspose.com/docs/display/cellsnet/Delete+redundant+spaces+after+line+break+while+importing+Html)

Simple usage scenario looks as follow.

**C#**

{{< code lang="c#" >}}
string html = @" 
<html>
    <body>
        <table>
            <tr>
                <td>
                    <br>    This is sample data 
                    <br>    This is sample data
                    <br>    This is sample data
                </td>
            </tr>
        </table>
    </body>
</html>
";

byte[] byteArray = Encoding.UTF8.GetBytes(html);
HTMLLoadOptions loadOptions = new Aspose.Cells.HTMLLoadOptions(LoadFormat.Html);
loadOptions.DeleteRedundantSpaces = true;
MemoryStream stream = new MemoryStream(byteArray);
Workbook workbook = new Workbook(stream, loadOptions);
workbook.Save(dir + "output.xlsx");
{{< /code >}}

### Added Style.QuotePrefix Property

Aspose.Cells for .NET 8.8.0 has exposed the `Style.QuotePrefix` property in order to detect if a cell value starts with a single quote symbol.

For more details on this feature, please review the detailed article on [Detect Single Quote at the Start of Cell Value](http://www.aspose.com/docs/display/cellsnet/Find+if+the+cell+value+starts+with+single+quote+mark)

Simple usage scenario looks as follow.

**C#**

{{< code lang="c#" >}}
Workbook book = new Workbook();
Worksheet sheet = book.Worksheets[0];
Cell a1 = sheet.Cells["A1"];
Cell a2 = sheet.Cells["A2"];

a1.PutValue("sample");
a2.PutValue("'sample");

Console.WriteLine("String value of A1: " + a1.StringValue);
Console.WriteLine("String value of A2: " + a2.StringValue);

Style s1 = a1.GetStyle();
Style s2 = a2.GetStyle();

Console.WriteLine("A1 has a quote prefix: " + s1.QuotePrefix);
Console.WriteLine("A2 has a quote prefix: " + s2.QuotePrefix);
{{< /code >}}

## Obsoleted APIs

### Obsoleted LoadOptions.ConvertNumericData Property

Aspose.Cells 8.8.0 has marked the `LoadOptions.ConvertNumericData` property as obsoleted. Please use the corresponding property from the `HTMLLoadOptions` or `TxtLoadOptions` classes.

