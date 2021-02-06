using System;
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
    public partial class FormView : Form
    {
        private List<object> _list = new List<object>();

        public FormView()
        {
            InitializeComponent();

            select.loadList = typeof();

            DateTime date = DateTime.Now;
            for (int i = 0; i < 7; i++)
            {
                date = date.AddDays(1);
                _list.Add(new TestClass()
                {
                    id = i,
                    Name = "IT" + i.ToString(),
                    Date = date
                });
            }

            output.List = _list;
        }
    }
}
