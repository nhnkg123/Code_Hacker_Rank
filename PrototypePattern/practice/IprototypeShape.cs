using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.PrototypePattern.practice
{
    public interface IPrototypeShape<T>
    {
        T clone();
    }
}
