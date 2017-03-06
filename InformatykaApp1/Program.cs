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

            int[] tablica;
            tablica = new int[] {2, 3, 5 };

            Wojtek.Oceny = new int[] { 5, 6, 5, 3, 2, 6 };

            Console.WriteLine(Wojtek.Adres_zamieszkania.Ulica);
            foreach(int x in Wojtek.Oceny)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(Wojtek.Srednia_ocen());
            Console.ReadKey();
        }
    }
}
