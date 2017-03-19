using Abp.UI;
using SimpleEmployeeManagement.Employees.Entities;

namespace SimpleEmployeeManagement.Employees.Services
{
    public class SalaryCreationPolicy : ISalaryCreationPolicy
    {
        public void CheckSalaryCreationAttempt(double amount, Currency currency)
        {
            if (amount < 0)
                throw new UserFriendlyException("Salary can not be negative");
        }
    }
}
