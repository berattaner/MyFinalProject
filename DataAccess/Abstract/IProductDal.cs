using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Yani bu benim productla ilgili veritabanın da yapacağım operasyonları içeren interfaceir.
    //Operasyon silme,ekleme,güncelleme,filtreleme,listele,getir gibi operasyonlardır.
    //interface kendisi public degildir.Operasyonları publicdir.
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAllByCategory(int categoryId);
    }
}
