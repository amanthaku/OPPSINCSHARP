using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opps
{
    // mutilevel inhertrnce 
    //    class Base {
    //        public void a()
    //    {
    //        Console.WriteLine("aman");
    //    }


    //}
    //    class Derivedclass1 : Base 
    //    {
    //        public void b()
    //        {
    //            Console.WriteLine("ram");
    //        }


    //    }
    //    class Derivedclass2 : Derivedclass1
    //    {
    //        public void c()
    //        {
    //            Console.WriteLine("laximan");
    //        }


    //    }
    //    class Derivedclass3 : Derivedclass2
    //    {
    //        public void d()
    //        {
    //            Console.WriteLine("l");
    //        }


    //    }
    //    internal class program2
    //    {
    //        static void Main(string[] args)
    //        {
    //            Derivedclass2 obj = new Derivedclass2();
    //            obj.a();
    //            obj.b();
    //            obj.c();
    //            Console.ReadLine();
    //        }

    class Base {
            public  void a()
        {
            Console.WriteLine("aman");
        }
    }
     class Derivedclass : Base 
    {
        public void b() {
            Console.WriteLine("ee");
                }
    }

    class Derivedclass2 : Base
    {
        public void b()
        {
            Console.WriteLine("eeeeeee");
        }
    }
  internal class mutilevel
  {
        static void Main(string[] args)
        {
            Derivedclass2 obj = new Derivedclass2();
            obj.a();
            obj.b();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
