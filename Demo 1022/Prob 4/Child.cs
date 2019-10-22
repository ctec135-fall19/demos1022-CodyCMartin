using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_4
{
    class Child : Parent
    {
        // Demonstrating overriding a base class method by a child
        public override void SomeMethod()
        {
            Console.WriteLine("Childs SomeMethod");
        }

        // Demonstrate a child method calling a parent method
        public override void SomeMethod2()
        {
            base.SomeMethod2();
            Console.WriteLine("Child.Method2");
        }
    }
}
