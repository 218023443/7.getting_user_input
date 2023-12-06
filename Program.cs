using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.getting_user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hi "+ name);
            Console.WriteLine("how old are you?");
            String age=Console.ReadLine();  
            Console.WriteLine(name+" is "+  age+" years old");
            Console.ReadLine();
        }
    }
}
