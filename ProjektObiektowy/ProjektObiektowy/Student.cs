namespace ProjektObiektowy;

public class Student : Osoba
{
    public override int LiczbaWypozyczen => 2;
    
    public override string Typ => "Student";
    
    public Student(int id, string imie, string nazwisko) :  base(id, imie, nazwisko){}
    
}