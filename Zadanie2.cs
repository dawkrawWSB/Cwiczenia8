namespace Ćwiczenia8
{
    struct Student_Zad2
    {
        public int NumerAlbumu;
        public string Imie;
        public string Nazwisko;
        public Plec Plec;
    }

    enum Plec
    {
        Kobieta,
        Mezczyzna,
        Inne
    }

    struct PrzedmiotDydaktyczny
    {
        public string Nazwa;
        public string Wykladowca;
        public int IloscGodzin;
    }

    struct Nauczyciel
    {
        public string Tytul;
        public string Stanowisko;
        public string Imie;
        public string Nazwisko;
        public Plec Plec;
    }
}
