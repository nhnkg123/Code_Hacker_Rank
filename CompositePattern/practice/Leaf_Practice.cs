using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.CompositePattern.practice
{
    public class Leaf_Practice: IComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public Leaf_Practice(string name, int price)
        {
            this.Price = price;
            this.Name = name;
        }
        public void DisplayPrice()
        {
            Console.WriteLine($"\tComponent Name: {Name} and Price: {Price}");
        }
    }
}
