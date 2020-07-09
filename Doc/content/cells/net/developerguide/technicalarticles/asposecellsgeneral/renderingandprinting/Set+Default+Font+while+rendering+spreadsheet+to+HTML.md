+++
title = "Set Default Font while rendering spreadsheet to HTML" 
description = "" 
weight = 20392 
+++

Aspose.Cells for .NET : Set Default Font while rendering spreadsheet to HTML  

# Aspose.Cells for .NET : Set Default Font while rendering spreadsheet to HTML


Aspose.Cells allows you to set default font while rendering spreadsheet to HTML. Please use the `HtmlSaveOptions.DefaultFontName` for this purpose. This property is useful when there are some cells in spreadsheet that has invalid or non-existing fonts. Then those cells will be rendered in a font specified with `HtmlSaveOptions.DefaultFontName` property.

## Set Default Font while rendering spreadsheet to HTML

The following sample code creates a workbook and adds some text in cell B4 of first worksheet and sets its font to some unknown/non-existing font. Then it saves the workbook in HTML by setting different default font names like Courier New, Arial, Times New Roman etc.

The screenshot shows the effect of setting different default font names via `HtmlSaveOptions.DefaultFontName` property.



## Attachments:


