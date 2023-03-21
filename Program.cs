using Interface;

IRAM ram1 = new RAM();
IRAM ram2 = new RAM();
IRAM ram3 = new RAM();

IHardDrive Kingston = new HardDrive();
IHardDrive Samsung = new HardDrive();

IProcessor AMD = new Processor();
IProcessor INTEL = new Processor();

Computer MacBook = new Computer();
MacBook.AddDevice(ram1);
MacBook.AddDevice(Kingston);
MacBook.AddDevice(AMD);

Computer HP = new Computer();
HP.AddDevice(ram1);
HP.AddDevice(ram2);
HP.AddDevice(Kingston);
HP.AddDevice(AMD);

Computer Dell = new Computer();
Dell.AddDevice(ram1);
Dell.AddDevice(ram2);
Dell.AddDevice(ram3);
Dell.AddDevice(Samsung);
Dell.AddDevice(INTEL);


public class Computer : IDisposable
{
    private List<IRAM> rams = new List<IRAM>();
    private List<IHardDrive> hardDrives = new List<IHardDrive>();
    private IProcessor processor;

    public void AddDevice(IDevice device)
    {
        if (device is IRAM)
        {
            rams.Add((IRAM)device);
        }
        else if (device is IHardDrive)
        {
            hardDrives.Add((IHardDrive)device);
        }
        else if (device is IProcessor)
        {
            processor = (IProcessor)device;
        }
    }

    public void Dispose()
    {
        foreach (IRAM ram in rams)
        {
            ram.Disable();
        }

        foreach (IHardDrive hardDrive in hardDrives)
        {
            hardDrive.Disable();
        }

        if (processor != null)
        {
            processor.Disable();
        }
    }
}

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