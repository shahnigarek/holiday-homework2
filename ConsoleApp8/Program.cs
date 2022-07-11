using System;
namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            Invoice inv = new Invoice("45378","Boby","Barlet");
            inv.CostCalculation(true);
            inv.Article="laptop";
            inv.Quantity = 6;
            Console.WriteLine(inv.CostCalculation(true));
            Console.WriteLine(inv.Article);
        }
    }
}