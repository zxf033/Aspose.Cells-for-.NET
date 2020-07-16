+++
title = "Track Document Conversion Progress" 
description = "" 
weight = 12076 
+++

Aspose.Cells for .NET : Track Document Conversion Progress  

# Aspose.Cells for .NET : Track Document Conversion Progress


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738026115 {padding: 0px;}div.rbtoc1590738026115 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738026115 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#TrackDocumentConversionProgress-PossibleUsageScenarios)
*   2 [Track Document Conversion Progress](#TrackDocumentConversionProgress-TrackDocumentConversionProgress)
*   3 [Sample Code](#TrackDocumentConversionProgress-SampleCode)
*   4 [Console Output](#TrackDocumentConversionProgress-ConsoleOutput)

## Possible Usage Scenarios

Sometimes converting large excel files can take some time. During this time, you might want to show the document conversion progress instead of just a loading screen to enhance the usability of your application. Aspose.Cells supports tracking document conversion process by providing the [IPageSavingCallback](https://apireference.aspose.com/net/cells/aspose.cells.rendering/ipagesavingcallback) interface. The [IPageSavingCallback](https://apireference.aspose.com/net/cells/aspose.cells.rendering/ipagesavingcallback) interface provides [PageStartSaving](https://apireference.aspose.com/net/cells/aspose.cells.rendering/ipagesavingcallback/methods/pagestartsaving) and [PageEndSaving](https://apireference.aspose.com/net/cells/aspose.cells.rendering/ipagesavingcallback/methods/pageendsaving) methods that you can implement in your custom class. You may also control which pages are rendered as demonstrated in the T*estPageSavingCallback* custom class.

## Track Document Conversion Progress


## Sample Code

The following is the code for the *TestPageSavingCallback* custom class.

## Console Output

Start saving page index 0 of pages 11  
End saving page index 0 of pages 11  
Start saving page index 1 of pages 11  
End saving page index 1 of pages 11  
Start saving page index 2 of pages 11  
End saving page index 2 of pages 11  
Start saving page index 3 of pages 11  
End saving page index 3 of pages 11  
Start saving page index 4 of pages 11  
End saving page index 4 of pages 11  
Start saving page index 5 of pages 11  
End saving page index 5 of pages 11  
Start saving page index 6 of pages 11  
End saving page index 6 of pages 11  
Start saving page index 7 of pages 11  
End saving page index 7 of pages 11  
Start saving page index 8 of pages 11  
End saving page index 8 of pages 11

## Attachments:


