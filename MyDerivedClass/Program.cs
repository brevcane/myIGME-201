using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDerivedClass
{
    internal class Program
    {
        public class MyClass
        {
            private string myString;

            public MyClass(string input)
            {
                myString = input;
            }

            public string MyString
            {
                set
                {
                    myString = value;
                }
            }


            public virtual string GetString()
            {
                return myString;
            }
        }

        public class MyDerivedClass : MyClass
        {
            public MyDerivedClass(string input) : base(input) { }

            public override string GetString()
            {
                string derivedString = base.GetString();
                return derivedString + " (output from the derived class)";
            }

        }

        static void Main(string[] args)
        {
            MyDerivedClass derivedClass = new MyDerivedClass("MyClass string");
            Console.WriteLine(derivedClass.GetString());
        }
    }
}
