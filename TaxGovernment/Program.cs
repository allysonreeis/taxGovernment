using System;
using System.Collections.Generic;
using TaxGovernment.Entities;

namespace TaxGovernment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company(i / c) ? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIcome = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIcome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIcome, numberOfEmployees));
                }
            }

            Console.WriteLine("TAXES PAID");
            double totalValue = 0.0;
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.Tax().ToString("F2")}");
                totalValue += taxPayer.Tax();
            }
            Console.WriteLine($"\nTOTAL TAXES: $ {totalValue.ToString("F2")}");
        }
    }
}
