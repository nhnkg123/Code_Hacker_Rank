using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BuilderPattern.practice
{
    public interface IComputerBuilder
    {
        void setCPU();
        void setRAM();
        void setStorage();
        void setGPU();
        Computer GetComputer();
    }
}
