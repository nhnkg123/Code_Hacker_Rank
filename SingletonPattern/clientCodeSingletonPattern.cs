using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.SingletonPattern
{
    public class clientCodeSingletonPattern
    {
        public void _clientCodeSingletonPattern()
        {
            Singleton s1 = Singleton.getInstance();
            Singleton s2 = Singleton.getInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            } else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
