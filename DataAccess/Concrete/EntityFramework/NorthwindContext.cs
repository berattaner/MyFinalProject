using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlamak.
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
            //SQL server kullanılak.SQL server adı yazılacak.
            //@ \ normal algıla demek.
            //Trusted_Connection=true ; kullanıcı adı şifre yazılır normalde.
        }

        //Hangi tabloya ne karşılık gelecek.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Costomers { get; set; }
        public DbSet<Order> Orders { get; set; }    
    }
}
