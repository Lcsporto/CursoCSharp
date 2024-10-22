using System.Globalization;

namespace Exercicio2 {
    internal class Employee {
        public int Id { get; set; }
        public String Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string nome, double salary) {
            Id = id;
            Name = nome;
            Salary = salary;
        }

        public void IcreaseSalary(double percent) {
            Salary += Salary * (percent / 100);
        }

        public override string ToString() {
            return Id 
                + ", " 
                + Name 
                + ", " 
                + Salary.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
