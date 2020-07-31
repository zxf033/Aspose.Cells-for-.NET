---
title : "Insert a Linked Picture from Web Address" 
description : "" 
weight : 20466 
toc : false
type: docs
url: /net/developerguide/technicalarticles/general/mngworkbooksandworksheets/insert+a+linked+picture+from+web+address/
---

# Aspose.Cells for .NET : Insert a Linked Picture from Web Address


Sometimes you need to insert a picture from the web (http://) into a worksheet. To do so, specify the picture’s URL and the picture will be downloaded every time the spreadsheet is opened in Microsoft Excel. The image is not physically embedded into the Excel document, but points to a web resource.

## Using Microsoft Excel

In Microsoft Excel (for example 2007):

1.  Click the **Insert** menu and select **Picture**.
2.  Specify the web address for the picture in the Insert Picture dialog.

## Using Aspose.Cells for .NET

Aspose.Cells for .NET supports adding a linked image using the [ShapeCollection.AddLinkedPicture(int upperLeftRow, int upperLeftColumn, int heightPixels, int widthPixels, string sourceFullName)](https://apireference.aspose.com/net/cells/aspose.cells.drawing/shapecollection/methods/addlinkedpicture). The method returns a [Picture](https://apireference.aspose.com/net/cells/aspose.cells.drawing/picture) object.

The following example shows how to add linked picture from web address to a worksheet.

