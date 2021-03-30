using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Generative
{
    class Skill
    {
        List<object> skills=new List<object>();
        public void Add(string skill)
        {
            skills.Add(skill);
        }

    }
}
