using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chava;

namespace BankTel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Amount");
            double x = Convert.ToDouble(Console.ReadLine());
            Class1 obj = new Class1();
            obj.GetBalance(x);
            Console.WriteLine(" End");
            obj.GetBalance(x);
            Console.WriteLine(" End");
            Console.WriteLine(" Youare into ");
            Console.ReadLine();
        }
    }
}
