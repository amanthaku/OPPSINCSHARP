using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opps
{


    // PROPERTIES IN C#

    class Person
    {
        public string Name;
        public int Age;

        public void setName(string Name) // setter method
        {
            if (string.IsNullOrEmpty(Name) == true)
            {
                Console.WriteLine("Name is Must..");
            }
            else
            {
                this.Name = Name;
            }

        }

        public void getName() // getter method
        {
            if (string.IsNullOrEmpty(this.Name) == true)
            {

            }
            else
            {
                Console.WriteLine("Your name is: " + this.Name);
            }


        }

        public void setAge(int Age) // setter method
        {
            if (Age > 0)
            {
                this.Age = Age;
            }
            else
            {
                Console.WriteLine("Age cannot be zero or negative");
            }

        }

        public void getAge() // getter method
        {
            if (Age > 0)
            {
                Console.WriteLine("Your age is: " + this.Age);
            }
            else
            {

            }
        }
    }

    class Encapsolation
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.setName("");
            p1.setAge(-27);

            p1.getName();
            p1.getAge();
            Console.ReadLine();


        }
    }
}