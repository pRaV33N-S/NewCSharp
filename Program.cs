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
            /*string firstName;
            string lastName;
            Console.WriteLine("Enter First Name");
            firstName=Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            lastName = Console.ReadLine();
            Console.WriteLine("Welcome Mr.\\Ms." + firstName + "" + lastName);
            Console.ReadKey();*/
            string name;
            int age;
            char grade;
            DateTime doj;
            double salary;
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade");
            grade = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of Joining");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Name : \t" + name + "\n Age: " + age + "\n Grade: \t"
                + grade + "\n Salary: \t  " + salary + "\n Date of Joining: \t " + doj);
            Console.ReadKey();
        }
    }
}
