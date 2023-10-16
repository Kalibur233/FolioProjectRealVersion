namespace FolioProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppointmentModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppointmentModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HosiptalId = c.Int(nullable: false),
                        AppointmentTime = c.DateTime(nullable: false),
                        Description = c.String(),
                        MedicImage_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MedicImages", t => t.MedicImage_Id)
                .Index(t => t.MedicImage_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AppointmentModels", "MedicImage_Id", "dbo.MedicImages");
            DropIndex("dbo.AppointmentModels", new[] { "MedicImage_Id" });
            DropTable("dbo.AppointmentModels");
        }
    }
}
