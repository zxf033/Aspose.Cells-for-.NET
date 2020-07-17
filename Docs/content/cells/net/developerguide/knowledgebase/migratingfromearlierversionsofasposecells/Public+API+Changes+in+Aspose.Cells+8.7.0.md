+++
title = "Public API Changes in Aspose.Cells 8.7.0" 
description = "" 
weight = 16770 
+++

Aspose.Cells for .NET : Public API Changes in Aspose.Cells 8.7.0  

# Aspose.Cells for .NET : Public API Changes in Aspose.Cells 8.7.0


This document describes the changes to the Aspose.Cells API from version 8.6.3 to 8.7.0 that may be of interest to module/application developers. It includes not only new and updated public methods, added & removed classes etc., but also a description of any changes in the behavior behind the scenes in Aspose.Cells.

## Added APIs

### Support for VBA Project Digital Signing, Detection & Extraction

This release of Aspose.Cells for .NET has exposed some new properties and methods to aid the users in tasks such as digitally signing a VBA project, detecting if a VBA project is signed & valid. Moreover, the new API allows to extract the certificate as raw data from digitally signed VBA project in `Workbook`.

###### Digitally Sign VBA Project

Aspose.Cells for .NET 8.7.0 has exposed the `VbaProject.Sign` method that can be used to [digitally sign the VBA project in a Workbook](http://www.aspose.com/docs/display/cellsnet/Digitally+Sign+a+VBA+Code+Project+with+Certificate). The said method accepts an instance of `DigitalSignature` class which resides in the `Aspose.Cells.DigitalSignatures` namespace.

Following is the simple usage scenario.

**C#**

//Create an instance of Workbook//Optionally load an existing spreadsheetvar book = new Workbook();//Access the VbaProject from the Workbookvar vbaProject = book.VbaProject;//Sign the VbaProject using the X509CertificatevbaProject.Sign(new DigitalSignature(new System.Security.Cryptography.X509Certificates.X509Certificate2(cert), "Comments", DateTime.Now));

###### Detection of Digitally Signed VBA Project

Newly exposed `VbaProject.IsSigned` property can be used to in [detect if the VBA project in a Workbook is digitally signed](http://www.aspose.com/docs/display/cellsnet/Check+if+VBA+Code+is+Signed). The `VbaProject.IsSigned` property is of type Boolean, which returns true if the VBA project is digitally signed and vice versa.

Following is the simple usage scenario.

**C#**

//Create an instance of Workbook and load an existing spreadsheetvar book = new Workbook(inFilePath);//Access the VbaProject from the Workbookvar vbaProject = book.VbaProject;//Check if VbaProject is digitally signedif (vbaProject.IsSigned){    Console.WriteLine("VbaProject is digitally signed");}else{    Console.WriteLine("VbaProject is not digitally signed");}

###### Extraction of Digital Signature from VBA Project

This revision of the API has also exposed the `VbaProject.CertRawData` property which allows to [extract the digital certificate's raw data from the VBA project](http://www.aspose.com/docs/display/cellsnet/Export+VBA+Certifcate+to+File+or+Stream). The `VbaProject.CertRawData` property is of type byte array, which will contain the raw certificate data if VBA project is digitally signed, otherwise the said property will be null.

Following is the simple usage scenario.

**C#**

//Create an instance of Workbook and load an existing spreadsheetvar book = new Workbook(inFilePath);//Access the VbaProject from the Workbookvar vbaProject = book.VbaProject;//Extract digital signature in an array of bytesvar cert = vbaProject.CertRawData;

###### Validate the Digital Signature of VBA Project

Another addition to the public API is the `VbaProject.IsValidSigned` property which could be useful in [validating the digital signature of the VBA project](http://www.aspose.com/docs/display/cellsnet/Check+if+Digital+Signature+of+VBA+Code+is+Valid). The said property returns true if the digital signature is valid and false if the signature is invalid.

Following is the simple usage scenario.

**C#**

//Create an instance of Workbook and load an existing spreadsheetvar book = new Workbook(inFilePath);//Access the VbaProject from the Workbookvar vbaProject = book.VbaProject;//Check if VbaProject is digitally signedif (vbaProject.IsSigned){    //Check if signature is valid    if (vbaProject.IsValidSigned)    {        Console.WriteLine("VbaProject is digitally signed & signature is valid");    }}

### Method Protection.VerifyPassword Added

Aspose.Cells for .NET 8.7.0 has exposed the `Protection.VerifyPassword` method that can be used to [verify the password used to protect the Worksheet](http://www.aspose.com/docs/display/cellsnet/Verify+Password+Used+to+Protect+the+Worksheet). This method accepts an instance of string as parameter and returns true if specified password matches with the password used to protect the `Worksheet`.

Following is the simple usage scenario.

**C#**

//Create an instance of Workbook and load an existing spreadsheetvar book = new Workbook(inFilePath);//Access the desired Worksheet via its index or namevar sheet = book.Worksheets\[0\];//Access Protection module of desired Worksheetvar protection = sheet.Protection;//Verify the password for Worksheetif (protection.VerifyPassword(password)){    Console.WriteLine("Password has matched");}else{    Console.WriteLine("Password did not match");}

### Property Protection.IsProtectedWithPassword Added

This release of Aspose.Cells for .NET API has also exposed the `Protection.IsProtectedWithPassword` property that can be useful in [detecting if a Worksheet is password protected or not](http://www.aspose.com/docs/display/cellsnet/Detect+if+Worksheet+is+Password+Protected).

Following is the simple usage scenario.

**C#**

//Create an instance of Workbook and load an existing spreadsheetvar book = new Workbook(inFilePath);//Access the desired Worksheet via its index or namevar sheet = book.Worksheets\[0\];//Access Protection module of desired Worksheetvar protection = sheet.Protection;//Check if Worksheet is password protectedif (protection.IsProtectedWithPassword){    Console.WriteLine("Worksheet is password protected");}else{    Console.WriteLine("Worksheet is not password protected");}

### Property ColorScale.Is3ColorScale Added

Aspose.Cells for .NET 8.7.0 has exposed the `ColorScale.Is3ColorScale` property that can be used to create 2-Color Scale conditional format. The said property is of type Boolean with default value of true which means that the conditional format will be of 3-Color Scale by default. However, switching the `ColorScale.Is3ColorScale` property to false will [generate a 2-Color Scale conditional format](http://www.aspose.com/docs/display/cellsnet/Adding+2-Color+Scale+and+3-Color+Scale+Conditional+Formattings).

Following is the simple usage scenario.

**C#**

//Create an instance of Workbook//Optionally load an existing spreadsheetvar book = new Workbook();//Access the Worksheet to which conditional formatting rule has to be addedvar sheet = book.Worksheets\[0\];//Add FormatConditions to the collectionint index = sheet.ConditionalFormattings.Add();//Access newly added formatConditionCollection via its indexvar formatConditionCollection = sheet.ConditionalFormattings\[index\];//Create a CellArea on which conditional formatting rule will be appliedvar cellArea = CellArea.CreateCellArea("A1", "A5");//Add conditional formatted cell rangeformatConditionCollection.AddArea(cellArea);//Add format condition of type ColorScaleindex = formatConditionCollection.AddCondition(FormatConditionType.ColorScale);//Access newly added format condition via its indexvar formatCondition = formatConditionCollection\[index\];//Set Is3ColorScale to false in order to generate a 2-Color Scale formatformatCondition.ColorScale.Is3ColorScale = false;//Set other necessary properties

### Property TxtLoadOptions.HasFormula Added

Aspose.Cells for .NET 8.7.0 has provided support to [identify & parse the formulas while loading CSV/TXT files having delimited plain data](http://www.aspose.com/docs/display/cellsnet/Load+or+Import+CSV+file+with+Formulas). Newly exposed `TxtLoadOptions.HasFormula` property when set to true directs the API to parse the formulas from the input delimited file and set them to relevant cells without requiring any additional processing.

Following is the simple usage scenario.

**C#**

//Create an instance of TxtLoadOptionsvar options = new TxtLoadOptions();//Set HasFormula property to trueoptions.HasFormula = true;//Set the Separator property as desiredoptions.Separator = ',';//Load the CSV/TXT file using the instance of TxtLoadOptionsvar book = new Workbook(inFilePath, options);//Calculate formulas in order to get the calculated values of formula in CSVbook.CalculateFormula();//Write result in any of the supported formatsbook.Save(outFilePath);

### Property DataLabels.IsResizeShapeToFitText Added

Another useful feature that Aspose.Cells for .NET 8.7.0 has exposed is the `DataLabels.IsResizeShapeToFitText` property that can enable the [Resize shape to fit text](http://www.aspose.com/docs/display/cellsnet/Resize+Chart%27s+Data+Label+Shape+To+Fit+Text) feature of Excel application for chart's data labels.

Following is the simple usage scenario.

**C#**

//Create an instance of Workbook containing the Chartvar book = new Workbook(inFilePath);//Access the Worksheet that contains the Chartvar sheet = book.Worksheets\[0\];//Access the desired Chart via its index or namevar chart = sheet.Charts\[0\];//Access the DataLabels of desired NSeriesvar labels = chart.NSeries\[0\].DataLabels;//Set ResizeShapeToFitText property to truelabels.IsResizeShapeToFitText = true;//Calculate Chartchart.Calculate();

### Property PdfSaveOptions.OptimizationType Added

Aspose.Cells for .NET 8.7.0 has exposed the `PdfSaveOptions.OptimizationType` property along with `PdfOptimizationType` enumeration in order to facilitate the users to [choose the desired optimization algorithm while exporting spreadsheets to PDF format](http://www.aspose.com/docs/display/cellsnet/Save+Excel+into+PDF+with+Standard+or+Minimum+Size). There are 2 possible values for the `PdfSaveOptions.OptimizationType` property as detailed below.

1.  `PdfOptimizationType.MinimumSize`: Quality is compromised for the resultant file size.
2.  `PdfOptimizationType.Standard`: Quality isn't compromised so the resultant file size will be large.

Following is the simple usage scenario.

**C#**

//Create an instance of PdfSaveOptionsvar pdfSaveOptions = new PdfSaveOptions();//Set the OptimizationType property to desired valuepdfSaveOptions.OptimizationType = PdfOptimizationType.MinimumSize;//Create an instance of Workbook//Optionally load an existing spreadsheetvar book = new Workbook(inFilePath);//Save the spreadsheet in PDF format while passing the instance of PdfSaveOptionsbook.Save(outFilePath, pdfSaveOptions);

## Removed APIs

### Property Workbook.SaveOptions Removed

The `Workbook.SaveOptions` property was marked obsoleted some time back. With this release, it has been completely removed from the public API therefore it is advised to use the `Workbook.Save(Stream, SaveOptions)` or `Workbook.Save(string, SaveOptions)` method as alternative.

