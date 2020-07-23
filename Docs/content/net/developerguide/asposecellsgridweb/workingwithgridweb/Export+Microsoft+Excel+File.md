+++
title = "Export Microsoft Excel File" 
description = "" 
weight = 16664 
+++

Aspose.Cells for .NET : Export Microsoft Excel File  

# Aspose.Cells for .NET : Export Microsoft Excel File


It is possible to create new, or manipulate existing Microsoft Excel files, on websites in GUI mode using Aspose.Cells.GridWeb control. The files can then be saved to Excel files. Aspose.Cells.GridWeb effectively serves as an online spreadsheet editor. This topic describes how to save grid content to Excel files.

{{< panel title="Contents Summary" style="primary" >}}
*   1 [Export Excel Files](#ExportMicrosoftExcelFile-ExportExcelFiles)
    *   1.1 [Export as a File](#ExportMicrosoftExcelFile-ExportasaFile)
    *   1.2 [Export as a Stream](#ExportMicrosoftExcelFile-ExportasaStream)
{{< /panel >}}
 

## Export Excel Files

### Export as a File

To save the content of Aspose.Cells.GridWeb control as an Excel file:

1.  Add the Aspose.Cells.GridWeb control to your web form.
2.  Save your work as an Excel file at a specified path.
3.  Run the application.

If you don't know about how to add Aspose.Cells.GridWeb control to your web form then you should refer to [Add GridWeb to Web Form](https://docs2.aspose.com/cells/net/developerguide/asposecellsgridweb/workingwithgridweb/add+gridweb+to+web+form)

When Aspose.Cells.GridWeb control is added to a windows form, the control is automatically instantiated and added to the form with a default size. You don't have to create an Aspose.Cells.GridWeb control object, all you have to do is drag and drop the control and start using it.

The code example below illustrates how to save grid content to an Excel file.

If your file system is NTFS, grant read/write access to the ASPNET or Everyone user accounts or you will get an access denied exception at runtime.

The above code snippet can be used in several ways. A common way is to add a button that saves the grid content to an Excel file when clicked. Aspose.Cells.GridWeb offers an easier approach for task. Aspose.Cells.GridWeb has an event called `SaveCommand`. The above code snippet can be added to the `SaveCommand` event's event handler which allow users to save their work by clicking the Aspose.Cells.GridWeb's in-built **Save** button.

**The GridWeb's SaveCommand event**  
![](https://docs2.aspose.com/cells/net/attachments/5013751/5115435.jpg)

**Saving grid content to Excel by clicking GridWeb's in-built Save button**  
![](https://docs2.aspose.com/cells/net/attachments/5013751/5115436.png)

If you are working in Visual Studio you can easily create the `SaveCommand` event's event handler by double-clicking the event in the **Properties** pane. To learn more about this, please refer to [Working with GridWeb Events](https://docs2.aspose.com/cells/net/developerguide/asposecellsgridweb/workingwithgridweb/working+with+gridweb+events)

### Export as a Stream

It is also possible to save grid content to a stream (for example `MemoryStream`).

## Attachments:

![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [Saving an MS Excel File-001.png.jpg](https://docs2.aspose.com/cells/net/attachments/5013751/5115435.jpg) (image/jpeg)  
![](https://docs2.aspose.com/cells/net/images/icons/bullet_blue.gif) [Saving an MS Excel File-002.png](https://docs2.aspose.com/cells/net/attachments/5013751/5115436.png) (image/png)  

