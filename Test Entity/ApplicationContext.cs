using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Test_Entity
{
    internal class ApplicationContext : DbContext
    {    
        public DbSet<Gpt_bot> Gpt_bots { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionProperties = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=8RU3aNQnbTMI";
                optionsBuilder.UseNpgsql(connectionProperties);
            }
        }
    }
}
