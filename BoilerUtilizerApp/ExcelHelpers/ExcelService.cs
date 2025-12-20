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
           if (!File.Exists(_path))
           {
                MessageBox.Show($"File{_path} does not exist or was not added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
           }
           using var wb = new XLWorkbook(_path);
            var ws = wb.Worksheet("Таб1");
            ws.Cell("C4");
            wb.Save(); 
        }
        public double ReadOutput()
        {  
            using var wb = new XLWorkbook(_path);
            var ws = wb.Worksheet("Результаты");
            var data = ws.Cell("C4").GetValue<double>();
            Console.WriteLine(data);
            return data;
        }
    }
}
