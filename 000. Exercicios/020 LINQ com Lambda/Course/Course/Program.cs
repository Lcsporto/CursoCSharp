using Course.Entities;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double salary_base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salary));
                }
            }

            var emails = list.Where(e => e.Salary > salary_base).OrderBy(e => e.Email).Select(e => e.Email);
            Console.WriteLine($"Email of people whose salary is more than {salary_base.ToString("F2", CultureInfo.InvariantCulture)}: ");
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

            var sum = list.Where(e => e.Name.StartsWith('M')).Select(e => e.Salary).DefaultIfEmpty(0.0).Sum();
            Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
