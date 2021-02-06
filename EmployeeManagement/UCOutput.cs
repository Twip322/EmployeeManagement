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
        private List<object> _list = new List<object>();
        //TODO Добавить в конструктор номер строки и номер столбца
        public List<Object> List
        {
            get { return _list; }
            set { dataGridView.DataSource = _list = value;}
        }

        public int SelectedIndex
        {
            get { return dataGridView.SelectedRows[0].Index; }
        }

        public UCOutput()
        {
            InitializeComponent();
        }

        private void ConfigureRow(int row, string property)
        {
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                if (dataGridView.Columns[i].Name == property)
                {
                    dataGridView.Columns[i].DisplayIndex = row;
                    break;
                }
            }
        }

        private void buttonConfigureRow_Click(object sender, EventArgs e)
        {
            string res = Interaction.InputBox("Введите индекс: ");
            try
            {
                int ind = Convert.ToInt32(res);
                string prop = Interaction.InputBox("Введите свойство: ");
                ConfigureRow(ind, prop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGetIndex_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                MessageBox.Show(SelectedIndex.ToString());
            }
        }

        private void buttonSetIndex_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                string res = Interaction.InputBox("Введите индекс: ");
                try
                {
                    int ind = Convert.ToInt32(res);
                    if (ind >= dataGridView.Rows.Count)
                    {
                        MessageBox.Show("За границами диапазона");
                        return;
                    }
                    if (SelectedIndex >= 0)
                    {
                        var temp = _list[SelectedIndex];
                        _list.RemoveAt(SelectedIndex);
                        _list.Insert(ind, temp);
                        List = _list;
                        dataGridView.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonSetCellValue_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count == 1)
            {
                string res = Interaction.InputBox("Введите значение: ");

                try
                {
                    var ot = Convert.ChangeType(res, dataGridView.SelectedCells[0].Value.GetType());
                    dataGridView.SelectedCells[0].Value = ot;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
