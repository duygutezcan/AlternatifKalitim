using BasitKalitim;

Ogrenci o = new Ogrenci();
o.Ad = "Duygu";
o.Soyad = "Tezcan Kantar";
//o.Adres = new AlternatifKalitim.Adres();
o.Adres.Ilce = "Ataşehir";
o.Adres.Sehir = "İstanbul";
o.Adres.Cadde = "Atatürk";
o.Adres.Sokak = "Mevlana";


Console.WriteLine(o.FullName());
foreach (var item in o.AdresAl())
{
    Console.WriteLine(item);
}

Egitmen e = new Egitmen();
e.Ad = "Şamil";
e.Soyad = "Yılmaz";
e.Adres.Ilce = "Ümraniye";
e.Adres.Sehir = "İstanbul";
e.Adres.Cadde = "Atatürk";

