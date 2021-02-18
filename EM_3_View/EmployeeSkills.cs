using EM_3_MainLogic.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_3_View
{
    [Serializable]
    public class EmployeeSkills
    {
        public List<string> Surname { get; set; }

        public SkillList Skills { get; set; }

    }
}
