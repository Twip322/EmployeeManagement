using EM_3_MainLogic.Binding_Model;
using EM_3_MainLogic.Interface;
using EM_3_MainLogic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;

namespace ChangeSkillPlugin
{
    [Export(typeof(IUpdate))]
    public class UpdateSkill:IUpdate
    {
        public string name => "Прохождение обучения";
        public void Update(Employee employee, EmployeeLogic employeeLogic, Action a)
        {
            var form = new FormChangeSkill(employee, employeeLogic, a);
            form.Show();
        }
    }
}
