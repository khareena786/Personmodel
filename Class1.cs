using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    public class diffroles:persons,Idriver,Istudent,Iemployee//diff roles extends from the persons 
    {
        public diffroles(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public void drive()
        {
            Console.WriteLine($"{name} is driving a car");//the string to display
        }
        public void study()
        {
            Console.WriteLine($"{name} studying intermediate");
        }
        public void works()
        {
            Console.WriteLine($"{name} works in infinite");
        }
    }
}
