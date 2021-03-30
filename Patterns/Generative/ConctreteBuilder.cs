using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Generative
{
    public class ConctreteBuilder : Builder
    {
        Skill skill = new Skill();
        public override void Communication()
        {
            skill.Add("Communication");
        }

        public override void Critical_Thinking()
        {
            skill.Add("Critical_Thinking");
        }

        public override void Leadership()
        {
            skill.Add("Leadership");
        }

        public override void Positive_Attitude()
        {
            skill.Add("Leadership");
        }

        public override void Teamwork()
        {
            skill.Add("Teamwork");
        }

        public override void Work_Ethic()
        {
            skill.Add("Work_Ethic");
        }
    }
}
