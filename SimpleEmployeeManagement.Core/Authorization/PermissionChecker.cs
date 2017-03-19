using Abp.Authorization;
using SimpleEmployeeManagement.Authorization.Roles;
using SimpleEmployeeManagement.MultiTenancy;
using SimpleEmployeeManagement.Users;

namespace SimpleEmployeeManagement.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
