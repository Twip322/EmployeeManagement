using EM_3_MainLogic.Binding_Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EM_3_MainLogic.Interface
{
    public interface IUpdate
    {
        string name { get; }
        void Update(Employee employee, EM_3_MainLogic.Logic.EmployeeLogic employeeLogic, Action a);
    }
}
