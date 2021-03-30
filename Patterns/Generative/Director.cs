using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Generative
{
    public class Director
    {
        Builder Builder;
        public Director(Builder builder)
        {
            this.Builder = builder;
        }
        public void Construct()
        {
            Builder.Communication();
            Builder.Critical_Thinking();
            Builder.Positive_Attitude();
            Builder.Teamwork();
            Builder.Leadership();
            Builder.Work_Ethic();
        }
    }
}
