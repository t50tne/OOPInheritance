using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public long ID;
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

        public Employee(string name = "unknown", string surname = "unknown", long id = 0, string sex = "unknown",
                        int age = 0, string position = "unknown", int salary = 0)
        {
            this.Name = name;
            this.Surname = surname;
            this.ID = id;
            this.Sex = sex;
            this.Age = age;
            this.Position = position;
            this.Salary = salary;
        }

        public virtual void GetEmployeeData()
        {
            Console.WriteLine("Employee Name: {0}", Name);
            Console.WriteLine("Employee Surname: {0}", Surname);
            Console.WriteLine("Employee ID: {0}", ID);
            Console.WriteLine("Employee Age: {0}", Age);
            Console.WriteLine("Employee Sex: {0}", Sex);
            Console.WriteLine("Employee Position: {0}", Position);
            Console.WriteLine("Employee Salary: {0}", Salary);
        }
    }
}
