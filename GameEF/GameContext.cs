using GameEF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEF
{
    public class GameContext : DbContext
    {
        public GameContext() : base()
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // Instellen van het database Schema
            modelBuilder.HasDefaultSchema("ExamenJanuari");

            // Mappen van de entiteiten aan een tabel
            modelBuilder.Entity<Account>().ToTable("Accounts");
            modelBuilder.Entity<Character>().ToTable("Characters");
            modelBuilder.Entity<Monster>().ToTable("Monsters");

            #region 1-op-geen-of-1 realtie tussen Account en Character
            // configureren van de primary key voor Account
            modelBuilder.Entity<Account>()
                .HasKey(a => a.AccountId);

            // foreign gedeelte
            modelBuilder.Entity<Account>().HasOptional(c => c.Character) // Markeerd Character als optioneel in de Account entity
               .WithRequired(a => a.Account); // Markeerd Account als verplicht, kan geen Character opslaan zonder account

            #endregion



        }
    }
}
