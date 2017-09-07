using System.Data.Common;
using Abp.Zero.EntityFramework;
using MT.Authorization.Roles;
using MT.Authorization.Users;
using MT.MultiTenancy;

namespace MT.EntityFramework
{
    public class MTDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public MTDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MTDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MTDbContext since ABP automatically handles it.
         */
        public MTDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MTDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public MTDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
