using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavioral
{
    public abstract class Employee
    {
        private int WorkExp;
        public abstract void setName();
        public abstract void setSkill();
        public  void addWorkExp(int addition)
        {
            WorkExp += addition;
        }

        
    }
}
