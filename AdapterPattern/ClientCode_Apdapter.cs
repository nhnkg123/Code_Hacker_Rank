using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AdapterPattern
{
    public class ClientCode_Apdapter
    {
        public void clientCodeAdapter()
        {
            Adaptee_ClientCanNotUse adaptee = new Adaptee_ClientCanNotUse();
            ITarget_IAdapter target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}
