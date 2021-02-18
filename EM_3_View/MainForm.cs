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
using EM_3_MainLogic.Database.Model;
using DataLabelType = MigraDoc.DocumentObjectModel.Shapes.Charts.DataLabelType;

namespace EM_3_View
{
    public partial class MainForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IEmployeeLogic unitLogic;
        public MainForm(IEmployeeLogic  unitLogic)
        {
            InitializeComponent();
            this.unitLogic = unitLogic;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var units = unitLogic.Read(null);
            var cl = new EmployeeSkills();
            var Skills = new List<List<SkillList>>();
            var name = new List<string>();
            foreach (var unit in units)
            {
                Skills.Add(new List<SkillList> { unit.Skills });
                name.Add(unit.Name);
            }
            var top = new string[] { "Name", "skill" };
            exelTable.Create<SkillList>("C:/table.pdf", false, name, Skills);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCreateEmployee>();
            form.ShowDialog();
            var unit = unitLogic.Read(null);
        }

        private void controlListBox1_Load(object sender, EventArgs e)
        {
            var units = unitLogic.Read(null);
            controlListBox1.Items.AddRange(new string[] { "Фамилия\t" + "Навык\t\t" + "Опыт" });
            foreach (var unit in units)
            {
                var list = new List<String>();
                list.Add(unit.Name + "\t" + unit.Skills.ToString() + "\t\t " + unit.WorkExp.ToString());
                controlListBox1.Items.AddRange(list.ToArray());
            }
        }

        [Obsolete]
        private void buttonPdfDiagram_Click(object sender, EventArgs e)
        {
            var units = unitLogic.Read(null);

            pdfDiagrammComponent.createPdfDeiagram("C:/diagramm.pdf", units[0], DataLabelType.Percent);
        }

    }
}
