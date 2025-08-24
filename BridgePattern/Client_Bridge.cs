using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BridgePattern
{
    public class Client_Bridge
    {
        public void ClientCode(Abstraction abstraction) 
        {
            Console.WriteLine(abstraction.Operation());
        }
    }
}
