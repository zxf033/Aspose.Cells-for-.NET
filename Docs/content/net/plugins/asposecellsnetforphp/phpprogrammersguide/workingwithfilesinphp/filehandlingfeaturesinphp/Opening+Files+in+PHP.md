+++
title = "Opening Files in PHP" 
description = "" 
weight = 24897 
+++

Aspose.Cells for .NET : Opening Files in PHP  

# Aspose.Cells for .NET : Opening Files in PHP


## Aspose.Cells - Open Excel Files

##### Opening through Path

Simply open a Microsoft Excel file by referencing the file's path

**PHP Code**

{{< code lang="cs" >}}
        $dataDir = '';
        // Create Aspose.Cells Helper Object
        $ptr = new \COM('Aspose.Cells.Interop.InteropHelper');
        // Opening through Path
        // Creating a Workbook object and opening an Excel file using its file path
        $workbook = $ptr->New("Aspose.Cells.Workbook",array($dataDir . '/Book1.xls'));
        $worksheets = $ptr->Get($workbook,"Worksheets",array());
{{< /code >}}

## Download Running Code

Download **Opening Files (Aspose.Cells)** from any of the below mentioned social coding sites:

*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/blob/master/Plugins/Aspose_Cells_NET_for_PHP/src/aspose/cells/WorkingWithFiles/FileHandlingFeatures/OpeningFiles.php)

