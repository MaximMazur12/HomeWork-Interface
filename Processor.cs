using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HomeWork_Interface;
    public class Processor : IProcessor
    {
        public void Disable()
        {
            Console.WriteLine("turn off or power down the processor");
        }

        public void Unplug()
        {
            Console.WriteLine("unplug the processor");
        }
    }

