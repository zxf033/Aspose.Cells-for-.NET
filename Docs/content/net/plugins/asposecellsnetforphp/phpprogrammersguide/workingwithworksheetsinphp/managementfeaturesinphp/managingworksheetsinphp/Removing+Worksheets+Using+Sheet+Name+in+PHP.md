+++
title = "Removing Worksheets Using Sheet Name in PHP" 
description = "" 
weight = 28912 
+++

Aspose.Cells for .NET : Removing Worksheets Using Sheet Name in PHP  

# Aspose.Cells for .NET : Removing Worksheets Using Sheet Name in PHP


## Removing Worksheets Using Sheet Name

Removing Worksheets Using Sheet Name

**PHP Code**

{{< code lang="cs" >}}
        $dataDir = '';
        // Create Aspose.Cells Helper Object
        $ptr = new \COM('Aspose.Cells.Interop.InteropHelper');
        // Opening through Path
        // Creating a Workbook object and opening an Excel file using its file path
        $workbook = $ptr->New("Aspose.Cells.Workbook",array($dataDir . '/book1.xls'));
        $worksheets = $ptr->Get($workbook,"Worksheets",array());
        $ptr->Call($worksheets,"RemoveAt_2",array("Sheet1"));
        $ptr->Call($workbook,"Save",array($dataDir."/output.xls"));
        print "Completed." . PHP_EOL;
{{< /code >}}

## Download Running Code

Download **Removing Worksheets Using Sheet Name (Aspose.Cells)** from any of the below mentioned social coding sites:

*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/blob/master/Plugins/Aspose_Cells_NET_for_PHP/src/aspose/cells/WorkingWithWorksheets/ManagementFeatures/ManagingWorksheets/RemovingWorksheetsUsingSheetName.php)

