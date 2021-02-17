using EM_3_MainLogic.Database.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EM_3_MainLogic.Binding_Model
{
    public class Employee
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public SkillList Skills { get; set; }
        public int WorkExp { get; set; }

    }
}
