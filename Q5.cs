using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Hello{
    public static double GetGrosspay(int hr)
    {
        double grosspay;
        if(hr<=56)
        {
            grosspay=hr*80;
        }
        else
        {
            double er= 1.5 * hr;
            grosspay = 56 * 80;
            int eh = hr - 56;
            grosspay = grosspay + (eh * er);
        }
        return grosspay;
    }
    public static double CalculateTax(double grosspay)
    {
        double tax;
        tax=grosspay*0.02;
        return tax;
    }
    public static double CalculateNetPay(int hr)
    {
        double grosspay,tax,netpay;
        grosspay=GetGrosspay(hr);
        tax=CalculateTax(grosspay);
        netpay=grosspay-tax;
        return netpay;
    }
  public static void Main() 
  {
    Console.WriteLine("Enter the number of hours worked :");
    int hr = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"The calculated Net pay is ${CalculateNetPay(hr)}");
  }
}
