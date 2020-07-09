+++
title = "Provide exported worksheet html file path via IFilePathProvider interface" 
description = "" 
weight = 20563 
+++

Aspose.Cells for .NET : Provide exported worksheet html file path via IFilePathProvider interface  

# Aspose.Cells for .NET : Provide exported worksheet html file path via IFilePathProvider interface


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738130386 {padding: 0px;}div.rbtoc1590738130386 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738130386 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#ProvideexportedworksheethtmlfilepathviaIFilePathProviderinterface-PossibleUsageScenarios)
*   2 [Provide exported worksheet HTML file path via IFilePathProvider interface](#ProvideexportedworksheethtmlfilepathviaIFilePathProviderinterface-ProvideexportedworksheetHTMLfilepathviaIFilePathProviderinterface)
*   3 [Sample Code](#ProvideexportedworksheethtmlfilepathviaIFilePathProviderinterface-SampleCode)

 

 

## Possible Usage Scenarios

Suppose, you have an excel file with multiples sheets and you want to export each sheet to individual HTML file. If any of your sheets have links to other sheets, then those links will be broken in the exported HTML. To deal with this problem, Aspose.Cells provides [IFilePathProvider](https://apireference.aspose.com/net/cells/aspose.cells/ifilepathprovider) interface which you can implement to fix the broken links.

## Provide exported worksheet HTML file path via IFilePathProvider interface


file:///C:/Temp/OtherSheets/Sheet2.html#RANGE!A1file:///C:/Temp/OtherSheets/Sheet3.html#RANGE!A1

The following screenshot shows how the `C:\Temp\Sheet1.html` and its links look like


The following screenshot shows the HTML source. As you can see that the links are now referring to `C:\Temp\OtherSheets` directory. This was achieved using the [IFilePathProvider](https://apireference.aspose.com/net/cells/aspose.cells/ifilepathprovider) interface.


## Sample Code


The sample code will only work when you will set Aspose.Cells license. If you will try to run the code without setting the license, it will go into an infinite loop. Therefore, we have added a check to print a message and stop execution when the license is not set. You can either purchase a license or request for a 30-day temporary license from Aspose.Purchase team.

Please see commenting these lines inside the code will break the links in `Sheet1.html` and `Sheet2.html` or `Sheet3.html` will not open up when their links will be clicked inside the `Sheet1.html`


## Attachments:


