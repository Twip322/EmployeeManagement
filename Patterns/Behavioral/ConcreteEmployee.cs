using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavioral
{
    public class ConcreteEmployee : EmployeeTemplate
    {
        string Name;
        string Skill;
        public override void setName()
        {
            Name = "Name";
        }

        public override void setSkill()
        {
            Skill = "Skill";
        }
    }
}
