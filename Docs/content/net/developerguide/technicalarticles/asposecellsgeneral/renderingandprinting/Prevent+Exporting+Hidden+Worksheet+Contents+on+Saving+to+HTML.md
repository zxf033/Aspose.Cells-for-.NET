+++
title = "Prevent Exporting Hidden Worksheet Contents on Saving to HTML" 
description = "" 
weight = 20376 
+++

Aspose.Cells for .NET : Prevent Exporting Hidden Worksheet Contents on Saving to HTML  

# Aspose.Cells for .NET : Prevent Exporting Hidden Worksheet Contents on Saving to HTML


You can save Excel workbooks to HTML. However, if the workbook contains hidden worksheets, Aspose.Cells by default exports the hidden worksheet contents to the HTML output (\_files) directory which contains files such as worksheets, images, tabstrip.htm, stylesheet.css etc. Sometimes, exporting the hidden worksheets content this way isn't appropriate. For example, if the hidden worksheet contains images that should not be exported to the \_files directory.

Aspose.Cells provides the `HtmlSaveOptions.ExportHiddenWorksheet` property. By default, it is set to true and hidden worksheets are exported to HTML. If you set it false, Aspose.Cells will not export hidden worksheet contents.

