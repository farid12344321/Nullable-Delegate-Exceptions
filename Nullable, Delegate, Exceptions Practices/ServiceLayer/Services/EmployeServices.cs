using DomainLayer.Models;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class EmployeServices : IEmployeeeService
    {
        public int GetCountByAge(int age)
        {
            var employess = GetAll();

            return employess.FindAll(m=>m.Age > age).Count;
        }
        private List<Employee> GetAll()
        {
            return new List<Employee>() {new Employee { Id = 1, Name = "mirze", Age = 26 },
                new Employee { Id = 2, Name = "Cahandar",Age=26 },
                new Employee { Id = 3,Name="Anar",Age=27 } };
        }   
    }
}
