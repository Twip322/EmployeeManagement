﻿using System;
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
        
        public FormView()
        {
            InitializeComponent();
            List<int> tl = new List<int> { 1, 2, 3, 4, 5 };
            select.loadList = tl;
            DateTime date = DateTime.Now;
            output.insert(1,2,new TestClass { cellValue="test"});
            output.insert(2, 1, new TestClass { cellValue = "test2" });
            output.insert(2, 3, new TestClass { cellValue = "test3" });
        }
    }
}
