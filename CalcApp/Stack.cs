using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{
    class Stack
    {
        private int[] stack = new int[10];
        private int sp = 0;

        public void Push(int v)
        {
            stack[sp++] = v;
        }

        public int Top
        {
            get
            {
                return stack[sp - 1];
            }
        }

        public bool IsEmpty
        {
            get
            {
                return sp == 0;
            }
        }

        public int Pop()
        {
            return stack[--sp];
        }
    }
}
