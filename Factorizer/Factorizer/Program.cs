using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Factorizer!");

            //creates Factorizer object
            Factorizer cond = new Factorizer();
            cond.Run();

            Console.ReadLine();
        }
    }
}
