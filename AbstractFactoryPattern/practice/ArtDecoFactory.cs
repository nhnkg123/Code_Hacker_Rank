using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AbstractFactoryPattern.practice
{
    public class ArtDecoFactory: IAbstractFactory
    {
        public IAbstractChair CreateChair ()
        {
            return new ArtDecoChair ();
        }
        public IAbstractCoffeeTable CreateCoffeeTable()
        {
            return new ArtDecoCoffeeTable();
        }
        public IAbstractSofa CreateSofa()
        {
            return new ArtDecoSofa();
        }
    }
}
