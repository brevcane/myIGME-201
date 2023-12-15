using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam_Q2
{
    internal class Program
    {
        class MyQueue
        {
            private List<int> myQueue = new List<int>();

            public void Enqueue(int n)
            {
                myQueue.Add(n);
            }

            public int Dequeue()
            {
                int dequeued = myQueue[0];
                myQueue.RemoveAt(0);
                return dequeued;
            }

            public int Peek()
            {
                return myQueue[0];
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
