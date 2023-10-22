namespace Labb_8_OOP_Generic_collections
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Create 5 employee-objects
			Employee employee1 = new Employee(001, "Alex", "Male", 30000);
			Employee employee2 = new Employee(002, "Hanna", "Female", 35000);
			Employee employee3 = new Employee(003, "Jonas", "Male", 40000);
			Employee employee4 = new Employee(004, "Ludvig", "Male", 25000);
			Employee employee5 = new Employee(005, "David", "Male", 27000);

			//Create new employee-stack and push all employees onto it
			Stack<Employee> employees = new Stack<Employee>();
			employees.Push(employee1);
			employees.Push(employee2);
			employees.Push(employee3);
			employees.Push(employee4);
			employees.Push(employee5);

			//Print out employee information by looping through employee-stack.
			foreach (Employee employee in employees)
			{
                Console.WriteLine(employee.ToString());
				Console.WriteLine($"Employee count: {employees.Count()}");
            }

			//Print-divider
            Console.WriteLine("\t---------------------------------------------\t");

			//For-loop going through the entire stack removing each object
			for (int i = 0; i < 5; i++)
			{
				//Popping and printing out information about the stack
				Console.WriteLine(employees.Pop().ToString());
				Console.WriteLine($"Employee left in stack: {employees.Count()}");
			}

			//Pushing the employees into the stack again
			employees.Push(employee1);
			employees.Push(employee2);
			employees.Push(employee3);
			employees.Push(employee4);
			employees.Push(employee5);

			//Print-divider
			Console.WriteLine("\t---------------------------------------------\t");

			//Peek and print out result
			Console.WriteLine(employees.Peek().ToString());
			Console.WriteLine(employees.Peek().ToString());

			//Print-divider
			Console.WriteLine("\t---------------------------------------------\t");

			//Check if employee3 is in stack
			if (employees.Contains(employee3))
			{
				Console.WriteLine("Employee 3 is in stack");
			}
			else
			{
				Console.WriteLine("Employee 3 is not in stack");
			}

			//Print-divider
			Console.WriteLine("\t---------------------------------------------\t");

			//Make a list of employees and add 5 employees
			List<Employee> employeeList = new List<Employee>()
			{
				employee1, employee2, employee3, employee4, employee5
			};

			//Check if an employee exists in the list
			if (employeeList.Contains(employee2))
			{
				Console.WriteLine("Employee2 exists in the list");
			}
			else
			{
                Console.WriteLine("Employee2 does not exist in list");
            }

			//Print-divider
			Console.WriteLine("\t---------------------------------------------\t");

            //Print out the first male employee in list
            Console.WriteLine("First male in list:");
            Console.WriteLine(employeeList.Find(employee => employee.Gender == "Male").ToString());

            //Print out all male employees in list
            Console.WriteLine("All males in list: ");
            foreach (Employee employee in employeeList.FindAll(x => x.Gender == "Male"))
			{
				Console.WriteLine(employee.ToString());
			}
        }
	}
}