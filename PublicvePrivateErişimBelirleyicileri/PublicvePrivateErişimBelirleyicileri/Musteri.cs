using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicvePrivateErişimBelirleyicileri
{
    public class Musteri
    {
        public string isim;
        public string soyisim;
        public int maasDegeri;
        public string cinsiyet;
        private int yas;
        public void MusteriBilgileriGoster()
        {
            Console.WriteLine("İsmi :" + isim);
            Console.WriteLine("Soyismi :" + soyisim);
            Console.WriteLine("Maaşı :" + maasDegeri);
            Console.WriteLine("Cinsiyeti :" + cinsiyet);
            Console.WriteLine("Yaşı" + yas);
        }

        private void İsimSoyisimYazdir(string musteriIsim , string musteriSoyisim)
        {
            Console.WriteLine("Müşterinin isim ve soyisimi :" + musteriIsim + " " + musteriSoyisim);
        }

    }
}
