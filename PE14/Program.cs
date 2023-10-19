using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PE14
{
    internal class Program
    {

        public abstract class MyClass
        {
            private string privateMember;  // Private member field

            public string Property
            {
                get { return privateMember; }
                set { privateMember = value; }
            }
        }

        public interface Interface
        {
            void Method();
        }

        public class Class1 : Interface
        {
            public void Method()
            {
                Console.WriteLine("This is class 1");
            }
        }

        public class Class2 : Interface
        {
            public void Method()
            {
                Console.WriteLine("This is class 2");
            }
        }

        public static void MyMethod(object obj)
        {
            if (obj is Interface intObj)
            {
                intObj.Method();
            }
            else
            {
                Console.WriteLine("invalid object type");
            }
        }

        static void Main(string[] args)
        {
            Interface one = new Class1();
            Interface two = new Class2();

            MyMethod(one);
            MyMethod(two);

        }
    }
}
