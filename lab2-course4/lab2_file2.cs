using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_file2
{
    class lab2_file2_class
    {
        public int n;
        public int a;
        public int sum_formula;
        public string Enter_N()
        {
            n =Convert.ToInt32(Console.ReadLine());
            return "";
        }
        public string Enter_A()
        {
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            return "";
        }
        public string CheckA()
        { 
            
            return "";
        }
        public string CheakN()
        {
            if (n % 1 == 0)
            {
                Console.WriteLine("Целое"); 
            }
            return "";
        }
        public string Formula()
        {
            sum_formula = a * (a + 1);

            for (int i = 0; i < (n-2); i++)
            {
                sum_formula *= (a + n - 1);
                Console.WriteLine(sum_formula);          
            }
            return "";
        }
        
    }
}
