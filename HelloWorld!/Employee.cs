using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_
{
    public class Employee
    {
        public string Name {  get; set; }
        public string Speciality {  get; set; }
        public int Salary {  get; set; }
        public Employee(string name, string speciality, int salary) 
        {
            Name = name;
            Speciality = speciality;
            Salary = salary;
        }
    }
}
