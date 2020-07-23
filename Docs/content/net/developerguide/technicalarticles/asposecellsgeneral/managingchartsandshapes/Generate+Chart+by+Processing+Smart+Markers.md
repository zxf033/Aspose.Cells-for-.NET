+++
title = "Generate Chart by Processing Smart Markers" 
description = "" 
weight = 20518 
+++

Aspose.Cells for .NET : Generate Chart by Processing Smart Markers  

# Aspose.Cells for .NET : Generate Chart by Processing Smart Markers


Aspose.Cells APIs provide the [WorkbookDesigner](https://apireference.aspose.com/net/cells/aspose.cells/workbookdesigner) class to work with Smart Markers where the formatting & formulas are placed in the designer spreadsheets and then processed with [WorkbookDesigner](https://apireference.aspose.com/net/cells/aspose.cells/workbookdesigner)class to fill up the data according to specified Smart Markers. It is also possible to create Excel charts by processing Smart Markers, which will require the following steps.

*   Creation of designer spreadsheet
*   Processing designer spreadsheet against the specified data source
*   Creation of chart based on populated data

{{< panel title="Contents Summary" style="primary" >}}
*   1 [Creation of Designer Spreadsheet](#GenerateChartbyProcessingSmartMarkers-CreationofDesignerSpreadsheet)
*   2 [Processing Designer Spreadsheet](#GenerateChartbyProcessingSmartMarkers-ProcessingDesignerSpreadsheet)
*   3 [Creation of Chart](#GenerateChartbyProcessingSmartMarkers-CreationofChart)
{{< /panel >}}
 

 

## Creation of Designer Spreadsheet

A designer spreadsheet is a simple Excel file created with Microsoft Excel application or Aspose.Cells APIs containing the visual formatting, formulas and smart markers, where the contents can be populated at runtime.

For the sake of simplicity, we will create the designer spreadsheet using the Aspose.Cells for .NET API and later process it against a dynamically created data source for demonstration purposes.

## Processing Designer Spreadsheet

In order to process the designer spreadsheet, one must have a data source that corresponds to the Smart Markers used in the designer spreadsheet. For instance, we have created a Smart Marker entry as &=Sales.Year, that represents the Year column in the DataTable Sales. In case a corresponding column isn't available in the data source, the Aspose.Cells APIs will skip the processing for that particular Smart Marker, and as a result, the data for the particular Smart Marker will not be populated.

In order to demonstrate this use case, we will create the data source from scratch and process it against the designer spreadsheet created in the previous step. However, in a real-time scenario, data could already be available for further processing so you can skip the creation of data source if data is already available.

  
The processing of Smart Markers is quite simple as demonstrated by the following code snippet.

The above code snippet uses the existing instance of the [Workbook](https://apireference.aspose.com/net/cells/aspose.cells/workbook) class created in the first step. If you already have the designer spreadsheet file on disk or memory, you can create an instance of [Workbook](https://apireference.aspose.com/net/cells/aspose.cells/workbook)class by loading the existing designer spreadsheet.

## Creation of Chart

Once the data is in place, all we need to do is to create a chart based on the data source. In order to keep the example simple, we will use the [Chart.SetChartDataRange](https://apireference.aspose.com/net/cells/aspose.cells.charts/chart/methods/setchartdatarange) method so that we do not have to configure the chart further.

## Attachments:

![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [SmartMarkerDesignerSample.png](https://docs2.aspose.com/cells/net/attachments/5015274/5115060.png) (image/png)  
![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [SmartMarkerDesignerProcessed.png](https://docs2.aspose.com/cells/net/attachments/5015274/5115059.png) (image/png)  
![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [ChartView.png](https://docs2.aspose.com/cells/net/attachments/5015274/5115088.png) (image/png)  

