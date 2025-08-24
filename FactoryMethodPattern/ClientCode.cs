using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FactoryMethodPattern
{
    public class ClientCode
    {
        public void _ClientCode(Creator creator)
        {
            Console.WriteLine("Client: Im not aware of creator's class, " + "but it still work.\n" + creator.SomeOperation());
        }
    }
}
   
