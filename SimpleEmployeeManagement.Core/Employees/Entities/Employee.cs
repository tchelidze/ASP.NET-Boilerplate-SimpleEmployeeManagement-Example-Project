using System;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Timing;
using Abp.UI;
using SimpleEmployeeManagement.Infrastructure.Extensions;

namespace SimpleEmployeeManagement.Employees.Entities
{
    public class Employee : Entity<long>
    {
        public virtual string Name { get; protected set; }

        public virtual string Surname { get; protected set; }

        public virtual string IdentityNumber { get; protected set; }

        public virtual string PhoneNumber { get; protected set; }

        public virtual DateTime BirthDate { get; protected set; }

        public virtual Nationality Nationality { get; protected set; }

        public virtual Salary Salary { get; protected set; }

        public static Task<Employee> Create(
            string name,
            string surname,
            string identityNumber,
            string phoneNumber,
            DateTime birthDate,
            Nationality nationality,
            Salary salary)
        {
            var employee = new Employee
            {
                Name = name,
                Surname = surname,
                IdentityNumber = identityNumber,
                PhoneNumber = phoneNumber,
                Nationality = nationality,
                Salary = salary
            };
            employee.SetBirthDate(birthDate);
            return Task.FromResult(employee);
        }

        public void SetBirthDate(DateTime what)
        {
            if (what.YearsDifference(Clock.Now) < 18)
                throw new UserFriendlyException("Employee must be of the full legal age");
        }
    }
}
