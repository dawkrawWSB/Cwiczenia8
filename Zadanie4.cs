namespace Ćwiczenia8
{
    internal class Zadanie4
    {
        public Zadanie4()
        {
            Student[] studenci = new Student[5];
            Student.Wypelnij(ref studenci[0], "Kowalski", 26431, 4.5, Plec.Mezczyzna);
            Student.Wypelnij(ref studenci[1], "Kowalska", 50124, 1.5, Plec.Kobieta);
            Student.Wypelnij(ref studenci[2], "Pyla", 123553, 3.4, Plec.Mezczyzna);
            Student.Wypelnij(ref studenci[3], "Janusz", 443123, 3.8, Plec.Mezczyzna);
            Student.Wypelnij(ref studenci[4], "Buc", 653123, 6.0, Plec.Kobieta);

            foreach(Student student in studenci)
            {
                student.WyswietlStudenta();
            }

            Console.WriteLine($"Srednia studentow: {Student.SredniaStudentow(studenci)}");
        }
    }
    struct Student
    {
        public string Nazwisko;
        public int NrAlbumu;
        public double Ocena;
        public Plec Plec;

        public static void Wypelnij(ref Student student, string Nazwisko, int NrAlbumu, double Ocena, Plec plec)
        {
            student.Nazwisko = Nazwisko;
            student.NrAlbumu = NrAlbumu;
            student.Plec = plec;
            student.Ocena = Math.Clamp(Ocena, 2.0, 5.0);
        }

        public static decimal SredniaStudentow(Student[] studenci)
        {
            double sumaOcen = studenci.Sum(stud => stud.Ocena);
            return Convert.ToDecimal(sumaOcen) / (decimal)studenci.Length;
        }

        public void WyswietlStudenta()
        {
            Console.WriteLine($"Nazwisko: {Nazwisko}, NrAlbumu: {NrAlbumu}, Ocena: {Ocena}, Plec: {Plec.ToString()}");
        }
    }
}
