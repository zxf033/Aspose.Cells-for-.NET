+++
title = "Using ICustomFunction Feature" 
description = "" 
weight = 20541 
+++

Aspose.Cells for .NET : Using ICustomFunction Feature  

# Aspose.Cells for .NET : Using ICustomFunction Feature


This article provides a detailed understanding of how to use the `ICustomFunction` feature to implement custom functions with Aspose.Cells APIs.

The `ICustomFunction` interface allows to add custom formula calculation functions to extend the Aspose.Cells' core calculation engine in order to meet certain requirements. This feature is useful to define custom (user defined) functions in a template file or in code where the custom function can be implemented and evaluated using Aspose.Cells APIs like any other default Microsoft Excel function.

## Creating and Evaluating a User-defined Function

This article demonstrates the implementation of `ICustomFunction` interface to write a custom function and use it in the spreadsheet to get the results. We will define a custom function by name **MyFunc** which will accepts 2 parameters with following details.

*   1st parameter refers to a single cell
*   2nd parameter refers to a range of cells

The custom function will add all the values from the cell range specified as 2nd parameter and divide the result with value in the 1st parameter.

Here is how we have implemented the `CalculateCustomFunction` method.

  
Here is how to use the newly defined function in a spreadsheet

## Overview

The Aspose.Cells APIs just put the `ReferredArea` object into the "paramsList" when the corresponding parameter is a reference or its calculated result is reference. If you need the reference itself then you can use the `ReferredArea` directly. If you need to get value of a single cell from the reference corresponding with the formula's position, you can use `ReferredArea.GetValue(rowOffset, int colOffset)` method. If you need cell values array for the whole area then you can use `ReferredArea.GetValues` method.

As the Aspose.Cells APIs give the `ReferredArea` in "paramsList", the `ReferredAreaCollection` in "contextObjects" will not be needed anymore (in old versions it was not able to give one-to-one map to the parameters of the custom function always) therefore it has been removed from the "contextObjects".

{{< code lang="cs" >}}
public object CalculateCustomFunction(string functionName, ArrayList paramsList, ArrayList contextObjects)
{
    ...
    object o = paramsList[i];
    if(o is ReferredArea) //fetch data from reference
    {
        ReferredArea ra = (ReferredArea)o;
        if(ra.IsArea)
        {
            o = ra.GetValues();
        }
        else
        {
            o = ra.GetValue(0, 0);
        }
    }
    if (o is Array)
    {
        ...
    }
    else if...
    ...
}
{{< /code >}}

## Attachments:

![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [Using ICustomFunction feature-001.png](https://docs2.aspose.com/cells/net/attachments/5017602/5112467.png) (image/png)  
![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [Using ICustomFunction feature-002.png](https://docs2.aspose.com/cells/net/attachments/5017602/5112472.png) (image/png)  

