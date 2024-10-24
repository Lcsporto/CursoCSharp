using System.Globalization;
using System.Collections.Generic;

namespace Exercicio2 {
    internal class Program {
        static void Main(string[] args) {
            //Projeto de treinamento do exercicio, para entender os conceitos. 

            Console.Write("How many employees will be registered: ");
            int num_emp = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i = 0; i < num_emp; i++) {

                Console.WriteLine($"Employee: #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                list.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee Id that will have salary increase: ");
            int emp_increase = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == emp_increase);

            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IcreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This Id does not Exist!");
            }

            Console.WriteLine();

            foreach(Employee obj in list) {
                Console.WriteLine(obj);
            }


        }
    }
}