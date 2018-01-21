using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.VisualStudio.Tools.Applications.Runtime;


namespace XLtesting1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }


        private static void TestXL()
        {
            //OPEN
            string wbFullPath = @"D:\Jarek\Projects\VSProjects\C#\_JMproj\XLtesting1\XLtest1wb.xlsb";
            Excel.Application xla = new Excel.Application();
            xla.Visible = true;
            Excel.Workbook wb = xla.Workbooks.Open(Filename: wbFullPath);
            Excel.Worksheet ws = wb.Worksheets.Item[1];// as Excel.Worksheet;

            //SAVE AS
            string saveAs = @"D:\Jarek\Projects\VSProjects\C#\_JMproj\XLtesting1\XLtest1wb - TEMP.xlsb";
            wb.SaveAs(Filename: saveAs);


            //COUNT
            Excel.Range rng = ws.UsedRange;
            int recordsCount = rng.Rows.Count;
            int add = recordsCount + 1;
            ws.Cells[add, 1] = "Toral Rows: " + recordsCount;

            //AUTOFIT
            rng.Columns.AutoFit();

            //BOLD
            rng.Font.Bold = true;

            //MERGE CELLS
            ws.Range[rng.Cells[1, 2], rng.Cells[1, 4]].Merge();

            //BORDER A CELL
            Excel.Range cellRNG = ws.Range["A4"];
            Excel.Borders xborders = cellRNG.Borders;
            xborders.LineStyle = Excel.XlLineStyle.xlContinuous;
            xborders.Weight = 2d;

            //BORDER ALL
            Excel.Range lastCLL = ws.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            Excel.Range allRNG = ws.Range["A1", lastCLL];
            xborders = allRNG.Borders;
            xborders.LineStyle = Excel.XlLineStyle.xlContinuous;
            xborders.Weight = 2d;

            //WRITE DATA
            ws.Cells[7, 2].Value = "some NEW DATA";


            //RUN VBA MACRO
            xla.Run("vbaMacro");

            //RUN VBA MACRO WITH PARAMETERS
            //xla.Run("vbaMacro",3); // CRASHES :(

            //CLOSE
            wb.Close(true, Type.Missing, Type.Missing);
            xla.Quit();

            MessageBox.Show("DONE");
        }


        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {firstNameText.Text}");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TestXL();
        }
    }
}
