using System;

namespace Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double metre = double.Parse(Console.ReadLine());
            double metrePrice = 7.61;
            double price = metre * metrePrice;
            double discount = 0.18 * price;
            double finnalPrice = price - discount;

            Console.WriteLine($"The finnal price is:{finnalPrice} lv.");
            Console.WriteLine($"The discount is:{discount}");
            
        }
    }
}
