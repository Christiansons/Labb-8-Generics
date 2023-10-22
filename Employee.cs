using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_8_OOP_Generic_collections
{
	internal class Employee
	{
        //Properties for employees
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        //Constructor for initiating employee-object with properties
        public Employee(int id, string name, string gender, int salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary; 
        }

        //To-string method to print out information about an employee
        public override string ToString()
        {
            return $"Employee ID: {Id} - Name: {Name} - Gender: {Gender} - Salary: {Salary}";
		}
    }
}
