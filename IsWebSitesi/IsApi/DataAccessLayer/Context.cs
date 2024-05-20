using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsApi.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-MDRTU7J\\SQLEXPRESS;database=IsWebSitesiApi; integrated security=true;");
        }
        public DbSet<Company> Companies { get; set; }
    }
}
