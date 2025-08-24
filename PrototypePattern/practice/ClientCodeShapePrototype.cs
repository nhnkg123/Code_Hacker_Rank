using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.PrototypePattern.practice
{
    public class ClientCodeShapePrototype
    {
        public void _clientCodeShapePrototype ()
        {
            //create original objects
            Circle originalCircle = new Circle(10, "Red");
            Rectangle originalRectangle= new Rectangle(20, 30, "Blue");

            // Clone objects
            Circle clonedCircle = originalCircle.clone();
            Rectangle clonedRectangle = originalRectangle.clone();

            //Modify the clone objects
            clonedCircle.Color = "Green";
            clonedRectangle.Width = 40;

            //Print original and cloned objects 
            Console.WriteLine($"Original Circle: {originalCircle}");
            Console.WriteLine($"Cloned Circle: {clonedCircle}");
            Console.WriteLine($"Original Rectangle: {originalRectangle}");
            Console.WriteLine($"Cloned Rectangle: {clonedRectangle}");
        }
    }
}
