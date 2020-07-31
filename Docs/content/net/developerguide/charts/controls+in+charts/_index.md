---
title : "Controls in Charts" 
description : "" 
weight : 12269 
toc : false
type: docs
url: /net/developerguide/charts/controls+in+charts/
---

# Aspose.Cells for .NET : Controls in Charts


Sometimes you need to insert drawing objects like labels, text boxes, pictures and so on into a chart. Aspose.Cells can add the controls to a chart at runtime.

{{< panel title="Contents Summary" style="primary" >}}
*   1 [Adding Label Control to the Chart](#adding-label-control-to-the-chart)
*   2 [Adding TextBox Control to the Chart](#adding-textbox-control-to-the-chart)
*   3 [Adding Picture to the Chart](#adding-picture-to-the-chart)
*   4 [Adding Checkbox in the Chart](#adding-checkbox-in-the-chart)
{{< /panel >}}
 

## Adding Label Control to the Chart

Labels provide a means for giving information to users about a spreadsheet's content.  
Aspose.Cells allows you to add and manipulate labels even into charts.

The [Aspose.Cells.Drawing.ShapeCollection](https://apireference.aspose.com/net/cells/aspose.cells.drawing/shapecollection) class provides a method named [AddLabelInChart](https://apireference.aspose.com/net/cells/aspose.cells.drawing/shapecollection/methods/addlabelinchart), used to add a label control to a chart. Below is a list of the parameters used for the method:

*   **top** – the vertical offset of the label from the upper left corner in units of 1/4000 of the chart area.
*   **left** – the vertical offset of the label from the upper left corner in units of 1/4000 of the chart area.
*   **height** – the height of the label, in units of 1/4000 of the chart area.
*   **width** – the width of label, in units of 1/4000 of the chart area.

The method returns [Aspose.Cells.Drawing.Label](https://apireference.aspose.com/net/cells/aspose.cells.drawing/label) object. The [Label](https://apireference.aspose.com/net/cells/aspose.cells.drawing/label) class represents a label in the chart. It has some important members:

*   [Text](https://apireference.aspose.com/net/cells/aspose.cells.drawing/shape/properties/text) (property) – specifies a label's caption string.
*   [Fill](https://apireference.aspose.com/net/cells/aspose.cells.drawing/shape/properties/fill) (property) – specifies the fill color attributes.

The following example shows how to add a label to the chart. The example uses a designer file (**exp\_piechart.xls**) which has a chart in it. We use this file to insert a label into the chart. Below is the original code for adding a label to the chart. The following output is generated when executing the code.

## Adding TextBox Control to the Chart

One way to highlight important information in a report is to use a text box. For example, enter text to highlight the company name or to indicate the geographic region with the highest sales. The [Aspose.Cells.Drawing.ShapeCollection](https://apireference.aspose.com/net/cells/aspose.cells.drawing/shapecollection) class provides a method named [AddTextBoxInChart](https://apireference.aspose.com/net/cells/aspose.cells.drawing/shapecollection/methods/addtextboxinchart), which is used to add a text box control to a chart. Following is the parameters list used for the method:

*   **top** – the vertical offset of the text box from the upper left corner in units of 1/4000 of the chart area.
*   **left** – the vertical offset of text box from the upper left corner in units of 1/4000 of the chart area.
*   **height** – the height of text box, in units of 1/4000 of the chart area.
*   **width** – the width of the text box, in units of 1/4000 of the chart area.

The method returns [Aspose.Cells.Drawing.TextBox](https://apireference.aspose.com/net/cells/aspose.cells.drawing/textbox) object. The [TextBox](https://apireference.aspose.com/net/cells/aspose.cells.drawing/textbox) class represents a text box in the chart.

The following example shows how to add a text box to a chart. The example uses the previous designer file (**exp\_piechart.xls**) which has a chart in it. We use this file to insert a text box into the chart to show the chart title. Below is the original code for adding text box to the chart.

## Adding Picture to the Chart

Aspose.Cells allows you to insert images into a chart. For example, add a picture to emphasize or give more meaning to a chart or its contents, or insert a brand image file.

The [Aspose.Cells.Drawing.ShapeCollection](https://apireference.aspose.com/net/cells/aspose.cells.drawing/shapecollection) class provides a method named [AddPictureInChart](https://apireference.aspose.com/net/cells/aspose.cells.drawing/shapecollection/methods/addpictureinchart), which is used to add a picture object to the chart. Following is the parameters list used for the method:

*   **top** – the vertical offset of the picture from the upper left corner in units of 1/4000 of the chart area.
*   **left** – the vertical offset of the picture from the upper left corner in units of 1/4000 of the chart area.
*   **stream** – a stream object which contains the image data.
*   **widthScale** – the scale of image width, a percentage value.
*   **heightScale** – the scale of image height, a percentage value.

The method returns an [Aspose.Cells.Drawing.Picture](https://apireference.aspose.com/net/cells/aspose.cells.drawing/picture) object. The [Picture](https://apireference.aspose.com/net/cells/aspose.cells.drawing/picture) class represents a picture object in the chart. 

The following example shows how to add a picture to the chart. The example utilizes the previous designer file (**exp\_piechart.xls**) which has a chart in it. We use this file to insert an image into the chart. Below is the original code for adding picture to the chart.

## Adding Checkbox in the Chart

Aspose.Cells allows you to insert checkboxes into a chart sheet by using [MsoDrawingType](https://apireference.aspose.com/net/cells/aspose.cells.drawing/msodrawingtype) enumeration. The following example demonstrates adding a checkbox to a chart sheet.

The following image shows the chart sheet with the checkbox in the output file.

![](https://docs2.aspose.com/cells/net/attachments/5017124/101089315.jpg)

The [output file](https://docs2.aspose.com/cells/net/attachments/5017124/101089316.xlsx) generated by the following code snippet is attached for your reference.

