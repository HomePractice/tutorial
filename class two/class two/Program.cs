using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_two
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter your  first name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("enter your  last name");
            string LastName = Console.ReadLine();

            Console.WriteLine("hello {0} , {1}", FirstName ,LastName);
           // Console.WriteLine("hello " + UserName);
            Console.ReadKey();
        }
    }
}
