using EM_3_MainLogic.Database.Model;
using EM_3_MainLogic.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace EM_3_View
{
    public partial class FormCreateEmployee : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IEmployeeLogic unitLogic;
        public FormCreateEmployee(IEmployeeLogic unitLogic)
        {
            InitializeComponent();
            this.unitLogic = unitLogic;
        }
        private void FormCreateOraganizationUnit_Load(object sender, EventArgs e)
        {
            var list = Enum.GetValues(typeof(SkillList))
     .Cast<SkillList>()
     .Select(v => v.ToString())
     .ToList();
            controlSelected.AddList(list);

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SkillList skill;
                Enum.TryParse<SkillList>(controlSelected.SelectedItem, out skill);
                unitLogic.CreateOrUpdate(new EM_3_MainLogic.Binding_Model.Employee
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurename.Text,
                    Patronymic = textBoxPatr.Text,
                    Skills = skill,
                    WorkExp = (int)rangeNumber.Value.Value

                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
