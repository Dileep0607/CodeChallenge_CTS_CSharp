using System;
using System.IO;

public class Helloworld
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the name of the product :");
        var i = Console.ReadLine();
        Console.WriteLine("Enter the price of the product : ");
        var p = Convert.ToInt64(Console.ReadLine());
        bool? input;
        Console.WriteLine("Is the product on SALE (yes/no) : ");
        input = bool.Parse (Console.ReadLine ());
        Console.WriteLine("Enter number of product sold in day 1 ");
        var d1 = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Enter number of product sold in day 2 ");
        var d2 = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Enter number of product sold in day 3 ");
        var d3 = Convert.ToInt64(Console.ReadLine());
        if (input == true)
        {
            var s = 100 - 7;
            p = (int)((p * s) / 100);
            var d1t = d1 * p;
            Console.WriteLine("Day 1 sales total : " + d1t.ToString());
            p = (int)((p * s) / 100);
            var d2t = d2 * p;
            Console.WriteLine("Day 2 sales total : " + d2t.ToString());
            p = (int)((p * s) / 100);
            var d3t = d3 * p;
            Console.WriteLine("Day 3 sales total : " + d3t.ToString());
        }
        else 
        {
            var d11t = d1 * p;
            Console.WriteLine("Day 1 sales total : " + d11t.ToString());
            var d22t = d2 * p;
            Console.WriteLine("Day 1 sales total : " + d22t.ToString());
            var d33t = d3 * p;
            Console.WriteLine("Day 1 sales total : " + d33t.ToString());
        }
    }
}
