using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char_project
{
    class Program
    {
        static void Main(string[] args)
        {
           int charMin = Char.MinValue;
            int charMax = Char.MaxValue;

           Char myVar = 'G';
            int myVarValue = 'G';
            Console.WriteLine("Min char ={0} Max char = {1} my character = {2} my Variable Number = {3}",charMin ,charMax ,myVar ,myVarValue);
            string mystring = "this is my program ";
            Console.WriteLine("\nmystring is  {0}",mystring);
            Console.ReadKey();
        }
    }
}
