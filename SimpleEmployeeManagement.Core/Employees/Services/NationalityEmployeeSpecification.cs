using System;
using System.Linq.Expressions;
using Abp.Specifications;
using SimpleEmployeeManagement.Employees.Entities;

namespace SimpleEmployeeManagement.Employees.Services
{
    public class NationalityEmployeeSpecification : Specification<Employee>
    {
        public string Nationality { get; }

        public NationalityEmployeeSpecification(string nationality)
        {
            Nationality = nationality;
        }

        public override Expression<Func<Employee, bool>> ToExpression()
            => it => it.Nationality.Name == Nationality;
    }
}
