using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            diffroles diff=new diffroles("vignesh",21,"5-2-17 khammam");//this to display values 
            Console.WriteLine($"Name:{diff.name}");//obj property to display
            Console.WriteLine($"Age:{diff.age}");
            Console.WriteLine($"Address:{diff.address}");

            Console.WriteLine("Roles");//displays roles in the output
            diff.drive();
            diff.study();
            diff.works();

        }
    }
}
