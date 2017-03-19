using Abp.Domain.Values;
using SimpleEmployeeManagement.Employees.Services;

namespace SimpleEmployeeManagement.Employees.Entities
{
    public class Currency : ValueObject<Currency>
    {
        public virtual string Name { get; set; }

        public static Currency Create(
            string name,
            ICurrencyCreationPolicy policy)
        {
            policy.CheckCurrencyCreationAttempt(name);
            return new Currency { Name = name };
        }
    }
}
