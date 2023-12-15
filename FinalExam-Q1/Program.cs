using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam_Q1
{
    internal class Program
    {
        class MyStack
        {
            private List<int> myStack = new List<int>();

            public void Push(int n)
            {
                myStack.Add(n);
            }

            public int Pop()
            {
                int removed = myStack[myStack.Count - 1];
                myStack.RemoveAt(myStack.Count - 1);
                return removed;
            }

            public int Peek()
            {
                return myStack[myStack.Count - 1];
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
