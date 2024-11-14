using System.Globalization;

namespace Course.Entities
{
    internal class IndividualPayer : Payer
    {
        public double HealthExpenditures { get; set; }

        public IndividualPayer(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesCalculation()
        {
            double taxes = 0.0;

            if (AnualIncome < 20000.00)
            {
                taxes = AnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                taxes = AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }

            return taxes;
        }
    }
}
