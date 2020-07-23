+++
title = "Ignore Errors while Rendering Excel to PDF" 
description = "" 
weight = 12095 
+++

Aspose.Cells for .NET : Ignore Errors while Rendering Excel to PDF  

# Aspose.Cells for .NET : Ignore Errors while Rendering Excel to PDF


{{< panel title="Contents Summary" style="primary" >}}
*   1 [Possible Usage Scenarios](#IgnoreErrorswhileRenderingExceltoPDF-PossibleUsageScenarios)
*   2 [Ignore Errors while Rendering Excel to PDF](#IgnoreErrorswhileRenderingExceltoPDF-IgnoreErrorswhileRenderingExceltoPDF)
*   3 [Sample Code](#IgnoreErrorswhileRenderingExceltoPDF-SampleCode)
{{< /panel >}}
 

## Possible Usage Scenarios

Sometimes when you convert your Excel file to PDF, errors or exceptions occur and the conversion process terminates. You can ignore all such errors during the conversion process by using the [PdfSaveOptions.IgnoreError](https://apireference.aspose.com/net/cells/aspose.cells/pdfsaveoptions/properties/ignoreerror) property. This way, the conversion process will complete smoothly without throwing any error or exception but the loss of data may occur. Therefore, please use this property only if the loss of data is not critical for you.

## Ignore Errors while Rendering Excel to PDF

The following code loads the [sample Excel file](https://docs2.aspose.com/cells/net/attachments/54690010/55541778.xlsx) but the sample Excel file is erroneous and throws an error during [conversion to PDF](https://docs2.aspose.com/cells/net/attachments/54690010/55541779.pdf) in 17.11 but since we are using [PdfSaveOptions.IgnoreError](https://apireference.aspose.com/net/cells/aspose.cells/pdfsaveoptions/properties/ignoreerror) property, it does not throw an error. However, one *rounded red arrow like shape* as shown in this screenshot is lost. 

![](https://docs2.aspose.com/cells/net/attachments/54690010/55541780.png)

## Sample Code

## Attachments:

![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [outputErrorExcel2Pdf.pdf](https://docs2.aspose.com/cells/net/attachments/54690010/55541779.pdf) (application/pdf)  
![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [sampleErrorExcel2Pdf.xlsx](https://docs2.aspose.com/cells/net/attachments/54690010/60489730.xlsx) (application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)  
![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [PdfSaveOptions.IgnoreError-True-Ignores-the-Errors-while-Excel2Pdf-Conversion.png](https://docs2.aspose.com/cells/net/attachments/54690010/55541780.png) (image/png)  
![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [sampleErrorExcel2Pdf.xlsx](https://docs2.aspose.com/cells/net/attachments/54690010/55541778.xlsx) (application/vnd.openxmlformats-officedocument.spreadsheetml.sheet)  

