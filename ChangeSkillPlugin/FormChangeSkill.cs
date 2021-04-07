using Database;
using EM_3_MainLogic.Binding_Model;
using EM_3_MainLogic.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeSkillPlugin
{
    public partial class FormChangeSkill : Form
    {
        private Employee employee;
        private EmployeeLogic logic;
        private Action a;
        public FormChangeSkill(Employee employee,EmployeeLogic employeeLogic,Action a)
        {
            InitializeComponent();
            this.employee = employee;
            this.logic = employeeLogic;
            this.a = a;
        }

        private void FormChangeSkill_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(
                typeof(SkillList))
                .Cast<SkillList>()
                .Select(p => new
                {
                    Name = Enum.GetName(typeof(SkillList), p),
                    Value = (int)p
                })
                .ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee.Skills = (SkillList)Enum.Parse(typeof(SkillList), comboBox1.SelectedValue.ToString());
            logic.CreateOrUpdate(employee);
            a.Invoke();
        }
    }
}
