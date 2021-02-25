using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract'lar referans tutucu olacak.
            //Concrete asıl işi yapanlardır.
            //DataAccess = Ürünü ekleyecek,listeleyecek.Veri erişimidir.Bizim SQL cümleciklerini yazdığımız yerdir.
            //Business = Ürünü kontrol edecek.İş kuralları yazılır.
            //Console = Ürünü gösterecek.

            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine("Ürünün Adı: " + product.ProductName + "    " + " Ürünün Fiyatı: " + product.UnitPrice + " TL");
            }
        }
    }
}
