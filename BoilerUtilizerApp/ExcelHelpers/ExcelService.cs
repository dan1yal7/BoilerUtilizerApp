using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoilerUtilizerApp.ExcelHelpers
{
    public class ExcelService
    {
        private readonly string _path;
       
        public ExcelService(string path)
        {
            _path = path;
        }

        public void WriteInput(double gasTemperature)
        {
            using var workbook = new XLWorkbook(_path);
            var sheet = workbook.Worksheet("Таб1");
            sheet.Cell("С5");
            workbook.Save();
        }
        public double ReadOutput()
        {
            using var workbook = new XLWorkbook(_path);
            var sheet = workbook.Worksheet("Результаты");
            var cell = sheet.Cell("C27");
            return double.TryParse(cell.Value.ToString(), out var val) ? val : 0;

        }
    }
}
