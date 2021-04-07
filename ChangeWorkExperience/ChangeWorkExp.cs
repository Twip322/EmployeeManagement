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

namespace ChangeWorkExperience
{
    public partial class ChangeWorkExp : Form
    {
        private Employee employee;
        private EmployeeLogic logic;
        private Action a;
        public ChangeWorkExp(Employee employee, EmployeeLogic employeeLogic, Action a)
        {
            InitializeComponent();
            maskedTextBox1.Mask = "0";
            this.employee = employee;
            this.logic = employeeLogic;
            this.a = a;
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text.Equals(null))
            {
                MessageBox.Show("Введите число");
            }
            else
            {
                employee.WorkExp += Int32.Parse(maskedTextBox1.Text);
                logic.CreateOrUpdate(employee);
                a.Invoke();
            }
        }
    }
}
