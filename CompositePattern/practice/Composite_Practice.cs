using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.CompositePattern.practice
{
    public class Composite_Practice : IComponent
    {
        public string Name { get; set; }
        List<IComponent> components = new List<IComponent>();
        public Composite_Practice(string name)
        {
            this.Name = name;
        }
        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }
        public void DisplayPrice()
        {
            foreach(IComponent component in components)
            {
                component.DisplayPrice();
            }
        }
    }
}
