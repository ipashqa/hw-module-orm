namespace orm_module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        CardNumber = c.String(nullable: false, maxLength: 128),
                        ExpirationDate = c.DateTime(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CardNumber)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CreditCards", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.CreditCards", new[] { "EmployeeId" });
            DropTable("dbo.CreditCards");
        }
    }
}
