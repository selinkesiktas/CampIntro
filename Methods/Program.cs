using System;

namespace Methods 
{
    class Program
    {
        static void Main(string[] args) 
        {
     
            Product product1= new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";


            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("-----------Methods-----------");    
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);


            sepetManager.Add2("Armut", "Yeşil Armut", 12, 9);
            sepetManager.Add2("Elma", "Yeşil Elma", 12, 8);
            sepetManager.Add2("Karpuz", "Diyarbakır Karpuzu", 12, 3);





            // Console.WriteLine("Hello, World!");

        }
        
    }

}


