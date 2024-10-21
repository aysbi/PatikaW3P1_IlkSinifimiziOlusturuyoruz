using PatikaW3P1_IlkSinifimiziOlusturuyoruz;

Person BirinciOgrenci = new Person(); // yeni bir nesne olusturuyoruz BirinciOgrenci adinda 
BirinciOgrenci.Ad = "Aysel"; //nesnenin icerigi yazilir
BirinciOgrenci.Soyad = "Bilmez";
BirinciOgrenci.DogumTarihi = "01.01.1998";
BirinciOgrenci.OgrenciyiYazdir(); //ogrenci oldugu icin bu metot kullanilir ve  ad soyad ve dogumtarihi konsola yazilir

Person BirinciOgretmen = new Person();
BirinciOgretmen.Ad = "Ozcan";
BirinciOgretmen.Soyad = "Yazici";
BirinciOgretmen.DogumTarihi = "01.01.1975";
BirinciOgretmen.OgretmeniYazdir();

Person IkinciOgrenci = new Person();
IkinciOgrenci.Ad = "Esra";
IkinciOgrenci.Soyad = "Suluoglu";
IkinciOgrenci.DogumTarihi = "02.02.1999";
IkinciOgrenci.OgrenciyiYazdir();

Person IkinciOgretmen = new Person();
IkinciOgretmen.Ad = "Zeliha";
IkinciOgretmen.Soyad = "Al";
IkinciOgretmen.DogumTarihi = "02.02.1970";
IkinciOgretmen.OgretmeniYazdir();