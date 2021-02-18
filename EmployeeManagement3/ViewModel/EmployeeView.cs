using EM_3_MainLogic.Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EM_3_MainLogic.ViewModel
{
    public class EmployeeView
    {
        public int? Id { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [DisplayName("Отчество")]
        public string Patronymic { get; set; }
        [DisplayName("Навыки")]
        public SkillList Skills { get; set; }
        [DisplayName("Опыт работы")]
        public int WorkExp { get; set; }
    }
}
