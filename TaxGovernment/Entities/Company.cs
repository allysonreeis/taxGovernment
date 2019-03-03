namespace TaxGovernment.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company (string name, double anualIncome, int numberOfEmployees) : base (name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double total = 0.0;
            if (NumberOfEmployees <= 10)
            {
                total = AnualIncome * 0.16;
            }
            else
            {
                total = AnualIncome * 0.14;
            }
            return total;
        }
    }
}
