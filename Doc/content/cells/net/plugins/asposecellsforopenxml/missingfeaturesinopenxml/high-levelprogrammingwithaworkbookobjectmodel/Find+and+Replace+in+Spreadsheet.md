+++
title = "Find and Replace in Spreadsheet" 
description = "" 
weight = 20876 
+++

Aspose.Cells for .NET : Find and Replace in Spreadsheet  

# Aspose.Cells for .NET : Find and Replace in Spreadsheet


![](download/thumbnails/5020491/985004860)

When we click on find button following is the code:

if (TXBX\_Find.Text != ""){	 workbook = new Workbook(FOD\_OpenFile.FileName);	FindOptions Opts = new FindOptions();	Opts.LookInType = LookInType.Values;	Opts.LookAtType = LookAtType.Contains;	string found = "";	Cell cell = null;	foreach (Worksheet sheet in workbook.Worksheets)	{		found += Environment.NewLine + "Sheet: " + sheet.Name + ":";		do		{			cell = sheet.Cells.Find(TXBX\_Find.Text, cell, Opts);			if (cell != null)				found += cell.Name + ",";		}		while (cell != null);	}	LBL\_FindResults.Text = found;}

Clicking on Replace button following code is executed:

if (TXBX\_Find.Text != "" && TXBX\_Replace.Text!=""){	workbook = new Workbook(FOD\_OpenFile.FileName);	FindOptions Opts = new FindOptions();	Opts.LookInType = LookInType.Values;	Opts.LookAtType = LookAtType.Contains;	string found = "";	Cell cell = null;	foreach (Worksheet sheet in workbook.Worksheets)	{		do		{			cell = sheet.Cells.Find(TXBX\_Find.Text, cell, Opts);			if (cell != null)			{				string celltext = cell.Value.ToString();				celltext = celltext.Replace(TXBX\_Find.Text, TXBX\_Replace.Text);				cell.PutValue(celltext);			}		}		while (cell != null);	}	LBL\_FindResults.Text = "Replaced All Existing Values, Save the file now";}

## Download Sample Code

*   [Codeplex](https://asposecellsopenxml.codeplex.com/releases/view/619160)
*   [Github](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/tag/MissingFeaturesOpenXMLExcelv1.1)
*   [Code.MSDN](https://code.msdn.microsoft.com/AsposeCells-Features-8fba7c3c)
*   [Bitbucket](https://bitbucket.org/asposemarketplace/aspose-for-openxml/downloads/Find%20and%20replace%20%28Aspose.Cells%29.zip)

## Attachments:


