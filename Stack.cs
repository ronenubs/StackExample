using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    interface Stack<E>
    {
        int Size();
        bool IsEmpty();
        E Top();

        void Push(E element);
        E Pop();
    }
}
