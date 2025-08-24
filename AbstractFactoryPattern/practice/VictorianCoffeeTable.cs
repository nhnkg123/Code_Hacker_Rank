using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AbstractFactoryPattern.practice
{
    public class VictorianCoffeeTable: IAbstractCoffeeTable
    {
        public string Have4Legs()
        {
            return "A Victorian CoffeeTable have 4 legs";
        }
        public string SitOn()
        {
            return "Absolutelly we can sit on a Victorian CoffeeTable";
        }
    }
}
