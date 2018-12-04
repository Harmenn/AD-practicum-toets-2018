using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTP.Opdracht3Tree
{

    public interface IBinaryTree<T>
    {
        BinaryNode<T> GetRoot();
        int Size();
        int Height();
        void PrintPreOrder();
        void PrintInOrder();
        void PrintPostOrder();
        void MakeEmpty();
        bool IsEmpty();
        void Merge(T rootItem, BinaryTree<T> t1, BinaryTree<T> t2); 

        // Opgave 2
        string ToPreorderString();
        T Decode(string signals);
        string Encode(T elem);
    }
}
