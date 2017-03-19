using SimpleEmployeeManagement.Employees.Entities;

namespace SimpleEmployeeManagement.Employees.Services
{
    public interface ISalaryCreationPolicy
    {
        void CheckSalaryCreationAttempt(double amount, Currency currency);
    }
}