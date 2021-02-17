using EM_3_MainLogic.Binding_Model;
using EM_3_MainLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EM_3_MainLogic.Logic
{
    public interface IEmployeeLogic
    {
        void CreateOrUpdate(Employee model);

        List<EmloyeeView> Read(Employee filter);

        void Delete(Employee model);

    }
}
