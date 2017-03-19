using System.Collections.Generic;

namespace SimpleEmployeeManagement.Employees.Services
{
    public interface IAvailableNationalityListKnowledge
    {
        IEnumerable<string> List();
    }
}