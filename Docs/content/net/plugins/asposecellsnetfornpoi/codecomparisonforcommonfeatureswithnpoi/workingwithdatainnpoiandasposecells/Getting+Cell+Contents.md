+++
title = "Getting Cell Contents" 
description = "" 
weight = 20916 
+++

Aspose.Cells for .NET : Getting Cell Contents  

# Aspose.Cells for .NET : Getting Cell Contents


## Aspose.Cells - Getting Cell Contents

`Cells[0] or Cells[name]` method is available to access cells.

**C#**

{{< code lang="c#" >}}
Workbook workbook = new Workbook("../../data/test.xlsx");
Worksheet sheet1 = workbook.Worksheets[0];

Cells cells = sheet1.Cells;
Range range = sheet1.Cells.MaxDisplayRange;
int tcols = range.ColumnCount;
int trows = range.RowCount;

for (int i = 0 ; i < trows; i++)
{
	for (int j = 0 ; j < tcols ; j++)
	{
		if (cells[i, j].Type != CellValueType.IsNull)
		{
			Console.WriteLine(cells[i, j].Name + " - " + cells[i, j].Value);
		}
	}
}
{{< /code >}}

## NPOI - HSSF XSSF - Getting Cell Contents

NPOI provides Cell class to access various properties of cells.

**C#**

{{< code lang="c#" >}}
IWorkbook wb = new XSSFWorkbook("../../data/test.xlsx");
ISheet sheet1 = wb.GetSheetAt(0);

for (int index = 0; index <= sheet1.LastRowNum; index++)
{
    IRow row = sheet1.GetRow(index);

    foreach (ICell cell in row.Cells)
    {
        CellReference cellRef = new CellReference(row.RowNum, cell.ColumnIndex);
        Console.Write(cellRef.FormatAsString());
        Console.Write(" - ");

        switch (cell.CellType)
        {
            case CellType.String:
                Console.Write(cell.StringCellValue);
                break;
            case CellType.Numeric:
                if (DateUtil.IsCellDateFormatted(cell))
                    Console.Write(cell.DateCellValue);
                else
                    Console.Write(cell.NumericCellValue);
                break;
            case CellType.Boolean:
                Console.Write(cell.BooleanCellValue);
                break;
            case CellType.Formula:
                Console.Write(cell.CellFormula);
                break;
        }
        Console.WriteLine();
    }
}
{{< /code >}}

## Download Running Code

Download **Getting Cell Contents** form any of the below mentioned social coding sites:

*   [CodePlex](https://asposenpoi.codeplex.com/downloads/get/1479037)
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/download/Aspose.Cells_vs_NPOI_1.0/Getting.Cell.Contents.Aspose.Cells.zip)

For more details, visit [Data Handling Features](http://www.aspose.com/docs/display/cellsnet/Data+Handling+Features).

