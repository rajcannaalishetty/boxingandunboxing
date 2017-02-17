using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxingandunboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter the variable");
            //string x = (Console.ReadLine());

            int x = 479;
            int n = (int) GetBox(x);
            
            Console.WriteLine("the unboxed variable is {0}",n);
            Console.ReadLine();
            

        }

        public static object GetBox(object obj)
        {

            Console.WriteLine("the boxed variable is {0}",obj);
            return obj;
            //Console.ReadLine();


        }

    }
}
