
namespace Ćwiczenia8
{
    internal class Zadanie3
    {
        public Zadanie3()
        {
            Przedmiot[] przedmioty = new Przedmiot[4];
            Przedmiot.Wypelnij(ref przedmioty[0], 1.0F, 5, "Zbroja mistrza", KlasaRzadkosci.Rzadki, TypPrzedmiotu.Zbroja);
            Przedmiot.Wypelnij(ref przedmioty[1], 0.5F, 3, "Mikstura leczenia", KlasaRzadkosci.Powszechny, TypPrzedmiotu.Uzywalny);
            Przedmiot.Wypelnij(ref przedmioty[2], 0.2F, 20, "Narzedzie do skradania", KlasaRzadkosci.Unikalny, TypPrzedmiotu.Narzedzie);
            Przedmiot.Wypelnij(ref przedmioty[3], 3.0F, 11, "Buty", KlasaRzadkosci.Epicki, TypPrzedmiotu.Buty);

            Przedmiot wylosowanyPrzedmiot = Przedmiot.LosujPrzedmiotZeSkrzynki(przedmioty);
            wylosowanyPrzedmiot.WyswietlPrzedmiot();
        }
    }

    enum KlasaRzadkosci
    {
        Powszechny = 4,
        Rzadki = 3,
        Unikalny = 2,
        Epicki = 1
    }
    enum TypPrzedmiotu
    {
        Bron,
        Zbroja,
        Amulet,
        Pierscien,
        Helm,
        Tarcza,
        Uzywalny,
        Narzedzie,
        Buty
    }
    struct Przedmiot
    {
        public float Waga;
        public int Wartosc;
        public string Nazwa;
        public KlasaRzadkosci Rzadkosc;
        public TypPrzedmiotu Typ;
        public static void Wypelnij(ref Przedmiot przedmiot, float Waga, int Wartosc, string Nazwa, KlasaRzadkosci Rzadkosc, TypPrzedmiotu Typ)
        {
            przedmiot.Waga = Math.Max(Waga, 0);
            przedmiot.Wartosc = Math.Max(Wartosc, 0);
            przedmiot.Nazwa = Nazwa;
            przedmiot.Rzadkosc = Rzadkosc;
            przedmiot.Typ = Typ;
        }
        public void WyswietlPrzedmiot()
        {
            Console.WriteLine($"Przedmiot: {Nazwa}, Wartosc: {Wartosc}, Typ: {Typ.ToString()}");
        }

        public static Przedmiot LosujPrzedmiotZeSkrzynki(Przedmiot[] skrzynia)
        {
            if(skrzynia.Length == 0)
            {
                Console.WriteLine("Skrzynia jest pusta!");
                return default;
            }

            List<Przedmiot> pulaPrzedmiotow = new List<Przedmiot>();

            foreach (Przedmiot przedmiot in skrzynia)
            {
                for (int i = 0; i < (int)przedmiot.Rzadkosc; i++)
                {
                    pulaPrzedmiotow.Add(przedmiot);
                }
            }

            return pulaPrzedmiotow[Random.Shared.Next(pulaPrzedmiotow.Count)];
        }
    }

}
