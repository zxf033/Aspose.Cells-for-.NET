+++
title = "Avoid exponential notation of large numbers while importing from Html" 
description = "" 
weight = 20557 
+++

Aspose.Cells for .NET : Avoid exponential notation of large numbers while importing from Html  

# Aspose.Cells for .NET : Avoid exponential notation of large numbers while importing from Html


Sometimes your Html contains numbers like 1234567890123456 which are longer than 15 digits and when you import your HTML to excel file, these numbers convert to exponential notation like 1.23457E+15. If you want, your number should be imported as it is and not converted to exponential notation, then please use [HTMLLoadOptions.KeepPrecision](https://apireference.aspose.com/net/cells/aspose.cells/abstracttextloadoptions/properties/keepprecision) property and set it **true** while loading your HTML.

The following sample code explains the usage of [HTMLLoadOptions.KeepPrecision](https://apireference.aspose.com/net/cells/aspose.cells/abstracttextloadoptions/properties/keepprecision)property. The API will import the number as it is without converting it to exponential notation.

