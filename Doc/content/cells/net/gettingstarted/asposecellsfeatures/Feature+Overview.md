+++
title = "Feature Overview" 
description = "" 
weight = 12007 
+++

Aspose.Cells for .NET : Feature Overview  

# Aspose.Cells for .NET : Feature Overview


The tables below summarize Aspose.Cells for .NET features and provide links to detailed feature descriptions.

{{< panel title="Contents Summary" style="primary" >}}
*   1 [Supported Platforms](#FeatureOverview-SupportedPlatforms)
*   2 [File Formats and Conversions](#FeatureOverview-FileFormatsandConversions)
*   3 [Rendering and Printing](#FeatureOverview-RenderingandPrinting)
*   4 [Spreadsheet Content Features](#FeatureOverview-SpreadsheetContentFeatures)
*   5 [Spreadsheet Formatting Features](#FeatureOverview-SpreadsheetFormattingFeatures)
*   6 [PageSetup Features](#FeatureOverview-PageSetupFeatures)
{{< /panel >}}

{{< lead >}} **Summary** {{< /lead >}}
 

{{< code lang="cs" >}} <?xml version="1.0" standalone="yes"?><SalesData>  <Products>    <ProductName>Data</ProductName>    <QuantityPerUnit>Data</QuantityPerUnit>    <CategoryName>Data</CategoryName>    <UnitPrice>Data</UnitPrice>    <Sale>Data</Sale>  </Products> .........</SalesData>  {{< /code >}}

{{< code lang="cs" >}}
// Access the XML Map from the spreadsheet
var map = book.Worksheets.XmlMaps[0];

// Access first worksheet from the collection
var sheet = book.Worksheets[0];

// Map FIELD1 and FIELD2 to cell A1 and B2
sheet.Cells.LinkToXmlMap(map.Name, 0, 0, &quot;/root/row/FIELD1&quot;);
sheet.Cells.LinkToXmlMap(map.Name, 1, 1, &quot;/root/row/FIELD2&quot;);

// Map FIELD4 and FIELD5 to cell C3 and D4
sheet.Cells.LinkToXmlMap(map.Name, 2, 2, &quot;/root/row/FIELD4&quot;);
sheet.Cells.LinkToXmlMap(map.Name, 3, 3, &quot;/root/row/FIELD5&quot;);

// Map FIELD7 and FIELD8 to cell E5 and F6
sheet.Cells.LinkToXmlMap(map.Name, 4, 4, &quot;/root/row/FIELD7&quot;);
sheet.Cells.LinkToXmlMap(map.Name, 5, 5, &quot;/root/row/FIELD8&quot;);
{{< /code >}}

```
fdsfsddf
```
 

## Supported Platforms

Aspose.Cells for .NET product covers most of the popular development environments and deployment platforms.

Feature

Description

[.NET Framework](http://localhost:1313/cellsnet/gettingstarted/installationanddeployment/system+requirements)

Use Aspose.Cells for .NET to build ASP.NET, Web Services, WinForms or any other type of application for any .NET Framework versions 2.0 or later including Client Profile versions. Full support for 32-bit and 64-bit.

.NET Standard 2.0

The 'netStandard' folder contains assembly to use with framework that implement .NET Standard 2.0 such as .NET Core 2.0.

Xamarin.Android

Use Aspose.Cells for .NET in your native Android applications.

Xamarin.iOS

Use Aspose.Cells for .NET in your native iOS applications.

[COM](http://localhost:1313/cellsnet/gettingstarted/installationanddeployment/system+requirements)

Can be a lifesaver if you have to develop using pre- .NET technologies.

[Mono](http://localhost:1313/cellsnet/gettingstarted/installationanddeployment/system+requirements)

You can use Aspose.Cells for .NET to build applications with Mono.

[Windows Azure](http://localhost:1313/cellsnet/gettingstarted/installationanddeployment/system+requirements)

Aspose.Cells for .NET also runs on Windows Azure.

## File Formats and Conversions

Many customers worldwide rely on the thorough document import and export features provided by Aspose.Cells for .NET.

Feature

Description

.NET

.NET Standard 2.0

High-quality conversions

Quickly and reliably convert between several popular document formats.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Microsoft Excel workbook (XLS)

The fastest and most complete XLS format implementation you can find.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

SpreadsheetML (XLSX, XML)

Aspose.Cells supports OOXML, Flat OPC and also Excel 2003 XML. Moreover, the component supports  
all the major Excel 2007, 2010 and 2013 file formats for example XLSX, XLTX, XLSM, XLTM etc.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Comma Separated Value (CSV)

Comprehensive support of the CSV format to interact with a variety of applications.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

TSV

Load and save documents in the TSV file format.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

HTML

Save as HTML is available.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

[OpenDocument - ODS](http://localhost:1313/cellsnet/gettingstarted/asposecellsfeatures/fileformatsandconversions/opendocument+-+ods)

Aspose.Cells can load and save documents in the OpenDocument Spreadsheet (.ods) format.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Converting to PDF files

Convert any Spreadsheet to PDF with high fidelity.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Tab delimited

Load and save documents in the tab delimited file format.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Plain text (TXT)

Easily extract text by saving in plain text format.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

[XPS document](http://localhost:1313/cellsnet/developerguide/loading,saving,convertingandmanaging/convert+workbook+to+different+formats#convertworkbooktodifferentformats-convertingexcelworkbooktoxps)

Convert Excel spreadsheet to XPS document

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

[Converting worksheet to image & worksheet to image by page](http://localhost:1313/cellsnet/developerguide/technicalarticles/asposecellsgeneral/renderingandprinting/converting+worksheet+to+image+and+worksheet+to+image+by+page)

The spreadsheets can also be exported to Tagged Image File Format (TIFF) with any desired compression types.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

## Rendering and Printing

Aspose.Cells for .NET now provides high fidelity rendering of spreadsheet pages.

Feature

.NET

.NET Standard 2.0

Layout document into pages with high fidelity to Microsoft Excel® (exactly like Microsoft Excel® would do that).

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Render worksheet pages to raster images (TIFF, multipage TIFF, PNG, JPEG, BMP).

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Render spreadsheet pages to vector images (EMF).

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Specify image resolution, quality, compression, and other options.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Print spreadsheets using the .NET printing infrastructure. The component has a built-in print method to print the worksheets as shown in Microsoft Excel's Print Preview.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Update page numbers and other fields before rendering or printing.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

## Spreadsheet Content Features

Aspose.Cells for .NET provides a rich object model that consists of over 100 public classes, which allow you to programmatically generate, combine, modify, parse or otherwise examine loaded spreadsheets. Some key features are given in the below table.

Feature

.NET

.NET Standard 2.0

Import/export data from a DataTable, DataView, Array, DataGrid etc.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Add a copy of existing worksheet (all contents including images, charts, other objects, etc.)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Copy or move worksheets within or between workbooks

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Insert images

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Create charts

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Set gradient background for charts using API

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Add comments to cells

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Microsoft Excel 2007 themes and colors

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Create auto-filters

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Implement data validations

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Implement data sorting

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Find and replace text

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Merge/split cells

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Group/ungroup rows and columns

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Create custom page breaks

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Insert/delete or hide rows, columns, and sheets

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Calculate complex Excel formulae

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Support advanced conditional formatting supported in Microsoft Excel 2007

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Freeze/unfreeze Panes

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Insert hyperlinks to link data

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Implement Smart Markers

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Specify document property settings

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Protect/unprotect Worksheets

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Specify advanced protection options introduced in Excel XP and later versions

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Create list object/Microsoft Excel tables

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Create subtotals

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Insert form controls and other drawing shapes/objects

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Create pivot tables and pivot charts

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Preserve or remove addin, VBA, macros

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Manipulate named ranges

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Implement transpose options

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Create custom charts

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Add, preserve or extract OLE objects from the spreadsheets.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Implement Microsoft Excel 2010 sparklines

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Encrypt files

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

## Spreadsheet Formatting Features

Aspose.Cells for .NET provides detailed programmatic access to formatting properties of all spreadsheet elements.

Feature

.NET

.NET Standard 2.0

Apply all characters formatting in the cells including fonts, colors, effects, borders, and shading.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Apply all the number format settings supported by Microsoft Excel to cells.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Set all types of text alignment settings.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Apply different kinds of font settings for the cells.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Apply different colors to cells, fonts, gridlines, graphic objects, etc.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Apply different rich text formatting in a single cell.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Apply different border settings on cells.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Apply different background patterns on cells.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Apply format settings on a worksheet, row, column or a range of cells, etc.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

## PageSetup Features

You can use Aspose.Cells for .NET to implement PageSetup options for your worksheets.

Feature

.NET

.NET Standard 2.0

Adjust your page orientation, scaling, paper size.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Specify your margins and page centering.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Create or edit your header and/or footer.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

Set print area, print titles, or turn on gridlines, etc.

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

![(tick)](s/en_GB-1988229788/4108/b47156ace146e4f759b49ef98258cb637bdd5af8.5/_/images/icons/emoticons/check.png)

