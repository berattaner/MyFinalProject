using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess //Core katmanı diğer katmanları referans almaz.
{
    // generic constraint : generic kısık sadece yazılanı filtrele.
    // class : Referans tip olabilir demek.
    // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    // new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new() //IEntity kendisi veya implementleri olabilir.new olunca IEntity kendisi olmaz.
                                                                      //ICategoryDal product customer dalda IEntity yazılmaz.
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filtreleme işlemi yapıyor.Categoriye,fiyatına vb. göre getir gibi.
                                                                 //null=filtre vermeye bilirsin demek.
        T Get(Expression<Func<T, bool>> filter); //Tek bir data getirmek için.Yani tek bir hesaplara,tek bir krediye gibi.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
