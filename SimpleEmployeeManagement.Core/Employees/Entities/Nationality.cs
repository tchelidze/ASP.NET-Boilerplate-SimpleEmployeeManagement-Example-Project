using Abp.Domain.Values;
using SimpleEmployeeManagement.Employees.Services;

namespace SimpleEmployeeManagement.Employees.Entities
{
    public class Nationality : ValueObject<Nationality>
    {
        public virtual string Name { get; protected set; }

        public static Nationality Create(string name, INationalityCreationPolicy policy)
        {
            policy.CheckNationalityCreationAttempt(name);
            return new Nationality { Name = name };
        }
    }
}
