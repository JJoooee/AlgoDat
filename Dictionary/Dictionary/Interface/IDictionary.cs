using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    interface IDictionary
    {
        int Search(int wert);
        bool delete(int wert);
        bool insert(int wert);
        void print();
    }
}
