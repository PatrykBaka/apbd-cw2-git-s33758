namespace ProjektObiektowy;

public abstract class Sprzet
{

    private static int _counter = 1;
    public int Id { get; private set; }
    public string Nazwa { get; set; }
    public Status status { get; set; }

    public Sprzet(string nazwa)
    {
        Id = _counter++;
        Nazwa = nazwa;
        status = Status.Dostepny;
    }
}