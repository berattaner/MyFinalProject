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
        IDataResult<List<Product>> GetAll(); //Tümünü getir.
        IDataResult<List<Product>> GetAllByCategoryId(int id); //by:ile categoryId göre getir.
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId); //Tek başına bir ürün döndürür.
        IResult Add(Product product);  
    }
}
