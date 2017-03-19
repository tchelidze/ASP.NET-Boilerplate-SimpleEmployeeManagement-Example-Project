using System.Linq;
using SimpleEmployeeManagement.EntityFramework;
using SimpleEmployeeManagement.MultiTenancy;

namespace SimpleEmployeeManagement.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly SimpleEmployeeManagementDbContext _context;

        public DefaultTenantCreator(SimpleEmployeeManagementDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
