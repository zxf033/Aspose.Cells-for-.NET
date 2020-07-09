+++
title = "Query Cell Areas Mapped to XML Map Path using Worksheet.XmlMapQuery method" 
description = "" 
weight = 12333 
+++

Aspose.Cells for .NET : Query Cell Areas Mapped to XML Map Path using Worksheet.XmlMapQuery method  

# Aspose.Cells for .NET : Query Cell Areas Mapped to XML Map Path using Worksheet.XmlMapQuery method


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738063124 {padding: 0px;}div.rbtoc1590738063124 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738063124 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#QueryCellAreasMappedtoXMLMapPathusingWorksheet.XmlMapQuerymethod-PossibleUsageScenarios)
*   2 [Query Cell Areas Mapped to XML Map Path using Worksheet.XmlMapQuery method](#QueryCellAreasMappedtoXMLMapPathusingWorksheet.XmlMapQuerymethod-QueryCellAreasMappedtoXMLMapPathusingWorksheet.XmlMapQuerymethod)
    *   2.1 [Sample Code](#QueryCellAreasMappedtoXMLMapPathusingWorksheet.XmlMapQuerymethod-SampleCode)
    *   2.2 [Console Output](#QueryCellAreasMappedtoXMLMapPathusingWorksheet.XmlMapQuerymethod-ConsoleOutput)
*   3 [Get XML path from List Object/Table](#QueryCellAreasMappedtoXMLMapPathusingWorksheet.XmlMapQuerymethod-GetXMLpathfromListObject/Table)

 

## Possible Usage Scenarios

You can query cell areas mapped to the XML map path with Aspose.Cells using the [Worksheet.XmlMapQuery()](https://apireference.aspose.com/cells/net/aspose.cells/worksheet/methods/xmlmapquery) method. If the path exists, it will return the list of cell areas related to that path inside XML map. The first parameter of the [Worksheet.XmlMapQuery()](https://apireference.aspose.com/cells/net/aspose.cells/worksheet/methods/xmlmapquery) method specifies the XML element path and the second parameter specifies an XML map you want to query.

## Query Cell Areas Mapped to XML Map Path using Worksheet.XmlMapQuery method



### Sample Code

### Console Output

Query Xml Map from Path - /MiscDataAspose.Cells.CellArea(A1:A8)\[0,0,7,0\]Aspose.Cells.CellArea(B1:B8)\[0,1,7,1\]Aspose.Cells.CellArea(C1:C8)\[0,2,7,2\]Aspose.Cells.CellArea(D1:D8)\[0,3,7,3\]Aspose.Cells.CellArea(E1:E8)\[0,4,7,4\]Query Xml Map from Path - /MiscData/row/ColorAspose.Cells.CellArea(D1:D8)\[0,3,7,3\]

## Get XML path from List Object/Table

XML data can be imported to worksheets. Sometimes XML path is required from the ListObjects of the worksheet. This feature is available in Excel by using an expression like Sheet1.ListObjects(1).XmlMap.DataBinding. The same feature is available in Aspose.Cells by calling [ListObject.XmlMap.DataBinding.Url](https://apireference.aspose.com/cells/net/aspose.cells/xmldatabinding/properties/url).  The following example demonstrates this feature. Template file and other source files can be downloaded from the following links:


## Attachments:


