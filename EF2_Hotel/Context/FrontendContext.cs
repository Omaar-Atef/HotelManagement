using EF2_Hotel.Entities.FrontendEntitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2_Hotel.Context
{
    public class FrontendContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=FrontendDB;Integrated Security=True;Encrypt=False;");

        public  virtual DbSet<Reservation> Reservation { get; set; }
    }
}
