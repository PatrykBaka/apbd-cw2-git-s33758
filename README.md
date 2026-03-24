# apbd-cw2-git-s33758

Opis kklas i metod zawartych w nich

1. Klasa Sprzet to klasa abstrakcyjne z której dziedziczą klasy Laptop, Camera i Projector, zanjduję się w niej kilka zmiennych(counter który daje unikalne id tak aby się nie powtarzało) oraz konstruktor. Klasy dziedziczące mają unikalne zmienne i konstruktor.
2. Klasa Osoba to klasa abstrakcyjna, z której dziedziczą klasy Student i Employee. W klasie znajdują się zmienne oraz konstruktor, posiada również 2 abstrakcyjne właściwości. Klasy dziedziczące mają nadpisane te właściwości po to aby na przykład określić limit wypożyczeń czy określić czy Typ osoby.
3. Enum, który posiada status naszych sprzętów, z tego enuma korzysta Klasa Sprzet i klasy dziedzidziczące.
4. Klasa Wypozyczenie, jest to klasa wykorzystująca obiekty klas Sprzet i Osoba, posiada również zmienne typy DateTime oraz typ DateTime? który może być null, dlatego że wykorzystuje się to do tego że jeśli osoba jeszcze nie zwróciła sprzętu to nie ma przypisanej daty czyli null oraz kare typu decimal. Klasa ta tworzy obiekt kto, co, od kiedy do kiedy i czy ma kare za wypożyczenie.
5.Klasa Serwis to taki mózg, tutaj są przechowywane listy wszystkich obiektów, wykonywane są metody, 5 metod:
5a. Metoda  dodajOsoba to po prostu metoda, która dodaje obiekt Osoba do listy obiektów Osoba
5b. Metoda dodajSprzet to po prostu metoda, która dodaje obiekt Sprzet do listy obiektów Sprzet
5c. Metoda Wypozycz, trzeba wpisać id sprzetu i osoby, następnie znajduje w liście sprzet i osobe o podanym id. Sprawdza czy taki sprzet i osoba istnieje, czy sprzet jest napewno dostepny oraz czy dana osoba nie przekroczyła limitu. Następnie, jeśli wszytsko jest spełnione to zmienia status sprzętu na zajęty i dodaje do listy obiektów Wypozyczenie obiekt Wypozyczenie, podając aktualne daty i ustawiając datę do zwrotu na 14 dni do przodu.
5d. Metoda Zwrot, trzeba wpisać w niej id sprzetu, następnie znajduje id sprzetu w liscie wypozyczenia i przypisuje do zmiennej. Sprawdza czy napewno w historii istnieje takie wypożyczenie sprzętu i czy nie został on już zwrócony. Jeśli to spełnia to status zmieniamy na dostępny, dodajemy do DatyFaktycznegiZwrotu aktualną date, następnie sprawdzamy czy data jest większa od datyZwrotu(ustalonej daty do której trzeba było zwrócić sprzęt), jeśli data jest mniejsza nie ma kary jest jest większa to tworzymy zmienna w której liczymy dni i następnie liczmy kare(1 zl za dzień).
5e. Metoda Podsumowanie to metoda, która pokazuję nam historię wypożyczeń, czyli sprawdzamy najpierw czy nie jest ona pusta, używamy for each do przelecenia po całej liście i wypisania wszystkich danych kto, co, od kiedy do kiedy i czy posiada kare. Tworzymy również zmienną, która jest potrzebna do tego, aby napisać co konkretnie jest w DataFaktycznegoZwrotu, ponieważ może tam być null.
6. Klasa Program.cs to nasz main, w którym testujemy czy wszystko działa, tworzymy obiekty, dodajemy na liste i testujemy metody czy napewno działają, czy w przypadku np. przekroczenia przez osobę limitu wypiszą odpowiedni komunikat

To wszystko:)
