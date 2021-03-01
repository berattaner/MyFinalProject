using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category> //Category yerine IEntity yazılmaz new() ledikten sonra.Product, customer içinde geçerli.
    {
     

    }
}
