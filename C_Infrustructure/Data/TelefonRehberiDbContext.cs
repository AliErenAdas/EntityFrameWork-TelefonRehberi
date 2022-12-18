using A_Domain.Entity;
using C_Infrustructure.EntityTypeConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Infrustructure.Data
{
    public class TelefonRehberiDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-72MJDUFP;Database=TelefonRehberi;Trusted_Connection=True");
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Grup>(new GrupConfig())
            .ApplyConfiguration<İletişimNumarası>(new İletişimNumarasıConfig())
            .ApplyConfiguration<İletişimTür>(new İletişimTürConfig())
            .ApplyConfiguration<Kisi>(new KisiConfig())
            .ApplyConfiguration<KisiGruplari>(new KisiGruplariConfig())
            .ApplyConfiguration<Mail>(new MailConfig());
        }

        public DbSet<Grup> Grup { get; set; }
        public DbSet<İletişimNumarası> İletişimNumarası { get; set; }
        public DbSet<Kisi> Kişiler { get; set; }
        public DbSet<Mail> Mailler { get; set; }
        public DbSet<KisiGruplari> KisiGrupları { get; set; }
        public DbSet<İletişimTür> İletişimTürü { get; set; }

    }
}

