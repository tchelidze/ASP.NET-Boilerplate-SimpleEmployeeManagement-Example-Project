using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using SimpleEmployeeManagement.Authorization.Roles;
using SimpleEmployeeManagement.Employees.Entities;
using SimpleEmployeeManagement.MultiTenancy;
using SimpleEmployeeManagement.Users;

namespace SimpleEmployeeManagement.EntityFramework
{
    public class SimpleEmployeeManagementDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public virtual IDbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ComplexType<Nationality>();
            modelBuilder.ComplexType<Salary>();
            modelBuilder.ComplexType<Currency>();
        }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public SimpleEmployeeManagementDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in SimpleEmployeeManagementDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of SimpleEmployeeManagementDbContext since ABP automatically handles it.
         */
        public SimpleEmployeeManagementDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public SimpleEmployeeManagementDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
