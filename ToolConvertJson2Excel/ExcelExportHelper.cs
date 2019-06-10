using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace ToolConvertJson2Excel
{
    public interface IExcelExportHelper<T> where T : new()
    {
        void ExportXlsx(Stream stream, IEnumerable<T> items);
    }

    public class ExcelExportHelper<T> : IExcelExportHelper<T> where T : new()
    {
        public void ExportXlsx(Stream stream, IEnumerable<T> items)
        {
            if (stream == null)
                throw new ArgumentNullException("stream");

            var listProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            /// Where(x => Attribute.IsDefined(x, typeof(YourAttribute)));
            using (var xlPackage = new ExcelPackage(stream))
            {
                var worksheet = xlPackage.Workbook.Worksheets.Add("Sheet 1");
                var columnHeaders = new List<string>
                {
                };
                foreach (var prop in listProperties)
                {
                    columnHeaders.Add(prop.Name);
                }
                for (int i = 0; i < columnHeaders.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = columnHeaders[i];
                    worksheet.Cells[1, i + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(216, 228, 188));
                    worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                    worksheet.Cells[1, i + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells[1, i + 1].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    worksheet.Cells[1, i + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                }
                int row = 2;
                int index = 0;
                foreach (var item in items)
                {
                    index++;
                    int col = 1;

                    worksheet.Cells[row, col].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells[row, col].Style.Border.BorderAround(ExcelBorderStyle.Thin);

                    worksheet.Cells[row, col].Style.Font.Size = 10;
                    worksheet.Cells[row, col].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    foreach (var prop in listProperties)
                    {
                        var value = prop.GetValue(item, null);
                        worksheet.Cells[row, col].Value = value == null ? string.Empty : value;
                        col++;
                    }
                    row++;
                }
                xlPackage.SaveAs(stream);
            }
        }
    }
}