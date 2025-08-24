using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BuilderPattern.practice
{
    public class OfficeComputerBuilder: IComputerBuilder
    {
        private Computer _computer = new Computer();
        public void setCPU()
        {
            this._computer.CPU = "Intel i5";
        }
        public void setRAM()
        {
            this._computer.RAM = "16 GB";
        }
        public void setStorage()
        {
            this._computer.Storage = "512GB SSD";
        }
        public void setGPU()
        {
            this._computer.GPU = "Integrated Graphics";
        }
        public Computer GetComputer()
        {
            return this._computer;
        }
    }
}
