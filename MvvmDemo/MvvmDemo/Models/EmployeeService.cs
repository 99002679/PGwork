using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MvvmDemo.Models
{
    public class EmployeeService //: INotifyPropertyChanged
    {
        private static List<Employee> ObjEmployeesList;

        public EmployeeService()
        {
            ObjEmployeesList = new List<Employee>()
            {
                new Employee{Id = 101, Name="Grace",Age=23},
                new Employee{Id = 101, Name="Grace",Age=23},
                new Employee{Id = 101, Name="Grace",Age=23},
                new Employee{Id = 101, Name="Grace",Age=23},
                new Employee{Id = 101, Name="Grace",Age=23},
                new Employee{Id = 101, Name="Grace",Age=23},
                new Employee{Id = 101, Name="Grace",Age=23}

            };
        }

        public List<Employee> GetAll()
        {
            return ObjEmployeesList;
        }

        public bool Add(Employee objNewEmployee)
        {
            /*if (objNewEmployee.Age < 21 || objNewEmployee.Age > 58)
               // throw new ArgumentException("Invalid age limit of Employee");*/
            ObjEmployeesList.Add(objNewEmployee);
            return true;
        }

        public bool Update(Employee objEmployeeToUpdate)
        {
            bool IsUpdated = false;
            for(int index=0;index<ObjEmployeesList.Count;index++)
            {
                if(ObjEmployeesList[index].Id==objEmployeeToUpdate.Id)
                {
                    ObjEmployeesList[index].Name = objEmployeeToUpdate.Name;
                    ObjEmployeesList[index].Age = objEmployeeToUpdate.Age;
                    IsUpdated = true;
                    break;
                }
            }


            return IsUpdated;
        }


        public bool Delete(int id)
        {
            bool IsDeleted = false;
            for(int index=0; index<ObjEmployeesList.Count;index++)
            {
                if(ObjEmployeesList[index].Id==id)
                {
                    ObjEmployeesList.RemoveAt(index);
                    IsDeleted = true;
                    break;
                }
                    
            }
            return IsDeleted;
        }


        public Employee Search(int id)
        {
            return ObjEmployeesList.FirstOrDefault(e => e.Id == id);
            
        }
    }
}
