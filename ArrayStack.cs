using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    public class ArrayStack<E> : Stack<E>
    {
        public const int CAPACITY = 1000;
        private E[] data;
        private int t = -1;
        private int capacity;

        public ArrayStack(int capacity)
        {
            this.capacity = capacity;
            data = new E[capacity];
        }

        public ArrayStack():this(CAPACITY)
        {
            
        }

        public bool IsEmpty()
        {
            return t == -1;
        }

        public E Pop()
        {
            if(IsEmpty())
            {
                return default;
            }

            E temp = data[t];
            data[t] = default;
            t--;
            return temp;
        }

        public void Push(E element)
        {
            if(capacity == (t + 1))
            {
                throw new StackOverflowException("Stack overflow!");
            }
            data[++t] = element;
        }

        public int Size()
        {
            return t + 1;
        }

        public E Top()
        {
            if(IsEmpty())
            {
                return default;
            }
            return data[t];
        }
    }
}
