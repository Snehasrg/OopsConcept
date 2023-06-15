using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Encapsulation
    {
        public string Name;
        public int Salary;

        public void SetSalary(int salary)
        {
            this.Salary = salary;
        }
        public int GetSalary()
        {
            return Salary;
        }
    }
}
