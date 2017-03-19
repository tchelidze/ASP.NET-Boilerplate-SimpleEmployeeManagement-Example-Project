using System.Threading.Tasks;
using Abp.Domain.Services;
using Abp.Specifications;
using SimpleEmployeeManagement.Employees.Entities;

namespace SimpleEmployeeManagement.Employees.Services
{
    public interface IEmployeeDomainService : IDomainService
    {
        Task CreateAsync(Employee input);
        Task<double> GetAverageSalary(ISpecification<Employee> spec);
    }
}