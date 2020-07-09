+++
title = "Default Font and Font Color of the GridDesktop" 
description = "" 
weight = 16602 
+++

Aspose.Cells for .NET : Default Font and Font Color of the GridDesktop  

# Aspose.Cells for .NET : Default Font and Font Color of the GridDesktop


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738141427 {padding: 0px;}div.rbtoc1590738141427 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738141427 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#DefaultFontandFontColoroftheGridDesktop-PossibleUsageScenarios)
*   2 [Change Default Font and Font Color at Design Time](#DefaultFontandFontColoroftheGridDesktop-ChangeDefaultFontandFontColoratDesignTime)
*   3 [Change Default Font and Font Color at Run Time](#DefaultFontandFontColoroftheGridDesktop-ChangeDefaultFontandFontColoratRunTime)

 

## Possible Usage Scenarios

Sometimes, you want to change the default font and font color of the GridDesktop. Please use the following two properties for this purpose. You can access these properties at Design Time or at Runtime depending upon your needs.

*   `GridDesktop.DefaultCellFont`
*   `GridDesktop.DefaultCellFontColor`

## Change Default Font and Font Color at Design Time

The following screenshot shows how to change the default font and font color of GridDesktop at Design Time.


## Change Default Font and Font Color at Run Time

The following sample code explains how to change the default font and font color of GridDesktop at Run Time.

//Assign your desired Font object to DefaultCellFont propertySystem.Drawing.Font fnt = new System.Drawing.Font("Arial Black", 18);this.gridDesktop1.DefaultCellFont = fnt;//Assign your desired Font color to DefaultCellFontColor propertythis.gridDesktop1.DefaultCellFontColor = System.Drawing.Color.Blue;

## Attachments:


