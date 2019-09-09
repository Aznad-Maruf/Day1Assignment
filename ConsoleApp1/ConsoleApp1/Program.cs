using System;

namespace myNameSpace
{
    class FisrtClass
    {
        static void Main(string[] args)
        {
            string name, address, contact;
            int age;
            Console.Write("Enter your name : ");
            name = Console.ReadLine();
            Console.Write("Enter your Age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Address : ");
            address = Console.ReadLine();
            Console.Write("Enter your Contact : ");
            contact = Console.ReadLine();

            Console.WriteLine("\n--------o------\nName\t: " + name + "\nAge\t: " + age + "\nAddress\t: " + address + "\nContact : " + contact);

            Console.ReadKey();

        }
    }
}