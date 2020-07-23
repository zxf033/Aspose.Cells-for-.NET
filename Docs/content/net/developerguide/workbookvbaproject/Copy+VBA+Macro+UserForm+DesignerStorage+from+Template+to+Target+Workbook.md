+++
title = "Copy VBA Macro UserForm DesignerStorage from Template to Target Workbook" 
description = "" 
weight = 12325 
+++

Aspose.Cells for .NET : Copy VBA Macro UserForm DesignerStorage from Template to Target Workbook  

# Aspose.Cells for .NET : Copy VBA Macro UserForm DesignerStorage from Template to Target Workbook


{{< panel title="Contents Summary" style="primary" >}}
*   1 [Possible Usage Scenarios](#CopyVBAMacroUserFormDesignerStoragefromTemplatetoTargetWorkbook-PossibleUsageScenarios)
*   2 [Copy VBA Macro UserForm DesignerStorage from Template to Target Workbook](#CopyVBAMacroUserFormDesignerStoragefromTemplatetoTargetWorkbook-CopyVBAMacroUserFormDesignerStoragefromTemplatetoTargetWorkbook)
*   3 [Sample Code](#CopyVBAMacroUserFormDesignerStoragefromTemplatetoTargetWorkbook-SampleCode)
{{< /panel >}}
## Possible Usage Scenarios

Aspose.Cells allows you to copy a VBA project from one Excel file into another Excel file. VBA project consists of various types of modules i.e. Document, Procedural, Designer, etc. All modules can be copied with simple code but for the Designer module, there is some extra data called Designer Storage that needs to be accessed or copied. The following two methods deal with Designer Storage.

*   [VbaModuleCollection.GetDesignerStorage()](https://apireference.aspose.com/net/cells/aspose.cells.vba/vbamodulecollection/methods/getdesignerstorage)
*   [VbaModuleCollection.AddDesignerStorage()](https://apireference.aspose.com/net/cells/aspose.cells.vba/vbamodulecollection/methods/adddesignerstorage)

## Copy VBA Macro UserForm DesignerStorage from Template to Target Workbook

Please see the following sample code. It copies the VBA project from the [template Excel file](https://docs2.aspose.com/cells/net/attachments/50270298/50528345.xlsm) into an empty workbook and saves it as the [output Excel file](https://docs2.aspose.com/cells/net/attachments/50270298/50528346.xlsm). If you open the VBA project inside the template Excel file, you will see a User Form as shown below. The User Form consists of Designer Storage, so it will be copied using [VbaModuleCollection.GetDesignerStorage()](https://apireference.aspose.com/net/cells/aspose.cells.vba/vbamodulecollection/methods/getdesignerstorage) and [VbaModuleCollection.AddDesignerStorage()](https://apireference.aspose.com/net/cells/aspose.cells.vba/vbamodulecollection/methods/adddesignerstorage) methods.

**![](https://docs2.aspose.com/cells/net/attachments/50270298/50528347.png)**

The following screenshot shows the output Excel file and its contents which were copied from the template Excel file. When you click on the `Button 1`, it opens up the `VBA User Form` which itself has a command button that shows a message box on clicking.

**![](https://docs2.aspose.com/cells/net/attachments/50270298/50528344.png)**

## Sample Code

## Attachments:

![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [Target Workbook after copying VBA-Macro-UserForm-DesignerStorage from Template Workbook.png](https://docs2.aspose.com/cells/net/attachments/50270298/50528344.png) (image/png)  
![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [Besides other Modules - Template Workbook also contains UserForm-DesignerStorage.png](https://docs2.aspose.com/cells/net/attachments/50270298/50528347.png) (image/png)  
![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [sampleDesignerForm.xlsm](https://docs2.aspose.com/cells/net/attachments/50270298/50528345.xlsm) (application/vnd.ms-excel.sheet.macroenabled.12)  
![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [outputDesignerForm.xlsm](https://docs2.aspose.com/cells/net/attachments/50270298/50528346.xlsm) (application/vnd.ms-excel.sheet.macroenabled.12)  

