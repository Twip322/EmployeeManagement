using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EmployeeManagement
{
    public partial class UCInput : UserControl
    {
        public string date { get; private set; }

        Regex reg = new Regex(@"\d{1,2}/\d{1,2}/\d{4}");
        public string Result
        {
            get => Result;
            set
            {
                this.Result = value;
                textBox.Text = Result;
            }
        }
        public UCInput()
        {
            InitializeComponent();
        }

        private void CheckInput()
        {
            if (textBox.Text == "")
            {
                textBoxState.Text = "Значение не введено";
                return;
            }
            if (textBox.Text == null && checkBox.Checked.Equals(false))
            {
                textBoxState.Text = "Значение нулевое";
                Result = null;
                return;
            }
            string[] test = textBox.Text.Split('/');
            if(Int32.Parse(test[0])>31 && Int32.Parse(test[1]) > 12 && Int32.Parse(test[2]) > DateTime.Now.Year)
            {
                if (reg.Match(textBox.Text).Success)
                {
                    Result = textBox.Text;
                    textBoxState.Text = "Дата введена верно";
                    return;
                }
                else
                {
                    Result = null;
                    textBoxState.Text = "Дата имеет неверный формат";
                    return;
                }
            }
            else
            {
                Result = null;
                textBoxState.Text = "Числа в дате превышают допустимые";
                return;
            }
            
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            CheckInput();
        }
    }
}
