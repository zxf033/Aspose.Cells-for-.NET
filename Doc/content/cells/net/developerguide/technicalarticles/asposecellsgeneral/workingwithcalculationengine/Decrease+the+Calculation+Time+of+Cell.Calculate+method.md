+++
title = "Decrease the Calculation Time of Cell.Calculate method" 
description = "" 
weight = 20548 
+++

Aspose.Cells for .NET : Decrease the Calculation Time of Cell.Calculate method  

# Aspose.Cells for .NET : Decrease the Calculation Time of Cell.Calculate method


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738129044 {padding: 0px;}div.rbtoc1590738129044 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738129044 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#DecreasetheCalculationTimeofCell.Calculatemethod-PossibleUsageScenarios)
*   2 [Decrease the Calculation Time of Cell.Calculate() method](#DecreasetheCalculationTimeofCell.Calculatemethod-DecreasetheCalculationTimeofCell.Calculate()method)
*   3 [Console Output](#DecreasetheCalculationTimeofCell.Calculatemethod-ConsoleOutput)

 

 

## Possible Usage Scenarios

Normally, we recommend users to call [Workbook.CalculateFormula()](https://apireference.aspose.com/net/cells/aspose.cells/workbook/methods/calculateformula/index) method once and then get the calculated values of the individual cells. But sometimes, users do not want to calculate entire workbook. They just want to calculate a single cell. Aspose.Cells provides [CalculationOptions.Recursive](https://apireference.aspose.com/net/cells/aspose.cells/calculationoptions/properties/recursive) property which you can set to **false **and it will decrease the calculation time of individual cell significantly. Because when the recursive property is set to **true**, then all the dependents of cells are recalculated on each call. But when the recursive property is **false**, then dependent cells are calculated only once and are not calculated again on subsequent calls.

## Decrease the Calculation Time of Cell.Calculate() method


## Console Output


Recursive True: 96 secondsRecursive False: 42 seconds

## Attachments:


