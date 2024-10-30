using System.Collections.Generic;
using ExercicioResolvido001.Entities.Enums;

namespace ExercicioResolvido001.Entities
{
    internal class Worker
    {
        public String Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } //Dessa maneira que fazemos a associação entre duas Classes diferentes (Composição de Objetos)
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();// Quando temos uma associação 'Para Muitos', devemos fazer uma lista para o objeto. 

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) // Por padrão, não colocamos uma lista na instanciação de um construtor, ele inicia vazio e depois inserimos os valores.
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month) 
        {
            double sum = BaseSalary;

            foreach(HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month) {

                    sum += contract.TotalValue();
                }
            }

            return sum;
        }

    }
}
