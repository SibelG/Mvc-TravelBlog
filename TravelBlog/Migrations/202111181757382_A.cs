namespace TravelBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class A : DbMigration
    {
        public override void Up()
        {
            
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        Aciklama = c.String(),
                        Fax = c.String(),
                        Tel = c.String(),
                        Email = c.String(),
                        Konum = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
          
            
        }
        
        public override void Down()
        {
            
            DropTable("dbo.Addresses");
           
        }
    }
}
