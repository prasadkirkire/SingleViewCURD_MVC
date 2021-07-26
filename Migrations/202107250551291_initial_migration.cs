namespace SingleViewCURD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeTbl",
                c => new
                    {
                        EmployeeID = c.Long(nullable: false, identity: true),
                        EmployeeFirstName = c.String(),
                        EmployeeLastName = c.String(),
                        EmailID = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmployeeTbl");
        }
    }
}
