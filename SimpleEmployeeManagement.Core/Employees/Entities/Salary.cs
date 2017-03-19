using Abp.Domain.Values;
using SimpleEmployeeManagement.Employees.Services;

namespace SimpleEmployeeManagement.Employees.Entities
{
    public class Salary : ValueObject<Salary>
    {

        public virtual double Amount { get; set; }

        public virtual Currency Currency { get; set; }

        public static Salary Create(
            double amount,
            Currency currency,
            ISalaryCreationPolicy policy)
        {
            policy.CheckSalaryCreationAttempt(amount, currency);
            return new Salary
            {
                Currency = currency,
                Amount = amount
            };
        }
    }
}
