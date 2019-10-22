using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region an array of the Base class type created with member of each class

            Parent[] myArray = new Parent[3];
            myArray[0] = new Parent();
            myArray[1] = new Child();
            myArray[2] = new Grandchild();

            // Show that a method belonging to the base class is called from the child instances
            //create parent method in parent methos and iterate through array
            //calling this method to demonstrate that all child classes 
            //have access to it

            //foreach(Parent element in myArray)
            //{
            //    Console.WriteLine("{0}: ", element.GetType());
            //    element.ParentMethod();

            //}
            //Console.WriteLine();


            #endregion

            #region demonstrates overriding a base method by child

            foreach (Parent element in myArray)
            {
                Console.WriteLine("{0}: ", element.GetType());
                element.SomeMethod();

            }
            Console.WriteLine();





            #endregion

            #region demonstrate a child method calling a parent method
            //Create a virtual method in parent
            //override in a child and call the parent as part of the implementation

            foreach (Parent element in myArray)
            {
                Console.WriteLine("{0}: ", element.GetType());
                element.SomeMethod2();
                Console.WriteLine();

            }
            Console.WriteLine();




            #endregion


            #region demonstrate use of as keyword

            // repeat calls to SomeMethod
            foreach (object element in myArray)
            {
                Parent p = element as Parent;
                Console.WriteLine("{0}: ", element.GetType());
                p.SomeMethod();

            }
            Console.WriteLine();

            #endregion

            #region Is keyword demo

            Console.WriteLine("demo use of is keyword");
            foreach(Parent elememt in myArray)
            {
                if (elememt is Grandchild) Console.WriteLine("Grandchild");
                else if (elememt is Child) Console.WriteLine("Child");
                else if (elememt is Parent) Console.WriteLine("Parent");

            }
            Console.WriteLine();



            #endregion


            #region switch
            Console.WriteLine("Demo switch");
            foreach(Parent element in myArray)
            {
                switch (element)
                {
                    case Grandchild gc:
                        Console.WriteLine("Grandchild");
                        break;
                    case Child c:
                        Console.WriteLine("Child");
                        break;
                    case Parent p:
                        Console.WriteLine("Parent");
                        break;
                    default:
                        Console.WriteLine("default");
                        break;

                }
            }
            Console.WriteLine();
            #endregion


            #region Create object of object type
            object obj = new Parent();
            ((Parent)obj).ParentMethod();

            Parent p2 = new Grandchild();
            ((Grandchild)p2).SpecializedMethod();


            #endregion

        }
    }
}
