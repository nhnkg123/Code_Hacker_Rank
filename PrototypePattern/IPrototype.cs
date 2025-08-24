using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.PrototypePattern
{
    public interface IPrototypeShape
    {
        IPrototypeShape clone();
    }
}
