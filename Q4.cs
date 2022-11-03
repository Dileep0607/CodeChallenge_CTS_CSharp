using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class HelloWorld {
    public static void headerMessage(string Company)
    {
        Console.WriteLine(Company+" "+"Employee Information");
    }
    public static void footerMessage(int Year)
    {
        Console.WriteLine("CopyRight"+Year);
    }
    public static void entirerMessage(string Company,string Employee,string Project,int Year)
    {
        headerMessage(Company);
        Console.WriteLine(Employee);
        Console.WriteLine(Project);
        footerMessage(Year);
        Console.WriteLine("All Rights Reserved");
    }
  public static void Main() 
  {
    Console.WriteLine("Enter the Company Name  :");
    string Company=Console.ReadLine();
    Console.WriteLine("Enter the Employee Name  :");
    string Employee=Console.ReadLine();
    Console.WriteLine("Enter the Project Name  :");
    string Project=Console.ReadLine();
    Console.WriteLine("Enter the Year  :");
    int Year=Convert.ToInt32(Console.ReadLine());
    entirerMessage(Company,Employee,Project,Year);
  }

}
