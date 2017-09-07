using MT.EntityFramework;
using EntityFramework.DynamicFilters;

namespace MT.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MTDbContext _context;

        public InitialHostDbBuilder(MTDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
