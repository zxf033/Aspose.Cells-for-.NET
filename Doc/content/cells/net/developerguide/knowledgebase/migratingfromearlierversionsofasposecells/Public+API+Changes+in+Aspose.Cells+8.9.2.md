+++
title = "Public API Changes in Aspose.Cells 8.9.2" 
description = "" 
weight = 16779 
+++

Aspose.Cells for .NET : Public API Changes in Aspose.Cells 8.9.2  

# Aspose.Cells for .NET : Public API Changes in Aspose.Cells 8.9.2


This document describes the changes to the Aspose.Cells API from version 8.9.1 to 8.9.2 that may be of interest to module/application developers. It includes not only new and updated public methods, added & removed classes etc., but also a description of any changes in the behavior behind the scenes in Aspose.Cells.

Please also check the [Public API Changes introduced in Aspose.Cells for .NET 8.9.1](http://aspose.com/docs/display/cellsnet/Public+API+Changes+in+Aspose.Cells+8.9.1)

## Added APIs

### Added TextOptions Class & FontSettings.TextOptions Property

Aspose.Cells for .NET has exposed the `TextOptions` class along with `FontSettings.TextOptions` property in order to control the appearance of textual parts of a `Shape`.

Here is simple usage scenario of `FontSettings.TextOptions` property.

**C#**

// Initialize Workbook instancevar book = new Workbook();// Access first worksheet from collectionvar sheet = book.Worksheets\[0\];// Add a Shape of type TextBox to the collection var shape = sheet.Shapes.AddTextBox(0, 0, 0, 0, 100, 200);// Access TextOptions of Shapevar textOptions = shape.TextBody\[1\].TextOptions;

### Added TextOptions.Fill, Outline & Shadow Properties

Aspose.Cells for .NET 8.9.2 has exposed the `TextOptions.Fill`, `TextOptions.Outline` & `TextOptions.Shadow` properties which allows to control the aspects of textual contents of the shape, such as fill, shadow & outline respectively.

Here is simple usage scenario of aforementioned properties.

**C#**

// Initialize Workbook instancevar book = new Workbook();// Access first worksheet from collectionvar sheet = book.Worksheets\[0\];// Add a Shape of type TextBox to the collection var shape = sheet.Shapes.AddTextBox(0, 0, 0, 0, 100, 200);// Set text for TextBoxshape.Text = "Aspose";// Access TextOptions of Shapevar textOptions = shape.TextBody\[1\].TextOptions;// Set shadow textOptions.Shadow.PresetType = PresetShadowType.Below;// Set fill colortextOptions.Fill.FillType = FillType.Solid;textOptions.Fill.SolidFill.Color = Color.Red;// Set outline colortextOptions.Outline.SetOneColorGradient(Color.Blue, 0.3, GradientStyleType.Horizontal, 2);

### Added Shape.Line Property

Aspose.Cells for .NET has exposed the `Shape.Line` property which returns an instance of `LineFormat` in order to control the appearance of outlines of a `Shape`.

Here is simple usage scenario of `Shape.Line` property.

**C#**

// Initialize Workbook instancevar book = new Workbook();// Access first worksheet from collectionvar sheet = book.Worksheets\[0\];// Add a Shape of type TextBox to the collection var shape = sheet.Shapes.AddTextBox(0, 0, 0, 0, 100, 200);// Access LineFormat of Shapevar line = shape.Line;// Set weight of lineline.Weight = 1;

### Added Shape.Fill property

Aspose.Cells for .NET 8.9.2 has exposed the `Shape.Fill` property which returns an instance of `FillFormat` in order to control the different aspects of shape area.

Following is the simple usage scenario of `Shape.Fill` property.

**C#**

// Initialize Workbook instancevar book = new Workbook();// Access first worksheet from collectionvar sheet = book.Worksheets\[0\];// Add a Shape of type TextBox to the collection var shape = sheet.Shapes.AddTextBox(0, 0, 0, 0, 100, 200);// Access FillFormat of Shapevar fill = shape.Fill;// Set color for fillfill.SetOneColorGradient(Color.Red, 0.1, GradientStyleType.Horizontal, 2);

## Obsoleted APIs

### Obsoleted ShapeFont Class

Please use `TextOptions` class instead.

### Obsoleted ShapeFormat Class

Please directly use `Shape.Fill` and `Shape.Line` properties.

### Obsoleted Shape.Format Property

Please directly use `Shape.Fill` and `Shape.Line` properties.

### Obsoleted Shape.LineFormat Property

Please use `Shape.Line` property instead.

### Obsoleted Shape.FillFormat Property

Please use `Shape.Fill` property instead.

### Obsoleted FontSetting.ShapeFont Property

Please use `FontSetting.TextOptions` property instead.

