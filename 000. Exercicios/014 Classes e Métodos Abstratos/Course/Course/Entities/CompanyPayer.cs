
namespace Course.Entities
{
    internal class CompanyPayer : Payer
    {
        public int Empolyees { get; set; }

        public CompanyPayer(string name, double anualIncome, int empolyees) : base(name, anualIncome)
        {
            Empolyees = empolyees;
        }

        public override double TaxesCalculation()
        {
            double taxes = 0.0;

            if (Empolyees < 10)
            {
                taxes = AnualIncome * 0.16;
            }
            else
            {
                taxes = AnualIncome * 0.14;
            }

            return taxes;
        }
    }
}
