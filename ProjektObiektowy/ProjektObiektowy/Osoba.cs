namespace ProjektObiektowy;

public abstract class Osoba
{
    
    public int Id { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    
    public abstract int LiczbaWypozyczen { get; }
    
    public abstract string Typ { get; }

    protected Osoba(int id, string imie, string nazwisko)
    {
        Id = id;
        Imie = imie;
        Nazwisko = nazwisko;
    }
}