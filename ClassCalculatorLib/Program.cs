using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCalculatorLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opening Calculator...");
            Calculator_new.Form1 cal = new Calculator_new.Form1();
            Console.WriteLine("Add A number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add Another number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation + , -, *, /");
            string stringOperation = Console.ReadLine();

            if (stringOperation == "+")
            {
                int total = n1 + n2;
               Console.WriteLine(total);
            }

            if (stringOperation == "-")
            {
                int total = n1 - n2;
                Console.WriteLine(total);
            }

            if (stringOperation == "*")
            {
                int total = n1 * n2;
                Console.WriteLine(total);
            }

            if (stringOperation == "/")
            {
                int total = n1/n2;
                Console.WriteLine(total);
            }

            Console.ReadKey();
        }
    }
}
