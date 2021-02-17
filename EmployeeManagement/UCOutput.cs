using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EmployeeManagement
{
    public partial class UCOutput : UserControl
    {
        public void construct(int columnNum, int rowNum, object cellObj)
        {
            
            while (dataGridView.Columns.Count < columnNum)
            {
                dataGridView.Columns.Add("", cellObj.GetType().GetProperty("cellValue").Name);
            }
            while (dataGridView.Rows.Count < rowNum)
            {
                dataGridView.Rows.Insert(dataGridView.Rows.Count-1,1);
            }
            dataGridView.Rows[rowNum-1].Cells[columnNum-1].Value = cellObj.GetType().GetProperty("cellValue").GetValue(cellObj);
            dataGridView.Rows.Insert(dataGridView.Rows.Count - 1, 1);
        }
        public int index
        {
            get { return dataGridView.CurrentRow.Index; }
            set { dataGridView.Rows.InsertCopy(dataGridView.CurrentRow.Index, value); }
        }
        public object returnObject(object obj)
        {
            obj.GetType().GetProperty("cellValue").SetValue(obj, dataGridView.CurrentRow.DataBoundItem);
            return obj;
        }
        public void clear()
        {
               dataGridView.Rows.SharedRow(dataGridView.CurrentRow.Index);
        }
        public UCOutput()
        {
            InitializeComponent();
            dataGridView.RowHeadersVisible=false;
            dataGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
        }


    }
}
