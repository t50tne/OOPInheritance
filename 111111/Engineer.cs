using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance
{
    internal class Engineer : Employee
    {
        public string EngineerDegree { get; set; }
        public Engineer(string name, string surname, long id, string sex,
                    int age, string position, int salary, string engineerDegree = "unknown")
        {
            this.Name = name;
            this.Surname = surname;
            this.ID = id;
            this.Sex = sex;
            this.Age = age;
            this.Position = position;
            this.Salary = salary;
            this.EngineerDegree = engineerDegree;
        }
        public override void GetEmployeeData()
        {
            Console.WriteLine("Employee Name: {0}", Name);
            Console.WriteLine("Employee Surname: {0}", Surname);
            Console.WriteLine("Employee ID: {0}", ID);
            Console.WriteLine("Employee Age: {0}", Age);
            Console.WriteLine("Employee Sex: {0}", Sex);
            Console.WriteLine("Employee Position: {0}", Position);
            Console.WriteLine("Employee Salary: {0}", Salary);
            Console.WriteLine("Employee Degree: {0}", EngineerDegree);
        }
    }
}
