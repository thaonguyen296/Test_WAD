namespace Test_WAD_NguyenThao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        ExamId = c.Int(nullable: false, identity: true),
                        ExamSubject = c.String(nullable: false, unicode: false),
                        StartTime = c.DateTime(nullable: false, precision: 0),
                        ExamDate = c.DateTime(nullable: false, precision: 0),
                        ExamDuration = c.Int(nullable: false),
                        Room = c.String(nullable: false, unicode: false),
                        Faculty = c.String(nullable: false, unicode: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExamId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Exams");
        }
    }
}
