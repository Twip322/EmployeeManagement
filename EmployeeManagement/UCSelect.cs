using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class UCSelect : UserControl
    {
        public Object[] List { set
            {
                checkedListBox.Items.Clear();
                checkedListBox.Items.AddRange(value);
            }
        }
        public List<int> CheckIndex
        {
            get
            {
                return checkedListBox.CheckedIndices.OfType<int>().ToList();
            }
            set
            {
                foreach (var index in value)
                {
                    checkedListBox.SetItemChecked(index, true);
                }
            }
        }
        public UCSelect()
        {
            InitializeComponent();
        }
       
    }
}
