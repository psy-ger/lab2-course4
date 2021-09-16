using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2_file2;

namespace la2_file1
{
    class lab2_file1_class
    {
        static void Main()
        {

            lab2_file2_class class_call = new lab2_file2_class();
            Console.WriteLine(class_call.Enter_N());
            Console.WriteLine(class_call.Enter_A());
            Console.WriteLine(class_call.CheakN());
            Console.WriteLine(class_call.Formula());
        }

    }
}