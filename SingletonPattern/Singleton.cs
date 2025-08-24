using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.SingletonPattern
{
    public sealed class Singleton
    {
        private Singleton() { }
        private static Singleton _instance;
        public static Singleton getInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        public void SomeBusinessLogic()
        {
            //....
        }
    }
}
