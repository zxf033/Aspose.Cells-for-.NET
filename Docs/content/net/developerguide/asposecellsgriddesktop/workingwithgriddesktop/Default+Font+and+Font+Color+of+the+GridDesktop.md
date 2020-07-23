+++
title = "Default Font and Font Color of the GridDesktop" 
description = "" 
weight = 16602 
+++

Aspose.Cells for .NET : Default Font and Font Color of the GridDesktop  

# Aspose.Cells for .NET : Default Font and Font Color of the GridDesktop


{{< panel title="Contents Summary" style="primary" >}}
*   1 [Possible Usage Scenarios](#DefaultFontandFontColoroftheGridDesktop-PossibleUsageScenarios)
*   2 [Change Default Font and Font Color at Design Time](#DefaultFontandFontColoroftheGridDesktop-ChangeDefaultFontandFontColoratDesignTime)
*   3 [Change Default Font and Font Color at Run Time](#DefaultFontandFontColoroftheGridDesktop-ChangeDefaultFontandFontColoratRunTime)
{{< /panel >}}
 

## Possible Usage Scenarios

Sometimes, you want to change the default font and font color of the GridDesktop. Please use the following two properties for this purpose. You can access these properties at Design Time or at Runtime depending upon your needs.

*   `GridDesktop.DefaultCellFont`
*   `GridDesktop.DefaultCellFontColor`

## Change Default Font and Font Color at Design Time

The following screenshot shows how to change the default font and font color of GridDesktop at Design Time.

![](https://docs2.aspose.com/cells/net/attachments/50266230/50528264.png)

## Change Default Font and Font Color at Run Time

The following sample code explains how to change the default font and font color of GridDesktop at Run Time.

{{< code lang="cs" >}}
//Assign your desired Font object to DefaultCellFont property
System.Drawing.Font fnt = new System.Drawing.Font("Arial Black", 18);
this.gridDesktop1.DefaultCellFont = fnt;

//Assign your desired Font color to DefaultCellFontColor property
this.gridDesktop1.DefaultCellFontColor = System.Drawing.Color.Blue;
{{< /code >}}

## Attachments:

![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [Default-font-and-font-color-GridDesktop.png](https://docs2.aspose.com/cells/net/attachments/50266230/50528264.png) (image/png)  

