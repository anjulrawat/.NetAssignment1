//Assignment 1 - Print The Stars

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelucid
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Enter the height of the triangle: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int spc = n - 1; // for Space
            int star = 1; // for stars

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < spc; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < star; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
                star = star + 2;
                spc--;
            }
            Console.ReadLine();
        }
      
    }
}
