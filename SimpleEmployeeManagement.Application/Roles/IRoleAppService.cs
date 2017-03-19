using System.Threading.Tasks;
using Abp.Application.Services;
using SimpleEmployeeManagement.Roles.Dto;

namespace SimpleEmployeeManagement.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
