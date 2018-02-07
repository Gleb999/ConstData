using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyClass
    {
        public const int B = 2000;
        public static readonly int A;

        static MyClass()
        {
            A = 100;
        }
    }
}
