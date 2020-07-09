+++
title = "Get DrawObject and Bound while rendering to Pdf using DrawObjectEventHandler class" 
description = "" 
weight = 12094 
+++

Aspose.Cells for .NET : Get DrawObject and Bound while rendering to Pdf using DrawObjectEventHandler class  

# Aspose.Cells for .NET : Get DrawObject and Bound while rendering to Pdf using DrawObjectEventHandler class


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738028386 {padding: 0px;}div.rbtoc1590738028386 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738028386 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#GetDrawObjectandBoundwhilerenderingtoPdfusingDrawObjectEventHandlerclass-PossibleUsageScenarios)
*   2 [Get DrawObject and Bound while rendering to Pdf using DrawObjectEventHandler class](#GetDrawObjectandBoundwhilerenderingtoPdfusingDrawObjectEventHandlerclass-GetDrawObjectandBoundwhilerenderingtoPdfusingDrawObjectEventHandlerclass)
*   3 [Sample Code](#GetDrawObjectandBoundwhilerenderingtoPdfusingDrawObjectEventHandlerclass-SampleCode)
*   4 [Console Output](#GetDrawObjectandBoundwhilerenderingtoPdfusingDrawObjectEventHandlerclass-ConsoleOutput)

 

## Possible Usage Scenarios

Aspose.Cells provides an abstract class [DrawObjectEventHandler](https://apireference.aspose.com/net/cells/aspose.cells.rendering/drawobjecteventhandler) which has a [Draw()](https://apireference.aspose.com/net/cells/aspose.cells.rendering/drawobjecteventhandler/methods/draw) method. The user can implement [DrawObjectEventHandler](https://apireference.aspose.com/net/cells/aspose.cells.rendering/drawobjecteventhandler) and utilize the [Draw()](https://apireference.aspose.com/net/cells/aspose.cells.rendering/drawobjecteventhandler/methods/draw) method to get the [DrawObject](https://apireference.aspose.com/net/cells/aspose.cells.rendering/drawobject) and Bound while rendering Excel to PDF or Image. Here is a brief description of the parameters of the [Draw()](https://apireference.aspose.com/net/cells/aspose.cells.rendering/drawobjecteventhandler/methods/draw) method.

*   `drawObject`

[DrawObject](https://apireference.aspose.com/net/cells/aspose.cells.rendering/drawobject) will be initialized and returned when rendering

*   `x`

Left of [DrawObject](https://apireference.aspose.com/net/cells/aspose.cells.rendering/drawobject)

*   `y`

Top of [DrawObject](https://apireference.aspose.com/net/cells/aspose.cells.rendering/drawobject)

*   `width`

Width of [DrawObject](https://apireference.aspose.com/net/cells/aspose.cells.rendering/drawobject)

*   `height`

Height of [DrawObject](https://apireference.aspose.com/net/cells/aspose.cells.rendering/drawobject)

If you are rendering Excel file to PDF, then you can utilize [DrawObjectEventHandler](https://apireference.aspose.com/net/cells/aspose.cells.rendering/drawobjecteventhandler) class with [PdfSaveOptions.DrawObjectEventHandler](https://apireference.aspose.com/net/cells/aspose.cells/pdfsaveoptions/properties/drawobjecteventhandler). Similarly, if you are rendering Excel file to Image, you can utilize [DrawObjectEventHandler](https://apireference.aspose.com/net/cells/aspose.cells.rendering/drawobjecteventhandler) class with [ImageOrPrintOptions.DrawObjectEventHandler](https://apireference.aspose.com/net/cells/aspose.cells.rendering/imageorprintoptions/properties/drawobjecteventhandler).

## Get DrawObject and Bound while rendering to Pdf using DrawObjectEventHandler class


## Sample Code

## Console Output

\[X\]: 153.6035 \[Y\]: 82.94118 \[Width\]: 103.2035 \[Height\]: 14.47059 \[Cell Value\]: This is sample text.----------------------\[X\]: 267.6917 \[Y\]: 153.4853 \[Width\]: 160.4491 \[Height\]: 128.0647 \[Shape Name\]: Sun----------------------

## Attachments:


