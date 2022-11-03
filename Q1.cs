using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter the number:");
                int n = Convert.ToInt32(Console.ReadLine());
                int[,] arr = new int[n,n];
                arr=GetArray(n);
                for (int i = 0; i < n; i++)
                {
                    Console.Write("\n");
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0}\t", arr[i, j]);
                    }
                    }
                Console.Write("\n\n");
        }
        public static int[,] GetArray(int num)
        {
            int i, j;
            int[,] arr = new int[num, num];
            for (i = 0; i < num; i++)
            { 
                for (j = 0; j < num; j++)
                {
                    if (i < j)
                    {
                        arr[i,j]=1;
                    }
                    else if (i > j)
                    {
                        arr[i, j] = -1;
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                }
            }   
            return arr;
        }
    }
}
