using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class NumberExample
    {
        int inputNum;

        string str;

        public NumberExample(int num)
        {
            inputNum = num;
        }

        public void setIntegerNumber(int temp)
        {
            inputNum = temp;
        }

        public void GetResult()
        {
            //str = inputNum + "";
            //int lengthInputNum = str.Length;

            //if (lengthInputNum % 2 == 1)
            //{
            //    int temp = 
            //}

            double numberLength = Math.Log10(inputNum);
            int num2 = int.Parse(numberLength.ToString)
            Console.WriteLine(numberLength);
        }
        

    }

    class Program
    {
        static void Main(string[] args)
        {
            NumberExample numExp = new NumberExample(123456);
            numExp.GetResult();

            Console.ReadLine();
        }
    }
}
