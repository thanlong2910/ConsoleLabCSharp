using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class ArrayExample
    {
        public void setArrayValue(int[] arrayInteger)
        {
            Console.WriteLine("Set value of array integer: ");
            for (int i = 0; i < arrayInteger.Length; i++)
            {
                arrayInteger[i] = int.Parse(Console.ReadLine());
            }
        }

        public void getArrayValue(int[] arrayInteger)
        {
            foreach (var item in arrayInteger)
            {
                Console.Write(item + " ");
            }
        }
    }

    // Constructor Example
    // Create Class Person: private string name, private int age.
    // Initial object Person by Constructor
    public class Person
    {
        

    }

    // Random Example
    public class RandomExample
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose: ");
            Console.WriteLine("1. ArrayExample");

            int status;
            status = int.Parse(Console.ReadLine());

            switch (status)
            {
                #region ArrayExample
                case 1:
                    {
                        
                        // Array
                        ArrayExample arrayExample = new ArrayExample();
                        int[] arrayInteger1 = { 1, 2, 4, 6, 8, 15 };
                        arrayExample.getArrayValue(arrayInteger1);

                        int[] arrayInteger2 = new int[3];
                        arrayExample.setArrayValue(arrayInteger2);
                        arrayExample.getArrayValue(arrayInteger2);
                        break;

                    }
                #endregion
                default:
                    break;
            }

            // Array
            //ArrayExample arrayExample = new ArrayExample();
            //int[] arrayInteger1 = { 1, 2, 4, 6, 8, 15 };
            //arrayExample.getArrayValue(arrayInteger1);

            //int[] arrayInteger2 = new int[3];
            //arrayExample.setArrayValue(arrayInteger2);
            //arrayExample.getArrayValue(arrayInteger2);

            Console.ReadLine();
        }
    }
}
