using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatykaApp1
{
    class Uczen
    {
        public Uczen(string Imie, string Nazwisko, int Data_urodzenia, Zameldowanie Adres_zamieszkania)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Data_urodzenia = Data_urodzenia;
            this.Adres_zamieszkania = Adres_zamieszkania;
        }

        private string imie;
        private string nazwisko;
        private int data_urodzenia;
        private Zameldowanie adres_zamieszkania;
        private int[] oceny;

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public int Data_urodzenia { get => data_urodzenia; set => data_urodzenia = value; }
        internal Zameldowanie Adres_zamieszkania { get => adres_zamieszkania; set => adres_zamieszkania = value; }
        public int[] Oceny { get => oceny; set => oceny = value; }

        public double Srednia_ocen()
        {
            double suma = 0;

            if(Oceny.Length == 0)
            {
                return 1;
            }
            else
            {
                foreach (int x in Oceny)
                {
                    suma = suma + x;
                }
                return (suma / Oceny.Length);
            }
        }

        public int Wiek(int Rok)
        {
            return ((Rok - Data_urodzenia) * 12);
        }
    }
}
