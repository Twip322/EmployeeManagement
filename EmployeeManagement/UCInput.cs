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
using System.Globalization;

namespace EmployeeManagement
{
    public partial class UCInput : UserControl
    {
        //TODO Передача NULL В DateTime
        private DateTime _dt;
        private DateTime _savedInput;
        private string _example = "Ex: 16/05/2001";
        private CultureInfo _ci = new CultureInfo("en-US");

        private bool isValid
        {
            get
            {
                bool b = DateTime.TryParseExact(textBoxDatePicker.Text, "dd/M/yyyy", _ci, DateTimeStyles.None, out _dt);
                return b;
            }
        }

        public DateTime? Date
        {
            get { return isValid ? DateTime.Parse(textBoxDatePicker.Text) : DateTime.Parse(""); }
            set { textBoxDatePicker.Text = value.ToString(); }
        }

        public bool isNull { get; set; } = false;

        public UCInput()
        {
            InitializeComponent();
            checkBoxNull.Checked = isNull;
            labelInfo.Text = _example;
        }

        private void checkBoxNull_CheckedChanged(object sender, EventArgs e)
        {
            isNull = checkBoxNull.Checked;
            textBoxDatePicker.Enabled = !isNull;
            if (isNull)
            {
                _savedInput = DateTime.Parse(textBoxDatePicker.Text);
                Date=DateTime.Parse("");
            }
            else
            {
                Date = _savedInput;
            }
        }

        private void textBoxDatePicker_TextChanged(object sender, EventArgs e)
        {
            if (!isValid)
            {
                labelInfo.Text = _example;
            }
            else
            {
                labelInfo.Text = "nice";
            }
        }
    }
}
