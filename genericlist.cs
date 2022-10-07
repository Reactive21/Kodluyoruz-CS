using System;

namespace generic_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<T> Class
            // System.Collections.Generic
            // T -> Object Türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // Count

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            // Foreach ve List.ForEach ile Elemanlara Erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Listeden Eleman Çıkartma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Liste İçerisinde Arama
            if(sayiListesi.Contains(10))
            {
                Console.WriteLine("10 Liste İçerisinde Bulundu!");
            }

            // Eleman İle İndex'e Erişim
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            // Diziyi List'e Çevirme
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            // Listeyi Nasıl Temizleriz?
            hayvanListesi.Clear();

            // List İçerisinde Nesne Tutmak
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.Yas = 26;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Özcan";
            kullanıcı2.Soyisim = "Çalışkan";
            kullanıcı2.Yas = 26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" + kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı:" + kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Yası:" + kullanici.Yas);
            }

            yeniListe.Clear();
        }
        
    }

    public class Kullanicilar 
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim {get => isim; set => isim = value;}
        public string Soyisim {get => soyisim; set => soyisim = value;}
        public int Yas {get => yas; set => yas = value;}

    }
}
