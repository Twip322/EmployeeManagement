using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EM_3_MainLogic.ViewModel
{
    public class EmloyeeView
    {
        public int Id { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [DisplayName("Отчество")]
        public string Patronimyc { get; set; }
        [DisplayName("Навыки")]
        public List<string> Skills { get; set; }
        [DisplayName("Опыт работы")]
        public int WorkExp { get; set; }
    }
}
