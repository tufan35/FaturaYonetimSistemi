using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.DatabaseContext
{
    public class BaseContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-AQCSOUN\MSSQLSERVER19;Database=FYS;Trusted_Connection=true");
        }

        public DbSet<Fatura> TBL_FATURA { get; set;}
        public DbSet<Konut> TBL_KONUT { get; set;}
        public DbSet<Konut_Tip> TBL_KONUT_TIP { get; set;}
        public DbSet<Kullanici> TBL_KULLANICI { get; set;}
        public DbSet<Sicil> TBL_SICIL { get; set;}


    }
}
