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
            
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            
            var result = productManager.GetProductDetails();
            
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
       
        }
    }
}
