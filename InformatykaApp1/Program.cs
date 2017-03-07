using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatykaApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Uczen Wojtek = new Uczen
                (
                Imie: "Wojtek",
                Nazwisko: "Konury",
                Data_urodzenia: 1998,
                Adres_zamieszkania: new Zameldowanie
                    (
                    Ulica: "Podwale", 
                    Kod_pocztowy: 56200, 
                    Numer_domu: 5
                    )
                );
            Uczen Mieszko = new Uczen
                (
                Imie: "Śmieszko",
                Nazwisko: "Wawrzyniak",
                Data_urodzenia: 1998,
                Adres_zamieszkania: new Zameldowanie
                    (
                    Ulica: "Kupa",
                    Kod_pocztowy: 64100,
                    Numer_domu: 9
                    )
                );

            Klasa Truskawki = new Klasa
                (
                Nazwa_klasy: "III D",
                Nazwisko_nauczyciela: "Pobreżny",
                Rocznik: 1998
                );

            Truskawki.Spis_uczniow = new Uczen[] { Wojtek, Mieszko };
            Wojtek.Oceny = new int[] { 5, 6, 5, 3, 2, 6 };
            Mieszko.Oceny = new int[] { 3, 2, 5, 3, 2, 1 };

            Console.WriteLine(Wojtek.Adres_zamieszkania.Ulica);
            Console.WriteLine(Wojtek.Srednia_ocen());
            Console.WriteLine(Mieszko.Srednia_ocen());
            Console.WriteLine(Truskawki.Srednia_ocen_klasy());
            Console.ReadKey();
        }
    }
}
