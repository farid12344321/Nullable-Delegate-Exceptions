using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable__Delegate__Exceptions_Homework
{
    public class PersonServoce : IPersonService
    {
        public int HighlySalary(int salary)
        {
            var people = GetAll();

           return people.FindAll(m => m.Salary > salary).Count;
            
        }
        private List<Person> GetAll()
        {
            return new List<Person>() {new Person { Id = 1, Name = "Farid", Surname = "Abdullayev" ,Address="Nesimi",Salary=1001},
                new Person { Id = 2, Name = "Shaiq",Surname="Kazimov",Address="Sedmoy" ,Salary=1002},
                new Person { Id = 3,Name="Cavid",Surname="Ismayilzade",Address="Sulutepe",Salary=999} };
        }
    }
}
