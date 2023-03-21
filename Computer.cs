using HomeWork_Interface;

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