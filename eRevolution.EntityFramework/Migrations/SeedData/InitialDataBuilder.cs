using eRevolution.EntityFramework;
using EntityFramework.DynamicFilters;

namespace eRevolution.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly eRevolutionDbContext _context;

        public InitialDataBuilder(eRevolutionDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.DisableAllFilters();

            new DefaultEditionsBuilder(_context).Build();
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new DefaultLanguagesBuilder(_context).Build();
        }
    }
}
