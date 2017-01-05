namespace GameEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ExamenJanuari.Accounts",
                c => new
                    {
                        AccountId = c.Int(nullable: false, identity: true),
                        CharacterId = c.Int(nullable: false),
                        GebruikersNaam = c.String(),
                        Wachtwoord = c.String(),
                    })
                .PrimaryKey(t => t.AccountId);
            
            CreateTable(
                "ExamenJanuari.Characters",
                c => new
                    {
                        CharacterId = c.Int(nullable: false),
                        AccountId = c.Int(nullable: false),
                        Naam = c.String(),
                        HP = c.Int(nullable: false),
                        Attack = c.Int(nullable: false),
                        Mana = c.Int(nullable: false),
                        Alive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CharacterId)
                .ForeignKey("ExamenJanuari.Accounts", t => t.CharacterId)
                .Index(t => t.CharacterId);
            
            CreateTable(
                "ExamenJanuari.Monsters",
                c => new
                    {
                        MonsterId = c.Int(nullable: false, identity: true),
                        HP = c.Int(nullable: false),
                        Attack = c.Int(nullable: false),
                        Alive = c.Boolean(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.MonsterId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("ExamenJanuari.Characters", "CharacterId", "ExamenJanuari.Accounts");
            DropIndex("ExamenJanuari.Characters", new[] { "CharacterId" });
            DropTable("ExamenJanuari.Monsters");
            DropTable("ExamenJanuari.Characters");
            DropTable("ExamenJanuari.Accounts");
        }
    }
}
