using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //using ; IDispossable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext()) //Bellekten işi bitince atılacak.
            {
                var addedEntity = context.Entry(entity);    //referansı yakala
                addedEntity.State = EntityState.Added;      // o eklenecek bir nesne
                context.SaveChanges();                      // ve ekle.
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext()) //Bellekten işi bitince atılacak.
            {
                var deletedEntity = context.Entry(entity);  //referansı yakala
                deletedEntity.State = EntityState.Deleted;  // o eklenecek bir nesne
                context.SaveChanges();                      // ve ekle.
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)  //Tek data getirecek.
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter); //Prıduct category customer olabilir.Category ve customerda.
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                return filter == null                                   //filtre null mı
                    ? context.Set<Product>().ToList()                   //evet ise bunu
                    : context.Set<Product>().Where(filter).ToList();    //hayır ise bunu getir.
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext()) //Bellekten işi bitince atılacak.
            {
                var updatedEntity = context.Entry(entity);  //referansı yakala
                updatedEntity.State = EntityState.Modified; // o eklenecek bir nesne
                context.SaveChanges();                      // ve ekle.
            }
        }
    }
}
