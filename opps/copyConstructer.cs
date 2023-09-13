using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace opps
{

    class kgf 
    {
        int a; int b;
              public kgf(int a , int b) {

            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    public kgf (kgf p)
        {
            a = p.a;
            b = p.a;                    
            Console.WriteLine(a);
                       Console.WriteLine(b);
           
        }
    
    
    }

    internal class copyConstructer 
    {
        static void Main(string[] args)
        {

            //Derivedclass3 obj = new Derivedclass3();
            //obj.a();
            //obj.b();
            //obj.c();        
            //obj.d();
           kgf kk = new kgf(1, 2);
            kgf kk1 = new kgf(kk);
            Console.ReadLine();
        }
    }
}
