using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of command line parameters = {0}", args.Length);
            int paramnbr = 1;
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("Number of parameters insufficient, inadequate.");
            }
            else
            {
                foreach (string s in args)
                {
                    Console.WriteLine("Param " + paramnbr.ToString() + ": " + s);
                    paramnbr++;  
                }
            }

        }
    }
}
