using EM_3_MainLogic.Binding_Model;
using EM_3_MainLogic.Interface;
using EM_3_MainLogic.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeWorkExperience
{
    [Export(typeof(IUpdate))]
    public class UpdateWorkExp : IUpdate
    {
        public string name => "Увеличение трудового стажа";

        public void Update(Employee employee, EmployeeLogic employeeLogic, Action a)
        {
            var form = new ChangeWorkExp(employee, employeeLogic, a);
            form.Show();
        }
    }
}
