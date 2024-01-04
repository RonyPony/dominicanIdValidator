
using Microsoft.EntityFrameworkCore;
using System;


namespace dominicanIdValidator
{
    public partial class DominicanIdContext : DbContext
    {

        public DominicanIdContext(DbContextOptions<DominicanIdContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //if (!optionsBuilder.IsConfigured)
        //    //{
        //    //    optionsBuilder.UseSqlServer(cnnstr);
        //    //}
        //}

        public DbSet<Padron> Padron { get; set; }
    }
}
