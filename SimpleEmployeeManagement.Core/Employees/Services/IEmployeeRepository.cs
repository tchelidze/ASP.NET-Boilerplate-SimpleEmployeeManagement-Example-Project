using Abp.Domain.Repositories;
using SimpleEmployeeManagement.Employees.Entities;

namespace SimpleEmployeeManagement.Employees.Services
{
    public interface IEmployeeRepository : IRepository<Employee, long>
    {
    }
}
