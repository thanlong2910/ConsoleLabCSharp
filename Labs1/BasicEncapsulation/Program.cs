using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicEncapsulation1
{
    // Encapsulation
    // private variable -> get, set function
    // how to set value and get value
    // how to access to the private variable
    class Person
    {
        public string name;
        public int age;
        private int money;

        public void setMoney(int tempMoney)
        {
            this.money = tempMoney;
        }

        public int getMoney()
        {
            return this.money;
        }
        public void DisplayInformation()
        {
            Console.WriteLine("name: {0}", name);
            Console.WriteLine("age: {0}", age);
            Console.WriteLine("money: {0}", getMoney());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.name = "Than Minh Vien";
            person1.age = 34;
            person1.setMoney(1000);
            person1.DisplayInformation();

            Console.ReadLine();
        }
    }
}
