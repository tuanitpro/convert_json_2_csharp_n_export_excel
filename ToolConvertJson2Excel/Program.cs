using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ToolConvertJson2Excel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string jsonFilePath = "file.json";
            string atTime = DateTime.Now.ToString("yyyyddMMHHmmss");
            string fileExportName = $"Excel_Report_{atTime}.xlsx";

            using (StreamReader r = new StreamReader(jsonFilePath))
            {
                string json = r.ReadToEnd();

                // JsonToCsharpHelper.GenerateFileClass(json);

                List<MathInfo> items = JsonConvert.DeserializeObject<List<MathInfo>>(json);

                IExcelExportHelper<ClassName> excelExportHelper = new ExcelExportHelper<ClassName>();

                using (Stream stream = new FileStream(fileExportName, FileMode.OpenOrCreate))
                {
                    excelExportHelper.ExportXlsx(stream, items);
                }
            }

            Console.WriteLine("Exported file {0} successful at {1} ", fileExportName, atTime);
            Console.ReadKey();
        }
    }
}
