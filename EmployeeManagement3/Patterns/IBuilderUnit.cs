using System;
using System.Collections.Generic;
using System.Text;

namespace EM_3_MainLogic.Patterns
{
    public interface IBuilderUnit
    {
        void setName();
        void setSurname();
        void setPatronymic();
        void setSkills();
        void setWorkExp();
        EM_3_MainLogic.Binding_Model.Employee Build();
    }
}
