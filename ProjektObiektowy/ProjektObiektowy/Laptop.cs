namespace ProjektObiektowy;

public class Laptop : Sprzet
{
    public string Processor { get; set; }
    public string Version { get; set; }

    public Laptop(string nazwa, string processor, string version) : base(nazwa)
    {
        Processor = processor;
        Version = version;
    }
}