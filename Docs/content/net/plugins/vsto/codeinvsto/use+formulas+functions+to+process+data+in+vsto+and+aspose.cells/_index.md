---
title : "Use Formulas Functions to Process Data in VSTO and Aspose.Cells" 
description : "" 
weight : 16812 
toc : false
type: docs
url: /net/plugins/vsto/codeinvsto/use+formulas+functions+to+process+data+in+vsto+and+aspose.cells/
---

# Aspose.Cells for .NET : Use Formulas Functions to Process Data in VSTO and Aspose.Cells


## Adding Cell Formula

### VSTO

{{< code lang="cs" >}}
//Note: To help you better, the code uses full namespacing
private void AddingCellFormula()
{
	//Access vsto application
	Microsoft.Office.Interop.Excel.Application app = Globals.ThisAddIn.Application;

	//Access workbook
	Microsoft.Office.Interop.Excel.Workbook workbook = app.ActiveWorkbook;

	//Access worksheet
	Microsoft.Office.Interop.Excel.Worksheet m_sheet = workbook.Worksheets[1];

	//Access vsto worksheet
	Microsoft.Office.Tools.Excel.Worksheet worksheet = Globals.Factory.GetVstoObject(m_sheet);

	//Access cells A1, A2, A3 , A4
	Microsoft.Office.Interop.Excel.Range cellA1 = worksheet.Range["A1"];
	Microsoft.Office.Interop.Excel.Range cellA2 = worksheet.Range["A2"];
	Microsoft.Office.Interop.Excel.Range cellA3 = worksheet.Range["A3"];
	Microsoft.Office.Interop.Excel.Range cellA4 = worksheet.Range["A4"];

	//Set integer values in cells A1, A2 and A3
	cellA1.Value = 10;
	cellA2.Value = 20;
	cellA3.Value = 30;

	//Add formula in cell A4
	cellA4.Formula = "=Sum(A1:A3)";

	//Set the font bold in cell A4
	cellA4.Font.Bold = true;

	//Set the background color to Yellow in cell A4
	cellA4.Interior.Color = Excel.XlRgbColor.rgbYellow;

	//Save the workbook
	workbook.SaveAs("OutputVsto.xlsx");

	//Quit the application
	app.Quit();

}
{{< /code >}}

### Aspose.Cells

{{< code lang="cs" >}}
private static void AddingCellFormula()
{
	//Create workbook
	Workbook workbook = new Workbook();

	//Access worksheet
	Worksheet worksheet = workbook.Worksheets[0];

	//Access cells A1, A2, A3 , A4
	Cell cellA1 = worksheet.Cells["A1"];
	Cell cellA2 = worksheet.Cells["A2"];
	Cell cellA3 = worksheet.Cells["A3"];
	Cell cellA4 = worksheet.Cells["A4"];

	//Set integer values in cells A1, A2 and A3
	cellA1.Value = 10;
	cellA2.Value = 20;
	cellA3.Value = 30;

	//Add formula in cell A4
	cellA4.Formula = "=Sum(A1:A3)";

	//Set the font bold in cell A4
	//and set the background color to Yellow in cell A4
	Style style = cellA4.GetStyle();
	style.Font.IsBold = true;
	style.Pattern = BackgroundType.Solid;
	style.ForegroundColor = Color.Yellow;
	cellA4.SetStyle(style);

	//Save the workbook
	workbook.Save("OutputAspose.xlsx", SaveFormat.Xlsx);
}
{{< /code >}}

## Download Sample Code

*   [Codeplex](https://asposevsto.codeplex.com/downloads/get/1459783)
*   [Github](https://github.com/asposemarketplace/Aspose_for_VSTO/releases/download/Aspose.Cells1.1/Use.Formulas.Functions.to.Process.Data.Aspose.Cells.zip)
*   [Sourceforge](https://sourceforge.net/projects/asposevsto/files/Aspose.Cells%20Vs%20VSTO%20Excel/Use%20Formulas%20Functions%20to%20Process%20Data%20(Aspose.Cells).zip/download)
*   [Bitbucket](https://bitbucket.org/asposemarketplace/aspose-for-vsto/downloads/Use%20Formulas%20Functions%20to%20Process%20Data%20(Aspose.Cells).zip)

