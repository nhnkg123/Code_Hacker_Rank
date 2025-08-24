using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AbstractFactoryPattern
{
    public class ConcreteProductB1: IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B1";
        }
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            string resullt = collaborator.UsefulFunctionA();
            return $"The result of the product B1 collaborating with ({resullt}) ";
        }
    }
}
