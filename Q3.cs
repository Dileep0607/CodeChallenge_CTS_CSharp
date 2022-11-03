using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class HelloWorld {
  static void Main() 
  {
    Console.WriteLine("Total students placed in CS :");
    int num1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Total students placed in MECH :");
    int num2=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Total students placed in MET :");
    int num3=Convert.ToInt32(Console.ReadLine());
    if(num1>num2 && num1>num3)
    Console.WriteLine("Highest Placement CS");
    else if(num2>num3)
    Console.WriteLine("Highest Placement MECH");
    else if(num1==num2)
    {
        Console.WriteLine("Highest Placement CS");
        Console.WriteLine("Highest Placement MECH");
    }
    else if(num1==num3)
    {
        Console.WriteLine("Highest Placement CS");
        Console.WriteLine("Highest Placement MET");
    }
    else if(num3==num2)
    {
        Console.WriteLine("Highest Placement MECH");
        Console.WriteLine("Highest Placement MET");
    }
    else
    Console.WriteLine("Highest Placement MET");
  }
}
