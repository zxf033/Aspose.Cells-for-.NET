using System.IO;

using Aspose.Cells;
using System;

namespace CSharp.Files.Handling
{
    public class SavingFiletoStream
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            string filePath = dataDir + "Book1.xlsx";

            // Load your source workbook
            Workbook workbook = new Workbook(filePath);
            FileStream stream = new FileStream(dataDir + "output.xlsx", FileMode.CreateNew);
            workbook.Save(stream, new XlsSaveOptions(SaveFormat.Xlsx));
            stream.Close();

            // ExEnd:1


        }
    }
}