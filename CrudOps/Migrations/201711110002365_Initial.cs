namespace CrudOps.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stuffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Prop1 = c.String(),
                        Prop2 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stuffs");
        }
    }
}
