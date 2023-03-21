using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HomeWork_Interface;

public class RAM : IRAM
{
    public void Disable()
    {
        Console.WriteLine("Disable Method");
    }

    public void Eject()
    {
        Console.WriteLine("Eject Method");
    }
}
