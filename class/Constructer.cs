using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace inheritence 
{
    class student
    {
        public int i; string name; int age;
        
      public  student()
        {
            i = 0;
            name = "aman";
            age = 0;
           Console.WriteLine(i);
            Console.WriteLine(name );
            //Console.WriteLine(age);
        }
    }
     class Constructer
    {
        static void Main(string[] args)
        {
            //student obj = new inheritence.student();
            student obj = new inheritence.student();
            student obj1 = new inheritence.student();

            Console.ReadLine();
        }

    }



}
