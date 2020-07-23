+++
title = "Extend and Contribute to CRM Update Import Tool" 
description = "" 
weight = 16967 
+++

Aspose.Cells for .NET : Extend and Contribute to CRM Update Import Tool  

# Aspose.Cells for .NET : Extend and Contribute to CRM Update Import Tool


You can download the latest source code at:

*   [CodePlex](https://asposenetcrm.codeplex.com/SourceControl/latest#Aspose.Plugins.UpdateImportTool/).
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/tree/master/Plugins/Dynamics%20CRM/Aspose.Plugins.UpdateImportTool).
*   [Code.MSDN](https://code.msdn.microsoft.com/Aspose-NET-Update-Import-1f94d3f9/view/SourceCode#content).

Export Data from CRM to Excel

{{< code lang="cs" >}}
 SaveFileDialog fileDialog = new SaveFileDialog();
 fileDialog.DefaultExt = ".xlsx";
 fileDialog.FileName = "Aspose ImportTool Export.xlsx";
 if (fileDialog.ShowDialog().Value)
 {
    string FileName = fileDialog.FileName;
    Workbook workbook = new Workbook();
    workbook.Worksheets.Add("Aspose Export");

    Worksheet MyWorksheet = workbook.Worksheets["Aspose Export"];
    int i = 0;
    foreach (string attrib in SelectedAttributes)
    MyWorksheet.Cells[0, i++].Value = attrib;
    int Row = 1,cell=0;
    foreach (Entity record in Result.Entities)
    {
       cell = 0;
       foreach (string attribute in SelectedAttributes)
       {
          if (record.Contains(attribute))
          {
             MyWorksheet.Cells[Row,cell].Value = record[attribute].ToString();
          }
          cell++;
       }
       Row++;
     }
     workbook.Save(FileName, SaveFormat.Xlsx);
}

{{< /code >}}

Import Data from Excel to CRM

{{< code lang="cs" >}}
 if (ctrl.CrmConnectionMgr != null && ctrl.CrmConnectionMgr.CrmSvc != null && ctrl.CrmConnectionMgr.CrmSvc.IsReady)
 {
    CrmServiceClient svcClient = ctrl.CrmConnectionMgr.CrmSvc;
    if (svcClient.IsReady)
    {
        OpenFileDialog fileDialog = new OpenFileDialog();
        fileDialog.DefaultExt = ".xlsx";
        if (fileDialog.ShowDialog().Value)
        {
           string FileName = fileDialog.FileName;
           Workbook workbook = new Workbook(FileName);
           Worksheet MyWorksheet = workbook.Worksheets["Aspose Export"];
           DataTable dt = MyWorksheet.Cells.ExportDataTable(0, 0, MyWorksheet.Cells.Rows.Count, MyWorksheet.Cells.Columns.Count, true);
           foreach (DataRow dr in dt.Rows)
           {
               Entity CrmRecord = new Entity(SelectedEntity);
               foreach (DataColumn th in dt.Columns)
               {
                  CrmRecord.Attributes.Add(th.ColumnName, dr[th.ColumnName].ToString());
               }
               CreateRequest req = new CreateRequest();
               req.Target = CrmRecord;
               CreateResponse res = (CreateResponse)svcClient.OrganizationServiceProxy.Execute(req);
            }
        }
    }
 }

{{< /code >}}

