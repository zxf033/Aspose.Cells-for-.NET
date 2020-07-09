+++
title = "Public API Changes in Aspose.Cells 9.0.0" 
description = "" 
weight = 16780 
+++

Aspose.Cells for .NET : Public API Changes in Aspose.Cells 9.0.0  

# Aspose.Cells for .NET : Public API Changes in Aspose.Cells 9.0.0


This document describes the changes to the Aspose.Cells API from version 8.9.2 to 9.0.0 that may be of interest to module/application developers. It includes not only new and updated public methods, added & removed classes etc., but also a description of any changes in the behavior behind the scenes in Aspose.Cells.

## Added APIs

### Added Shape.TextOptions Property

Aspose.Cells for .NET has exposed the `TextOptions` property for the `Shape` class in order to control the appearance of textual parts of a `Shape`.

Here is simple usage scenario of `Shape.TextOptions` property.

**C#**

// Initialize an instance of Workbookvar book = new Workbook();// Get the default Worksheet from the Workbookvar sheet = book.Worksheets\[0\];// Add a TextBox to the collectionvar textboxIndex = sheet.TextBoxes.Add(2, 1, 160, 200);// Get the TextBox objectvar textbox = sheet.TextBoxes\[textboxIndex\];// Add text to the TextBoxtextbox.Text = "Hello Aspose!";// Format the textual contentstextbox.TextOptions.Color = System.Drawing.Color.Red;textbox.TextOptions.IsItalic = true;

### Added LoadOptions.CultureInfo Property

Aspose.Cells for .NET 9.0.0 has exposed the `LoadOptions.CultureInfo` property which allows inject an instance of `CultureInfo` at the time of loading a document in an instance of `Workbook`.

Here is simple usage scenario of aforementioned properties.

