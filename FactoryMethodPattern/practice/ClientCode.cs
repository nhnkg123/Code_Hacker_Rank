using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FactoryMethodPattern.practice
{
    public class ClientCodePractice
    {
        public void _clientCode (DocumentCreator documentCreator)
        {
            Console.WriteLine(documentCreator.DoSomeOtherThingWithDocument());
        }
    }
}
