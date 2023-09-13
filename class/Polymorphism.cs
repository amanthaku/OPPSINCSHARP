using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    class Calculator { 
         
        public void Calc() {
            int a = 2; int b =3;
            int c=a + b;
            Console.WriteLine(c);
        }
        public void Calc2(string a, int b)
        {
            
            Console.WriteLine(a + b);
        }
        public void Calc3(string a, int b)
        {
            
            Console.WriteLine(a+b);
        }
        public void Calc4(int a, int b)
        {

            Console.WriteLine(a + b);
        }
        public void Calc5(int a, int b)
        {

            Console.WriteLine(a + b);
        }
    }

    internal class Polymorphism
{
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Calc();
            calculator.Calc2("aman",3);
            calculator.Calc3("aman", 3);
        }

}

}
