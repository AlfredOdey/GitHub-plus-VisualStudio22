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
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"My name is {name}.\nMy phone number is {phoneNumber}.\n");
        }
    }
}
