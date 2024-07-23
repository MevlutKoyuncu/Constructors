using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziElemanSayisiArttirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //Dizinin eleman sayısını içindeki verileri kaybetmeden arttırmak MÜMKÜN DEĞİLDİR!!!

            #endregion

            #region Bakalım nasıl oluyor?

            //string[] isimler = new string[3];
            //isimler[0] = "Murtaza";
            //isimler[1] = "Şuayip";
            //isimler[2] = "John";

            //isimler = new string[4];
            //isimler[3] = "Jane";

            //for(int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}

            #endregion

            #region Peki ne yapmalıyız?

            //string[] katilimcilar = new string[0];

            //string secenek = "e";

            //while (secenek == "e")
            //{
            //    string[] gecici = new string[katilimcilar.Length+1];

            //    //Dizi Kopyalama
            //    for (int i = 0; i < katilimcilar.Length; i++)
            //    {
            //        gecici[i] = katilimcilar[i];
            //    }
            //    Console.WriteLine("Lütfen katılımcı adınızı giriniz = ");
            //    string isim = Console.ReadLine();

            //    gecici[gecici.Length -1] = isim;

            //    katilimcilar = gecici;

            //    Console.WriteLine("Yeni katılımcı eklenecek mi? e/h");
            //    secenek = Console.ReadLine();
            //}

            #endregion

            #region  Galeri Uygulaması

            //Galeri g = new Galeri();

            //string secenek = "e";

            //while (secenek == "e")
            //{
            //    Console.WriteLine("Araç Adı Giriniz");
            //    string isim = Console.ReadLine();

            //    g.AracEkle(isim);

            //    Console.WriteLine("Araç eklemeye devam edilsin mi? e/h");
            //    secenek = Console.ReadLine();
            //}

            #endregion

            #region Konferans Uygulaması

            Konferans k = new Konferans();
            string devam = "e";

            while (devam == "e")
            {
                Insan kisi = new Insan();
                Console.Write("Katılımcı adı = ");
                kisi.isim = Console.ReadLine();
                Console.WriteLine("Katılımcı soyadı = ");
                kisi.soyisim = Console.ReadLine();

                k.KatilimciEkle(kisi);

                Console.WriteLine("Devam edilsin mi? e/h");
                devam = Console.ReadLine();
                Console.Clear();
            }
            k.KatilimciListele();

            #endregion

            #region Sınav oluştur. Sınavı başlat.

            #endregion

            #region 1.Kütüphane kitapları kaydet. 2ye basıldığında kitapları listele. 3.Türe göre listele. 4.Silme.

            #endregion

            #region Domates biberi, menü listele, stok kaydı da tutulmalı. Stok miktarı 0 olan listelenmeyecek. Ürün satın alınırken alınan miktar stoktan düşecek. 

            #endregion
        }
    }
}
