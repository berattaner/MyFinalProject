using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //public = Bu class'a diger katmanlarda ulaşabilsin demek.
    //internal = Sadece Entities erişebilir demek.
    //concrete de veri tabanı tabloları oluşturuldu.
    public class Product:IEntity 
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; } //short int'in bir küçüğü.
        public decimal UnitPrice { get; set; }  //decimal para birimini tutar.
    }
}
