using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            // Nhap so nguyen number
            Console.WriteLine("Nhap so nguyen chia het cho 4: ");
            string strTemp = Console.ReadLine();
            number = Convert.ToInt32(strTemp);
            Console.WriteLine("**************************");
            int temp = 1;

            // vong lap - In tung hang 
            for (int index = 1; index <= number / 4; index++)
            {
                // In ra cac hang le: hang 1, 3, 5, 7, ...
                if (index % 2 != 0)
                {
                    string outputString1;
                    //outputString1 = (4 * (index -1) /2 + 1) + " " + (4 * index /2 + 2) + " " + (4 * index/2 + 3) + " " + (4 * index/2 + 4);
                    outputString1 = (2 * index - 1) + " " + (2 * index) + " " + (2 * index + 1) + " " + (2 * index + 2);
                    Console.WriteLine(outputString1);
                }

                // In ra cac hang chan: 2, 4, 6, 8
                else
                {
                    temp++;
                    string outputString2;
                    outputString2 = (4 * temp + 1) + " " + (4 * temp + 2) + " " + (4 * temp + 3) + " " + (4 * temp + 4);
                    Console.WriteLine(outputString2);
                }
            }

            Console.ReadLine();
        }
    }
}
