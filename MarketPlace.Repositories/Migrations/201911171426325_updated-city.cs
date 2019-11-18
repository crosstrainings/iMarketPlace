namespace MarketPlace.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedcity : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Addresses", name: "City_Id", newName: "CityId");
            RenameColumn(table: "dbo.Cities", name: "Country_Id", newName: "CountryId");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Cities", name: "CountryId", newName: "Country_Id");
            RenameColumn(table: "dbo.Addresses", name: "CityId", newName: "City_Id");
        }
    }
}
