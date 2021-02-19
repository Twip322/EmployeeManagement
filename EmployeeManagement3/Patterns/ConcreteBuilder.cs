using System;
using System.Collections.Generic;
using System.Text;
using EM_3_MainLogic.Database.Model;

namespace EM_3_MainLogic.Patterns
{
    public class ConcreteBuilder:IBuilderUnit
    {
        private EM_3_MainLogic.Binding_Model.Employee unit = new Binding_Model.Employee();
        public Binding_Model.Employee Build()
        {
            return unit;
        }
        
        public void setName()
        {
            unit.Name = "Alexei";
        }
        public void setSurname()
        {
            unit.Surname = "Vermeev";
        }
        public void setPatronymic()
        {
            unit.Patronymic = "Alexeevich";
        }
        public void setSkills()
        {
            unit.Skills = SkillList.Leadership;
        }
        public void setWorkExp()
        {
            unit.WorkExp = 10;
        }
    }
}
