using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IDevice
    {
        void Disable();
    }

    public interface IRAM : IDevice
    {
        void Eject();
    }

    public interface IHardDrive : IDevice
    {
        void Remove();
    }

    public interface IProcessor : IDevice
    {
        void Unplug();
    }
}
