using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to C# Tutorials");
            //Console.ReadKey();
            string firstName;
            string lastName;
            Console.WriteLine("Enter First Name");
            firstName=Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            lastName = Console.ReadLine();
            Console.WriteLine("Welcome Mr.\\Ms." + firstName + "" + lastName);
            Console.ReadKey();
        }
    }
}
