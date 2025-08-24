using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.PrototypePattern.practice
{
    public class Circle: IPrototypeShape<Circle>
    {
        public int Radius { get; set; }
        public string Color {  get; set; }  
        public Circle(int radius, string color) { 
            this.Radius = radius;
            this.Color = color;
        }
        public Circle(Circle source)
        {
            this.Radius = source.Radius;
            this.Color = source.Color;
        }
        public Circle clone()
        {
            return new Circle(this);
        }
        public override string ToString() {
            return $"Circle [Radius={this.Radius}, Color={this.Color}]";
        }
    }
}
