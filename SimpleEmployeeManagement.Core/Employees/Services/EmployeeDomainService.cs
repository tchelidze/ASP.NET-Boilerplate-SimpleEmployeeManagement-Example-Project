using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Specifications;
using SimpleEmployeeManagement.Employees.Entities;

namespace SimpleEmployeeManagement.Employees.Services
{
    public class EmployeeDomainService : DomainService, IEmployeeDomainService
    {
        readonly IRepository<Employee, long> _employeeRepository;
        public EmployeeDomainService(
            IRepository<Employee, long> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task CreateAsync(Employee input)
            => await _employeeRepository.InsertAsync(input);

        public async Task<double> GetAverageSalary(ISpecification<Employee> spec)
        {
            var list = await _employeeRepository.GetAllListAsync(spec.ToExpression());
            return list.Average(it => it.Salary.Amount);
        }
    }
}
