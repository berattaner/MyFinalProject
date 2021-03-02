using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //İş katmanında kullanacağımız servis operasyonları.
    public interface IProductService
    {
        List<Product> GetAll(); //Tümünü getir.
        List<Product> GetAllByCategoryId(int id); //by:ile categoryId göre getir.
        List<Product> GetByUnitPrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();
        Product GetById(int productId); //Tek başına bir ürün döndürür.
        IResult Add(Product product);  //Birşey döndürmez.
    }
}
