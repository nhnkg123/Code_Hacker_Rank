using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.CompositePattern.practice
{
    public class ClientCompositePatternPractice
    {
        public void _ClientCompositePattern()
        {
            //Creating Leaf Objects or you can say child objects
            IComponent hardDisk = new Leaf_Practice("Hard Disk", 2000);
            IComponent ram = new Leaf_Practice("RAM", 3000);
            IComponent cpu = new Leaf_Practice("CPU", 2000);
            IComponent mouse = new Leaf_Practice("Mouse", 2000);
            IComponent keyboard = new Leaf_Practice("Keyboard", 2000);
            //Creating Composite Objects
            Composite_Practice motherBoard = new Composite_Practice("MotherBoard");
            Composite_Practice cabinet = new Composite_Practice("Cabinet");
            Composite_Practice peripherals = new Composite_Practice("Peripherals");
            Composite_Practice computer = new Composite_Practice("Computer");

            //Creating Tree Structure i.e. Adding Child Components inside the Composite Component
            //Adding CPU and RAM in Mother Board
            motherBoard.AddComponent(cpu);
            motherBoard.AddComponent(ram);
            //Adding Mother Board and Hard Disk in Cabinet
            cabinet.AddComponent(motherBoard);
            cabinet.AddComponent(hardDisk);
            //Adding Mouse and Keyboard in peripherals
            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);
            //Adding Cabinet and Peripherals in Computer
            computer.AddComponent(cabinet);
            computer.AddComponent(peripherals);
            //To Display the Price of the Computer i.e. it will display the Price of all components
            Console.WriteLine("Price of Computer Composite Components");
            computer.DisplayPrice();
            //To display the Price of the Keyboard
            Console.WriteLine("\nPrice of Keyboard Child or Leaf Component:");
            keyboard.DisplayPrice();

            //To display the Price of the Cabinet
            Console.WriteLine("\nPrice of Cabinet Composite Component:");
            cabinet.DisplayPrice();
            Console.Read();
        }
    }
}
