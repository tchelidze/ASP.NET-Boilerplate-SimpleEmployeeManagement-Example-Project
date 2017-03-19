namespace SimpleEmployeeManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migdev1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        IdentityNumber = c.String(),
                        PhoneNumber = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Nationality_Name = c.String(),
                        Salary_Amount = c.Double(nullable: false),
                        Salary_Currency_Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
