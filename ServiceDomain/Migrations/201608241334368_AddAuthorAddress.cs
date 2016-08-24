namespace ServiceDomain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuthorAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "Address");
        }
    }
}
