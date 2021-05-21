using System;

namespace metotlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";
            int outSayi;

            bool sonuc = int.TryParse(sayi, out outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }
            metotlar instance = new metotlar();
            instance.Topla(4,5, out int ToplamSonucu);
            Console.WriteLine(ToplamSonucu);

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
        }
    }
    class metotlar
    {
        public void Topla(int a, int b, out int topla)
        {
            topla = a + b;
        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
    }
}
