namespace ProjektObiektowy;

public class Employee : Osoba
{
    public override int LiczbaWypozyczen => 5;
    
    public override string Typ => "Employee";
    
    public Employee(int id, string imie, string nazwisko) :base(id, imie, nazwisko){}
}