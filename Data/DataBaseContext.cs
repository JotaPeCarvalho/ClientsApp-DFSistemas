using ClientApp.Data.Map;
using ClientApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ClientApp.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<PhoneModel> Phones { get; set; }
        public DbSet<AdressModel> Adresses { get; set; }
        public DbSet<SocialMidiaModel> SocialMidias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
