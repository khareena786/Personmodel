using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
     public class persons 
    {
        public string name {  get; set; } // property to store the name 
        public int age { get; set; }// property to store the age
        public string address { get; set; }// property to store the address

    }
    public interface Idriver //in interface need to use I to work as interface
    {
        void drive();
    }
    public interface Istudent
    {
        void study(); //here void implements the interface
    }
    public interface  Iemployee
    {
        void works();
    }
}
