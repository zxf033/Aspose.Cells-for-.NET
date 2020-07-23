+++
title = "Search Data using Original Values" 
description = "" 
weight = 20459 
+++

Aspose.Cells for .NET : Search Data using Original Values  

# Aspose.Cells for .NET : Search Data using Original Values


Sometimes the value of the data is hidden because it is formatted in some way. For example, suppose cell D4 has formula `=Sum(A1:A2)` and its value is 20 but it is formatted as ---, then the value 20 is hidden and cannot be found using Microsoft Excel find options. However, you can find it using Aspose.Cells using [LookInType.OriginalValues](https://apireference.aspose.com/net/cells/aspose.cells/lookintype)

The following sample code illustrates the above point. It finds cell D4 which cannot be found using Microsoft Excel find options but Aspose.Cells can find it using [LookInType.OriginalValues](https://apireference.aspose.com/net/cells/aspose.cells/lookintype). Please read the comments inside the code for more information.

## Console Output

Here is the console output of the above sample code.

{{< code lang="cs" >}}
Aspose.Cells.Cell [ D4; ValueType : IsNumeric; Value : ---; Formula:=SUM(A1:A2)]
{{< /code >}}

