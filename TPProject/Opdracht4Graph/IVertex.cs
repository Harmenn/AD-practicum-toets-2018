using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTP
{
    public interface IVertex
    {
        void Reset();
        string ToString();

        // Opgave 3
        int Outgoing();
    }
}