Check the detailed article on [Loading Spreadsheet with Specific CultureInfo](http://www.aspose.com/docs/display/cellsnet/Load+the+Workbook+with+specific+System+Culture+Info)

**C#**

// Create an instance of CultureInfo and populate its propertiesvar culture = new CultureInfo("en-GB");culture.NumberFormat.NumberDecimalSeparator = ",";culture.DateTimeFormat.DateSeparator = "-";culture.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";// Create an instance of LoadOptions and set the CultureInfo propertyvar options = new LoadOptions(LoadFormat.Html);options.CultureInfo = culture;// Load a HTML or TXT file in an instance of Workbook with instance of  LoadOptionsvar book = new Workbook(dir + "input.html", options);

### Added ChartPoint.IsInSecondaryPlot Property

Aspose.Cells for .NET has exposed the `ChartPoint.IsInSecondaryPlot` property which can be used to detect if a `ChartPoint` resides on a secondary plot of a Pie or Bar chart.

Here is simple usage scenario of `Shape.Line` property.

Check the detailed article on [Finding a DataPoint resides on the Second Plot](http://www.aspose.com/docs/display/cellsnet/Find+if+Data+Points+are+in+the+Second+Pie+or+Bar+on+a+Pie+of+Pie+or+Bar+of+Pie+Chart)

**C#**

// Load an existing spreadsheet containing a Pie chartvar book = new Workbook(dir + "PieBar.xlsx");// Load the Worksheet at 0 indexvar sheet = book.Worksheets\[0\];// Load the first chart from the collectionvar chart = sheet.Charts\[0\];// Calculate the chart before accessing its propertieschart.Calculate();// Accessing chart's first seriesvar series = chart.NSeries\[0\];// Loop over the ChartPoint collectionforeach (ChartPoint point in series.Points){    // Detect if ChartPoint resides on secondary plot    Console.WriteLine(point.IsInSecondaryPlot);}

### Added OleObject.ClassIdentifier property

Aspose.Cells for .NET 9.0.0 has exposed the `OleObject.ClassIdentifier` property which can be used to specify the application behavior to load an OleObject. For instance, a PPT file can be embedded in a spreadsheet with 2 different views, that is; presentation view or slide view, whereas both views have different class identifier values.

Following is the simple usage scenario of `OleObject.ClassIdentifier` property.

Check the detailed article on [Using OleObject.ClassIdentifier](http://www.aspose.com/docs/display/cellsnet/Get+or+Set+the+Class+Identifier+of+the+Embedded+OLE+Object)

**C#**

// Load a spreadsheet containing a presentation as OleObjectvar book = new Workbook(dir + "embeddedPresentation.xls");// Initialize variables to store properties of OleObjectint upperLeftRow = 0;int upperLeftColumn = 0;int height = 0;int width = 0;byte\[\] imageData = null;int x = 0;int y = 0;byte\[\] objData = null;string progID = "";FileFormatType fileFormatType = FileFormatType.Unknown;string sourceFullName = "";bool isDisplayAsIcon = false;byte\[\] classId = null;// Get the first worksheet from the collectionvar sheet = book.Worksheets\[0\];// Get the first OleObject from the collectionvar frame = sheet.OleObjects\[0\];// Store the properties in variablesupperLeftRow = frame.UpperLeftRow;upperLeftColumn = frame.UpperLeftColumn;height = frame.Height;width = frame.Width;imageData = frame.ImageData;x = frame.X;y = frame.Y;objData = frame.ObjectData;progID = frame.ProgID;fileFormatType = frame.FileFormatType;sourceFullName = frame.ObjectSourceFullName;isDisplayAsIcon = frame.DisplayAsIcon;classId = frame.ClassIdentifier;// Initialize a new Workbook instancebook = new Workbook();// Access first worksheet from the collectionsheet = book.Worksheets\[0\];// Insert the OleObject to the worksheetint oleNumber = sheet.OleObjects.Add(upperLeftRow, upperLeftColumn, height, width, imageData);// Access newly inserted OleObjectvar embeddedObject = sheet.OleObjects\[oleNumber\];// Assign previously stored properties to new OleObjectembeddedObject.X = x;embeddedObject.Y = y;embeddedObject.ObjectData = objData;embeddedObject.ProgID = progID;embeddedObject.FileFormatType = fileFormatType;embeddedObject.DisplayAsIcon = isDisplayAsIcon;embeddedObject.ObjectSourceFullName = sourceFullName;embeddedObject.IsAutoSize = false;if (classId != null){    embeddedObject.ClassIdentifier = classId;}// Save the resultant spreadsheetbook.Save(dir  + "output.xls");

## Obsoleted APIs

### Obsoleted Worksheet.SetBackground Method

Please use `Worksheet.BackgroundImage` property instead.

### Obsoleted LineShape.BeginArrowheadStyle & ArcShape.BeginArrowheadStyle Properties

Please use `Shape.Line.BeginArrowheadStyle` property as an alternative.

### Obsoleted LineShape.EndArrowheadStyle & ArcShape.EndArrowheadStyle Properties

Please use `Shape.Line.EndArrowheadStyle` property as an alternative.

### Obsoleted LineShape.BeginArrowheadWidth & ArcShape.BeginArrowheadWidth Properties

Please use `Shape.Line.BeginArrowheadWidth` property as an alternative.

### Obsoleted LineShape.BeginArrowheadLength & ArcShape.BeginArrowheadLength Properties

Please use `Shape.Line.BeginArrowheadLength` property instead.

### Obsoleted LineShape.EndArrowheadWidth & ArcShape.EndArrowheadWidth Properties

Please use `Shape.Line.EndArrowheadWidth` property instead.

### Obsoleted LineShape.EndArrowheadLength & ArcShape.EndArrowheadLength Properties

Please use `Shape.Line.EndArrowheadLength` property instead.

## Deleted APIs

### Deleted Worksheet.CopyConditionalFormatting Method

### Deleted Workbook.CheckWriteProtectedPassword Method

## Renamed APIs

### Renamed Workbook.RemoveDigitallySign Method

The `Workbook.RemoveDigitallySign` method has been renamed to `Workbook.RemoveDigitalSignature`.

