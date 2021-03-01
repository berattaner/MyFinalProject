using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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

            ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var product in productManager.GetAllByCategoryId(2)) //2 numardaki rünleri getirdi
            foreach (var product in productManager.GetByUnitPrice(50, 100))  // min:50 max:100 olan ürünler gelecek.
            {
                Console.WriteLine("Ürünün Adı: " + product.ProductName + " ---->" +
                    " Ürünün Kategorisi: " + product.CategoryId + " ---->" +
                    " Ürünün Fiyatı: " + product.UnitPrice + " TL ");

            }
        }
    }
}
