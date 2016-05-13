namespace ToDo.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoEntries",
                c => new
                    {
                        ToDoEntryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Text = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ToDoEntryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ToDoEntries");
        }
    }
}
