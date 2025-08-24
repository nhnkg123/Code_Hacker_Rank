using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BuilderPattern.practice
{
    public class ComputerDirector
    {
        private IComputerBuilder _computerBuilder;
        public void setBuilder(IComputerBuilder computerBuilder)
        {
            _computerBuilder = computerBuilder;
        }
        public Computer BuildComputer()
        {
            this._computerBuilder.setCPU();
            this._computerBuilder.setRAM();
            this._computerBuilder.setStorage();
            this._computerBuilder.setGPU();
            return this._computerBuilder.GetComputer();
        }
    }
}
