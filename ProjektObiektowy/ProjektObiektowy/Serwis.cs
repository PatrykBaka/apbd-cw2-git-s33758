namespace ProjektObiektowy;

public class Serwis
{

    private List<Sprzet> ListaSprzetu = new List<Sprzet>();
    private List<Osoba> ListaOsob = new List<Osoba>();
    private List<Wypozyczenie> Listawypozyczen = new List<Wypozyczenie>();

    public void DodajOsoba(Osoba osoba)
    {
        ListaOsob.Add(osoba);
    }

    public void DodajSprzet(Sprzet sprzet)
    {
        ListaSprzetu.Add(sprzet);
    }

    public void Wypozycz(int IdSprzetu, int IdOsoba)
    {

        var sp = ListaSprzetu.FirstOrDefault(x => x.Id == IdSprzetu);
        var os = ListaOsob.FirstOrDefault(x => x.Id == IdOsoba);

        if (sp == null || os == null)
        {
            Console.WriteLine("Nie można znależć takiej osoby lub sprzętu!!!");
            return;
        }

        if (sp.status != Status.Dostepny)
        {
            Console.WriteLine("Sprzęt, który chcesz wypożyczyć jest niedostępny!!!");
            return;
        }
        
        int _counter = Listawypozyczen.Count(x => x._Osoba.Id == IdOsoba && x.DataFaktycznegoZwrotu == null);

        if (_counter > os.LiczbaWypozyczen)
        {
            Console.WriteLine("Osoba nie może wypożyczyć więcej sprzętu, ze względu na swój limit!!!");
            return;
        }
        
        sp.status = Status.Zajety;

        var NoweWypozyczenie = new Wypozyczenie(sp ,os, DateTime.Now, DateTime.Now.AddDays(14), null);
        Listawypozyczen.Add(NoweWypozyczenie);
        Console.WriteLine($"Wypożyczono {sp.Nazwa} Osobie {os.Nazwisko}");
    }

    public void Zwrot(int IdSprzetu)
    {
        var wyp = Listawypozyczen.FirstOrDefault(x => x._Sprzet.Id == IdSprzetu && x.DataFaktycznegoZwrotu == null);
        
        if(wyp == null)
        {
            Console.WriteLine("Ten sprzęt nie jest wypożyczony!!!");
            return;
        }

        wyp.DataFaktycznegoZwrotu =  DateTime.Now;
        
        wyp._Sprzet.status = Status.Dostepny;

        if (wyp.DataFaktycznegoZwrotu > wyp.DataZwrotu)
        {
            TimeSpan opoznienie = wyp.DataFaktycznegoZwrotu.Value - wyp.DataZwrotu;
            
            int dni = opoznienie.Days;

            if (dni > 0)
            {
                wyp.Kara = dni * 1.00m;
                Console.WriteLine($"Kara za opóźnienie {wyp.Kara} zł.");
            }
            else
            {
                Console.WriteLine("Brak opóźnienia.");
            }
        }
    }

    public void Podsumowanie()
    {
        if (ListaSprzetu.Count == 0)
        {
            Console.WriteLine("Lista wypożyczeń nie posiada żadnej historii!!!");
            return;
        }

        foreach (var val in Listawypozyczen)
        {
            string StatusWypożyczenia = val.DataFaktycznegoZwrotu.HasValue ? $"Zwrócono {val.DataFaktycznegoZwrotu:dd/MM/yyyy}" : "Dalej nie zwrócono";
            
            Console.WriteLine($"Osoba: {val._Osoba.Nazwisko}, " +
                              $"Sprzęt: {val._Sprzet.Nazwa}, " +
                              $"Data wypożyczenia: {val.DataWypozyczenia:dd/MM/yyyy}, " +
                              $"Termin zwrotu: {val.DataZwrotu:dd/MM/yyyy}, " +
                              $"Status: {StatusWypożyczenia}, " +
                              $"Kara: {val.Kara}, zł.");
        }
    }

}