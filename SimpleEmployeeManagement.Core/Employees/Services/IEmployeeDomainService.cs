using System.Threading.Tasks;
using Abp.Domain.Services;
using SimpleEmployeeManagement.Employees.Entities;

namespace SimpleEmployeeManagement.Employees.Services
{
    public interface IEmployeeDomainService : IDomainService
    {
        Task CreateAsync(Employee input);
    }
}