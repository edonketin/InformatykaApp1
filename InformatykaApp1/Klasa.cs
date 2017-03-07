using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatykaApp1
{
    class Klasa
    {
        public Klasa(string Nazwa_klasy, string Nazwisko_nauczyciela, int Rocznik)
        {
            this.Nazwa_klasy = Nazwa_klasy;
            this.Nazwisko_nauczyciela = Nazwisko_nauczyciela;
            this.Rocznik = Rocznik;
        }

        private string nazwa_klasy;
        private string nazwisko_nauczyciela;
        private int rocznik;
        private Uczen[] spis_uczniow;

        public string Nazwa_klasy { get => nazwa_klasy; set => nazwa_klasy = value; }
        public string Nazwisko_nauczyciela { get => nazwisko_nauczyciela; set => nazwisko_nauczyciela = value; }
        public int Rocznik { get => rocznik; set => rocznik = value; }
        internal Uczen[] Spis_uczniow { get => spis_uczniow; set => spis_uczniow = value; }

        public double Srednia_ocen_klasy()
        {
            double suma = 0;

            foreach (Uczen x in Spis_uczniow)
            {
                suma = suma + x.Srednia_ocen();
            }
            return (suma / Spis_uczniow.Length);
        }

        public void Wypisz_uczniow()
        {
            foreach (Uczen x in Spis_uczniow)
            {
                Console.WriteLine
                    (
                    x.Imie +" " + 
                    x.Nazwisko + " " + 
                    x.Adres_zamieszkania.Ulica
                    );
            }
        }
    }
}
