namespace GameEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("ExamenJanuari.Accounts", "GebruikersNaam", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("ExamenJanuari.Accounts", "Wachtwoord", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("ExamenJanuari.Characters", "Naam", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("ExamenJanuari.Monsters", "Name", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("ExamenJanuari.Monsters", "Name", c => c.String());
            AlterColumn("ExamenJanuari.Characters", "Naam", c => c.String());
            AlterColumn("ExamenJanuari.Accounts", "Wachtwoord", c => c.String());
            AlterColumn("ExamenJanuari.Accounts", "GebruikersNaam", c => c.String());
        }
    }
}
