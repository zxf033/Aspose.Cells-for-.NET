+++
title = "Working with Visual Studio" 
description = "" 
weight = 16657 
+++

Aspose.Cells for .NET : Working with Visual Studio  

# Aspose.Cells for .NET : Working with Visual Studio


This topic explains how to use Aspose.Cells.GridWeb in ASP.NET applications using Visual Studio.NET 2005. This topic is useful for the beginner-level developers working with Aspose.Cells.GridWeb.

**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738154575 {padding: 0px;}div.rbtoc1590738154575 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738154575 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Working with Aspose.Cells.GridWeb Using Visual Studio 2013](#WorkingwithVisualStudio-WorkingwithAspose.Cells.GridWebUsingVisualStudio2013)
    *   1.1 [Step 1: Creating New Web Site](#WorkingwithVisualStudio-Step1:CreatingNewWebSite)
    *   1.2 [Step 2: Checking Source & Design Views of a Web Page](#WorkingwithVisualStudio-Step2:CheckingSource&DesignViewsofaWebPage)
    *   1.3 [Step 3: Adding Aspose.Cells.GridWeb to Web Page](#WorkingwithVisualStudio-Step3:AddingAspose.Cells.GridWebtoWebPage)
    *   1.4 [Step 4: Change the <!DOCTYPE> tag](#WorkingwithVisualStudio-Step4:Changethe<!DOCTYPE>tag)
    *   1.5 [Step 5: Resizing Aspose.Cells.GridWeb Control](#WorkingwithVisualStudio-Step5:ResizingAspose.Cells.GridWebControl)
    *   1.6 [Step 6: Configuring the Properties of Aspose.Cells.GridWeb](#WorkingwithVisualStudio-Step6:ConfiguringthePropertiesofAspose.Cells.GridWeb)
    *   1.7 [Step 7: Running Your First Web Site Containing Aspose.Cells.GridWeb](#WorkingwithVisualStudio-Step7:RunningYourFirstWebSiteContainingAspose.Cells.GridWeb)

## Working with Aspose.Cells.GridWeb Using Visual Studio 2013

This topic shows how to use Aspose.Cells.GridWeb by making a sample website in Visual Studio 2013. The process has been divided into steps.

### Step 1: Creating New Web Site

1.  Open Visual Studio 2013.
2.  From the **File** menu, select **New Menu**, then **Web Site**.  
      
    The New Web Site dialog is opened.
3.  Select **ASP.NET Web Forms Site** from Visual Studio installed templates.
4.  Choose HTTP mode for the location of the web site.  
      
      
    
5.  Specify a location where the web site files will be created and stored.
    1.  Click **Browse** in the New Web Site dialog.  
          
          
        The Choose Location dialog is displayed.
    2.  Click the **Local IIS** tab.  
        All folders and web applications stored in your IIS root folder are displayed (for example: C:\\Inetpub\\wwwroot).  
          
          
        
    3.  Now create a new web application in your local IIS where the website files will be stored.  
        The Choose Location dialog lets you create and delete web applications or virtual directories in your local IIS. To create a web application, click a button as shown below in the figure.  
          
          
        A new web application with the default name WebSite is created.
    4.  Rename the web application. We renamed it GridWebOn2013.
    5.  Click **Open**.  
          
          
        You return to the New Web Site dialog. The path of web site location is set to [http://localhost/GridWebOn2013](http://localhost/GridWebOn2013).
6.  Click **OK** to let Visual Studio create a web site.  
      

### Step 2: Checking Source & Design Views of a Web Page

A default web site will have been created by Visual Studio 2013. It contains a default.aspx web page with some dummy text and markup.  
  
**Source view of default.aspx page**  
  
All web pages (including ASP.NET) can be opened in two modes. One is the source view that lets developers access and modify the source code. The second mode is design view that can be used to design web pages in a WYSIWYG manner. The above screenshot shows a source view of default.aspx web page. To view the design view, click **Design**.  
  
**Design view of default.aspx page**  
  

Delete the Default.aspx page added by Visual Studio and add a new blank Default.aspx page.


### Step 3: Adding Aspose.Cells.GridWeb to Web Page

You can simply add Aspose.Cells.GridWeb (or GridWeb) control to a web page by dragging it from the toolbox.  
  
  

If you don't know about how to add Aspose.Cells.GridWeb to the toolbox, refer to [Integrate Aspose.Cells Grid Controls with Visual Studio.NET](http://localhost:1313/cellsnet/gettingstarted/asposecellsgridsuiteandvsnet/integrate+aspose.cells+grid+controls+with+visual+studio.net).

Once GridWeb control is dropped to web page, it would render like this:  
  
  

### Step 4: Change the <!DOCTYPE> tag

1.  Switch to source view and find the following **<!DOCTYPE>** tag in the source code:
    
    **ASP.NET**
    
     <!DOCTYPE html> 
    
2.  Select the complete tag.  
      
      
    
3.  Retain, change or delete the <!DOCTYPE> tag.
4.  Or modify the <!DOCTYPE> tag with the following one:
    
     <!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN"> 
    

### Step 5: Resizing Aspose.Cells.GridWeb Control

You can change the width and height of the GridWeb control after dragging it to the website.

In design view, you can resize the width and height of the GridWeb.  
  
  

### Step 6: Configuring the Properties of Aspose.Cells.GridWeb

Configure the Aspose.Cells.GridWeb properties in WYSIWYG by clicking the **Properties** button on the right side of Visual Studio 2013 IDE.  
A Properties dialog is displayed.  
  
  
The Properties pane makes it possible to configure the look & feel of the GridWeb and some other properties to control GridWeb's behaviour.

### Step 7: Running Your First Web Site Containing Aspose.Cells.GridWeb

Build and run the web site.

1.  Run the web site directly from Visual Studio by pressing Ctrl+F5 or clicking **Start Debugging**.  
      

Now, you can start playing with GridWeb control.  
  
**GridWeb control in action**  

## Attachments:


