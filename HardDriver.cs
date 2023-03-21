using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HomeWork_Interface;

public class HardDrive : IHardDrive
{
    public void Disable()
    {
        Console.WriteLine("turn off or power down the hard drive");
    }

    public void Remove()
    {
        Console.WriteLine("remove the hard drive");
    }
}
