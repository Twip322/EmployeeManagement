using System;
using System.Collections.Generic;
using System.Text;

namespace EM_3_MainLogic.Patterns
{
    public class DirectorBuilder
    {
       public EM_3_MainLogic.Binding_Model.Employee Build(IBuilderUnit builderUnit)
        {
            builderUnit.setName();
            builderUnit.setSurname();
            builderUnit.setPatronymic();
            builderUnit.setSkills();
            builderUnit.setWorkExp();
            return builderUnit.Build();
        }
    }
}
