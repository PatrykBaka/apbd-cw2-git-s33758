using ProjektObiektowy;

var serwis = new Serwis();

var l1 = new Laptop("Laptop 1", "intel", "pro");
var l2  = new Laptop("Laptop 2", "amd", "basic");

var pr1 = new Projector("Projektor 1", 980, 1080);

var c1 = new Camera("Camera 1", 60, "16:9");

var s1 = new Student(33, "Marcin" , "Kwiatek");
var e1 = new Employee(12, "Patryk", "Las");

serwis.DodajOsoba(s1);
serwis.DodajOsoba(e1);
serwis.DodajSprzet(l1);
serwis.DodajSprzet(l2);
serwis.DodajSprzet(pr1);
serwis.DodajSprzet(c1);

serwis.Wypozycz(1 , 33);
serwis.Wypozycz(2, 33);
serwis.Wypozycz(3,12);
serwis.Wypozycz(4, 12);

serwis.Wypozycz(3, 33);
serwis.Wypozycz(1, 12);

Console.WriteLine("Przed zwrotem");
serwis.Podsumowanie();

serwis.Zwrot(2);
serwis.Zwrot(3);

Console.WriteLine("Po zwrocie");
serwis.Podsumowanie();