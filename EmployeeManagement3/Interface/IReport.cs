using EM_3_MainLogic.Binding_Model;
using EM_3_MainLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EM_3_MainLogic.Interface
{
    public interface IReport
    {
        string name { get; }
        void Report(IEnumerable<Employee> units);
    }
}
