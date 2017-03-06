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

            Wojtek.Oceny[] = [2, 3];

            Console.WriteLine(Wojtek.Adres_zamieszkania.Ulica);
            Console.ReadKey();
        }
    }
}
