using System.Data.Common;
using Abp.Zero.EntityFramework;
using SimpleZero.Authorization.Roles;
using SimpleZero.MultiTenancy;
using SimpleZero.Users;
using System.Data.Entity;
using SimpleZero.Contacts;

namespace SimpleZero.EntityFramework
{
    public class SimpleZeroDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public virtual IDbSet<ContactGroup> ContactGroups { get; set; }
        public virtual IDbSet<Contact> Contacts { get; set; }


        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public SimpleZeroDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in SimpleZeroDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of SimpleZeroDbContext since ABP automatically handles it.
         */
        public SimpleZeroDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public SimpleZeroDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
