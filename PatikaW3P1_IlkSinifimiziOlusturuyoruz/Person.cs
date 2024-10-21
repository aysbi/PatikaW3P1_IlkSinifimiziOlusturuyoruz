using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaW3P1_IlkSinifimiziOlusturuyoruz
{
    public class Person // person adinda bir public class olusturuyoruz
    {
        public string ad; // degiskenleri public bir sekilde tanimliyoruz
        public string soyad;
        public string dogumTarihi;

        public string Ad // degisken kullanildiginda nasil bir yol izlenecek onu veriyoruz
        {
            get
            {
                return ad; //ad degiskeni geri donecek ve set ile ad verilen degere atanacak
            }
            set
            {
                ad = value;
            }
        }
        public string Soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }
        public string DogumTarihi
        {
            get
            {
                return dogumTarihi;
            }
            set
            {
                dogumTarihi = value;
            }
        }

        public void OgrenciyiYazdir() //metodu ogrenciyse kullaniyoruz ve konsola yazma islevini veriyor
        {
            Console.WriteLine($"Ogrencinin adi {Ad} {Soyad} ve dogum tarihi {DogumTarihi}");
        }
        public void OgretmeniYazdir()
        {
            Console.WriteLine($"Ogretmenin adi {Ad} {Soyad} ve dogum tarihi {DogumTarihi}");
        }
    }
}
