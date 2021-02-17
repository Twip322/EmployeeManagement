using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EM_3_MainLogic.Database.Model
{
    public class EmployeeBD
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Patronymic { get; set; }
        [Required]
        public SkillList Skills { get; set; }
        [Required]
        public int WorkExp { get; set; }
    }
}
