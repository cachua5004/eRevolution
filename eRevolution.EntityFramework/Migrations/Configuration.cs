using System.Data.Entity.Migrations;
using eRevolution.Migrations.SeedData;

namespace eRevolution.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<eRevolution.EntityFramework.eRevolutionDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "eRevolution";
        }

        protected override void Seed(eRevolution.EntityFramework.eRevolutionDbContext context)
        {
            new InitialDataBuilder(context).Build();
        }
    }
}
