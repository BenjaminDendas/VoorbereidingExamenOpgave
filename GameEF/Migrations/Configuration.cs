namespace GameEF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GameEF.GameContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GameEF.GameContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            Account A1 = new Account { AccountId = 1, GebruikersNaam = "Test1", Wachtwoord = "Test1" };
            Account A2 = new Account { AccountId = 2, GebruikersNaam = "Test2", Wachtwoord = "Test2" };
            Account A3 = new Account { AccountId = 3, GebruikersNaam = "Test3", Wachtwoord = "Test3" };
            Account A4 = new Account { AccountId = 4, GebruikersNaam = "Test4", Wachtwoord = "Test4" };
            Account A5 = new Account { AccountId = 5, GebruikersNaam = "Test5", Wachtwoord = "Test5" };

            Character C1 = new Character { CharacterId = 1, Account = A1, AccountId = A1.AccountId, Alive = true, Attack = 20, HP = 100, Mana = 100, Naam = "Char1" };
            Character C2 = new Character { CharacterId = 2, Account = A3, AccountId = A3.AccountId, Alive = false, Attack = 50, HP = 0, Mana = 0, Naam = "Char2" };
            Character C3 = new Character { CharacterId = 3, Account = A5, AccountId = A5.AccountId, Alive = true, Attack = 100, HP = 1000, Mana = 500, Naam = "Char3" };

            A1.Character = C1;
            A3.Character = C2;
            A5.Character = C3;

            A1.CharacterId = C1.CharacterId;
            A3.CharacterId = C2.CharacterId;
            A5.CharacterId = C3.CharacterId;

            context.Accounts.Add(A1);
            context.Accounts.Add(A2);
            context.Accounts.Add(A3);
            context.Accounts.Add(A4);
            context.Accounts.Add(A5);

        }
    }
}
