using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opps
{
     // object is class define in c# this-> current object reference k is obj 
     // it alway define in static method 
    static class tt { 
    public static void Hello (this object k)
        {
            Console.WriteLine("aman");
            
        }
    
    
    }
    class Extension
    {
        static void Main(string[] args)
        {
            Extension kgf = new Extension();
            kgf.Hello();
            Console.ReadLine();
        }
    }

}
