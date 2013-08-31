namespace botforge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LessonViewModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        WeekNumber = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                        LessonImage = c.String(nullable: false),
                        Summary = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LessonViewModels");
        }
    }
}
