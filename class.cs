// See https://aka.ms/new-console-template for more information
using System;

namespace sinif_kavrami{
    class program{


        static void Main(string[] args)
        {
            /*Söz dizimi
            Class Sinifadi
            {
                [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
                [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi(Parametre Listesi)
                {
                    Metot Komutları
                }    
            }
            
            Erişim Belirleyici Türleri
            Public
            Private
            Internal
            Protected
            */
            Calisan calisan1 = new Calisan();
            calisan1.Ad= "Yusuf";
            calisan1.Soyad = "Çavdar";
            calisan1.No = 23415634;
            calisan1.Departman="IT";
            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad="Tarık";
            calisan2.Soyad="Kum";
            calisan2.No=23415635;
            calisan2.Departman="IT";
            calisan2.CalisanBilgileri();


        }
    }

    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Ad:{0}",Ad);
            Console.WriteLine("Çalışan Soyad:{0}",Soyad);
            Console.WriteLine("Çalışan No:{0}",No);
            Console.WriteLine("Çalışan Departman:{0}",Departman);
        }
    }
}
