using EF2_Hotel.Entities.LoginEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2_Hotel.Context
{
    public class LoginContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=LoginDB;Integrated Security=True;Encrypt=False;");

        public virtual DbSet<Frontend> Frontend {  get; set; }
        public virtual DbSet<Kitchen> Kitchen { get; set; }

    }
}
