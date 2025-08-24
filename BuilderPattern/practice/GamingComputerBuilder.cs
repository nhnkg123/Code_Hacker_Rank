using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BuilderPattern.practice
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();
        public void setCPU()
        {
            this._computer.CPU = "Intel i9";
        }
        public void setRAM()
        {
            this._computer.RAM = "32 GB";
        }
        public void setStorage()
        {
            this._computer.Storage = "1T SSD";
        }
        public void setGPU()
        {
            this._computer.GPU = "NVIDA RTX 3080";
        }
        public Computer GetComputer()
        {
            return this._computer;
        }
    }
}
