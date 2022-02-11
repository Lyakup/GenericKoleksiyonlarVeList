using System;
using System.Collections.Generic;

namespace GenericKoleksiyonlarVeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(45);
            sayiListesi.Add(23); 
            sayiListesi.Add(87);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Eflatun");
            renkListesi.Add("Turkuaz");
            renkListesi.Add("Mavi");

            Console.WriteLine(renkListesi.Count);

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            renkListesi.ForEach(renk => Console.WriteLine(renk));

            renkListesi.Remove("Mavi");
            sayiListesi.RemoveAt(3);

            if (sayiListesi.Contains(23))
                Console.WriteLine("23 Sayısı listede mevcut");

            Console.WriteLine(renkListesi.BinarySearch("Eflatun"));

            //Diziyi listeye Çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Lİsteyi temizler
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Isim = "Burak";
            kullanici1.SoyIsim = "Layık";
            kullanici1.Yaş = 27;

            kullaniciListesi.Add(kullanici1);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Osman",
                SoyIsim= "Demir",
                Yaş = 30
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanici.SoyIsim);
                Console.WriteLine("Kullanıcı Yaş: " + kullanici.Yaş);
            }
        }
    }

    class Kullanıcılar
    {
        string isim;
        string soyIsim;
        int yaş;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public int Yaş { get => yaş; set => yaş = value; }
    }
}
