using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //syntax
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Ürün Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Ürün Sepete Eklendi : " + urunAdi);
        }
    }
}
