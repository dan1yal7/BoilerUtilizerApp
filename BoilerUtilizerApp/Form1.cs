using BoilerUtilizerApp.ExcelHelpers;

namespace BoilerUtilizerApp
{
    public partial class Form1 : Form
    {
        private ExcelService excel;
        public Form1()
        {
            InitializeComponent();
            excel = new ExcelService("BoilerUtilizer.xlsx");
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            excel.WriteInput(180.5);
            double t = excel.ReadOutput();
            MessageBox.Show($"1: {t} °C");
        }
    }
}
