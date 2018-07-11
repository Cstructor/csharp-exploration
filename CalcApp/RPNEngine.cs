using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{
    class RPNEngine
    {
        private Stack stack = new Stack(); // create an object of class Stack

        public void Process(string str)
        {
            switch (str)
            {
                case "+": // when user wants to add the last two numbers
                    {
                        int v1 = stack.Pop();
                        int v2 = stack.Pop();

                        stack.Push(v1 + v2);
                        break; // do not forget to break
                    }
                case "-": // when user wants to subtract the last two numbers
                    {
                        int v2 = stack.Pop();
                        int v1 = stack.Pop();

                        stack.Push(v1 - v2);
                        break;
                    }
                default: // when user enters a number
                    {
                        int v = int.Parse(str);
                        stack.Push(v);

                        break;
                    }
            }
        }

        public int Result
        {
            get
            {
                // do the code to return the last value
                // return the top value (or the result)
                return stack.Top;
            }
        }
    }
}
