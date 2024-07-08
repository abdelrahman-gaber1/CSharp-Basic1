using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB : TypeA
    {
        public TypeB() 
        {
            TypeA typeA = new TypeA();
            typeA.Z =0;
            X = 0;
            Z = 0;

        }
    }
}
