using EM_3_MainLogic.Binding_Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EM_3_MainLogic.Logic
{
    public class EmployeeLogic:IEmployeeLogic
    {
        public void CreateOrUpdate(Employee model)
        {
            Employee employeeunit;
            using (var context = new Database())
            {

                if (model.Id.HasValue)
                {
                    employeeunit = context.OrganizationUnit.FirstOrDefault(rec => rec.Id == model.Id);
                    if (employeeunit == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    employeeunit = new Employee
                    {
                        Name = model.Name,
                        Surname = model.Surname,
                        Patronymic = model.Patronymic,
                        Skills = model.Skills,
                        WorkExp = model.WorkExp;
                    };
                    context.OrganizationUnit.Add(employeeunit);
                    context.SaveChanges();
                    return;
                }
                employeeunit.Name = model.Name;
                employeeunit.Surname = model.Surname;
                employeeunit.Patronymic = model.Patronymic;
                employeeunit.Skills = model.Skills;
                employeeunit.WorkExp = model.WorkExp;
                context.SaveChanges();
            }
        }
    }
}
