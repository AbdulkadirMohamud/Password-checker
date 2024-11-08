using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Enter password: ");
            string passwordc   = Console.ReadLine();

            Console.WriteLine(password);
            Console.WriteLine(password);
            if (!password.Equals(string.Empty) && !password.Equals(string.Empty))
            {



                //
            }
            else
            {
                Console.WriteLine("please enter a password .");
            }

            Console.ReadLine();
        }
    }
}
