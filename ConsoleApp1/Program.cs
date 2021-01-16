using System;

namespace Methods
{
    class Program
    { 
        static void Main(string[] args)
        {
            //string urunAdi = "Elma";
            //double fiyati = 15;
            //string aciklama = "Amasya elması";

            //string[] meyveler = new string[] {"Elma", "Karpuz"};

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyatı = 15;
            product1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyatı = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyatı);
                Console.WriteLine(product.Aciklama);

            }

            Console.WriteLine("----------Metotlar--------------");

            //instance-class örneği oluşturmak
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,9);
            sepetManager.Ekle2("Elma", "Amasya elması", 12,8);

        }
    }
}

//do not repeat yourself-DRY
