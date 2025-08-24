using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.PrototypePattern
{
    public class ClientCodePrototype
    {
        public void _ClientCodePrototype ()
        {
            //set prop for conncretePrototype 1
            ConcretePrototype ConcretePrototype1 = new ConcretePrototype("this is field of ConcretePrototype1");
            //print previous concretePrototype
            Console.WriteLine($"ConcretePrototype before clone: {ConcretePrototype1.getField()}");

            ConcretePrototype ConcretePrototype2 = new ConcretePrototype(ConcretePrototype1);
            ConcretePrototype2.setField($"this is feild of ConcretePrototype2");
            Console.WriteLine($"ConcretePrototype before clone and change feild: {ConcretePrototype2.getField()}");

            Console.WriteLine($"printing again ConcreteProduct1 to ensure it not change: {ConcretePrototype1.getField()}");


            // thinking how to move property of ConcretePrototy up to IPrototype ==> to use this property by just declare ConcretePrototype in IPrototype type  
        }
    }
}
