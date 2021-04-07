using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KDAkop;
using EM_3_MainLogic.Logic;
using Unity;
using PdfSharp.Charting;
using System.ComponentModel;
using MigraDoc.DocumentObjectModel;
using DataLabelType = MigraDoc.DocumentObjectModel.Shapes.Charts.DataLabelType;
using Database;
using EM_3_MainLogic.Binding_Model;
using EM_3_MainLogic;

namespace EM_3_View
{
    public partial class MainForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public EM_3_MainLogic.PluginManager manager { get; }
        public EmployeeLogic employeeLogic;
        public MainForm(EmployeeLogic  unitLogic)
        {
            InitializeComponent();
            this.employeeLogic = unitLogic;
            manager = new PluginManager();
            if(manager.Headers.Count()!=0)
            {
                comboBoxPlugins.Items.AddRange(manager.Headers.ToArray());
                comboBoxPlugins.Text = comboBoxPlugins.Items[0].ToString();
            }    
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //var units = unitLogic.Read(null);
            //var cl = new EmployeeSkills();
            //var Skills = new List<List<SkillList>>();
            //var name = new List<string>();
            //foreach (var unit in units)
            //{
            //    Skills.Add(new List<SkillList> { unit.Skills });
            //    name.Add(unit.Name);
            //}
            //var top = new string[] { "Name", "skill" };
            //exelTable.Create<SkillList>("C:/table.pdf", false, name, Skills);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCreateEmployee>();
            form.ShowDialog();
            var unit = employeeLogic.Read(null);
        }

        private void controlListBox1_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        [Obsolete]
        private void buttonPdfDiagram_Click(object sender, EventArgs e)
        {
            var units = employeeLogic.Read(null);

            pdfDiagrammComponent.createPdfDeiagram("C:/diagramm.pdf", units[0], DataLabelType.Percent);
        }

        private void btnPluginStart_Click(object sender, EventArgs e)
        {
            Action<Employee, EmployeeLogic, Action> temp;
            manager.update.TryGetValue(comboBoxPlugins.Text, out temp);
            var employee=employeeLogic.Read(null)[controlListBox1.SelectedIndex];
            temp.Invoke(employee, employeeLogic, UpdateData);
        }
        private void UpdateData()
        {
            controlListBox1.Items.Clear();
            var info = employeeLogic.Read(null);
            controlListBox1.Items.AddRange(new string[] { "Фамилия\t" + "Навык\t\t" + "Опыт" });
            foreach(var infoes in info)
            {
                var list = new List<String>();
                list.Add(infoes.Name + "\t" + infoes.Skills.ToString() + "\t\t " + infoes.WorkExp.ToString());
                controlListBox1.Items.AddRange(list.ToArray());
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Action<IEnumerable<Employee>> temp;
            manager.report.TryGetValue(comboBoxPlugins.Text, out temp);
            List<Employee> employees = new List<Employee>();
            employees.Add(employeeLogic.Read(null)[controlListBox1.SelectedIndex]);
            temp.Invoke(employees);

        }
    }
}
