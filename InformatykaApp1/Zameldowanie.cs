using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatykaApp1
{
    class Zameldowanie
    {

        public Zameldowanie(string Ulica, int Kod_pocztowy, int Numer_domu)
        {
            this.Ulica = Ulica;
            this.Kod_pocztowy = Kod_pocztowy;
            this.Numer_domu = Numer_domu;
        }

        private string ulica;
        private int kod_pocztowy;
        private int numer_domu;

        public string Ulica { get => ulica; set => ulica = value; }
        public int Kod_pocztowy { get => kod_pocztowy; set => kod_pocztowy = value; }
        public int Numer_domu { get => numer_domu; set => numer_domu = value; }

       
       
    }
}
