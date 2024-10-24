using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("How many employees will be registered: ");
            int num_employees = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < num_employees; i++) {

                Console.WriteLine("Employee #" + (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                list.Add(new Employee(id, name, salary)); // Já instanciamos dentro da lista. 

            }

            Console.Write("Enter the employee Id that will have salary increase: ");
            int id_increase = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == id_increase);

            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percent);
            }
            else {
                Console.WriteLine("This ID dos not Exist");
            }

            Console.WriteLine();
            Console.WriteLine("Updated List of Employees:");
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }

        }
    }
}