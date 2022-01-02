namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameRentalColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "DateRented", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rentals", "DateAdded");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rentals", "DateAdded", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rentals", "DateRented");
        }
    }
}
