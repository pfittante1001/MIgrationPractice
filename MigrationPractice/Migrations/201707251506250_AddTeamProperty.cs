namespace MigrationPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeamProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scores", "Name", c => c.String());
            AddColumn("dbo.Scores", "Team", c => c.String());
            DropColumn("dbo.Scores", "Nmae");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Scores", "Nmae", c => c.String());
            DropColumn("dbo.Scores", "Team");
            DropColumn("dbo.Scores", "Name");
        }
    }
}
