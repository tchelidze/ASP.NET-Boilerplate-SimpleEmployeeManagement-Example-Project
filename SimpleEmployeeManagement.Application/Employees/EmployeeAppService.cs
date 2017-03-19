using System.Threading.Tasks;
using SimpleEmployeeManagement.Employees.Dtos;
using SimpleEmployeeManagement.Employees.Entities;
using SimpleEmployeeManagement.Employees.Services;

namespace SimpleEmployeeManagement.Employees
{
    public class EmployeeAppService : SimpleEmployeeManagementAppServiceBase, IEmployeeAppService
    {
        readonly IEmployeeDomainService _employeeDomainService;
        readonly ICurrencyCreationPolicy _currencyCreationPolicy;
        readonly ISalaryCreationPolicy _salaryCreationPolicy;
        readonly INationalityCreationPolicy _nationalityCreationService;

        public EmployeeAppService(
                IEmployeeDomainService employeeDomainService,
                ICurrencyCreationPolicy currencyCreationPolicy,
                ISalaryCreationPolicy salaryCreationPolicy,
                INationalityCreationPolicy nationalityCreationService)
        {
            _employeeDomainService = employeeDomainService;
            _currencyCreationPolicy = currencyCreationPolicy;
            _salaryCreationPolicy = salaryCreationPolicy;
            _nationalityCreationService = nationalityCreationService;
        }

        public async Task Create(CreateEmployeeInput input)
        {
            var employee =
                await Employee.Create(
                    input.Name,
                    input.Surname,
                    input.IdentityNumber,
                    input.PhoneNumber,
                    input.BirthDate,
                    Nationality.Create(input.Nationality, _nationalityCreationService),
                    Salary.Create(
                        input.SalaryAmount,
                        Currency.Create(
                            input.SalaryCurrency,
                            _currencyCreationPolicy),
                        _salaryCreationPolicy)
                    );
            await _employeeDomainService.CreateAsync(employee);
        }
    }
}
