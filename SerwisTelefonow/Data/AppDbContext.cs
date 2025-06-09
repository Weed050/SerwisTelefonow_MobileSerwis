using Microsoft.EntityFrameworkCore;
using SerwisTelefonow.DBModels;
using System;

namespace SerwisTelefonow.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {
        }

        public DbSet<Clients> Clients { get; set; }
        public DbSet<PhoneModel> PhoneModel { get; set; }
        public DbSet<ServiceEntry> ServiceEntry { get; set; }


        public void SeedDatabaseFromSqlScriptIfEmpty()
        {
            if (!this.Clients.Any())
            {
                var sql = File.ReadAllText("seeder_script.sql");
                this.Database.ExecuteSqlRaw(sql);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PhoneModel>().HasData(
                new PhoneModel
                {
                    KodModelu = "SM-A525F",
                    Marka = "Samsung",
                    PelnaNazwa = "Samsung Galaxy A52"
                },
                new PhoneModel
                {

                    KodModelu = "MI12PRO",
                    Marka = "Xiaomi",
                    PelnaNazwa = "Xiaomi 12 Pro"
                },
                new PhoneModel
                {

                    KodModelu = "PIXEL7P",
                    Marka = "Google",
                    PelnaNazwa = "Google Pixel 7 Pro"
                },
                new PhoneModel
                {

                    KodModelu = "REDMIN10",
                    Marka = "Xiaomi",
                    PelnaNazwa = "Redmi Note 10"
                }
                );
            modelBuilder.Entity<ServiceEntry>().HasData(
                new ServiceEntry
                {
                    Id = 1,
                    KlientId = 1,
                    KodModelu = "PIXEL7P",
                    IMEI = "123456789012345",
                    Opis = "Telefon się nie włącza, możliwe zalanie cieczą.",
                    CenaWstepna = 50,
                    CenaKoncowa = null,
                },
                new ServiceEntry
                {
                    Id = 2,
                    KlientId = 1,
                    KodModelu = "MI12PRO",
                    IMEI = "123456789012345",
                    Opis = "Rozbity ekran",
                    CenaWstepna = 550,
                    CenaKoncowa = 600,
                },
                new ServiceEntry
                {
                    Id = 3,
                    KlientId = 2,
                    KodModelu = "REDMIN10",
                    IMEI = "123461719012345",
                    Opis = "Telefon się nie włącza, oraz nie reaguje na podpięcie do ładowarki.",
                    CenaWstepna = 35,
                    CenaKoncowa = null,
                }
                );
            modelBuilder.Entity<Clients>().HasData(
                new Clients()
                {
                    Id = 1,
                    Imie = "Adrian",
                    Nazwisko = "Kowalczyk",
                    Telefon = "123123123"
                },
                new Clients()
                {
                    Id = 2,
                    Imie = "Kondrat",
                    Nazwisko = "Kwaśniak",
                    Telefon = "415617154"
                },
                new Clients()
                {
                    Id = 3,
                    Imie = "Karol",
                    Nazwisko = "Marek",
                    Telefon = "918472948"
                }
                );
        }

    }
}

