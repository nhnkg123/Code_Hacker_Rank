using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AbstractFactoryPattern
{
    public class ConcreteProductB2: IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B2";
        }
        public string AnotherUsefulFunctionB(IAbstractProductA collaborate)
        {
            string result = collaborate.UsefulFunctionA();
            return $"The result of the product B collaborating with ({result})";
        }
    }
}
