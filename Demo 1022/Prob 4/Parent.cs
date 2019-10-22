using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_4
{
    class Parent
    {
        // child that a method belonging to the base class can be called from a 
        //child instance 

        public void ParentMethod()
        {
            Console.WriteLine("Perent Method");
        }

        // Demonstrating a base class method by a child
        public virtual void SomeMethod()
        {
            Console.WriteLine("Parents SomeMethod");
        }

        // Demonstrate a child method calling a parent method
        public virtual void SomeMethod2()
        {
            Console.WriteLine("Parent.Method2");
        }
    }
}
