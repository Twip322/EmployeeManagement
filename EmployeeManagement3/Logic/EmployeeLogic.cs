using EM_3_MainLogic.Binding_Model;
using System;
using System.Collections.Generic;
using System.Text;
using EM_3_MainLogic.Database;
using System.Linq;
using EM_3_MainLogic.Database.Model;
using EM_3_MainLogic.ViewModel;

namespace EM_3_MainLogic.Logic
{
    public class EmployeeLogic:IEmployeeLogic
    {
        public void CreateOrUpdate(Employee model)
        {
            EmployeeBD employee;
            using (var context = new DataBase())
            {

                if (model.Id.HasValue)
                {
                    employee = context.Employees.FirstOrDefault(rec => rec.Id == model.Id);
                    if (employee == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    employee = new EmployeeBD
                    {
                        Name = model.Name,
                        Surname = model.Surname,
                        Patronymic = model.Patronymic,
                        Skills = model.Skills,
                        WorkExp = model.WorkExp
                    };
                    context.Employees.Add(employee);
                    context.SaveChanges();
                    return;
                }
                employee.Name = model.Name;
                employee.Surname = model.Surname;
                employee.Patronymic = model.Patronymic;
                employee.Skills = model.Skills;
                employee.WorkExp = model.WorkExp;
                context.SaveChanges();
            }
        }

        public void Delete(Employee model)
        {
            throw new NotImplementedException();
        }

        public List<EmloyeeView> Read(Employee filter)
        {
            throw new NotImplementedException();
        }
    }
}
