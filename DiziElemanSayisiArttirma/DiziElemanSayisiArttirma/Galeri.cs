using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziElemanSayisiArttirma
{
    internal class Galeri
    {

        private string[] araclar;

        public Galeri()
        {
            araclar = new string[0];
        }

        public void AracEkle(string arac)
        {
            string[] gecici = new string[arac.Length+1];
            for (int i = 0; i < gecici.Length; i++)
            {
                gecici[i] = araclar[i];
            }
            gecici[gecici.Length -1] = arac;
            araclar = gecici;

        }

        public void AracListele()
        {
            for (int i = 0;i < araclar.Length;i++)
            {
                Console.WriteLine(araclar[i]);
            }
        }

    }
}
