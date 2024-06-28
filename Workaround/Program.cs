using Business.Concrete;
using Entities.Concrete;
using System;
namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            Vatandas vatandas1 = new Vatandas();
            SelamVer(isim: "engin ");
            SelamVer(isim: "ayse");
            SelamVer(isim: "ahmet");
            SelamVer();
            int sonuc = Topla(3, 5);


            //diziler arrays
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "engin";
            ogrenciler[1] = "kerem";
            ogrenciler[2] = "berkay";



            Console.ReadLine();


            Person person1 = new Person();
            person1.FirstName = "Engin";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 1;




            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();


        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("merhaba " + isim);
        }


        static int Topla(int sayi1, int sayi2)
        {

            int sonuc = sayi1 + sayi2;
            Console.WriteLine("toplam :" + sonuc.ToString());
            return sonuc;

        }




        private static void Degiskenler()
        {
            string mesaj = "merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool giris = false;


            string Ad = "engin";
            string soyad = "demiroğ";
            int dogumyili = 1985;
            long tcno = 12345678910;

            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);
        }



    }

    public class Vatandas
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public int dogumyili { get; set; }
        public long tcno { get; set; }
    }


}