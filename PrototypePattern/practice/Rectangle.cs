using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.PrototypePattern.practice
{
    public class Rectangle: IPrototypeShape<Rectangle>
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string Color { get; set; }
        public Rectangle(int width, int height, string color)
        {
            this.Width= width;
            this.Height= height;
            this.Color = color;
        }
        public Rectangle(Rectangle source)
        {
            this.Width= source.Width;
            this.Height = source.Height;
            this.Color = source.Color;
        }
        public Rectangle clone()
        {
            return new Rectangle(this);
        }
        public override string ToString()
        {
            return $"Circle [Radius={this.Width}, Height={this.Height}, Color={this.Color}]";
        }
    }
}
