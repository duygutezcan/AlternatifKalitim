using AlternatifKalitim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitKalitim
{
    internal class Temel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public Temel()
        {
            Adres=new Adres();
        }
       
        public string FullName()
        {
            return Ad + Soyad;
        }
        public Adres Adres { get; set; }
        public List<string> AdresAl()
        {
            List<string> adres = new List<string>();
            adres.Add(FullName());
            adres.Add(Adres.Cadde);
            adres.Add(Adres.Sokak);
            adres.Add($"{Adres.Ilce}-{Adres.Sehir}");
            return adres;
        }
    }
}
