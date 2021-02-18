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
            using (var context = new DataBase())
            {
                var unit = context.Employees.FirstOrDefault(rec => rec.Id == model.Id);
                if (unit != null)
                {
                    context.Employees.Remove(unit);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public List<EmployeeView> Read(Employee filter)
        {
            using (var context = new DataBase())
            {
                return context.Employees
                .Where(rec => filter == null || rec.Id == filter.Id)
                .ToList()
               .Select(rec => new EmployeeView
               {
                   Id = rec.Id,
                   Name = rec.Name,
                   Surname = rec.Surname,
                   Patronymic = rec.Patronymic,
                   Skills = rec.Skills,
                   WorkExp = rec.WorkExp
               })
               .ToList();
            }
        }
    }
}
