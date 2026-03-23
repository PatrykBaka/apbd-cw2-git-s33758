namespace ProjektObiektowy;

public class Wypozyczenie
{
    
    public Sprzet _Sprzet { get; set; }
    public Osoba _Osoba { get; set; }
    public DateTime DataWypozyczenia { get; set; }
    public DateTime DataZwrotu { get; set; }
    public DateTime? DataFaktycznegoZwrotu { get; set; }
    
    public decimal Kara { get; set; }

    public Wypozyczenie(Sprzet sprzet, Osoba osoba, DateTime dataWypozyczenia, DateTime dataZwrotu, DateTime? dataFaktycznegoZwrotu)
    {
        _Sprzet = sprzet;
        _Osoba = osoba;
        DataWypozyczenia = dataWypozyczenia;
        DataZwrotu = dataZwrotu;
        DataFaktycznegoZwrotu = dataFaktycznegoZwrotu;
        Kara = 0;
    }
}