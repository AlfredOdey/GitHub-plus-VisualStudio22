using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_plus_VisualStudio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter phone number: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine($"My name is {name}.\nI am an adult.\n");
            }
            else
            {
                Console.WriteLine($"My name is {name}.\nI am a minor.\n");
            }


        }
    }
}
