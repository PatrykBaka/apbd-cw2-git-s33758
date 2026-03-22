namespace ProjektObiektowy;

public class Camera : Sprzet
{
    
    public int LiczbaKlatek { get; set; }
    public string Rozdzielczosc  { get; set; }

    public Camera(string nazwa, int liczbaKlatek, string rozdzielczosc) : base(nazwa)
    {
        LiczbaKlatek = liczbaKlatek;
        Rozdzielczosc = rozdzielczosc;
    }
    
}