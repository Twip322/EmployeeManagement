using EmployeeManagement;
using System;
using MigraDoc.DocumentObjectModel.Shapes.Charts;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementView
{
    public partial class FormView2 : Form
    {
        public FormView2()
        {
            InitializeComponent();
        }
        private void backupButton_Click(object sender, EventArgs e)
        {
            ClassT[] arr = new ClassT[10];
            ClassT cl = new ClassT();
            cl.name = "1";
            ClassT cl2 = new ClassT();
            cl2.name = "2";
            ClassT cl3 = new ClassT();
            cl3.name = "3";
            arr[1] = cl;
            arr[2] = cl2;
            arr[9] = cl3;
            backupComponent1.saveData<ClassT>("C:/123/2", arr);
        }

        [Obsolete]
        private void buttonDiagramm_Click(object sender, EventArgs e)
        {
            var cl = new ClassT();
            cl.ID = 55;
            cl.name = "ТestClass";
            cl.number1 = 30;
            cl.number2 = 20;
            cl.number3 = 10;
            cl.number4 = 40;
            // pdfDiagrammComponent.createPdfDeiagram<ClassT>("D:/diagramm.pdf", cl, DataLabelType.Percent);
        }

        private void buttonHistogramm_Click(object sender, EventArgs e)
        {
            try
            {
                var list = new List<Setting>();
                for (int i = 0; i < 12; i++)
                {
                    list.Add(new Setting());
                }
                componentExcelDiagram1.BuiltChart(list, @"C:\123\fileGraph.xlsx");
                MessageBox.Show("Всё хорошо");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            //List<List<String>> data = new List<List<String>>();
            // List<String> dateHelp = new List<String>();
            var lstString = new List<string>();
            Enumerable.Range(1, 5)
              .ToList()
              .ForEach(i => lstString.Add(string.Concat("string", i)));

            //Add data in outer list
            List<List<string>> lstStrings = new List<List<string>>();
            Enumerable.Range(1, 5)
              .ToList()
              .ForEach(j => lstStrings.Add(lstString));
            //data.Add(dateHelp);
            var a = new string[] { "123", "123", "123", "123", "123" };
            var b = new string[] { };
            componentWordSummary1.rowCount = a.Length;
            componentWordSummary1.columnCount = lstStrings.Count;
            componentWordSummary1.SetData(lstStrings);
            SaveFileDialog sf = new SaveFileDialog();

            if (sf.ShowDialog() == DialogResult.OK)
            {
                componentWordSummary1.CreateTable(new string[] { "123", "123", "123", "123", "123" }, null, sf.FileName);
            }
            //componentWordSummary1.saveData<ClassT>("D:/123/2", false, arr);
        }
    }
}
