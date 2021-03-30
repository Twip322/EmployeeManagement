using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Structure
{
    public class Employee
    {
        protected Skill implementor;
        public Skill Implementor
        {
            set { implementor = value; }
        }
        public Employee(Skill imp)
        {
            implementor = imp;
        }
        public virtual void Operation()
        {
            implementor.ImplementedOperation();
        }
    }
}
