// Facade pattern
using System.ComponentModel;

ComputerFacade facade = new();
facade.Start();

interface IDevice
{
    string Vendor { get; set; }
    string Model { get; set; }
    void Start();
}

class CPU: IDevice
{
    public string Vendor {  get; set; }
    public string Model { get; set; }
    public void Start()
    {
        Console.WriteLine("CPU start");
    }
}

class RAM: IDevice
{
    public string Vendor { get; set; }
    public string Model { get; set; }
    public void Start()
    {
        Console.WriteLine("RAM start");
    }
}

class GPU : IDevice
{
    public string Vendor { get; set; }
    public string Model { get; set; }
    public void Start()
    {
        Console.WriteLine("GPU start");
    }
}
class Motherboard : IDevice
{
    public string Vendor { get; set; }
    public string Model { get; set; }
    public void Start()
    {
        Console.WriteLine("Motherboard start");
    }
}

class PowerSupply : IDevice
{
    public string Vendor { get; set; }
    public string Model { get; set; }
    public void Start()
    {
        Console.WriteLine("PowerSupply start");
    }
}

class Case : IDevice, INotifyPropertyChanging
{
    private List<IDevice> Devices { get; set; } = new();
    public string Vendor { get; set; }
    public string Model { get; set; }
    public void Start()
    {
        Devices.ForEach(d => d.Start());
        Console.WriteLine("PC start");
    }

    public void AddDevice(IDevice device) => Devices.Add(device);
}

class ComputerFacade
{
    private Motherboard Motherboard = new();
    private RAM RAM = new();
    private CPU CPU = new();
    private PowerSupply PowerSupply = new();
    private GPU GPU = new();
    private Case Case = new();

    public void Start()
    {
        Case.AddDevice(Motherboard);
        Case.AddDevice(PowerSupply);
        Case.AddDevice(CPU);
        Case.AddDevice(GPU);
        Case.AddDevice(RAM);

        Case.Start();
    }
}