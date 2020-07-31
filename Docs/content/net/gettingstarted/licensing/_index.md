---
title : "Licensing" 
description : "" 
weight : 8040 
toc : false
type: docs
url: /net/gettingstarted/licensing/
---

# Aspose.Cells for .NET : Licensing



You can easily download an evaluation version of Aspose.Cells from its [download page](https://www.nuget.org/packages/Aspose.Cells) @ NuGet repos. The evaluation version provides absolutely the same capabilities as the licensed version of the component. Furthermore, evaluation version simply becomes licensed when you purchase a license and add a couple of lines of code to apply the license.

{{< panel title="Contents Summary" style="primary" >}}
*   1 [Evaluation Version Limitations](#evaluation-version-limitations)
*   2 [Applying a License in Aspose.Cells Component](#applying-a-license-in-aspose.cells-component)
    *   2.1 [Applying a License from Disk or Stream](#applying-a-license-from-disk-or-stream)
    *   2.2 [Applying Metered License](#applying-metered-license)
    *   2.3 [Using an Embedded Resource](#using-an-embedded-resource)
*   3 [Setting License in Aspose.Cells Grid Controls](#setting-license-in-aspose.cells-grid-controls)
    *   3.1 [Applying a License from Disk or Stream](#applying-a-license-from-disk-or-stream)
    *   3.2 [Applying a License as an Embedded Resource](#applying-a-license-as-an-embedded-resource)
*   4 [Applying a License in Aspose.Cells.GridDesktop for a WinForm Application](#applying-a-license-in-aspose.cells.griddesktop-for-a-winform-application)
*   5 [Notes on Applying a License in Aspose.Cells.GridWeb](#notes-on-applying-a-license-in-aspose.cells.gridweb)
{{< /panel >}}
 

 

## Evaluation Version Limitations

Evaluation version of Aspose.Cells product (without a license specified) provides full product functionality, but it is limited to open 100 files in one program and an extra worksheet with evaluation watermark.

The limitations are shown below:

*   **Number of Opened Files** (Aspose.Cells)  
    When running your program, you can only open 100 Excel files using Aspose.Cells library. If your application exceeds this number, an exception will be thrown.
*   **Config file settings** (Aspose.Cells.GridWeb)  
    You can't re-specify the script path by adding the following lines of code into the configuration section (e.g in the web.config file). The acw\_client is a folder that contains files and Aspose.Cells.GridWeb uses this folder to manage its internal configuration, it has scripts files, image files and other files to specify GridWeb's behavior and set other operations. The config file is used to prevent the control from using the embedded client resources (images, scripts, etc.) which is useful in some cases / scenarios. Moreover, this configuration settings in the web.config file will only take effect with the LICENSED version of the control.

**XML**

{{< code lang="xml" >}}
<appSettings>
<add key="aspose.cells.gridweb.acw_client_path" value="/acw_client/" />
<add key="aspose.cells.gridweb.force_script_path" value="true" />
</appSettings>
 
{{< /code >}}

These settings might be compulsory in some cases / scenarios if you are using Aspose.Cells.GridWeb control in File System Websites or MS Ajax extensions etc.

Moreover, a worksheet with evaluation watermark will always show as the active worksheet in the generated excel file using Aspose.Cells library. Only in licensed version, you can set the active worksheet to other worksheets. In the output PDF or image file by Aspose.Cells, an evaluation watermark would be pasted at the top of the document/image.You can't hide the Evaluation Copyright Warning (the extra worksheet) in the GridWeb control too, it will always be added (at the end in the worksheet tabs) in the control.

If you want to test Aspose.Cells without evaluation version limitations, you can also request a 30 Day Temporary License.

## Applying a License in Aspose.Cells Component

The license is a plain text XML file that contains details such as the product name, number of developers it is licensed to, subscription expiry date and so on. The file is digitally signed, so don't modify the file. Even inadvertent addition of an extra line break into the file will invalidate it.You need to set a license before utilizing Aspose.Cells if you want to avoid its evaluation limitation. It is only required to set a license once per application (or process). The license can be loaded from a file, stream or an embedded resource.

Aspose.Cells tries to find the license in the following locations:

*   Explicit path
*   The folder that contains Aspose.Cells.dll
*   The folder that contains the assembly that called Aspose.Cells.dll
*   The folder that contains the entry assembly (your .exe)
*   An embedded resource in the assembly that called Aspose.Cells.dll

There are two common methods to apply a license, from file or stream, or as an embedded resource.

### Applying a License from Disk or Stream

The easiest way to set a license, is to put the license file in the same folder as that of Aspose.Cells.dll and specify just the file name without its path.

{{< code lang="cs" >}}
//Instantiate an instance of license and set the license file through its path
Aspose.Cells.License license = new Aspose.Cells.License();
license.SetLicense("Aspose.Cells.lic");
{{< /code >}}

When you call the `SetLicense` method, the license name should be same as that of your license file name. For example, you may change the license file name to **Aspose.Cells.lic.xml**. Then in your code, you should use the modified license name (**Aspose.Cells.lic.xml**) for the `SetLicense` method.

It is also possible to load a license from a stream.

{{< code lang="cs" >}}
//Instantiate an instance of license and set the license through a stream
Aspose.Cells.License license = new Aspose.Cells.License();
license.SetLicense(myStream);
{{< /code >}}

### Applying Metered License

Aspose.Cells allows developers to to apply metered key. It is a new licensing mechanism. The new licensing mechanism will be used along with the existing licensing method. Those customers who want to be billed based on the usage of the API features can use the metered licensing. For more details, please refer to [Metered Licensing FAQ](https://purchase.aspose.com/faqs/licensing/metered) section.  

A new class [Metered](https://apireference.aspose.com/net/cells/aspose.cells/metered) has been introduced to apply metered key. Following is the sample code demonstrating how to set metered public and private key.

{{< code lang="cs" >}}
//Set metered public and private keys
Metered metered = new Metered();
//Access the setMeteredKey property and pass public and private keys as parameters
metered.SetMeteredKey("*************", "*************");
//Instantiate a new Workbook
Workbook workbook = new Workbook();
//Check if the license is set
Console.WriteLine(workbook.IsLicensed);


//Get the Consumption quantity
decimal amountBefore = Metered.GetConsumptionQuantity();
Console.WriteLine(amountBefore);
Workbook workbook2 = new Workbook("e:\\test2\\Book1.xlsx");
workbook2.Save("e:\\test2\\out1.xlsx");
//Since uploading data is already running on another thread, so you might need to wait for some time (optional)
System.Threading.Thread.Sleep(10000);
//Get the Consumption quantity again which should be greater a bit
decimal amountAfter = Metered.GetConsumptionQuantity();
Console.WriteLine(amountAfter);
{{< /code >}}

### Using an Embedded Resource

Another neat way of packaging the license with your application and making sure it will not be lost, is to include it as an embedded resource into one of the assemblies that calls Aspose.Cells. To include the license file as an embedded resource, perform the following steps:

1.  In Visual Studio .NET, include the license (.lic) file into the project by selection **Add Existing Item** from the **File** menu.
2.  Select the file in the Solution Explorer and set **Build Action** to **Embedded Resource** in the Properties window

To access the license embedded in the assembly (as embedded resource), it is not needed to call GetExecutingAssembly and GetManifestResourceStream methods of System.Reflection.Assembly class of Microsoft .NET Framework. All is needed to do, is to just add the license file as an embedded resource to your project and pass the name of the license file into SetLicense method. The **Aspose.Cells.License** class will automatically find the license file in the embedded resources. Please review the example given below to understand this method of setting license (embedded) in your applications.

{{< code lang="cs" >}}
//Instantiate the License class
Aspose.Cells.License license = new Aspose.Cells.License();

//Pass only the name of the license file embedded in the assembly
license.SetLicense("Aspose.Cells.lic");
{{< /code >}}

## Setting License in Aspose.Cells Grid Controls

In Aspose.Cells Grid Suite, license can be loaded from a file, stream or an embedded resource. Aspose.Cells.GridDesktop / Aspose.Cells.GridWeb tries to find the license in the following locations:

1.  Explicit path
2.  The folder that contains the dll of the component (included in Aspose.Cells.GridDesktop or Aspose.Cells.GridWeb)
3.  The folder that contains the assembly that called the dll of the component (included in Aspose.Cells.GridDesktop or Aspose.Cells.GridWeb)
4.  The folder that contains the entry assembly (your .exe)
5.  An embedded resource in the assembly that called the dll of the component (included in Aspose.Cells.GridDesktop or Aspose.Cells.GridWeb)

If you are using Aspose.Cells.GridDesktop control then the license class will be used as Aspose.Cells.GridDesktop.License but if you are using Aspose.Cells.GridWeb control then Aspose.Cells.GridWeb.License class will be used to set the license.

### Applying a License from Disk or Stream

The easiest way to set a license, is to put the license file in the same folder as that of the dll of the component (included in Aspose.Cells.GridWeb) and specify just the file name without its path.

{{< code lang="cs" >}}
//Instantiate an instance of license and set the license file through its path
Aspose.Cells.GridWeb.License license = new Aspose.Cells.GridWeb.License();

license.SetLicense("MyLicense.lic");
{{< /code >}}

When you call SetLicense method, the license name should be same as that of your license file name. For example, you may change the license file name to "MyLicense.lic.xml". Then in your code, you should use the modified license name (that is MyLicense.lic.xml) for the SetLicense method.

It is also possible to load a license from a stream.

{{< code lang="cs" >}}
//Instantiate an instance of license and set the license through a stream
Aspose.Cells.GridWeb.License license = new Aspose.Cells.GridWeb.License();

license.SetLicense(myStream);
{{< /code >}}

### Applying a License as an Embedded Resource

Another neat way of packaging the license with your application and making sure it will not be lost, is to include it as an embedded resource into one of the assemblies that calls the dll of the component (included in Aspose.Cells.GridDesktop). To include the license file as an embedded resource, perform the following steps:

1.  In Visual Studio .NET, include the license (.lic) file into the project using the **Add Existing Item** option on the **File** menu.
2.  Select the file in the Solution Explorer and set Build Action to Embedded Resource in the Properties window.
3.  To access the license embedded in the assembly (as embedded resource), it is not needed to call the `GetExecutingAssembly` and `GetManifestResourceStream` methods of the `System.Reflection.Assembly` class of Microsoft .NET Framework.Instead, add the license file as an embedded resource in your project and pass the name of the license file into the `SetLicense` method. The `License` class automatically finds the license file in the embedded resources.

Please review the example given below to understand this method of applying a license as an embedded resource to your applications.

{{< code lang="cs" >}}
//Instantiate the License class
Aspose.Cells.GridDesktop.License license = new Aspose.Cells.GridDesktop.License();

//Pass only the name of the license file embedded in the assembly
license.SetLicense("Aspose.Total.lic");
{{< /code >}}

## Applying a License in Aspose.Cells.GridDesktop for a WinForm Application

It's recommended that you should put your licensing code before your application starts and apply it only once. For example, for a windows C# application, put the licensing code in the `Main` method.

{{< code lang="cs" >}}
public class Form1 : System.Windows.Forms.Form
{
private Aspose.Cells.GridDesktop.GridDesktop gridDesktop1;
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel.Container components = null;
public Form1()
{
//
// Required for Windows Form Designer support
//
InitializeComponent();
//
// TODO: Add any constructor code after InitializeComponent call
//
}
/// The main entry point for the application.
/// </summary>
.
.
.
.
[STAThread]
static void Main()
{
Aspose.Cells.GridDesktop.License lic = new Aspose.Cells.GridDesktop.License();

//Use this line if you are using an explicit path for the license file.
lic.SetLicense(@"C:\MyLicense.lic");

//Or use the line below if you are using the license file as an embedded resource.
//lic.SetLicense("MyLicense.lic");
Application.Run(new Form1());
}
private void Form1_Load(object sender, System.EventArgs e)
{
Aspose.Cells.GridDesktop.Worksheet sheet = this.gridDesktop1.Worksheets.Add("MySheet");
sheet.Cells["A1"].SetCellValue("Hello");
gridDesktop1.ActiveSheetIndex = 1;
}
}
{{< /code >}}

## Notes on Applying a License in Aspose.Cells.GridWeb

It's recommended to put the licensing code in the Global.asax.cs of your web application (this license file is assumed to be put on the " d:\\ " drive):

{{< code lang="cs" >}}
protected void Application_Start(Object sender, EventArgs e)
{
    Aspose.Cells.GridWeb.License lic = new Aspose.Cells.GridWeb.License();
    lic.SetLicense(@"d:\Aspose.Cells.GridWeb.lic.xml");
}
 
{{< /code >}}

  
Loading a License from a Stream

  

{{< code lang="cs" >}}
protected void Application_Start(Object sender, EventArgs e)
{
    Aspose.Cells.GridWeb.License lic = new Aspose.Cells.GridWeb.License();
    lic.SetLicense(myStream);
}
{{< /code >}}

