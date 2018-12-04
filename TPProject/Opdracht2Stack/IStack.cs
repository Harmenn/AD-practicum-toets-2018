using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTP.Opdracht2Stack
{
    public interface IStack<T>
    {
        void Push(T data);
        T Pop();
        T Top();
        IStack<int> MakeStack1();

        // Opgave 1
        void Expand();
        string ToString();
        int Count();  	
    }

    
}
