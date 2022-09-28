using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicvePrivateErişimBelirleyicileri
{
    class Program
    {
        static void Main(string[] args)
        {
            // public -- private -- protected -- internal
            Musteri musteri1 = new Musteri();
            musteri1.isim = "Enes";
            musteri1.soyisim = "Bayram";
            musteri1.maasDegeri = 2500;
            musteri1.yas = 21;
        }
    }
}
