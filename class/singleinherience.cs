using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    // base class
    public class Aman
    {


        public int a;
        public void ss()
        {
            Console.WriteLine("ramji");
        }

    }
    // derived class
    class ram : Aman
    {

        public int student()
        {
            a = 3; return a;
        }

    }
    class singleinherience
    {
        static void Main(string[] args)
        {
            ram obj = new ram();

            obj.student();
            obj.ss();
            
            Console.WriteLine(obj.student());

            Console.ReadLine();
        }
    }
}

