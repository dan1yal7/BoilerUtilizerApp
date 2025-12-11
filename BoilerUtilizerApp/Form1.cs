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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
