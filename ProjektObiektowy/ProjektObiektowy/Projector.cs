namespace ProjektObiektowy;

public class Projector : Sprzet
{
    
    public int Cale { get; set; }
    public int Jakosc { get; set; }

    public Projector(string nazwa, int cale, int jakosc) : base(nazwa)
    {
        Cale =  cale;
        Jakosc =  jakosc;
    }
    
}