using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Structure
{
    public class RefinedEmployee:Employee
    {
        public RefinedEmployee(Skill imp)
       : base(imp)
        { }
        public override void Operation()
        {
        }
    }
}
