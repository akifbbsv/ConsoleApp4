using Metodlar;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Qarpiz";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Sabirabad Qarpizi";
            Urun urun2 = new Urun();
            urun2.Adi = "Alma";
            urun2.Fiyati = 5;
            urun2.Aciklama = "Quba Almasi";
            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");
            }
            Console.WriteLine("----Metodlar-----");
            Sepetmanagar sepetmanagar = new Sepetmanagar();
            sepetmanagar.Ekle(urun1);
            sepetmanagar.Ekle(urun2);
           
        }
    }
}