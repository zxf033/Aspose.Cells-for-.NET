+++
title = "Data in Non-Primitive Shape" 
description = "" 
weight = 12283 
+++

Aspose.Cells for .NET : Data in Non-Primitive Shape  

# Aspose.Cells for .NET : Data in Non-Primitive Shape


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738055966 {padding: 0px;}div.rbtoc1590738055966 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738055966 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Accessing Data of Non-Primitive Shape](#DatainNon-PrimitiveShape-AccessingDataofNon-PrimitiveShape)
*   2 [A Non-Primitive Shape](#DatainNon-PrimitiveShape-ANon-PrimitiveShape)

 

## Accessing Data of Non-Primitive Shape

Sometimes, you need to access data from a shape that is not built-in. Built-in shapes are called primitive shapes; ones that aren't are called non-primitive. For example, you can define your own shapes using different curve connected lines.

## A Non-Primitive Shape

In Aspose.Cells, non-primitive shapes are assigned the type [AutoShapeType.NotPrimitive](https://apireference.aspose.com/net/cells/aspose.cells.drawing/autoshapetype). You can check their type using the [Shape.AutoShapeType](https://apireference.aspose.com/net/cells/aspose.cells.drawing/shape/properties/autoshapetype) property.

Access the shape data using the [Shape.Paths](https://apireference.aspose.com/net/cells/aspose.cells.drawing/shape/properties/paths) property. It returns all the connected paths that comprise the non-primitive shape. These paths are of the type [ShapePath](https://apireference.aspose.com/net/cells/aspose.cells.drawing/shapepath) that holds a list of all the segments which in turn contain the points in each segment.

**Shows an example of a non-primitive shape**


## Attachments:


