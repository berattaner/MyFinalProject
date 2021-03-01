using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın standı.
    public class Category:IEntity //using ekle. IEntity Category referansını tutabiliyor.
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
